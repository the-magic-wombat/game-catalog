CREATE TABLE [dbo].[Accounts] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [Username] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Admin]    NVARCHAR (MAX) NULL DEFAULT 'User',
    CONSTRAINT [PK_dbo.Accounts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

