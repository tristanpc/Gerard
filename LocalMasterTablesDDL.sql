create table dbo.OpenFigiLocalInstrumentMaster
(
	IONACN varchar(4) not null,
	ION_INSTRUMENT varchar(20) not null,
	LocalSymbol varchar(20) null,
	BBGStem varchar(10) null,
	FutureOptionIndicator varchar(12) not null,
	ReutersYearIsOneDigitAfterOneYearAgo boolean,
	DateAfterWhichReutersYearIsOneDigit datetime,
	IONInstrumentDescription varchar(40) null,
	OpenFigiInstrumentDescription varchar(40) null,
	DoNotRaiseWarningIfNotFoundIn boolean default false
)

create table dbo.OpenFigiLocalProductMaster
(
	IONACN varchar(4) not null,
	ION_INSTRUMENT varchar(20) not null,
	LocalSymbol varchar(20) null,
	ReutersStem varchar(10) null,
	FutureOptionIndicator varchar(12) not null,
	IONInstrumentDescription varchar(40) null,
	OpenFigiInstrumentDescription varchar(40) null,
	DoNotRaiseWarningIfNotFoundIn boolean default false,
	BBGUniqueId varchar(50) null,
	BBGFigi varchar(50) null,
	BBGTicker varchar(50) null,
	BBGFullTicker varchar(60) null,
	BBGStem varchar(10),
	BBGMarketSector varchar(20) null,
	BBGExchangeCode varchar(10) null
)

create table dbo.OpenFigiRemoteProductsFound
(
	IONACN varchar(4) not null,
	ION_INSTRUMENT varchar(20) not null,
	LocalSymbol varchar(20) null,
	ReutersStem varchar(10) null,
	FutureOptionIndicator varchar(12) not null,
	IONInstrumentDescription varchar(40) null,
	OpenFigiInstrumentDescription varchar(40) null,
	DoNotRaiseWarningIfNotFoundIn boolean default false,
	BBGUniqueId varchar(50) null,
	BBGFigi varchar(50) null,
	BBGTicker varchar(50) null,
	BBGFullTicker varchar(60) null,
	BBGStem varchar(10),
	BBGMarketSector varchar(20) null,
	BBGExchangeCode varchar(10) null
)