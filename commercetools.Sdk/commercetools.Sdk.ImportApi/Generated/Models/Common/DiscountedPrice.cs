using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class DiscountedPrice : IDiscountedPrice
    {
        public ITypedMoney Value { get; set; }

        public IProductDiscountKeyReference Discount { get; set; }
    }
}
