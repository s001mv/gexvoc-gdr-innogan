

declare @IdModulo int;
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='_BÁSICO';----OBTENGO EL IDENTIFICADOR DEL MÓDULO BÁSICO.

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Basico' AND Formulario='Principal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Basico','Principal',null) 


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA ECONOMÍA';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA ECONOMÍA

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Economia' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Economia','ArbolInfomes',null)            
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Economia' AND Formulario='EditTratEnfermedad' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Economia','EditTratEnfermedad',null) 	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Economia' AND Formulario='EditTratEnfermedad' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Economia','EditTratEnfermedad',null) 


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA SANIDAD';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA SANIDAD

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Sanidad' AND Formulario='EditAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Sanidad','EditAnimales',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Sanidad' AND Formulario='EditExplotaciones' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Sanidad','EditExplotaciones',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Sanidad' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Sanidad','ArbolInfomes',null) 	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Sanidad' AND Formulario='InfFichaAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Sanidad','InfFichaAnimal',null) 


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA AGENDA';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA AGENDA

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Agenda' AND Formulario='FindExplotaciones' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Agenda','FindExplotaciones',null) 	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Agenda' AND Formulario='EditExplotaciones' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Agenda','EditExplotaciones',null) 
	
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA ALIMENTACIÓN';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA ALIMENTACIÓN

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Alimentacion' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Alimentacion','ArbolInfomes',null) 	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Alimentacion' AND Formulario='Principal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Alimentacion','Principal',null) 	
	
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA FINCAS';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA FINCAS

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Fincas' AND Formulario='Principal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Fincas','Principal',null) 	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Fincas' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Fincas','ArbolInfomes',null) 

SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA GENEALOGÍA';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA GENEALOGÍA
	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Genealogia' AND Formulario='EditAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Genealogia','EditAnimales',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Genealogia' AND Formulario='FindAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Genealogia','FindAnimales',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Genealogia' AND Formulario='InfFichaAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Genealogia','InfFichaAnimal',null) 
	
	
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA PRODUCCIÓN CARNE';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA PRODUCCIÓN CARNE
	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProducionCarne' AND Formulario='InfEvolucionAnual' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProducionCarne','InfEvolucionAnual',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProducionCarne' AND Formulario='InfFichaAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProducionCarne','InfFichaAnimal',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProducionCarne' AND Formulario='EditAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProducionCarne','EditAnimales',null) 


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA PRODUCCIÓN LECHE';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA PRODUCCIÓN LECHE
	
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProduccionLeche' AND Formulario='InfFichaAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProduccionLeche','InfFichaAnimal',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProduccionLeche' AND Formulario='EditAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProduccionLeche','EditAnimales',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProduccionLeche' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProduccionLeche','ArbolInfomes',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProduccionLeche' AND Formulario='FindAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProduccionLeche','FindAnimales',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='ProduccionLeche' AND Formulario='Principal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'ProduccionLeche','Principal',null) 

SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA REPRODUCCIÓN';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA REPRODUCCIÓN

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='EditAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','EditAnimales',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','ArbolInfomes',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='InfFichaAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','InfFichaAnimal',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='FindLoteAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','FindLoteAnimal',null)
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='Principal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','Principal',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='EditLoteAnimal' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','EditLoteAnimal',null) 
IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Reproduccion' AND Formulario='FindAnimales' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Reproduccion','FindAnimales',null) 

SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA TRAZABILIDAD';----OBTENGO EL IDENTIFICADOR DEL SUBSISTEMA TRAZABILIDAD

IF NOT EXISTS (SELECT * FROM [Proceso] WHERE IdModulo=@IdModulo AND Nombre='Trazabilidad' AND Formulario='ArbolInfomes' )	
	INSERT INTO [Proceso]([IdModulo],[Nombre],[Formulario],[ValorBoolInicial]) VALUES(@IdModulo,'Trazabilidad','ArbolInfomes',null) 

