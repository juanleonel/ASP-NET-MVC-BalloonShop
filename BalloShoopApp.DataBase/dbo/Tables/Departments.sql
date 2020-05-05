CREATE TABLE [dbo].[Departments] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Description] TEXT          NULL,
    [CreatedAt]   DATETIME      CONSTRAINT [DF_Departments_CreatedAt] DEFAULT (getdate()) NOT NULL,
    [CreatedUser] INT           NOT NULL,
    [UpdatedAt]   DATETIME      NULL,
    [UpdatedUser] INT           NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED ([ID] ASC)
);

