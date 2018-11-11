
create proc dbo.OpenFigi_insertCapturedContractMappings
(
	@IONACN varchar(4),
	@IONInstrument varchar(25),
	@IONDescription varchar(50),
	@TickerCalculatedLocally varchar(50),
	@ExchangeCodeFromInstrument varchar(5),
	@FutureOption varchar(6),
	@PutCall varchar(4),
	@Strike decimal(21,6),
	@Declaration datetime,
	@LastTradedDate datetime,
	@exchCode varchar(5),
	@figi varchar(40),
	@marketSector varchar(15),
	@name varchar(50),
	@securityDescription varchar(50),
	@securityType varchar(40),
	@securityType2 varchar(40),
	@ticker varchar(50),
	@uniqueID varchar(50)
)
as
insert into OpenFigiCapturedContractMappings
(IONACN, IONInstrument, IONDescription, TickerCalculatedLocally, ExchangeCodeFromInstrument,FutureOption,PutCall, Strike, Declaration, LastTradedDate --stored against the instrument or supplied from open positions or trades
, exchCode, figi, marketSector, [name], securityDescription, securityType, securityType2, ticker, uniqueID) -- retrieved from OpenFigi
select @IONACN, @IONInstrument, @IONDescription, @TickerCalculatedLocally, @ExchangeCodeFromInstrument, @FutureOption, @PutCall, @Strike, @Declaration, @LastTradedDate
, @exchCode, @figi, @marketSector, @name, @securityDescription, @securityType, @securityType2, @ticker, @uniqueID

