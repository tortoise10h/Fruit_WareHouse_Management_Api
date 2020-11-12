using api.Contracts.V1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.IServices
{
    public interface IOrderServices
    {
        Task<List<ProductInOrder>> MakeValidProductsOfNewOrder(
            List<ProductInOrder> productsInNewOrder);
    }
}
