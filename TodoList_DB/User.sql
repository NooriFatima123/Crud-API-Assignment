CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL IDENTITY PRIMARY KEY, 
    [UserName] NVARCHAR(200) NULL, 
    [Email] NVARCHAR(200) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [CreatedOn] DATETIME NULL, 
    [ModifyOn] DATETIME NULL, 
    [IsDeleted] BIT NULL DEFAULT 0, 
)
