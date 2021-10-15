using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Customers
{

    public class ByProjectKeyCustomersPasswordTokenByPasswordTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string PasswordToken { get; }

        public ByProjectKeyCustomersPasswordTokenByPasswordTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string passwordToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.PasswordToken = passwordToken;
        }

        public ByProjectKeyCustomersPasswordTokenByPasswordTokenGet Get()
        {
            return new ByProjectKeyCustomersPasswordTokenByPasswordTokenGet(ApiHttpClient, ProjectKey, PasswordToken);
        }

    }
}
