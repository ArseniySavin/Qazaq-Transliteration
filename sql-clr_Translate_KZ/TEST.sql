
/*
CREATE ASSEMBLY CTranslitKZ 
FROM '<Dir>\sql-clr_Translate_KZ\sql-clr_Translate_KZ\bin\Debug\Translate_KZ.dll'
WITH PERMISSION_SET = SAFE;

sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO

USE [sql-clr_Translate_KZ]
GO
EXEC sp_changedbowner 'sa'
*/


declare @WORD NVARCHAR(max)
declare @TrWORDS NVARCHAR(max)

set @WORD = N'НҰРЛЫ ЖОЛ - БОЛАШАҚҚА БАСТАР ЖОЛ'

--set @TrWORDS = dbo.TranslateOnCyrillicQazaq(@WORD)

--set @TrWORDS = dbo.TranslateOnAbcNet(@WORD)

--set @TrWORDS= dbo.TranslateOnCommon(@WORD)

--set @TrWORDS = dbo.TranslateOnGostB(@WORD)

set @TrWORDS = dbo.TranslateOnQazakAqparat(@WORD)
select @TrWORDS