using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload))]
    public interface IOrderDiscountCodeStateSetMessagePayload : IMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set;}
        
        string State { get; set;}
        
        DiscountCodeState StateAsEnum { get; }
        
        string OldState { get; set;}
        
        DiscountCodeState OldStateAsEnum { get; }
    }
}
