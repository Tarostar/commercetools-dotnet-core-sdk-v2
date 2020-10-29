using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addShippingRate", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodAddShippingRateAction))]
    [SubTypeDiscriminator("addZone", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodAddZoneAction))]
    [SubTypeDiscriminator("changeIsDefault", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeNameAction))]
    [SubTypeDiscriminator("changeTaxCategory", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction))]
    [SubTypeDiscriminator("removeShippingRate", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction))]
    [SubTypeDiscriminator("removeZone", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetKeyAction))]
    [SubTypeDiscriminator("setLocalizedDescription", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetLocalizedDescriptionAction))]
    [SubTypeDiscriminator("setPredicate", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction))]
    public interface IShippingMethodUpdateAction 
    {
        string Action { get; set;}
    }
}
