using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("OrderBillingAddressSet", typeof(commercetools.Api.Models.Messages.OrderBillingAddressSetMessagePayload))]
    [SubTypeDiscriminator("OrderCreated", typeof(commercetools.Api.Models.Messages.OrderCreatedMessagePayload))]
    [SubTypeDiscriminator("OrderCustomLineItemDiscountSet", typeof(commercetools.Api.Models.Messages.OrderCustomLineItemDiscountSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomerEmailSet", typeof(commercetools.Api.Models.Messages.OrderCustomerEmailSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomerGroupSet", typeof(commercetools.Api.Models.Messages.OrderCustomerGroupSetMessagePayload))]
    [SubTypeDiscriminator("OrderCustomerSet", typeof(commercetools.Api.Models.Messages.OrderCustomerSetMessagePayload))]
    [SubTypeDiscriminator("OrderDeleted", typeof(commercetools.Api.Models.Messages.OrderDeletedMessagePayload))]
    [SubTypeDiscriminator("OrderDiscountCodeAdded", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload))]
    [SubTypeDiscriminator("OrderDiscountCodeRemoved", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload))]
    [SubTypeDiscriminator("OrderDiscountCodeStateSet", typeof(commercetools.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload))]
    [SubTypeDiscriminator("OrderEditApplied", typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    [SubTypeDiscriminator("OrderImported", typeof(commercetools.Api.Models.Messages.OrderImportedMessagePayload))]
    [SubTypeDiscriminator("OrderLineItemAdded", typeof(commercetools.Api.Models.Messages.OrderLineItemAddedMessagePayload))]
    [SubTypeDiscriminator("OrderLineItemDiscountSet", typeof(commercetools.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload))]
    [SubTypeDiscriminator("OrderPaymentStateChanged", typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessagePayload))]
    [SubTypeDiscriminator("ReturnInfoAdded", typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessagePayload))]
    [SubTypeDiscriminator("OrderReturnShipmentStateChanged", typeof(commercetools.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderShipmentStateChanged", typeof(commercetools.Api.Models.Messages.OrderShipmentStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderShippingAddressSet", typeof(commercetools.Api.Models.Messages.OrderShippingAddressSetMessagePayload))]
    [SubTypeDiscriminator("OrderShippingInfoSet", typeof(commercetools.Api.Models.Messages.OrderShippingInfoSetMessagePayload))]
    [SubTypeDiscriminator("OrderShippingRateInputSet", typeof(commercetools.Api.Models.Messages.OrderShippingRateInputSetMessagePayload))]
    [SubTypeDiscriminator("OrderStateChanged", typeof(commercetools.Api.Models.Messages.OrderStateChangedMessagePayload))]
    [SubTypeDiscriminator("OrderStateTransition", typeof(commercetools.Api.Models.Messages.OrderStateTransitionMessagePayload))]
    [SubTypeDiscriminator("OrderStoreSet", typeof(commercetools.Api.Models.Messages.OrderStoreSetMessagePayload))]
    [SubTypeDiscriminator("ParcelAddedToDelivery", typeof(commercetools.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload))]
    [SubTypeDiscriminator("ParcelItemsUpdated", typeof(commercetools.Api.Models.Messages.ParcelItemsUpdatedMessagePayload))]
    [SubTypeDiscriminator("ParcelMeasurementsUpdated", typeof(commercetools.Api.Models.Messages.ParcelMeasurementsUpdatedMessagePayload))]
    [SubTypeDiscriminator("ParcelRemovedFromDelivery", typeof(commercetools.Api.Models.Messages.ParcelRemovedFromDeliveryMessagePayload))]
    [SubTypeDiscriminator("ParcelTrackingDataUpdated", typeof(commercetools.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload))]
    [SubTypeDiscriminator("PaymentCreated", typeof(commercetools.Api.Models.Messages.PaymentCreatedMessagePayload))]
    [SubTypeDiscriminator("PaymentInteractionAdded", typeof(commercetools.Api.Models.Messages.PaymentInteractionAddedMessagePayload))]
    [SubTypeDiscriminator("PaymentStatusInterfaceCodeSet", typeof(commercetools.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload))]
    [SubTypeDiscriminator("PaymentStatusStateTransition", typeof(commercetools.Api.Models.Messages.PaymentStatusStateTransitionMessagePayload))]
    [SubTypeDiscriminator("PaymentTransactionAdded", typeof(commercetools.Api.Models.Messages.PaymentTransactionAddedMessagePayload))]
    [SubTypeDiscriminator("PaymentTransactionStateChanged", typeof(commercetools.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload))]
    [SubTypeDiscriminator("ProductAddedToCategory", typeof(commercetools.Api.Models.Messages.ProductAddedToCategoryMessagePayload))]
    [SubTypeDiscriminator("ProductCreated", typeof(commercetools.Api.Models.Messages.ProductCreatedMessagePayload))]
    [SubTypeDiscriminator("ProductDeleted", typeof(commercetools.Api.Models.Messages.ProductDeletedMessagePayload))]
    [SubTypeDiscriminator("ProductImageAdded", typeof(commercetools.Api.Models.Messages.ProductImageAddedMessagePayload))]
    [SubTypeDiscriminator("ProductPriceDiscountsSet", typeof(commercetools.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload))]
    [SubTypeDiscriminator("ProductPriceExternalDiscountSet", typeof(commercetools.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload))]
    [SubTypeDiscriminator("ProductPublished", typeof(commercetools.Api.Models.Messages.ProductPublishedMessagePayload))]
    [SubTypeDiscriminator("ProductRemovedFromCategory", typeof(commercetools.Api.Models.Messages.ProductRemovedFromCategoryMessagePayload))]
    [SubTypeDiscriminator("ProductRevertedStagedChanges", typeof(commercetools.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload))]
    [SubTypeDiscriminator("ProductSlugChanged", typeof(commercetools.Api.Models.Messages.ProductSlugChangedMessagePayload))]
    [SubTypeDiscriminator("ProductStateTransition", typeof(commercetools.Api.Models.Messages.ProductStateTransitionMessagePayload))]
    [SubTypeDiscriminator("ProductUnpublished", typeof(commercetools.Api.Models.Messages.ProductUnpublishedMessagePayload))]
    [SubTypeDiscriminator("ProductVariantDeleted", typeof(commercetools.Api.Models.Messages.ProductVariantDeletedMessagePayload))]
    [SubTypeDiscriminator("ReviewCreated", typeof(commercetools.Api.Models.Messages.ReviewCreatedMessagePayload))]
    [SubTypeDiscriminator("ReviewRatingSet", typeof(commercetools.Api.Models.Messages.ReviewRatingSetMessagePayload))]
    [SubTypeDiscriminator("ReviewStateTransition", typeof(commercetools.Api.Models.Messages.ReviewStateTransitionMessagePayload))]
    [SubTypeDiscriminator("CustomerCompanyNameSet", typeof(commercetools.Api.Models.Messages.CustomerCompanyNameSetMessagePayload))]
    [SubTypeDiscriminator("CustomerAddressChanged", typeof(commercetools.Api.Models.Messages.CustomerAddressChangedMessagePayload))]
    [SubTypeDiscriminator("InventoryEntryDeleted", typeof(commercetools.Api.Models.Messages.InventoryEntryDeletedMessagePayload))]
    [SubTypeDiscriminator("InventoryEntryQuantitySet", typeof(commercetools.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload))]
    [SubTypeDiscriminator("InventoryEntryCreated", typeof(commercetools.Api.Models.Messages.InventoryEntryCreatedMessagePayload))]
    [SubTypeDiscriminator("DeliveryRemoved", typeof(commercetools.Api.Models.Messages.DeliveryRemovedMessagePayload))]
    [SubTypeDiscriminator("CustomerGroupSet", typeof(commercetools.Api.Models.Messages.CustomerGroupSetMessagePayload))]
    [SubTypeDiscriminator("DeliveryAddressSet", typeof(commercetools.Api.Models.Messages.DeliveryAddressSetMessagePayload))]
    [SubTypeDiscriminator("LineItemStateTransition", typeof(commercetools.Api.Models.Messages.LineItemStateTransitionMessagePayload))]
    [SubTypeDiscriminator("CategorySlugChanged", typeof(commercetools.Api.Models.Messages.CategorySlugChangedMessagePayload))]
    [SubTypeDiscriminator("CustomerEmailVerified", typeof(commercetools.Api.Models.Messages.CustomerEmailVerifiedMessagePayload))]
    [SubTypeDiscriminator("CustomerEmailChanged", typeof(commercetools.Api.Models.Messages.CustomerEmailChangedMessagePayload))]
    [SubTypeDiscriminator("CustomLineItemStateTransition", typeof(commercetools.Api.Models.Messages.CustomLineItemStateTransitionMessagePayload))]
    [SubTypeDiscriminator("CustomerDateOfBirthSet", typeof(commercetools.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload))]
    [SubTypeDiscriminator("CustomerAddressAdded", typeof(commercetools.Api.Models.Messages.CustomerAddressAddedMessagePayload))]
    [SubTypeDiscriminator("CategoryCreated", typeof(commercetools.Api.Models.Messages.CategoryCreatedMessagePayload))]
    [SubTypeDiscriminator("CustomerAddressRemoved", typeof(commercetools.Api.Models.Messages.CustomerAddressRemovedMessagePayload))]
    [SubTypeDiscriminator("DeliveryItemsUpdated", typeof(commercetools.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload))]
    [SubTypeDiscriminator("DeliveryAdded", typeof(commercetools.Api.Models.Messages.DeliveryAddedMessagePayload))]
    [SubTypeDiscriminator("CustomerCreated", typeof(commercetools.Api.Models.Messages.CustomerCreatedMessagePayload))]
    public partial interface IMessagePayload 
    {
        string Type { get; set;}
    }
}
