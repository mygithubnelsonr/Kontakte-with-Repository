CREATE TABLE [dbo].[Personen] (
    [Kontakt_ID] INT           IDENTITY (1, 1) NOT NULL,
    [Vorname]    NVARCHAR (50) NULL,
    [Nachname]   NVARCHAR (50) NULL,
    [Firma]      NVARCHAR (50) NULL,
    [Telefon]    NVARCHAR (50) NULL,
    [Email]      NVARCHAR (50) NULL,
    [Kunde]      BIT           NULL,
    [Anruf]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Kontakt_ID] ASC)
);

