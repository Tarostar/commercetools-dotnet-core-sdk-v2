using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscount))]
    public partial interface ICartDiscount : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        ILocalizedString Name { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Description { get; set;}
        
        ICartDiscountValue Value { get; set;}
        
        string CartPredicate { get; set;}
        
        ICartDiscountTarget Target { get; set;}
        
        string SortOrder { get; set;}
        
        bool IsActive { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        bool RequiresDiscountCode { get; set;}
        
        List<IReference> References { get; set;}
        
        string StackingMode { get; set;}
        
        StackingMode StackingModeAsEnum { get; }
        
        ICustomFields Custom { get; set;}
    }
}
