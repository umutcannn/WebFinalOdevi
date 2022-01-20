Create table Banka
(
Id INT IDENTITY(1,1) NOT NULL,
Ad NVARCHAR(20) NULL,
Soyad NVARCHAR(20) NULL,
Telefon NVARCHAR(20) NULL,
Sehir NVARCHAR(20) NULL,
Ilce NVARCHAR(20) NULL,
Banka_Ad NVARCHAR(20) NULL, 
	
	PRIMARY KEY CLUSTERED
	(
		Id
	)ON [PRIMARY]

);

INSERT INTO dbo.Banka(Ad,Soyad,Telefon,Sehir,Ilce,Banka_Ad) VALUES ('Ali','Yilmaz','05300000000','Istanbul','Kadikoy','Ziraat Bankas�');
INSERT INTO dbo.Banka(Ad,Soyad,Telefon,Sehir,Ilce,Banka_Ad) VALUES ('Ayse','Nur','05300000000','Ankara','Kecioren','Halk Bankas�');
INSERT INTO dbo.Banka(Ad,Soyad,Telefon,Sehir,Ilce,Banka_Ad) VALUES ('Mehmet','Celik','05311111111','Izmir','Konak','Ziraat Bankas�');
INSERT INTO dbo.Banka(Ad,Soyad,Telefon,Sehir,Ilce,Banka_Ad) VALUES ('Melis','Aydin','05322222222','Istanbul','Bakirkoy','Halk Bankas�');
INSERT INTO dbo.Banka(Ad,Soyad,Telefon,Sehir,Ilce,Banka_Ad) VALUES ('Emir','Gulturk','05333333333','Ankara','Polatli','Ziraat Bankas�');
INSERT INTO dbo.Banka(Ad,Soyad,Telefon,Sehir,Ilce,Banka_Ad) VALUES ('Sede','Yaprak','05344444444','Izmir','Foca','Halk Bankas�');

select * from Banka



Create table Sube
(
Id INT IDENTITY(1,1) NOT Null,
Ad NVARCHAR(20) NULL,
Soyad NVARCHAR(20) NULL,
Telefon NVARCHAR(20) NULL,
Banka_Ad NVARCHAR(20) NULL,
Banka INT null,

	PRIMARY KEY CLUSTERED
	(
		Id
	)ON [PRIMARY]

);

INSERT INTO dbo.Sube(Ad,Soyad,Telefon,Banka_Ad) VALUES ('Ali','Yilmaz','05300000000','Ziraat Bankas�');
INSERT INTO dbo.Sube(Ad,Soyad,Telefon,Banka_Ad) VALUES ('Ayse','Nur','05300000000','Halk Bankas�');
INSERT INTO dbo.Sube(Ad,Soyad,Telefon,Banka_Ad) VALUES ('Mehmet','Celik','05311111111','Ziraat Bankas�');
INSERT INTO dbo.Sube(Ad,Soyad,Telefon,Banka_Ad) VALUES ('Melis','Aydin','05322222222','Halk Bankas�');
INSERT INTO dbo.Sube(Ad,Soyad,Telefon,Banka_Ad) VALUES ('Emir','Gulturk','05333333333','Ziraat Bankas�');
INSERT INTO dbo.Sube(Ad,Soyad,Telefon,Banka_Ad) VALUES ('Sede','Yaprak','05344444444','Halk Bankas�');

select * from Sube

 ALTER TABLE Sube WITH CHECK ADD CONSTRAINT [FK_Sube_Banka_id] FOREIGN KEY (Banka) REFERENCES Banka (Id)
 GO