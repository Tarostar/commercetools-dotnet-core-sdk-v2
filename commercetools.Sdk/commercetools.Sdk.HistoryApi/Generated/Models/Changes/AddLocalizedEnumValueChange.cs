using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddLocalizedEnumValueChange : IAddLocalizedEnumValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }

        public ILocalizedEnumValue NextValue { get; set; }
        public AddLocalizedEnumValueChange()
        {
            this.Type = "AddLocalizedEnumValueChange";
        }
    }
}
