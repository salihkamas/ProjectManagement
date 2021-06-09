CREATE TABLE [dbo].[Announcements] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (1000) NOT NULL,
    [Date]        DATE            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Departments] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Tasks] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [UserId]      INT            NOT NULL,
    [Description] NVARCHAR (500) NOT NULL,
    [endDate]     DATE           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

CREATE TABLE [dbo].[UserImages] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [UserId]    INT             NOT NULL,
    [ImagePath] NVARCHAR (1000) NOT NULL,
    [date]      DATE            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]),
    FOREIGN KEY ([OperationClaimId]) REFERENCES [dbo].[OperationClaims] ([Id])
);

CREATE TABLE [dbo].[Users] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [DepartmentId]  INT             NOT NULL,
    [firstName]     NVARCHAR (50)   NOT NULL,
    [lastName]      NVARCHAR (50)   NOT NULL,
    [email]         NVARCHAR (100)  NOT NULL,
    [nationalityId] NVARCHAR (11)   NOT NULL,
    [passwordHash]  VARBINARY (500) NOT NULL,
    [passwordSalt]  VARBINARY (500) NOT NULL,
    [isActive]      BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Departments] ([Id])
);

