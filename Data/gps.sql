CREATE TABLE [dbo].[GP] (
[gpID] char(4) NOT NULL default '',
[gpName] varchar(150) NOT NULL default '',
[lapNumber] int NOT NULL default '',
[circuitID] char(5) NOT NULL default '',
PRIMARY KEY ([gpID])
);

INSERT INTO [GP] VALUES ('gp1','Formula 1 Rolex Grosser Preis Von Österreich 2020',71,'RBR00');
INSERT INTO [GP] VALUES ('gp2','Formula 1 Pirelli Grosser Preis Der Steiermark 2020',71,'RBR00');
INSERT INTO [GP] VALUES ('gp3','Formula 1 Aramco Magyar Nagydíj 2020',70,'HUN00');
INSERT INTO [GP] VALUES ('gp4','Formula 1 Pirelli British Grand Prix 2020',52,'GBT00');
INSERT INTO [GP] VALUES ('gp5','Emirates Formula 1 70th Anniversary Grand Prix 2020',52,'GBT00');
INSERT INTO [GP] VALUES ('gp6','Formula 1 Aramco Gran Premio De España 2020',66,'SPA00');
INSERT INTO [GP] VALUES ('gp7','Formula 1 Rolex Belgian Grand Prix 2020',44,'BEL00');
INSERT INTO [GP] VALUES ('gp8','Formula 1 Gran Premio Heineken D’italia 2020',53,'ITA00');
INSERT INTO [GP] VALUES ('gp9','Formula 1 Pirelli Gran Premio Della Toscana Ferrari 1000 2020',59,'ITA01');
INSERT INTO [GP] VALUES ('gp10','Formula 1 VTB Russian Grand Prix 2020',53,'RUS00');
INSERT INTO [GP] VALUES ('gp11','Formula 1 Aramco Grosser Preis Der Eifel 2020',60,'GER00');
INSERT INTO [GP] VALUES ('gp12','Formula 1 Heineken Grande Prémio De Portugal 2020',66,'POR00');
INSERT INTO [GP] VALUES ('gp13','Formula 1 Emirates Gran Premio Dell’ emilia Romagna 2020',63,'ITA02');
INSERT INTO [GP] VALUES ('gp14','Formula 1 DHL Turkish Grand Prix 2020',58,'TUR00');
INSERT INTO [GP] VALUES ('gp15','Formula 1 Gulf Air Bahrain Grand Prix 2020',57,'BAH00');
INSERT INTO [GP] VALUES ('gp16','Formula 1 Rolex Sakhir Grand Prix 2020',87,'BAH01');
INSERT INTO [GP] VALUES ('gp17','Formula 1 Etihad Airways Abu Dhabi Grand Prix 2020',55,'ABU01');