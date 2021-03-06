﻿using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Entities;
using api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.IServices
{
    public interface IGoodsDeliveryNoteServices
    {
        Task<List<ProductInGoodsDeliveryNote>> MakeSureProductsOfNewGoodsDeliveryNoteValid(List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote, List<OrderDetail> orderDetails);

        Task ValidateWhenUpdateStatus(GoodsDeliveryNote goodsDeliveryNote, GoodsDeliveryNoteStatus newStatus);

        Task HandleBusinessWhenStatusIsChanged(
            DataContext ctx,
            GoodsDeliveryNote goodsDeliveryNote,
            GoodsDeliveryNoteStatus newStatus);

        Task<List<ProductInGoodsDeliveryNote>> ValidateWhenAddNewProductToExistedGoodsDeliveryNote(
            int goodsDeliveryNoteId,
            List<OrderDetail> orderDetails,
            List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote
            );

        List<ProductInGoodsDeliveryNote> ValidateWhenUpdateProductsInGoodsDeliveryNote(List<GoodsDeliveryDetail> goodsDeliveryDetails,
            List<OrderDetail> orderDetails,
            List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote
            );
    }
}
