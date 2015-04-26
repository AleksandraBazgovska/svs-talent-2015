CREATE TABLE Bikes
(
BikeId int PRIMARY KEY IDENTITY(1,1),
Model nvarchar(50) not null,
Producer nvarchar(50) not null,
RegNumber int UNIQUE not null,
TypeOfBike nvarchar(50) not null,
Colour nvarchar(50) not null,
DateOfProduction Date not null,
DateOfPurchase Date not null

);