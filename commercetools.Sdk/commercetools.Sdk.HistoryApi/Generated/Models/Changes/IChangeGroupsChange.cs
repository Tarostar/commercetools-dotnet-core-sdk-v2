using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeGroupsChange))]
    public partial interface IChangeGroupsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<string> PreviousValue { get; set; }

        List<string> NextValue { get; set; }
    }
}
