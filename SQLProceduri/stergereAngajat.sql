
CREATE PROCEDURE StergereAngajat
@AngajatID int 
AS
BEGIN
	DELETE FROM Angajati where AngajatID = @AngajatID 
END
