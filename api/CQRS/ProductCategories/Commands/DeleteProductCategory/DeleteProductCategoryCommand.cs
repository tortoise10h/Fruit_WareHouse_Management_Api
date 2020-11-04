using api.Contracts.V1.ResponseModels.ProductCategories;
using MediatR;

namespace api.CQRS.ProductCategories.Commands.DeleteProductCategory
{
    public class DeleteProductCategoryCommand : IRequest<ProductCategoryResponse>
    {
        public DeleteProductCategoryCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}