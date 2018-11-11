create table dbo.OpenFigiOpenPositionInstruments
(
	IONACN varchar(4) not null,
	ION_INSTRUMENT varchar(20) not null,
	FutureOptionIndicator varchar(12) not null,
	IONInstrumentDescription varchar(40) null
)


create table dbo.OpenFigiOpenPositionContracts
(
	IONACN varchar(4) not null,
	ION_INSTRUMENT varchar(20) not null,
	FutureOptionIndicator varchar(12) not null,
	CallPut	varchar(4) null,
	Strike	decimal(18,4) null
	IONInstrumentDescription varchar(40) null
)