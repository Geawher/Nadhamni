CREATE TABLE [dbo].[categorie] (
    [categorie_id] INT          IDENTITY (1, 1) NOT NULL,
    [nom_cat]      VARCHAR (20) NULL,
    CONSTRAINT [PK_categorie] PRIMARY KEY CLUSTERED ([categorie_id] ASC),
    CONSTRAINT [FK_categorie_categorie] FOREIGN KEY ([categorie_id]) REFERENCES [dbo].[categorie] ([categorie_id])
);

