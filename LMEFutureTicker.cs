using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigiApiCsharpExample
{
    

    //Tickers up to and including June 17 had two digits, from July 17 have one digit. Presumably July 27 will require two digits, 
    //though the boundary likely rolls monthly.

    public static class FutureTicker
    {
        public static string MakeFutureTicker(string LMEinstrumentCode, int monthNumber, int fourDigitYear, bool tickersMoreRecentThanAYearAgoHaveOneDigitYears)
        {
            string ReutersMonthCodes = "FGHJKMNQUVXZ";
            string fullTicker = "";
            fullTicker = LMEinstrumentCode;
            string monthCodeReuters = ReutersMonthCodes.Substring(monthNumber - 1, 1);
            fullTicker += monthCodeReuters;
            string yearCode = "";

            if (tickersMoreRecentThanAYearAgoHaveOneDigitYears == true)
            {
                yearCode = fourDigitYear.ToString().Substring(3, 1); //We'll never want a Bloomberg code with a maturity in the past so with this kind of instrument, just take the last digit. We might find some instruments traded more than ten years out but I doubt it.
            }
            else
            {
                if (LMEinstrumentCode == "LA" || LMEinstrumentCode == "NG") // primary aluminium appears to only use two digit years in OpenFigi. Natural Gas on NYM has had two digits since June 2016.
                {
                    yearCode = fourDigitYear.ToString().Substring(2, 2);
                }
                else
                {
                    switch (fourDigitYear.ToString().Substring(2, 2))
                    {
                        case "18":
                        case "19":
                        case "20":
                        case "21":
                        case "22":
                        case "23":
                        case "24":
                        case "25":
                        case "26":
                            yearCode = fourDigitYear.ToString().Substring(3, 1);
                            break;

                        case "17":
                            string monthsIn17withTwoDigitYears = "FGHJKM";
                            if (monthsIn17withTwoDigitYears.Contains(monthCodeReuters))
                            {
                                yearCode = fourDigitYear.ToString().Substring(3, 1);
                            }
                            else
                            {
                                yearCode = fourDigitYear.ToString().Substring(2, 2);
                            }
                            break;
                        default:
                            yearCode = fourDigitYear.ToString().Substring(2, 2);
                            break;
                    }

                }
            }
        
            fullTicker += yearCode;
            return fullTicker;
        }
    }
}
