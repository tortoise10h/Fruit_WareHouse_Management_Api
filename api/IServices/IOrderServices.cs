using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Entities;
using api.Helpers;
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

        Task ValidateWhenUpdateStatus(Order order, OrderStatus newStatus);
        Task HandleBusinessWhenStatusIsChanged(
            DataContext ctx,
            Order order,
            OrderStatus newStatus);
    }
}
