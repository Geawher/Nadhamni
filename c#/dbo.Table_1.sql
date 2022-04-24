CREATE TABLE [dbo].[adresse] (
    [id_adr]  INT          IDENTITY (1, 1) NOT NULL,
    [nom_adr] VARCHAR (20) NULL,
    CONSTRAINT [PK_adresse] PRIMARY KEY CLUSTERED ([id_adr] ASC),
    CONSTRAINT [FK_adresse_adresse] FOREIGN KEY ([id_adr]) REFERENCES [dbo].[adresse] ([id_adr])
);
