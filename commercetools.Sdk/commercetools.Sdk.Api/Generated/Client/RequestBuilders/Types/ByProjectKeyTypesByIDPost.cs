using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Types
{
    public partial class ByProjectKeyTypesByIDPost : ApiMethod<ByProjectKeyTypesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Api.Models.Types.ITypeUpdate TypeUpdate;

        public ByProjectKeyTypesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Api.Models.Types.ITypeUpdate typeUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.TypeUpdate = typeUpdate;
            this.RequestUrl = $"/{ProjectKey}/types/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTypesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.Types.IType> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Types.IType>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(TypeUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
