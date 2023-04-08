CREATE TABLE [dbo].[Exceptions] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Exception Type]    VARCHAR (50)  NULL,
    [Exception Message] VARCHAR (200) NULL,
    [TimeStamp]         DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

