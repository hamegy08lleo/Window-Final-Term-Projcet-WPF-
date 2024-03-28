USE ManageRoom

CREATE TABLE Room( 
	roomID int identity, 	
	hotelID int, 
	roomType varchar(100), 
	price int, 
	primary key(roomID)
)

CREATE TABLE Hotel( 
	hotelID int identity,
	hotelName varchar(100) unique, 
	city varchar(100) not null, 
	address varchar(100) not null, 
	email varchar(100), 
	phoneNumber varchar(10), 
	rating float not null, 
	primary key(hotelID)
)

CREATE TABLE Booking( 
	bookingID int IDENTITY, 
	roomID int not null,
)

ALTER TABLE Room WITH CHECK ADD FOREIGN KEY(hotelID) REFERENCES Hotel(hotelID)
ALTER TABLE Booking WITH CHECK ADD PRIMARY KEY(bookingID, roomID)

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email)
VALUES('Horizon Travel HCM', '5.0', 'Ho Chi Minh City', '188 Phan Van Tri', '0123456789', 'h@gmail.com')

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email)
VALUES('Quantum Travel HCM', '4.9', 'Ho Chi Minh City', '190 Phan Dinh Phung', '0123456789', 'qt@gmail.com')

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email)
VALUES('Quantum Travel DN', '5.0', 'Da Nang City', '100 Le Quy Don', '012345632', 'qt@gmail.com')

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email)
VALUES('Quantum Travel HN', '5.0', 'Ha Noi', '102 Tran Duy Hung', '017745632', 'qt@gmail.com')

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email)
VALUES('abcxyz', '5.0', 'Ho Chi Minh City', '102 Tran Duy Hung', '017745632', 'qt@gmail.com')

INSERT INTO Hotel(hotelName, rating, city, address, phoneNumber, email)
VALUES('Horizon Travel ST', '5.0', 'Soc Trang', '77 Hoang Dieu', '017745632', 'qt@gmail.com')

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


SELECT * FROM Room
SELECT * FROM Hotel 
SELECT * FROM Booking 

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


USE ManageRoom
DROP TABLE Room
DROP TABLE Hotel 
DROP TABLE Booking

