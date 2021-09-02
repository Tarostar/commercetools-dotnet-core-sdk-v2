using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTextLineItemNameChange : IChangeTextLineItemNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITextLineItemValue TextLineItem { get; set; }

        public ILocalizedString NextValue { get; set; }

        public ILocalizedString PreviousValue { get; set; }
        public ChangeTextLineItemNameChange()
        {
            this.Type = "ChangeTextLineItemNameChange";
        }
    }
}
