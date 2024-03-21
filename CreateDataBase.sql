CREATE TABLE Room( 
	roomID int identity, 	
	city varchar(100), 
	roomType varchar(100), 
	hotel varchar(100), 
	price int, 
	rating float,
	primary key(roomID)
)

DROP TABLE Room

INSERT INTO 
Room(roomType, hotel, city, price, rating)
VALUES('1 Single Bed', 'Horizon Travel', 'TPHCM', '100', '5')

DELETE 
FROM Room
WHERE RoomID = '1'

SELECT * FROM Room
