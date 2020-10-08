CREATE TABLE [dbo].[Driver] (
[driverNumber] int NOT NULL ,
[driverName] varchar(35) NOT NULL default '',
[driverSurname] varchar(70) NOT NULL default '',
[teamCode] char(3) NOT NULL default '',
[countryCode] char(2) NOT NULL default '',
[winNumber] int NOT NULL default 0,
[worldChampionshipsNumber] int NOT NULL default 0,
[img] varchar(512) NOT NULL,
PRIMARY KEY ([driverNumber])
);

INSERT INTO [Driver] VALUES (44,'Lewis','Hamilton','MER','GB',90,6,'https://www.formula1.com/content/fom-website/en/drivers/lewis-hamilton/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (77,'Valtteri','Bottas','MER','FI',9,0,'https://www.formula1.com/content/fom-website/en/drivers/valtteri-bottas/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (33,'Max','Verstappen','RBR','NL',9,0,'https://www.formula1.com/content/fom-website/en/drivers/max-verstappen/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (23,'Alexander','Albon','RBR','TH',0,0,'https://www.formula1.com/content/fom-website/en/drivers/alexander-albon/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (16,'Charles','Leclerc','FER','MC',2,0,'https://www.formula1.com/content/fom-website/en/drivers/charles-leclerc/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (5,'Sebastian','Vettel','FER','DE',53,4,'https://www.formula1.com/content/fom-website/en/drivers/sebastian-vettel/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (55,'Carlos','Sainz','MCL','ES',0,0,'https://www.formula1.com/content/fom-website/en/drivers/carlos-sainz/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (4,'Lando','Norris','MCL','GB',0,0,'https://www.formula1.com/content/fom-website/en/drivers/lando-norris/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (11,'Sergio','Perez','RPT','MX',0,0,'https://www.formula1.com/content/fom-website/en/drivers/sergio-perez/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (18,'Lance','Stroll','RPT','CA',0,0,'https://www.formula1.com/content/fom-website/en/drivers/lance-stroll/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (3,'Daniel','Ricciardo','REN','AT',7,0,'https://www.formula1.com/content/fom-website/en/drivers/daniel-ricciardo/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (31,'Esteban','Ocon','REN','FR',0,0,'https://www.formula1.com/content/fom-website/en/drivers/esteban-ocon/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (10,'Pierre','Gasly','ATR','FR',1,0,'https://www.formula1.com/content/fom-website/en/drivers/pirre-gasly/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (26,'Daniil','Kvyat','ATR','RU',0,0,'https://www.formula1.com/content/fom-website/en/drivers/daniil-kvyat/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (7,'Kimi','Räikkönen','ARR','FI',21,1,'https://www.formula1.com/content/fom-website/en/drivers/kimi-raikkonen/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (99,'Antonio','Giovinazzi','ARR','IT',0,0,'https://www.formula1.com/content/fom-website/en/drivers/antonio-giovinazzi/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (20,'Kevin','Magnussen','HAS','DK',0,0,'https://www.formula1.com/content/fom-website/en/drivers/kevin-magnussen/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (8,'Romain','Grosjean','HAS','FR',0,0,'https://www.formula1.com/content/fom-website/en/drivers/romain-grosjean/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (63,'George','Russell','WLR','GB',0,0,'https://www.formula1.com/content/fom-website/en/drivers/george-russell/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
INSERT INTO [Driver] VALUES (6,'Nicholas','Latifi','WLR','CA',0,0,'https://www.formula1.com/content/fom-website/en/drivers/nicholas-latifi/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg');
