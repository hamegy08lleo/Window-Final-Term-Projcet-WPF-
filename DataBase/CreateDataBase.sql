CREATE TABLE [dbo].[Room] (
    [roomID]   INT           IDENTITY (1, 1) NOT NULL,
    [city]     VARCHAR (100) NULL,
    [roomType] VARCHAR (100) NULL,
    [hotel]    VARCHAR (100) NULL,
    [price]    INT           NULL,
    [rating]   FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([roomID] ASC)
);
