using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public abstract partial class Attribute : IAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
    }
}
