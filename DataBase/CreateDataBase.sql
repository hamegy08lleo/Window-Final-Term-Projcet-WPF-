USE ManageRoom

CREATE TABLE Customer( 
	customerID int identity primary key, 
	username varchar(100) unique not null, 
	password varchar(100) not null, 
	name varchar(100),
	email varchar(100) not null,
	phoneNumber varchar(100) not null, 
)

INSERT INTO Customer(username, password, name, email, phoneNumber)
VALUES('hvmegy', 'hyngulem123', 'nguyennamhy', 'namhy@gmail.com', '0389600712')

INSERT INTO Customer(username, password, name, email, phoneNumber)
VALUES('lvt', 'lvt123', 'luuvinhtuong', 'lvt@gmail.com', '032323232')

CREATE TABLE Owner( 
	ownerID int identity primary key, 
	username varchar(100) unique not null, 
	password varchar(100) not null, 
	name varchar(100),
	email varchar(100) not null,
	phoneNumber varchar(100) not null, 
)

INSERT INTO Owner(username, password, name, email, phoneNumber) 
VALUES('hvmegy', 'hyngulem123', 'namhy', 'namhy@email', '0389600712')

INSERT INTO Owner(username, password, name, email, phoneNumber) 
VALUES('wallliu', 'tuong', 'tuong', 'tuong@email', '012345685')

CREATE TABLE Room( 
	roomID int identity, 	
	hotelID int not null,
	roomType varchar(100) not null, 
	price int not null, 
	primary key(roomID)
)


INSERT INTO 
Room(roomType, hotelID, price)
VALUES('1 Single Bed', '1', '100')

INSERT INTO 
Room(roomType, hotelID, price)
VALUES('2 Single Bed', '1', '100')

INSERT INTO 
Room(roomType, hotelID, price)
VALUES('1 Single Bed', '2', '100')

INSERT INTO 
Room(roomType, hotelID, price)
VALUES('2 Single Bed', '2', '100')

INSERT INTO 
Room(roomType, hotelID, price)
VALUES('1 Couple Bed', '5', '200')

INSERT INTO 
Room(roomType, hotelID, price)
VALUES('1 Couple Bed', '5', '200')

CREATE TABLE Hotel( 
	hotelID int identity,
	hotelName varchar(100) unique not null, 
	city varchar(100) not null, 
	address varchar(100) not null, 
	email varchar(100), 
	phoneNumber varchar(10), 
	rating float not null, 
	ownerID int not null foreign key references Owner(ownerID), 
	primary key(hotelID)
)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email, ownerID)
VALUES('Horizon Travel HCM', '5.0', 'Ho Chi Minh City', '188 Phan Van Tri', '0123456789', 'h@gmail.com', 1)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email, ownerID)
VALUES('Quantum Travel HCM', '4.9', 'Ho Chi Minh City', '190 Phan Dinh Phung', '0123456789', 'qt@gmail.com', 1)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email, ownerID)
VALUES('Quantum Travel DN', '5.0', 'Da Nang City', '100 Le Quy Don', '012345632', 'qt@gmail.com', 2)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email, ownerID)
VALUES('Quantum Travel HN', '5.0', 'Ha Noi', '102 Tran Duy Hung', '017745632', 'qt@gmail.com', 2)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email, ownerID)
VALUES('abcxyz', '5.0', 'Ho Chi Minh City', '102 Tran Duy Hung', '017745632', 'qt@gmail.com', 2)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email, ownerID)
VALUES('Horizon Travel ST', '5.0', 'Soc Trang', '77 Hoang Dieu', '017745632', 'qt@gmail.com', 2)

CREATE TABLE Booking( 
	customerID int foreign key references Customer(customerID) not null, 
	checkin date not null, 
	checkout date not null, 
	bookingID int IDENTITY, 
	roomID int not null,
    FOREIGN KEY ([roomID]) REFERENCES [dbo].[Room] ([roomID]), 
)

INSERT INTO 
Booking(roomID, checkin, checkout, customerID) 
VALUES('6', '2024-2-24', '2024-01-24', '1')

CREATE TABLE [dbo].[SearchResult] (
    [roomType] VARCHAR (100) NOT NULL,
    [price]    INT           NOT NULL,
    [hotelID]  INT           NOT NULL,
    [roomID]   INT           NOT NULL,
    CONSTRAINT [PK_SearchResult] PRIMARY KEY CLUSTERED ([roomID]),
    FOREIGN KEY ([hotelID]) REFERENCES [dbo].[Hotel] ([hotelID]),
    FOREIGN KEY ([roomID]) REFERENCES [dbo].[Room] ([roomID])
);


ALTER TABLE Room WITH CHECK ADD FOREIGN KEY(hotelID) REFERENCES Hotel(hotelID)
ALTER TABLE Booking WITH CHECK ADD PRIMARY KEY(bookingID, roomID)




SELECT * FROM Room
SELECT * FROM Hotel 
SELECT * FROM Booking 
SELECT * FROM SearchResult
SELECT * FROM Customer
SELECT * FROM Owner





SELECT hotelID, hotelName, address, price, rating, ammount FROM
(SELECT Hotel.hotelID, Hotel.hotelName, room.roomType, city, address, price, rating, count(roomID) as 'ammount'
FROM 
Room inner join Hotel on Hotel.hotelID = Room.hotelID
group by Hotel.hotelName, Hotel.hotelID, room.roomType, city, address, price, rating) as tmp
WHERE roomType = '2 Single Bed' AND city = 'Ho Chi Minh City'

SELECT hotelID, hotelName, address, price, rating, amount FROM
(SELECT Hotel.hotelID, Hotel.hotelName, roomType, city, address, price, rating, count(roomID) as 'amount' FROM
(SELECT * FROM
(SELECT Room.roomID, hotelID, roomType, price, bookingID FROM 
Room left join Booking on Room.roomID = Booking.roomID) as Q1
WHERE bookingID is null) as Q2 inner join Hotel on Hotel.hotelID = Q2.hotelID
GROUP BY Hotel.hotelID, Hotel.hotelName, roomtype, city, address, price, rating) as Q3
WHERE roomType = '2 Single Bed' AND city = 'Ho Chi Minh City'

drop table Booking
drop table SearchResult
drop table Customer
drop table Room
drop table Hotel
drop table Owner

