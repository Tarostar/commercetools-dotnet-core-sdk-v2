using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Address))]
    public partial interface IAddress : IBaseAddress
    {
        new string Id { get; set; }

        ICustomFields Custom { get; set; }

    }
}
