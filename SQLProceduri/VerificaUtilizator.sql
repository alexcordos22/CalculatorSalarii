USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[VerificaUtilizator]    Script Date: 19.11.2021 11:27:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[VerificaUtilizator]
@NumeUtilizator as nvarchar(50),
@Parola as nvarchar(50)	
AS
BEGIN
	SELECT * FROM Utilizator
	WHERE NumeUtilizator = @NumeUtilizator OR
	Parola = @Parola	
END