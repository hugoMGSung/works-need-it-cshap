CREATE TABLE [dbo].[Memos] (
    [Num]      INT            NOT NULL,
    [Name]     NVARCHAR (25)  NOT NULL,
    [Email]    NVARCHAR (100) NULL,
    [Title]    NVARCHAR (150) NOT NULL,
    [PostDate] DATETIME       CONSTRAINT [DF__Memos__PostDate__24927208] DEFAULT (getdate()) NULL,
    [PostIP]   NVARCHAR (15)  NULL,
    CONSTRAINT [PK__Memos__C7D08B635C819150] PRIMARY KEY CLUSTERED ([Num] ASC)
);

