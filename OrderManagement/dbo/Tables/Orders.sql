CREATE TABLE [dbo].[Orders] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Number]    NVARCHAR (MAX)   NULL,
    [Qty]       INT              NOT NULL,
    [Price]     DECIMAL (18, 2)  NOT NULL,
    [Name]      NVARCHAR (MAX)   NULL,
    [OrderDate] DATETIME         NULL,
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

