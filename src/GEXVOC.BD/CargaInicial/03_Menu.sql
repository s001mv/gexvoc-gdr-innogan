declare @IdModulo int;
declare @IdMenuSuperior int;

SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA AGENDA';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA AGENDA
set @IdMenuSuperior=null;

INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSExplotaciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSHerramientas',0)

           
SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSExplotaciones';----OBTENGO EL IDENTIFICADOR DEL Menú MSExplotaciones

INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador0',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MContactos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTareas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCitas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador3',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProximaCita',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR DEL Menú MSMantenimientos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposDeContactos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSHerramientas';----OBTENGO EL IDENTIFICADOR DEL Menú MSHerramientas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSincronizarContactos',0)


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA APPCC';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA APPCC
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAPPCC',0)

SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA ECONOMÍA';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA ECONOMÍA
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSGestionFinanciera',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSHerramientas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSGestionFinanciera';----OBTENGO EL IDENTIFICADOR DEL Menú MSGestionFinanciera
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MVentas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCompras',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MGastos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR DEL Menú MSGestionFinanciera
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MGFinanciera',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MGFinanciera';----OBTENGO EL IDENTIFICADOR DEL Menú MSGestionFinanciera
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MClientes',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProveedores',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MNaturalezaGasto',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSHerramientas';----OBTENGO EL IDENTIFICADOR DEL Menú MSGestionFinanciera
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRegularizarStock',0)


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA FINCAS';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA FINCAS
set @IdMenuSuperior=null;

INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSFincas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSHerramientas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSFincas';----OBTENGO EL IDENTIFICADOR DEL Menú MSFincas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFincas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador14',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAbono',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSiembra',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRecolecta',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamiento',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSProductos';----OBTENGO EL IDENTIFICADOR DEL Menú MSFincas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFamiliasProductos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MProductos';----OBTENGO EL IDENTIFICADOR DEL Menú MProductos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPTratamiento parcela',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR DEL Menú MSMantenimientos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MGFincas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCVeterinario',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSsanidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPersonalPrincipal',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MGFincas';----OBTENGO EL IDENTIFICADOR DEL Menú MGFincas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAbonos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSemillas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPlagas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFamiliaTratParcelas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProductoTratParcelas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR DEL Menú MSInformes
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoFincas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoFincas';----OBTENGO EL IDENTIFICADOR DEL Menú MPNodoFincas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndSembrados',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndAbonados',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndTratamientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndCortesHierba',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSHerramientas';----OBTENGO EL IDENTIFICADOR DEL Menú MSInformes
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRegularizarStock',0)


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA SANIDAD';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA SANIDAD
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSControl',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSanidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSControl';----OBTENGO EL IDENTIFICADOR DEL Menú MSControl
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSVeterinario',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSVeterinario';----OBTENGO EL IDENTIFICADOR DEL Menú MSVeterinario
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDiagnosticos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador13',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MHistoricoMedicamentos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSProductos';----OBTENGO EL IDENTIFICADOR DEL Menú MSVeterinario
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFamiliasProductos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MProductos';----OBTENGO EL IDENTIFICADOR DEL Menú MProductos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPHigiene',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPSanidad',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MFamiliasProductos';----OBTENGO EL IDENTIFICADOR DEL Menú MFamiliasProductos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFHigiene',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFSanidad',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSanidad';----OBTENGO EL IDENTIFICADOR DEL Menú MSanidad
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamientosHigiene',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamientosProfilaxis',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MCVeterinario';----OBTENGO EL IDENTIFICADOR DEL MCVeterinario
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MEnfermedades',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MMedicamentos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposEnfermedades',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSsanidad';----OBTENGO EL IDENTIFICADOR DEL MSsanidad
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPlanHigiene',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProgramasProfilaxis',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPersonalPrincipal';----OBTENGO EL IDENTIFICADOR DEL  MPersonalPrincipal
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPersonal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTipoPersonal',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR DEL  MSInformes
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoAnimales',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoSanidad',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoAnimales';----OBTENGO EL IDENTIFICADOR DEL  MPNodoAnimales
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndHistorialEnfermedades',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoSanidad';----OBTENGO EL IDENTIFICADOR DEL  MPNodoSanidad
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndPrevalenciaEnfermedades',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndConsultaMorbilidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndConsultaMortalidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndAnimalesEnTratamiento',0)



SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='_BÁSICO';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA _BÁSICO
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSExplotaciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSGanado',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSHerramientas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSVentana',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSAyuda',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSExplotaciones';----OBTENGO EL IDENTIFICADOR DEL  MSExplotaciones
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDatosExplotacion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTitulares',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador4',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MLibro',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSGanado';----OBTENGO EL IDENTIFICADOR DEL  MSGanado
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAnimales',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MLotesAnimales',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSProductos';----OBTENGO EL IDENTIFICADOR DEL  MSProductos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFamiliasProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador2',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MExploradorProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador2',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposProductos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MExploradorProductos',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MProductos';----OBTENGO EL IDENTIFICADOR DEL  MSProductos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPProducción',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MFamiliasProductos';----OBTENGO EL IDENTIFICADOR DEL  MFamiliasProductos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFProducción',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR DEL MSMantenimientos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAnimal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MBancos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MLocalizaciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCondicionesJuridicas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposLotes',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MAnimal';----OBTENGO EL IDENTIFICADOR DEL MSMantenimientos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRazas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MEstadosAnimal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTamanosCria',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MConformacionCria',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'toolStripSeparator2',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposAltas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposBajas',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MBancos';----OBTENGO EL IDENTIFICADOR DEL MSBancos
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCuentas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MLocalizaciones';----OBTENGO EL IDENTIFICADOR DEL MLocalizaciones
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProvincias',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MMunicipios',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR 
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MINFArbol',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparadorInformes',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoExplotacion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoAnimales',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoExplotacion';----OBTENGO EL IDENTIFICADOR 
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndLibroExplotacion',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoAnimales';----OBTENGO EL IDENTIFICADOR 
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndFichaAnimal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndListadoAnimales',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSHerramientas';----OBTENGO EL IDENTIFICADOR DEL MLocalizaciones
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MBackups',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MOpciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAdministrativas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MAdministrativas';----OBTENGO EL IDENTIFICADOR DEL MAdministrativas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPersonalizarMenus',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPersonalizarProcesos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MModulos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDatosSistema',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSVentana';----OBTENGO EL IDENTIFICADOR DEL MSVentana
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCascada',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MMinimizar',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSAyuda';----OBTENGO EL IDENTIFICADOR DEL MSAyuda
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAcerca',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'toolStripSeparator3',0)


SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA ALIMENTACIÓN';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA ALIMENTACIÓN
set @IdMenuSuperior=null;

INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSGanado',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSControl',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSFincas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSHerramientas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSGanado';----OBTENGO EL IDENTIFICADOR DEL MSGanado
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPesos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSControl';----OBTENGO EL IDENTIFICADOR DEL MSGanado
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSAlimentacion',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSAlimentacion';----OBTENGO EL IDENTIFICADOR DEL MSGanado
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAsignaciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPastoreo',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MFincas';----OBTENGO EL IDENTIFICADOR DEL MFincas
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFincas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR 
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCAlimentario',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProduccionCarne',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MCAlimentario';----OBTENGO EL IDENTIFICADOR 
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAlimentos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MFamiliasAlimentos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRaciones',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MProduccionCarne';----OBTENGO EL IDENTIFICADOR MProduccionCarne
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MMomentoPeso',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSHerramientas';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRegularizarStock',0)



SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA GENÉTICA';----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA GENÉTICA
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSGenetica',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSGenetica';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAnalisisGenetico',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MResena',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MGenetica',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MGenetica';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTipoAnalisis',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MMarcador',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCombinacion',0)


----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA PRODUCCIÓN CARNE
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA PRODUCCIÓN CARNE';
set @IdMenuSuperior=null;


INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSGanado',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSControl',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSGanado';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador12',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPesos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCondicionesCorporales',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDesteteMultiple',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSControl';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'controlCarneToolStripMenuItem',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='controlCarneToolStripMenuItem';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MEngrasamientoCanal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTipificacionCanal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRendimientoCanal',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MProduccionCarne',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MProduccionCarne';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MMomentoPeso',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposDeCondiciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'toolStripSeparator4',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCategoria',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTipoEngrasamiento',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MConformacionCanal',0)



SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoProduccionLeche',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoProduccionLeche';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndProduccionCarne',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPndProduccionCarne';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndIndicesConversion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodo3',0)



----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA SUBSISTEMA PRODUCCIÓN LECHE
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA PRODUCCIÓN LECHE';
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoProduccionLeche',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoProduccionLeche';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndProduccionLeche',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPndProduccionLeche';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndRecuentoCelulasSomaticas',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndRecuentoCelSomGraf',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndResumenProduccionLeche',0)


----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA SUBSISTEMA TRAZABILIDAD
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA TRAZABILIDAD';
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSTrazabilidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAPPCC',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSHerramientas',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSTrazabilidad';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'TProcesos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTrazabilidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPersonalPrincipal',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MTrazabilidad';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'Maquinaria',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'Zonas',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPersonalPrincipal';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPersonal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTipoPersonal',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoTrazabilidad',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoTrazabilidad';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoTrazaProductos',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSHerramientas';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MRegularizarStock',0)


----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA SUBSISTEMA VADEMÉCUM
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA VADEMÉCUM';
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSanidad',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSanidad';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamientosHigiene',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamientosProfilaxis',0)


----OBTENGO EL IDENTIFICADOR DEL MÓDULO: SUBSISTEMA REPRODUCCIÓN
SELECT @IdModulo=Id FROM Modulo WHERE Descripcion='SUBSISTEMA REPRODUCCIÓN';
set @IdMenuSuperior=null;
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSReproduccion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSGanado',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSControl',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSMantenimientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSInformes',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSReproduccion';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSincronizacionCelos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCelos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador6',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MInseminaciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MCubriciones',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador11',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDiagGestacion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'toolStripSeparator1',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPartos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MAbortos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPartosMultiples',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSGanado';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSeparador12',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDesteteMultiple',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSControl';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MSVeterinario',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSVeterinario';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDiagnosticos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTratamientos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MHistoricoMedicamentos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSMantenimientos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MReproduccion',0)


SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MReproduccion';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposInseminacion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposCubricion',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposDiagnostico',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MIPartos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTiposAbortos',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MIPartos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MTParto',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MDificultad',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MSInformes';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoSanidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPNodoReproduccion',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoSanidad';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndPrevalenciaEnfermedades',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndConsultaMorbilidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndConsultaMortalidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndAnimalesEnTratamiento',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPNodoReproduccion';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndProlificidad',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndNacidosGenealogia',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndDestetados',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndAnimalesMuertos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndCapacidadMaternal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPnPartos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndEstaFertilidaLeche',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndEvolucionAnual',0)



SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPndAnimalesMuertos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndGeneral',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndNacidosMuertos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndMuertePerinatal',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndMuerteHastaDestete',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndMuertePostDestete',0)

SELECT @IdMenuSuperior=Id FROM Menu WHERE [IdModulo]=@IdModulo AND [Texto]='MPnPartos';----OBTENGO EL IDENTIFICADOR
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndIntervaloPartos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndDistribucionpartos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndTasaPartos',0)
INSERT INTO [Menu]([IdModulo],[IdMenuSuperior],[Orden],[Texto],[Visible]) VALUES (@IdModulo,@IdMenuSuperior,0,'MPndTasaAbortos',0)