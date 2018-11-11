using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace FigiApiCsharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var client = new RestClient("https://api.openfigi.com/v1/mapping");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("X-OPENFIGI-APIKEY", "");
            request.AddHeader("Content-Type", "text/json");

            //Our customers appear to trade only the monthly futures Zinc, Alumninium and Nickel contracts
            string futuresTicker = FutureTicker.MakeFutureTicker("LX", 11, 2018, false);        //Zinc
            string futuresTicker2 = FutureTicker.MakeFutureTicker("LA", 11, 2018, false);        //Aluminium - search for LME PRI ALUM FUTR
            string futuresTicker3 = FutureTicker.MakeFutureTicker("LN", 11, 2018, true);        //Nickel - search for LME NICKEL FUTURE
            string futuresTicker4 = FutureTicker.MakeFutureTicker("G ", 3, 2019, true);         // LONG GILT FUTURE, ICE Futures
            string futuresTicker5 = FutureTicker.MakeFutureTicker("OE", 3, 2019, true);         //Eurex EURO-BOBL Future
            string futuresTicker6 = FutureTicker.MakeFutureTicker("RX", 3, 2019, true);         //Eurex EURO-BUND FUTURE
            string futuresTicker7 = FutureTicker.MakeFutureTicker("ER", 12, 2018, true); //LEUR //IX17144355-0 //Search for "3MO EURO EURIBOR" 
            string futuresTicker8 = FutureTicker.MakeFutureTicker("ED", 12, 2018, true); //ED1 // Search for "90DAY EURO$ FUTR"
            string futuresTicker9 = FutureTicker.MakeFutureTicker("L ", 12, 2018, true); //LST // IX17164120-0 is the Dec 18 contract
            string futuresTicker10 = FutureTicker.MakeFutureTicker("FV", 12, 2018, true); //CTN // IX40542994-0 is the Dec 18 contract
            string futuresTicker11 = FutureTicker.MakeFutureTicker("TU", 12, 2018, true); //CTN2 // IX40543078-0 is the Dec 18 contract
            string futuresTicker12 = FutureTicker.MakeFutureTicker("TY", 03, 2019, true); //TN1 //ix42848774-0 is the Mar 19 contract
            string futuresTicker13 = FutureTicker.MakeFutureTicker("WN", 12, 2018, true); //EXUL //IX40312267-0 is the Dec 18 contract
            string futuresTicker14 = FutureTicker.MakeFutureTicker("ES", 12, 2018, true); //ES //IX37071885-0 is the Dec 18 contract //Search for S&P500 EMINI FUT
            string futuresTicker15 = FutureTicker.MakeFutureTicker("MES", 12, 2018, true); //MMEM = MSCI EM Markets Index - // IX37163923-0 is the Dec 18 contract.
            string futuresTicker16 = FutureTicker.MakeFutureTicker("US", 12, 2018, true); //CBO = CBOT TREASURY BOND 30YR - IX40312099-0 is the Dec 18 contract
            string futuresTicker17 = FutureTicker.MakeFutureTicker("BP", 12, 2018, true); //CBRP = CME "IMM BRITISH POUND" //ix20266744-0 is the Dec 18 contract
            string futuresTicker18 = FutureTicker.MakeFutureTicker("EC", 12, 2018, true); //EC = IMM Euro Currency // IX20984910-0 for March 2019
            string futuresTicker19 = FutureTicker.MakeFutureTicker("C ", 12, 2018, true);
            string futuresTicker20 = FutureTicker.MakeFutureTicker("RTY", 12, 2018, true);
            string futuresTicker21 = FutureTicker.MakeFutureTicker("FF", 12, 2018, true);
            string futuresTicker22 = FutureTicker.MakeFutureTicker("Z ", 12, 2018, true);
            string futuresTicker23 = FutureTicker.MakeFutureTicker("OE", 12, 2018, true);
            string futuresTicker24 = FutureTicker.MakeFutureTicker("UB", 12, 2018, true);
            string futuresTicker25 = FutureTicker.MakeFutureTicker("QC", 12, 2018, true);
            string futuresTicker26 = FutureTicker.MakeFutureTicker("UXY", 12, 2018, true);
            string futuresTicker27 = FutureTicker.MakeFutureTicker("LEB", 12, 2018, true);
            string futuresTicker28 = FutureTicker.MakeFutureTicker("LC", 12, 2018, true);
            string futuresTicker29 = FutureTicker.MakeFutureTicker("SM", 12, 2018, true);
            string futuresTicker30 = FutureTicker.MakeFutureTicker("BO", 12, 2018, true);
            string futuresTicker31 = FutureTicker.MakeFutureTicker("W", 12, 2018, true);
            string futuresTicker32 = FutureTicker.MakeFutureTicker("FA", 12, 2018, true);
            string futuresTicker33 = FutureTicker.MakeFutureTicker("IK", 12, 2018, true);
            string futuresTicker34 = FutureTicker.MakeFutureTicker("BTS", 12, 2018, true);
            string futuresTicker35 = FutureTicker.MakeFutureTicker("VG", 12, 2018, true);
            string futuresTicker36 = FutureTicker.MakeFutureTicker("OAT", 12, 2018, true);
            string futuresTicker37 = FutureTicker.MakeFutureTicker("KC", 12, 2018, true);
            string futuresTicker38 = FutureTicker.MakeFutureTicker("CL", 12, 2018, true);
            string futuresTicker39 = FutureTicker.MakeFutureTicker("NG", 12, 2018, false);
            string futuresTicker40 = FutureTicker.MakeFutureTicker("LSI", 12, 2018, true);
            string futuresTicker41 = FutureTicker.MakeFutureTicker("HG", 12, 2018, true);


            //Also try at 18th March 2019 Euribor put option, strike 99.125 - IX34308913-0-0C64 

            var list = new List<OpenFIGIRequest>()
            {
                //new OpenFIGIRequest("ID_EXCH_SYMBOL", "SNAP").WithExchangeCode("US").WithOptionType("Put").WithStrike(12,12.5).WithSecurityType2("Option").WithExpiration("2018-01-19", "2018-01-19"),
                //new OpenFIGIRequest("ID_EXCH_SYMBOL", "GBU").WithExchangeCode("CME").WithOptionType("Put").WithStrike(130.5,130.5).WithSecurityType2("Option").WithExpiration("2019-01-04", "2019-01-04"),
                new OpenFIGIRequest("ID_EXCH_SYMBOL", "KCO").WithExchangeCode("GR").WithOptionType("Put").WithSecurityType2("Option").WithExpiration("2018-11-16", "2018-11-30").WithStrike(7.4,7.4),
                //new OpenFIGIRequest("ID_EXCH_SYMBOL", "I").WithExchangeCode("ICF").WithOptionType("Put").WithStrike(99.125,99.125).WithSecurityType2("Option").WithExpiration("2019-03-18", "2019-03-18"), //Leur options
                //new OpenFIGIRequest("ID_EXCH_SYMBOL", "FMAS").WithSecurityType2("Future").WithExchangeCode("EUX").WithMaturity("2018-12-01","2018-12-31"),
                //new OpenFIGIRequest("ID_EXCH_SYMBOL", "ZS").WithSecurityType2("Future").WithExchangeCode("LME"), //Where ins_market in R&N is LME, the BBG Exchange Code is LME
                //new OpenFIGIRequest("TICKER", "ZSZ8"),
                //new OpenFIGIRequest("BASE_TICKER", "LX"),
                //new OpenFIGIRequest("TICKER", futuresTicker).WithSecurityType2("Future").WithExchangeCode("LME"), //we can't send an exchange symbol with a maturity for LME Futures as the maturity is currently ignored - so send a Bloomberg ticker (easy to make for futures)?
                //new OpenFIGIRequest("TICKER", futuresTicker2).WithSecurityType2("Future").WithExchangeCode("LME"),
                //new OpenFIGIRequest("TICKER", futuresTicker3).WithSecurityType2("Future").WithExchangeCode("LME"),
                //new OpenFIGIRequest("TICKER", futuresTicker4).WithSecurityType2("Future").WithExchangeCode("ICF"),
                //new OpenFIGIRequest("TICKER", futuresTicker5).WithSecurityType2("Future").WithExchangeCode("EUX"),
                //new OpenFIGIRequest("TICKER", futuresTicker6).WithSecurityType2("Future").WithExchangeCode("EUX"),
                //new OpenFIGIRequest("TICKER", futuresTicker7).WithSecurityType2("Future").WithExchangeCode("ICF"),
                //new OpenFIGIRequest("TICKER", futuresTicker8).WithSecurityType2("Future").WithExchangeCode("CME"), //IX8078551-0 is the Dec18 contract 
                //new OpenFIGIRequest("TICKER", futuresTicker9).WithSecurityType2("Future").WithExchangeCode("ICF"),
                //new OpenFIGIRequest("TICKER", futuresTicker10).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker11).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker12).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker13).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker14).WithSecurityType2("Future").WithExchangeCode("CME"),
                //new OpenFIGIRequest("TICKER", futuresTicker15).WithSecurityType2("Future").WithExchangeCode("NYF"), //INS_MARKET=NYBT for Futures -> NYF
                //new OpenFIGIRequest("TICKER", futuresTicker16).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker17).WithSecurityType2("Future").WithExchangeCode("CME"),
                //new OpenFIGIRequest("TICKER", futuresTicker18).WithSecurityType2("Future").WithExchangeCode("CME"),
                //new OpenFIGIRequest("TICKER", futuresTicker19).WithSecurityType2("Future").WithExchangeCode("CBT"), //CBOT CORN
                //new OpenFIGIRequest("TICKER", futuresTicker20).WithSecurityType2("Future").WithExchangeCode("CME"), //E-MINI RUSS 2000 IND FUT
                //new OpenFIGIRequest("TICKER", futuresTicker21).WithSecurityType2("Future").WithExchangeCode("CBT"), //30-DAY INT RATE (FEDFUND)
                //new OpenFIGIRequest("TICKER", futuresTicker22).WithSecurityType2("Future").WithExchangeCode("ICF"), //LIFFE FTSE 100 GBP10
                //new OpenFIGIRequest("TICKER", futuresTicker23).WithSecurityType2("Future").WithExchangeCode("EUX"), //FGBM
                //new OpenFIGIRequest("TICKER", futuresTicker24).WithSecurityType2("Future").WithExchangeCode("EUX"), //FGBX
                //new OpenFIGIRequest("TICKER", futuresTicker25).WithSecurityType2("Future").WithExchangeCode("ICE"),//COCOA NO.7
                //new OpenFIGIRequest("TICKER", futuresTicker26).WithSecurityType2("Future").WithExchangeCode("CBT"),//UL 10 YR T-NOTE
                //new OpenFIGIRequest("TICKER", futuresTicker27).WithSecurityType2("Future").WithExchangeCode("LSE"),//CEUI
                //new OpenFIGIRequest("TICKER", futuresTicker28).WithSecurityType2("Future").WithExchangeCode("CME"),
                //new OpenFIGIRequest("TICKER", futuresTicker29).WithSecurityType2("Future").WithExchangeCode("CBT"),
                new OpenFIGIRequest("TICKER", futuresTicker30).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker31).WithSecurityType2("Future").WithExchangeCode("CBT"),
                //new OpenFIGIRequest("TICKER", futuresTicker32).WithSecurityType2("Future").WithExchangeCode("CME"),
                //new OpenFIGIRequest("TICKER", futuresTicker33).WithSecurityType2("Future").WithExchangeCode("EUX"),
                //new OpenFIGIRequest("TICKER", futuresTicker34).WithSecurityType2("Future").WithExchangeCode("EUX"),
                //new OpenFIGIRequest("TICKER", futuresTicker35).WithSecurityType2("Future").WithExchangeCode("EUX"),
                //new OpenFIGIRequest("TICKER", futuresTicker36).WithSecurityType2("Future").WithExchangeCode("EUX"),
                //new OpenFIGIRequest("TICKER", futuresTicker37).WithSecurityType2("Future").WithExchangeCode("NYB"),
                //new OpenFIGIRequest("TICKER", futuresTicker38).WithSecurityType2("Future").WithExchangeCode("NYM"),
                new OpenFIGIRequest("TICKER", futuresTicker39).WithSecurityType2("Future").WithExchangeCode("NYM") //tw digit date handling for NYM Natural Gas
                //new OpenFIGIRequest("TICKER", futuresTicker40).WithSecurityType2("Future").WithExchangeCode("LSE"),
                //new OpenFIGIRequest("TICKER", futuresTicker41).WithSecurityType2("Future").WithExchangeCode("CMX")


                //See if we can build a ticker for all the other exchanges' futures, so we don't get multiple maturities back
                //-> but still check for multiple results returned as we will need to handle that scenario.
                // SX5E example
                // Only build a Bloomberg ticker for LME Futures with maturity on the third wednesday.
                // Zinc TAPOs coming down as futures - must we filter on the name after download? Perhaps make a new '.With...' filter going up to exclude TAPOs if we know we only want a future.
            };


            //Works: new OpenFIGIRequest("TICKER", "SNAP 01/19/18 P12.5").WithExchangeCode("US").WithMarketSectorDescription("Equity").WithSecurityType("Equity Option").WithOptionType("Put")

            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new NewtonsoftJsonSerializer();
            request.AddJsonBody(list);

            var response = client.Post<List<OpenFIGIArrayResponse>>(request);

            StreamWriter sw = new StreamWriter(@"c:\temp\OpenFigResponse.txt");

            foreach (var dataInstrument in response.Data)
                if (dataInstrument.Data != null && dataInstrument.Data.Any())
                    foreach (var instrument in dataInstrument.Data)
                    {
                        sw.WriteLine("Name:" + instrument.Name);
                        sw.WriteLine("CompositeFIGI:" + instrument.CompositeFIGI);
                        sw.WriteLine("FIGI: " + instrument.figi);
                        sw.WriteLine("MarketSector: " + instrument.MarketSector);
                        sw.WriteLine("Exchange Code:" + instrument.exchCode);
                        sw.WriteLine("Security Type:" + instrument.SecurityType);
                        sw.WriteLine("Security Type 2:" + instrument.SecurityType2);
                        sw.WriteLine("UniqueID:" + instrument.uniqueID);
                        sw.WriteLine("UniqueIDFutOpt:" + instrument.uniqueIDFutOpt);
                        sw.WriteLine("Ticker:" + instrument.Ticker);
                        sw.WriteLine("TickerComplete:" + instrument.TickerComplete);
                        sw.WriteLine("SecurityDescription: " + instrument.SecurityDescription);
                        sw.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
            sw.Close();
        }
    }
}
