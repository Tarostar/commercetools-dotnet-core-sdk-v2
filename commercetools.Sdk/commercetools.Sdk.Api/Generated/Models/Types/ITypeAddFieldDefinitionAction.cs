using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeAddFieldDefinitionAction))]
    public interface ITypeAddFieldDefinitionAction : ITypeUpdateAction
    {
        IFieldDefinition FieldDefinition { get; set;}
    }
}
