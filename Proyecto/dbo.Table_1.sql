CREATE TABLE [dbo].[Data]
(
	[SessionID] INT NOT NULL PRIMARY KEY, 
    [Date] DATETIME NOT NULL, 
    [RPE_Training] INT NOT NULL, 
    [RPE_match] INT NOT NULL, 
    [RPE_out] INT NOT NULL, 
    CONSTRAINT [FK_Data_ToTable] FOREIGN KEY ([SessionID]) REFERENCES [Users]([UserID]) 
)
