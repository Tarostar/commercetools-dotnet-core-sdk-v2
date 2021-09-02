using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetCustomTypeAction : ICategorySetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CategorySetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
