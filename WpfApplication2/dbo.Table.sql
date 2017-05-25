CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] TEXT NOT NULL, 
    [password] TEXT NOT NULL, 
    [goal] TEXT NOT NULL, 
    [activity] TEXT NOT NULL, 
    [gender] TEXT NOT NULL, 
    [birthday] DATETIME NOT NULL, 
    [height] INT NOT NULL, 
    [currentWeight] REAL NOT NULL, 
    [goalWeight] REAL NOT NULL
)
