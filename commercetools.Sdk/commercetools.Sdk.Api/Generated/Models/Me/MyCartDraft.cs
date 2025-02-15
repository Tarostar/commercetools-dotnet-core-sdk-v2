using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartDraft : IMyCartDraft
    {
        public string Currency { get; set; }

        public string CustomerEmail { get; set; }

        public string Country { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IList<IMyLineItemDraft> LineItems { get; set; }
        public IEnumerable<IMyLineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public IBaseAddress ShippingAddress { get; set; }

        public IBaseAddress BillingAddress { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Locale { get; set; }

        public ITaxMode TaxMode { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public IList<IBaseAddress> ItemShippingAddresses { get; set; }
        public IEnumerable<IBaseAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public IStoreKeyReference Store { get; set; }

        public IList<string> DiscountCodes { get; set; }
        public IEnumerable<string> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }

    }
}
