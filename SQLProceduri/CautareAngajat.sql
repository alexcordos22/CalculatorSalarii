
CREATE PROCEDURE CautareAngajat
@AngajatID int
AS
BEGIN
	select*
	from Angajati
	where AngajatID = @AngajatID

END
