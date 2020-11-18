using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.TermFacetResult))]
    public partial interface ITermFacetResult : IFacetResult
    {
        ITermFacetResultType DataType { get; set;}
        
        long Missing { get; set;}
        
        long Total { get; set;}
        
        long Other { get; set;}
        
        List<IFacetResultTerm> Terms { get; set;}
    }
}
