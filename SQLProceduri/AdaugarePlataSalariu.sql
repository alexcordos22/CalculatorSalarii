USE [CalculatorSalarii]
GO
/****** Object:  StoredProcedure [dbo].[AdaugarePlataSalariu]    Script Date: 19.11.2021 11:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AdaugarePlataSalariu] 
@AngajatID int,
@Nume nvarchar(50),
@Prenume nvarchar(50),
@CNP  nvarchar(50),
@DataPlatii  datetime,
@PerioadaPlata   nvarchar(50),
@LunaPlata nvarchar(50),
@TarifOrar  decimal(18, 2),
@TarifOreSuplimentare decimal(18, 2),
@OreContract	decimal(18, 2),
@OreSuplimentare decimal(18, 2),
@TotalOre	  decimal(18, 2),
@SalariuOreContract money,
@SalariuOreSuplimentare	 money,
@SalariuBrut		 money,
@ImpozitVenit			money,
@CAS  money,
@CASS	money,
@DeducerePersonala	money,
@TotalDeducere			money,
@SalariuNet			money
AS
BEGIN
INSERT INTO PlatiSalariu(AngajatID, Nume, Prenume, CNP, DataPlatii, PeriodaPlata, LunaPlata, 
TarifOrar, TarifOreSuplimentare ,OreContract, OreSuplimentare,TotalOre, SalariuOreContract, SalariuOreSuplimentare, 
SalariuBrut, ImpozitVenit, CAS, CASS, DeducerePersonala,TotalDeducere, SalariuNet)
	VALUES(@AngajatID, @Nume, @Prenume, @CNP, @DataPlatii, @PerioadaPlata, @LunaPlata,
@TarifOrar, @TarifOreSuplimentare , @OreContract, @OreSuplimentare, @TotalOre, @SalariuOreContract, 
@SalariuOreSuplimentare, @SalariuBrut, @ImpozitVenit, @CAS, @CASS, @DeducerePersonala,
@TotalDeducere, @SalariuNet);	
END