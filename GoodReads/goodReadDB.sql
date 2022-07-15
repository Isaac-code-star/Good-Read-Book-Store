CREATE TABLE [dbo].[booksData]
(
	[bookID] INT NOT NULL PRIMARY KEY,
	Title nchar(40) NOT NULL,
	Author nchar(40) NOT NUll,
	Publisher nchar(60) NOT NULL,
	Price money NOT NULL,
	PurchaseDate date NOT NULL
)
