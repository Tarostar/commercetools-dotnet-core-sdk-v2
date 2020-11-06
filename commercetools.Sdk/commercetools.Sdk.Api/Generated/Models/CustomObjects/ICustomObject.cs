using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomObjects.CustomObject))]
    public partial interface ICustomObject : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Container { get; set;}
        
        string Key { get; set;}
        
        Object Value { get; set;}
    }
}
