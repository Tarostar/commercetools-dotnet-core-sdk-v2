using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsByIDGet : ApiMethod<ByProjectKeyBusinessUnitsByIDGet>, IApiMethod<ByProjectKeyBusinessUnitsByIDGet, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyBusinessUnitsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyBusinessUnitsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyBusinessUnitsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyBusinessUnitsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/business-units/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyBusinessUnitsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnit>(requestMessage, cancellationToken);
        }

    }
}
