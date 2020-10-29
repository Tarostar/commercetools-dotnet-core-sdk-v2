using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetSkuAction))]
    public interface IProductSetSkuAction : IProductUpdateAction
    {
        long VariantId { get; set;}
        
        string Sku { get; set;}
        
        bool? Staged { get; set;}
    }
}
