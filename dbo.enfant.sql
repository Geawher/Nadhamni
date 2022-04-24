CREATE TABLE [dbo].[enfant] (
    [id_enfant]       INT          IDENTITY (1, 1) NOT NULL,
    [nom_enfant]      VARCHAR (20) NULL,
    [occupation]      VARCHAR (20) NULL,
    [Username_father] VARCHAR (50) NULL,
    [father_name]     VARCHAR (20) NULL,
    [age]             VARCHAR (10) NULL,
    CONSTRAINT [PK_enfant] PRIMARY KEY CLUSTERED ([id_enfant] ASC),
    CONSTRAINT [FK_enfant_ToTable] FOREIGN KEY ([Username_father]) REFERENCES [dbo].[personne] ([username])
);

