CREATE TABLE [dbo].[Categories] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (150) NOT NULL,
    [Description]  TEXT           NULL,
    [CreatedAt]    DATETIME       CONSTRAINT [DF_Categories_CreateAt] DEFAULT (getdate()) NOT NULL,
    [CreatedUser]  INT            NOT NULL,
    [UpdatedAt]    DATETIME       NULL,
    [UpdatedUser]  INT            NULL,
    [DepartmentID] INT            NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Categories_Departments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Departments] ([ID])
);



