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
            public const string GetById = Base + "/productCategories/{productCategoryId}";
            public const string Create = Base + "/productCategories";
            public const string Update = Base + "/productCategories/{productCategoryId}";
            public const string Delete = Base + "/productCategories/{productCategoryId}";
        }
    }
}