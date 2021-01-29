using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.Orders
{
   public partial class ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsByIdGet : ApiMethod<ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsByIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string Id { get; }
       
   
       public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsByIdGet(IClient apiHttpClient, string projectKey, string importSinkKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.Id = id;
           this.RequestUrl = $"/{ProjectKey}/orders/importSinkKey={ImportSinkKey}/import-operations/{Id}";
       }
   
   

       public async Task<commercetools.ImportApi.Models.Importoperations.ImportOperation> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importoperations.ImportOperation>(requestMessage);
       }
   }
}
