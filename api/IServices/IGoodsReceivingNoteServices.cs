using api.Contracts.V1.Dtos;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.IServices
{
    public interface IGoodsReceivingNoteServices
    {
        List<ProductInGoodsReceivingNote> ValidateProductsOfNewGoodsReceivingNote(List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote, List<PurchaseProposalDetail> purchaseProposalDetails);
        List<GoodsReceivingDetail> CalculatePriceOfProducsInGoodsReceivingNote(
            List<GoodsReceivingDetail> goodsReceivingDetails);
    }
}
