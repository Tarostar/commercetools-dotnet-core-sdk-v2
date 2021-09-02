using commercetools.ImportApi.Models.Importsummaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsummaries
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsummaries.ImportSummary))]
    public partial interface IImportSummary
    {
        IOperationStates States { get; set; }

        long Total { get; set; }
    }
}
