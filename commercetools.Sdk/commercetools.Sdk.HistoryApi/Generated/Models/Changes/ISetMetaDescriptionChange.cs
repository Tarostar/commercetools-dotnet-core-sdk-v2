using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetMetaDescriptionChange))]
    public partial interface ISetMetaDescriptionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString PreviousValue { get; set; }

        ILocalizedString NextValue { get; set; }
    }
}
