using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Categories;

namespace commercetools.ImportApi.Client.RequestBuilders.Categories
{
   public class ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyPost Post(commercetools.ImportApi.Models.Importrequests.ICategoryImportRequest categoryImportRequest) {
           return new ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, categoryImportRequest);
       }
       
       public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder ResourceKeyWithResourceKeyValue(string resourceKey) {
           return new ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, resourceKey);
       }
       public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations() {
           return new ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
       }
   }
}
