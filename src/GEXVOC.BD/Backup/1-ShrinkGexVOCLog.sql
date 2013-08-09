-- =============================================
-- Author:		Francisco Gonzalez (Autor inicial: Marcos García Núñez)
-- Create date: 09/09/2008
-- Description:	Reduce el archivo de log de la base de datos gexvoc a 0
-- NOTA: ESTE PROCEDIMIENTO SERÁ CREADO EN LA BD GEXVOC, PERO SERÁ LLAMADO DESDE EL PROCEDIMIENTO master.dbo.BackupGEXVOC (Ubicado en master)
-- =============================================
USE [gexvoc]
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'ShrinkGEXVOCLog')
	BEGIN
		DROP  Procedure  ShrinkGEXVOCLog
	END
GO

CREATE Procedure ShrinkGEXVOCLog AS
BEGIN	
	SET NOCOUNT ON;
	DBCC SHRINKFILE (N'gexvoc_log' , 0) WITH NO_INFOMSGS;	
END
GO


GRANT EXEC ON ShrinkGEXVOCLog TO PUBLIC
GO


