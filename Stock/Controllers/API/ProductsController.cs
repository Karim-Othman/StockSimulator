using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stock.Models;
using Stock.Dtos;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Stock.Controllers.API
{
    public class ProductsController : ApiController
    {

        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPut]
        public IHttpActionResult ModifyProduct (EditProduct ReqOrder)
        {
            var AgentName = System.Web.HttpContext.Current.User.Identity.Name;

            var ProductCode = ReqOrder.ProductCode;

            var Operation = ReqOrder.Operation;

            var Product = _context.AllProducts.SqlQuery("Select * from AllProducts where Code = '" + ProductCode + "'").SingleOrDefault();
       
            var Agent = _context.Users.SingleOrDefault(u => u.UserName == AgentName);

            var ProductPrice = Product.InitPrice / Product.FreeAmount;

            if (Operation == "Buy")
            {
                if (Agent.Money < ProductPrice)
                    return BadRequest("You don't have enough money");

                if (Product.FreeAmount <= 0)
                    return BadRequest("Product is not avilable");

                Product.FreeAmount--;
                Product.OwnedAmount++;

                var order = new OwnedProducts
                {
                    Owner = AgentName,
                    OwnedProductCode = ProductCode,
                    OwnedProductName = Product.Name
                };

                _context.OwnedProducts.Add(order);
                Agent.Money -= ProductPrice;

                _context.SaveChanges();

                return Ok();
            }

            else if (Operation == "Sell")
            {
                try
                {
                    var AgentProduct = _context.OwnedProducts.SqlQuery("Select * from OwnedProducts where OwnedProductCode = '" + ProductCode + "' and Owner='" + AgentName + "'").FirstOrDefault();
                    _context.OwnedProducts.Remove(AgentProduct);

                    Agent.Money += ProductPrice;

                    _context.SaveChanges();
                    return Ok();
                }
                catch
                {
                    return BadRequest("Agent doesn't has this product");

                }

            }

            else
            {

                return BadRequest("Operation not found");
            }
        }

    }
}
