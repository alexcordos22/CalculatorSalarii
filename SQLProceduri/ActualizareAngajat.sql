
CREATE PROCEDURE ActualizareAngajat
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
	UPDATE Angajati SET AngajatID = @AngajatID, Nume = @Nume, Prenume = @Prenume, Gen = @Gen, CNP = @CNP, [Data Nasterii] = @DataNasterii, Adresa = @Adresa,
	Localitatea = @Localitatea, [Cod Postal] = @CodPostal, Judet = @Judet, Telefon = @Telefon, Email = @Email, NumeFisier = @NumeFisier, Imagine = @Imagine
	where AngajatID = @AngajatID 
END

