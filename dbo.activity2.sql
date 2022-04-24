CREATE TABLE [dbo].[activity2] (
    [id_act]        INT           NOT NULL,
    [name_act]      VARCHAR (20) NULL,
    [date_d]        DATE         NULL,
    [tempsd]        VARCHAR (10)  NULL,
    [recurrence]    VARCHAR (10) NULL,
    [nom_categorie] VARCHAR (50) NULL,
    [id_personne]   VARCHAR (50) NULL,
    [nom_adr]       VARCHAR (50) NULL,
    [tempsf]        VARCHAR (10)  NULL,
    [done] VARCHAR(10) NULL, 
    CONSTRAINT [PK_activity2] PRIMARY KEY CLUSTERED ([id_act] ASC),
    CONSTRAINT [FK_activity2_personne] FOREIGN KEY ([id_personne]) REFERENCES [dbo].[personne] ([username])
);

