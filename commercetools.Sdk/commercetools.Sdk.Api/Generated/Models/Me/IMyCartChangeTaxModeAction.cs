using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartChangeTaxModeAction))]
    public partial interface IMyCartChangeTaxModeAction : IMyCartUpdateAction
    {
        ITaxMode TaxMode { get; set; }
    }
}
