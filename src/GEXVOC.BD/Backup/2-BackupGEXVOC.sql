-- =============================================
-- Author:		Francisco Gonzalez (Autor inicial: Marcos García Núñez)
-- Create date: 09/09/2008
-- Description:	Realiza tanto el backup como la restauración de la base de datos gexvoc
-- Nota: ESTE PROCEDIMIENTO SERÁ CREADO EN MASTER.
-- =============================================

USE [master]
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'BackupGEXVOC')
	BEGIN
		DROP  Procedure  BackupGEXVOC
	END

GO

CREATE Procedure dbo.BackupGEXVOC
	(		
		@Operation		varchar(255),
		@DiskFileName	varchar(255),
		@BackupName		varchar(255) = NULL
	) AS
BEGIN

	SET NOCOUNT ON; 
	if (upper(@Operation) = 'BACKUP') 
	begin	
		BACKUP DATABASE [gexvoc] TO  DISK = @DiskFileName 
		WITH NOFORMAT, NOINIT,  NAME = @BackupName, SKIP, NOREWIND, NOUNLOAD,  STATS = 10;
		BACKUP LOG [gexvoc] with TRUNCATE_ONLY;

		exec gexvoc.dbo.ShrinkGexVOCLog
	end

	if (upper(@Operation) = 'RESTORE') 
	begin
		-- Se carga todas las conexiones a la BD gexvoc.
		DECLARE spids2Kill CURSOR FAST_FORWARD for
				select 
					sproc.spid
				from 
					master.dbo.sysprocesses sproc 
					inner join
						master.dbo.sysdatabases sdb
					  on
						sproc.dbid = sdb.dbid
				where
					upper(sdb.name) = 'GEXVOC';
		declare	@spid integer;
		declare @ExecCommand varchar(255);

		open spids2Kill;
		fetch next from spids2Kill into @spid;

		while @@FETCH_STATUS = 0
		begin
			set @ExecCommand = 'Kill ' + convert(varchar, @spid) + ';';
			exec (@ExecCommand);

			fetch next from spids2Kill into @spid;
		end

		close spids2Kill;
		deallocate spids2Kill;

		RESTORE DATABASE [gexvoc] FROM  DISK = @DiskFileName WITH  FILE = 1,  NOUNLOAD,  STATS = 10
	end

END


GO


GRANT EXEC ON BackupGEXVOC TO PUBLIC
GO


