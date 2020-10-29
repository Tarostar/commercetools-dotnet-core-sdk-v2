using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class HighPrecisionMoney : IHighPrecisionMoney
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public MoneyType TypeAsEnum => this.Type.GetEnum<MoneyType>();
        
        public int FractionDigits { get; set;}
        
        public long CentAmount { get; set;}
        
        public string CurrencyCode { get; set;}
        
        public long PreciseAmount { get; set;}
        public HighPrecisionMoney()
        { 
           this.Type = "highPrecision";
        }
    }
}
