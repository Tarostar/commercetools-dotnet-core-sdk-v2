using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductStateTransitionMessagePayload))]
    public interface IProductStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set;}
        
        bool Force { get; set;}
    }
}
