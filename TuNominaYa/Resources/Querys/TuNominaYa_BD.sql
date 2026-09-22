/*
Abreviaciones de las tablas ->

Empleados: empl
Nómina: nomi
Pagos: pago
Configuraciones: conf
Auxiliares: auxi
Auditoria: audi

Abreviaciones de la estructura de una tabla -> 

id: id+[Primeras 4 letras de la tabla]: idempr

-> Nota:
1.Cualquier campo abreviado que tenga 3 o 4 letras debera ser acompañado por 
las primeras 4 letras de la tabla: nomempr

2.Cuando se crea una tabla cuyo funcionamiento es para determinar los lugares
donde una información se puede mostrar o no, deberan de tener incluido la palabra
'Vistas' al igual que otras como 'Conversion', 'audi': auxiVistasTipTelfEmpresa 

3.Las abreviaciones del id de las tablas vistas deberan de tomar la 'V' para identificar
que es una vista: idVtipt
*/

-- Tipo de identificacion: Cedula, RNC, Pasaporte y Ninguno
Create table auxiTipIdentificacion(
	idtipi		int				primary key identity(1,1),
	nomtipi		nvarchar(75)	not null,
	destipi		nvarchar(100)	not null default(''),
	obligatorio	bit				not null default(1),	
	estado		bit				not null default(1)
);

-- Monedas
Create table auxiMonedas(
	idmone		int				primary key identity(1,1),
	nommone		nvarchar(75)	not null,
	abreviatura nvarchar(20)	not null default(''),
	tasa		float			not null,
	estado		bit				not null default(1)
);

-- Valor de conversión de la moneda
Create table auxiConversionMonedas(
	idCmone		int				not null,
	idmone		int				not null,
	tasa		float			not null
);

-- Auditoria de cambios en la tabla auxiConversionMonedas
Create table audiConversionMonedas(
	idACmone	int				not null,
	hostName	nvarchar(150)	not null,
	loginName	nvarchar(150)	not null,
	fecha		datetime		not null default(getdate()),	
	cambios		nvarchar(250)	not null
);

-- ======
-- Trigger de auditoria para la tabla: auxiConversionMonedas
if object_id('tr_audi_auxiConversionMonedas_upd', 'TR') is not null drop trigger tr_audi_auxiConversionMonedas_upd;
go
Create trigger tr_audi_auxiConversionMonedas_upd
on auxiConversionMonedas
after update
as
begin

set nocount on;
insert into audiConversionMonedas (idACmone, hostName, loginName, fecha, cambios)
Select i.idCmone,
	host_name(),
	ORIGINAL_LOGIN(),
	getdate(),
	'Para la moneda: [' + i.idCmone + '] y su Conversion: [' + i.idmone + '], su tasa original fue: ' + d.tasa 
		+ ' y la nueva tasa es: '+ i.tasa
from inserted i inner join deleted d on i.idCmone = d.idCmone

end;
-- ======


-- Empresa
Create table confEmpresa( 
	idempr		int				primary key identity(1,1),
	nomempr		nvarchar(75)	not null default(''),
	fotoempr	nvarchar(250)	null,
	selloempr	nvarchar(250)	null,
	ubicacion	nvarchar(150)	not null default(''),
	email		nvarchar(150)	not null default(''),
	idtipi		int				not null, -- FK Tipo Rnc
	identiempr	nvarchar(15)	not null, -- Rnc
	idmone		int				not null, -- FK
	estado		bit				not null default(1),

	constraint fk_confEmpresa_auxiTipIdentificacion foreign key (idtipi)
		references auxiTipIdentificacion (idtipi),
	constraint fk_confEmpresa_auxiMonedas foreign key (idmone)
		references auxiMonedas (idmone)
);

-- Pantallas (Formularios) del sistema
Create table auxiPantallas(
	idpant		int				primary key identity(1,1),
	nompant		nvarchar(75)	not null,
	despant		nvarchar(100)	not null default(''),
	estado		bit				not null default(0)
);

-- Tipos de telefenos
Create table auxiTipTelfEmpresa(
	idtipt		int				primary key identity(1,1),
	nomtipt		nvarchar(75)	not null,
	destipt		nvarchar(100)	not null default(''),
	estado		bit				not null default(1)
);


-- Vistas de los tipos de telefonos
Create table auxiVistasTipTelfEmpresa(
	idVtipt		int				not null,
	idpant		int				not null,
	estado		bit				not null default(0),

	constraint pk_auxiVistasTipTelfEmpresa primary key (idVtipt, idpant),
	constraint fk_auxiVistasTipTelfEmpresa_auxiPantallas foreign key (idpant)
		references auxiPantallas (idpant),
	constraint fk_auxiVistasTipTelfEmpresa_auxiTipTelfEmpresa foreign key (idVtipt)
		references auxiTipTelfEmpresa (idtipt)
);


-- Telefonos de la empresa
Create table confTelfEmpresa(
	idtelf		int				primary key identity(1,1),
	idtipt		int				not null,
	telefono	varchar(30)		not null,
	prioridad	int				not null default(0),
	estado		bit				not null default(1),

	constraint fk_confTelfEmpresa_auxiTipTelfEmpresa foreign key (idtipt)
		references auxiTipTelfEmpresa (idtipt)
);