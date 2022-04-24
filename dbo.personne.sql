CREATE TABLE [dbo].[personne] (
    [nom_pers]   VARCHAR (50) NULL,
    [mdp]        VARCHAR (20) NULL,
    [mail]       VARCHAR (50) NULL,
    [date_naiss] DATE         NULL,
    [occupation] VARCHAR (20) NULL,
    [situation]  VARCHAR (20) NULL,
    [username]   VARCHAR (50) NOT NULL,
    [hobby]      VARCHAR (20) NULL,
    [kids]       INT          NULL,
    [sexe]       VARCHAR (10) NULL,
    CONSTRAINT [PK_personne] PRIMARY KEY CLUSTERED ([username] ASC)
);

