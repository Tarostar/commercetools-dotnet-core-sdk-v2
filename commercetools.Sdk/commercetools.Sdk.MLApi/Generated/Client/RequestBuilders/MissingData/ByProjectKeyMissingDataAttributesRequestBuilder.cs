using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyMissingDataAttributesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMissingDataAttributesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMissingDataAttributesPost Post(commercetools.Sdk.MLApi.Models.MissingData.IMissingAttributesSearchRequest missingAttributesSearchRequest)
        {
            return new ByProjectKeyMissingDataAttributesPost(ApiHttpClient, SerializerService, ProjectKey, missingAttributesSearchRequest);
        }

        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataAttributesStatusRequestBuilder Status()
        {
            return new ByProjectKeyMissingDataAttributesStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
