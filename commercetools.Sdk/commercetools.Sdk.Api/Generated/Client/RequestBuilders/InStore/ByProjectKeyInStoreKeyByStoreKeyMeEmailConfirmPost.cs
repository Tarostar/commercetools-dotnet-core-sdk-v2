using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost, commercetools.Sdk.Api.Models.Customers.ICustomer>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private commercetools.Sdk.Api.Models.Customers.IMyCustomerEmailVerify MyCustomerEmailVerify;

        public ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Sdk.Api.Models.Customers.IMyCustomerEmailVerify myCustomerEmailVerify)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.MyCustomerEmailVerify = myCustomerEmailVerify;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/email/confirm";
        }




        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomer> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(MyCustomerEmailVerify);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
