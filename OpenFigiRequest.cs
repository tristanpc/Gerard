using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace FigiApiCsharpExample
{
    public class OpenFIGIRequest
    {
        private OpenFIGIRequest()
        {

        }

        public OpenFIGIRequest(string idType, string idValue)
            : this()
        {
            this.IdType = idType;
            this.IdValue = idValue;
        }

        public OpenFIGIRequest WithExchangeCode(string exchCode)
        {
            this.ExchangeCode = exchCode;
            return this;
        }

        public OpenFIGIRequest WithMicCode(string micCode)
        {
            this.MicCode = micCode;
            return this;
        }

        public OpenFIGIRequest WithCurrency(string currency)
        {
            this.Currency = currency;
            return this;
        }

        public OpenFIGIRequest WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public OpenFIGIRequest WithMarketSectorDescription(string marketSectorDescription)
        {
            MarketSectorDescription = marketSectorDescription;
            return this;
        }

        public OpenFIGIRequest WithOptionType(string optionType)
        {
            OptionType = optionType;
            return this;
        }

        public OpenFIGIRequest WithSecurityType(string securityType)
        {
            SecurityType = securityType;
            return this;
        }

        public OpenFIGIRequest WithSecurityType2(string securityType2)
        {
            SecurityType2 = securityType2;
            return this;
        }

        public OpenFIGIRequest WithExpiration(string expirationFrom, string expirationTo)
        {
            Expiration = new string[] { expirationFrom, expirationTo };
            return this;
        }

        public OpenFIGIRequest WithMaturity(string maturityFrom, string maturityTo)
        {
            Maturity = new string[]{ maturityFrom, maturityTo };
            return this;
        }

        public OpenFIGIRequest WithStrike(double strikeFrom, double strikeTo)
        {
            Strike = new double[] { strikeFrom, strikeTo };
            return this;
        }

        [JsonProperty("idType")]
        public string IdType { get; set; }

        [JsonProperty("idValue")]
        public string IdValue { get; set; }

        [JsonProperty("exchCode")]
        public string ExchangeCode { get; set; }

        [JsonProperty("micCode")]
        public string MicCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("marketSecDes")]
        public string MarketSectorDescription { get; set; }

        [JsonProperty("optionType")]
        public string OptionType { get; set; }

        [JsonProperty("securityType")]
        public string SecurityType { get; set; }

        [JsonProperty("securityType2")]
        public string SecurityType2 { get; set; }

        [JsonProperty("expiration")]
        public string[] Expiration { get; set; }

        [JsonProperty("maturity")]
        public string[] Maturity { get; set; }

        [JsonProperty("strike")]
        public double[] Strike { get; set; }


    }
}