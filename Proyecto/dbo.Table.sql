CREATE TABLE [dbo].[Users]
(
	[AdminID] INT NOT NULL , 
    [UserID] INT NOT NULL, 
    [Password] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY ([UserID]),

)
