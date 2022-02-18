USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[InserareUtilizator]    Script Date: 19.11.2021 11:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[InserareUtilizator]
@NumeUtilizator as nvarchar(50),
@Parola as nvarchar(50),
@Pozitie as nvarchar(50)

AS
BEGIN
	INSERT INTO Utilizator(NumeUtilizator, Parola, Pozitie)
	VALUES(@NumeUtilizator, @Parola, @Pozitie);	
END
