USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[StergereUtilizator]    Script Date: 19.11.2021 11:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[StergereUtilizator]
@UtilizatorID as int
AS
BEGIN
	DELETE FROM Utilizator
	WHERE UtilizatorID = @UtilizatorID
END

