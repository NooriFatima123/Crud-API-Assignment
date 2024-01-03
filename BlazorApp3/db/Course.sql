CREATE TABLE [dbo].[Course]
(
	[CourseId] INT NOT NULL  IDENTITY PRIMARY KEY, 
    [CourseName] NVARCHAR(50) NULL, 
    [StdId] INT NULL, 
    [Marks] BIGINT NULL

    CONSTRAINT [SD_Course_Std] FOREIGN KEY ([StdId]) REFERENCES [Std]([StdId])
)
