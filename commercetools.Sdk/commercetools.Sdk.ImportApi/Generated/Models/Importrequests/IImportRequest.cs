using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("category", typeof(commercetools.ImportApi.Models.Importrequests.CategoryImportRequest))]
    [SubTypeDiscriminator("product", typeof(commercetools.ImportApi.Models.Importrequests.ProductImportRequest))]
    [SubTypeDiscriminator("product-draft", typeof(commercetools.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    [SubTypeDiscriminator("product-variant", typeof(commercetools.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    [SubTypeDiscriminator("price", typeof(commercetools.ImportApi.Models.Importrequests.PriceImportRequest))]
    [SubTypeDiscriminator("order", typeof(commercetools.ImportApi.Models.Importrequests.OrderImportRequest))]
    [SubTypeDiscriminator("product-variant-patch", typeof(commercetools.ImportApi.Models.Importrequests.ProductVariantPatchRequest))]
    [SubTypeDiscriminator("customer", typeof(commercetools.ImportApi.Models.Importrequests.CustomerImportRequest))]
    [SubTypeDiscriminator("inventory", typeof(commercetools.ImportApi.Models.Importrequests.InventoryImportRequest))]
    public partial interface IImportRequest 
    {
        IImportResourceType Type { get; set;}
    }
}
