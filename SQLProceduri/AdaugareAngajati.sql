USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[AdaugareAngajati]    Script Date: 16.11.2021 18:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[AdaugareAngajati]
@AngajatID int,
@Nume nvarchar(50),
@Prenume nvarchar(50),
@Gen nvarchar(50),
@CNP nvarchar(50),
@DataNasterii date,
@Adresa nvarchar(50),
@Localitatea nvarchar(50),
@CodPostal nvarchar(50),
@Judet nvarchar(50),
@Telefon nvarchar(50),
@Email nvarchar(50),
@NumeFisier nvarchar(50),
@Imagine image
AS
BEGIN
	INSERT  INTO Angajati(AngajatID, Nume, Prenume, Gen, CNP, [Data Nasterii], Adresa,
	Localitatea, [Cod Postal], Judet, Telefon, Email, NumeFisier, Imagine)
	values(@AngajatID, @Nume, @Prenume, @Gen, @CNP, @DataNasterii, @Adresa,
	@Localitatea, @CodPostal, @Judet, @Telefon, @Email, @NumeFisier, @Imagine);	
END

