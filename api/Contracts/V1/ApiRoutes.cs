namespace api.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Auth
        {
            public const string Login = Base + "/auth/login";
            public const string Register = Base + "/auth/register";
            public const string Refresh = Base + "/auth/refresh";
            public const string Profile = Base + "/auth/profiles";
        }
        public static class Product
        {
            public const string Create = Base + "/products";
            public const string GetAll = Base + "/products";
            public const string GetBySku = Base + "/products/{sku}";
            public const string Update = Base + "/products/{productId}";
            public const string Delete = Base + "/products/{productId}";
        }

        public static class ProductUnit
        {
            public const string Create = Base + "/productUnits";
            public const string Update = Base + "/productUnits/{productUnitId}";
            public const string Delete = Base + "/productUnits/{productUnitId}";
        }

        public static class PurchaseProposalForm
        {
            public const string Create = Base + "/purchaseProposalForms";
            public const string GetAll = Base + "/purchaseProposalForms";
            public const string GetById = Base + "/purchaseProposalForms/{purchaseProposalFormId}";
            public const string Update = Base + "/purchaseProposalForms/{purchaseProposalFormId}";
            public const string Delete = Base + "/purchaseProposalForms/{purchaseProposalFormId}";
            public const string AddProductToPurchaseProposalForm = Base + "/purchaseProposalForms/{purchaseProposalFormId}/purchaseProposalDetails";
            public const string BulkUpdatePurchaseProposalDetail = Base + "/purchaseProposalForms/{purchaseProposalFormId}/purchaseProposalDetails/bulkUpdate";
            public const string BulkDeletePurchaseProposalDetail = Base + "/purchaseProposalForms/{purchaseProposalFormId}/purchaseProposalDetails/bulkDelete";
        }

        public static class ProductCategories
        {
            public const string GetAll = Base + "/productCategories";
            public const string Create = Base + "/productCategories";
            public const string Update = Base + "/productCategories/{productCategoryId}";
            public const string Delete = Base + "/productCategories/{productCategoryId}";
        }

        public static class GoodsReceivingNotes
        {
            public const string Create = Base + "/goodsReceivingNotes";
            public const string GetAll = Base + "/goodsReceivingNotes";
            public const string GetById = Base + "/goodsReceivingNotes/{goodsReceivingNoteId}";
            public const string Update = Base + "/goodsReceivingNotes/{goodsReceivingNoteId}";
            public const string Delete = Base + "/goodsReceivingNotes/{goodsReceivingNoteId}";
            public const string AddProductToGoodReceivingNote = Base + "/goodsReceivingNotes/{goodsReceivingNoteId}/goodsDeliveryDetails";
            public const string BulkUpdateProductInGoodsReceivingNote = Base + "/goodsReceivingNotes/{goodsReceivingNoteId}/goodsReceivingDetails/bulkUpdate";
            public const string BulkDeleteProductInGoodsReceivingNote = Base + "/goodsReceivingNotes/{goodsReceivingNoteId}/goodsReceivingDetails/bulkDelete";
        }

        public static class Orders
        {
            public const string Create = Base + "/orders";
            public const string GetAll = Base + "/orders";
            public const string GetById = Base + "/orders/{orderId}";
            public const string Update = Base + "/orders/{orderId}";
            public const string Delete = Base + "/orders/{orderId}";
            public const string AddProductsToOrder = Base + "/orders/{orderId}/orderDetails";
            public const string BulkUpdateProductsInOrder = Base + "/orders/{orderId}/orderDetails/bulkUpdate";
            public const string BulkDeleteProductsInOrder = Base + "/orders/{orderId}/orderDetails/bulkDelete";
        }

        public static class Suppliers
        {
            public const string GetAll = Base + "/suppliers";
            public const string GetById = Base + "/suppliers/{supplierId}";
            public const string Create = Base + "/suppliers";
            public const string Update = Base + "/suppliers/{supplierId}";
            public const string Delete = Base + "/suppliers/{supplierId}";
            public const string GetAllSupplierProducts = Base + "/suppliers/{supplierId}/products";
            public const string AddProductsToSupplier = Base + "/suppliers/{supplierId}/products";
            public const string RemoveProductsFromSupplier = Base + "/suppliers/{supplierId}/products";
        }

        public static class InventoryRecordForms
        {
            public const string CreateInventoryRecordForm = Base + "/inventoryRecordForms";
            public const string UpdateInventoryRecordForm = Base + "/inventoryRecordForms/{inventoryRecordFormId}";
            public const string GetAll = Base + "/inventoryRecordForms";
            public const string GetById = Base + "/inventoryRecordForms/{inventoryRecordFormId}";
            public const string CreateInventoryRecordDetail = Base + "/inventoryRecordForms/{inventoryRecordFormId}/inventoryRecordDetails";
            public const string UpdateInventoryRecordDetail = Base + "/inventoryRecordForms/{inventoryRecordFormId}/inventoryRecordDetails";
            public const string DeleteInventoryRecordDetail = Base + "/inventoryRecordForms/{inventoryRecordFormId}/inventoryRecordDetails";

        }

        public static class GoodsDeliveryNotes
        {
            public const string Create = Base + "/goodsDeliveryNotes";
            public const string GetAll = Base + "/goodsDeliveryNotes";
            public const string GetById = Base + "/goodsDeliveryNotes/{goodsDeliveryNoteId}";
            public const string Update = Base + "/goodsDeliveryNotes/{goodsDeliveryNoteId}";
            public const string Delete = Base + "/goodsDeliveryNotes/{goodsDeliveryNoteId}";
            public const string AddProductsToGoodsDeliveryNote = Base + "/goodsDeliveryNotes/{goodsDeliveryNoteId}/goodsDeliveryDetails";
            public const string BulkUpdateProductsInGoodsDeliveryNote = Base + "/goodsDeliveryNotes/{goodsDeliveryNoteId}/goodsDeliveryDetails/bulkUpdate";
            public const string BulkDeleteProductsInGoodsDeliveryNote = Base + "/goodsDeliveryNotes/{goodsDeliveryNoteId}/goodsDeliveryDetails/bulkDelete";
        }

        public static class ProductRemoveForms
        {
            public const string CreateProductRemoveForm = Base + "/productRemoveForms";
            public const string UpdateProductRemoveForm = Base + "/productRemoveForms/{productRemoveFormId}";
            public const string GetAll = Base + "/productRemoveForms";
            public const string GetById = Base + "/productRemoveForms/{productRemoveFormId}";
            public const string CreateProductRemoveDetail = Base + "/productRemoveForms/{productRemoveFormId}/productRemoveDetails";
            public const string UpdateProductRemoveDetail = Base + "/productRemoveForms/{productRemoveFormId}/productRemoveDetails";
            public const string DeleteProductRemoveDetail = Base + "/productRemoveForms/{productRemoveFormId}/productRemoveDetails";
        }
    }
}