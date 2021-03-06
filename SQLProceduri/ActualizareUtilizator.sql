USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[ActualizareUtilizator]    Script Date: 19.11.2021 11:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ActualizareUtilizator]
@UtilizatorID as int,
@NumeUtilizator as nvarchar(50),
@Parola	as nvarchar(50),
@Pozitie as nvarchar(50)
AS
BEGIN
	UPDATE Utilizator SET NumeUtilizator = @NumeUtilizator, Parola = @Parola,
	Pozitie = @Pozitie
	WHERE UtilizatorID = @UtilizatorID
END

