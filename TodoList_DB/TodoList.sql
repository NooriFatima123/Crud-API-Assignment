CREATE TABLE [dbo].[TodoList]
(
	[ItemId] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Title] NVARCHAR(100) NULL, 
    [Desc] NVARCHAR(MAX) NULL, 
    [CreatedOn] DATETIME NULL, 
    [IsDeleted] BIT NULL, 
    [ModifyOn] DATETIME NULL, 
    [UserId] INT NULL

    CONSTRAINT [FK_TodoList_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId])
)
