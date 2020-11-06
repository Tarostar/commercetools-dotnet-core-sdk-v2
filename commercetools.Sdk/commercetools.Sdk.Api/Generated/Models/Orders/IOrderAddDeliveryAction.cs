using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderAddDeliveryAction))]
    public partial interface IOrderAddDeliveryAction : IOrderUpdateAction
    {
        List<IDeliveryItem> Items { get; set;}
        
        IAddress Address { get; set;}
        
        List<IParcelDraft> Parcels { get; set;}
    }
}
