# Stock
Stock simulator .Net



# Business Desc

This project should simulate a market where user/agent has to register mentioning his money amount to be able to participate in market. Agent should buy products at their highest availability rate then sell them again at their lowest availability to earn more money. product’s list and prices will be refreshed every 100 sec. 

# errors and disclaimers

- Login and register page for anonymous users
- you haven’t enough money
- confirmation before buying or selling a product




Products table

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('AllProducts'))
BEGIN;
    DROP TABLE [AllProducts];
END;
GO

CREATE TABLE [AllProducts] (
    [AllProductsID] INTEGER NOT NULL IDENTITY(1, 1),
    [Code] VARCHAR(255) NULL,
    [Name] VARCHAR(MAX) NULL,
    [InitPrice] INTEGER NULL,
    [FreeAmount] INTEGER NULL,
    [OwnedAmount] INTEGER NULL,
    PRIMARY KEY ([AllProductsID])
);
GO

INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('KWE70JJV9PO','lobortis. Class aptent',354,14,94),('WUP82FIQ9UC','Sed',6822,28,91),('TEC36KGD7HC','dapibus quam',8375,36,40),('FLP58KMH6ZO','Nunc mauris sapien,',7602,81,71),('XMB39DCE0JF','vitae',1434,99,34),('HBR31JUT9SB','nec, leo.',7765,65,24),('MPP78VFY1DF','velit eu',3228,34,2),('UJH01QEV0NB','non, lobortis',9419,32,23),('WRA16DNI5BK','lorem, luctus',1856,93,4),('AND51NQA3EB','auctor non,',1491,30,52);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('TST00ESW7ZG','vitae',8885,62,9),('XST69AYQ2VC','ac orci.',3797,83,80),('YZT04ONP9NJ','Integer mollis. Integer',9851,94,85),('PCO00EMP5UL','faucibus orci luctus',193,84,97),('SHA63KLY3XH','ut, nulla.',3791,16,2),('BGZ41FXA5IH','Aliquam vulputate ullamcorper',5579,25,57),('ISD38PPT9KJ','at lacus. Quisque',8341,84,15),('RAZ97YGN1XO','taciti sociosqu ad',2544,30,78),('OEB10BWJ5WV','Nunc mauris',9134,29,68),('UHQ87MEN4FQ','malesuada',705,93,78);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('PYL44XDB7YQ','magnis dis parturient',5663,4,35),('DFI62EDB0TA','elit. Aliquam',686,20,28),('ZNJ41UPR3XD','eu',5746,90,85),('FMS72VXB8KP','dis parturient montes,',2264,32,88),('IQC86QAF6OU','sed',7627,6,0),('URJ36SJC4CB','augue',432,81,81),('SZW98IDL7MY','vulputate',8417,96,17),('QKA95VJI4FL','nibh. Phasellus',2993,26,32),('ICS22IPZ4ZK','Duis',6014,35,60),('ZOU81GKU1PV','adipiscing fringilla,',2505,72,13);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('NUY04XBG2JZ','quam.',4074,42,46),('EFH79XRP7SK','nonummy ut, molestie',1760,47,51),('KXW35EXZ0CX','massa rutrum magna.',5214,6,33),('CPS46NWG1OD','tincidunt,',569,36,22),('FKM49UJT6IV','feugiat non,',5568,45,88),('ZWU47JHJ5SP','facilisis vitae, orci.',3707,29,8),('KGI26IDZ4MC','Cras',9434,41,27),('QOX14QAC9MA','malesuada malesuada.',8908,1,83),('WKG78BAL7TI','non justo. Proin',3938,0,34),('TYZ84QPY3EP','at, libero. Morbi',2232,15,66);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('TWW20TNZ3RS','Cras eget',3187,63,12),('DDD25ZXV7AJ','tempor augue ac',4542,51,49),('KTG25MBX2FV','Integer mollis.',5080,62,33),('FZW83WHI2ZY','nec urna et',2158,63,15),('UPN65UCL0PY','venenatis lacus.',6308,60,86),('BPQ25STD3QD','velit in',7286,97,50),('WAL78HRL7WC','sed, hendrerit a,',9296,78,90),('MPS85LSQ2NC','blandit viverra. Donec',2592,13,57),('MZD32KMD7CL','metus. In lorem.',9081,30,58),('HBV91AUO3PA','mus. Donec dignissim',9975,73,63);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('QEG68DQK9XB','nunc est,',6153,34,68),('FCA99ZPS3AD','Quisque fringilla euismod',3593,79,75),('LEN52VUJ6WU','Nulla eu neque',3784,38,29),('RUV98LUG9DT','arcu. Aliquam ultrices',5022,98,35),('GQV91MAE7WA','malesuada malesuada.',9915,34,8),('VAA86NQE1OV','enim',5166,3,62),('JML12COR6WU','fermentum',7906,71,34),('NBI16YKK8EN','consectetuer',526,29,40),('NSR03UEV8DN','sem molestie sodales.',1051,39,60),('QSV29RPD7WQ','orci',8133,93,21);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('QDM24FVF6JS','ornare. Fusce',9682,55,36),('LKO43WOK4LS','scelerisque sed,',3025,27,86),('EEC64FTM6WF','venenatis vel, faucibus',8563,34,85),('QAH04DKL4TM','sit amet,',5729,92,1),('CLM05TWP4ZK','dictum. Proin',215,70,49),('QGA45AUB2GO','nisi nibh lacinia',562,79,21),('QTT09CII2WO','quam.',5526,30,69),('YZQ41IVP6TY','euismod urna. Nullam',3127,76,47),('UZA37GXX2HB','imperdiet',1569,39,18),('YON58SMT0SR','elementum',850,86,26);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('UUH06RJO9DS','rutrum',6786,18,89),('QTL36MBV1UK','elit, dictum',3597,68,18),('HLC98NBH0FX','risus quis diam',9966,66,40),('PSV93BGJ3OR','pretium et, rutrum',4610,31,9),('HSS09GSQ9QY','Curae;',6545,41,25),('IFX90NLB4UX','Quisque tincidunt pede',5605,91,81),('XCF64HSE4FI','Nam',4205,98,3),('DAS60SMV1JM','Vivamus molestie dapibus',7476,99,17),('FFT89PRK2WV','sociis natoque penatibus',399,37,5),('NBY67BRV7CE','rutrum.',7025,48,100);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('EJF92QEQ6GT','amet risus. Donec',2102,41,10),('JMU61SJD3TN','ac, eleifend',4949,86,76),('JHV12EJI8LU','et',9602,67,18),('OTI71JTP2TX','sem',4842,4,18),('TXU11RUB1PE','elit, dictum',8413,97,91),('SNH32ZAS9JX','feugiat.',6158,94,33),('HYV93LCH5OE','morbi',7042,52,3),('GVB99UNH1VP','eu, eleifend',9187,7,39),('NTT07HAV6MS','eget',3683,78,74),('QBQ64EFS3QY','tempus risus. Donec',8553,64,93);
INSERT INTO AllProducts([Code],[Name],[InitPrice],[FreeAmount],[OwnedAmount]) VALUES('VYV97IKG8DB','a purus.',93,71,41),('NLX00LFU0FG','amet ante.',2336,47,21),('DHI51TTQ2RQ','libero',3093,33,22),('DOF23CSN1MB','nisi',7469,91,51),('UFR67NNH3XH','sociis',7331,65,95),('EGQ10VFT5QI','dapibus',8114,69,82),('LIN73HXF9AU','tristique',2635,60,32),('BST48PAW6KH','et',2505,90,26),('WXK19NXJ1II','enim. Curabitur massa.',3076,86,82),('ATQ40AYC3KG','metus facilisis',4061,85,75);
