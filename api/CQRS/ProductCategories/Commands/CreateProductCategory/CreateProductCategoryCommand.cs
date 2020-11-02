using api.Contracts.V1.ResponseModels.ProductCategories;
using LanguageExt.Common;
using MediatR;

namespace api.CQRS.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommand : IRequest<ProductCategoryResponse>
    {
        public string Name { get; set; }
    }
}