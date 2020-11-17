using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.Entities;
using api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.IServices
{
    public interface IGoodsReceivingNoteServices
    {
        List<ProductInGoodsReceivingNote> MakeSureProductsOfNewGoodsReceivingNoteSastifyProposal(List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote, List<PurchaseProposalDetail> purchaseProposalDetails);

        List<GoodsReceivingDetail> CalculatePriceOfProducsInGoodsReceivingNote(
            List<GoodsReceivingDetail> goodsReceivingDetails);

        List<ProductInGoodsReceivingNote> CalculatePriceOfProducsInGoodsReceivingNote(
            List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote);

        void ValidateValidNewStatus(GoodsReceivingNoteStatus oldSatus, GoodsReceivingNoteStatus newStatus);

        Task UpdateQuantityOfProductWhenGoodsReceivingNoteIsDone(
            int purchaseProposalFormId,
            List<GoodsReceivingDetail> goodsReceivingDetails,
            DataContext ctx);

        Task<List<ProductInGoodsReceivingNote>> ValidateWhenAddNewProductToExistedGoodsReceivingNote(
            int goodsReceivingNoteId,
            List<PurchaseProposalDetail> purchaseProposalDetails,
            List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote
          );

        List<ProductInGoodsReceivingNote> ValidateWhenUpdateProductsInGoodsReceivingNote(
            List<GoodsReceivingDetail> goodsReceivingDetails,
            List<PurchaseProposalDetail> purchaseProposalDetails,
            List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote
            );

        Task MakeSureNewProductMustBelongToSupplier(
            int supplierId,
            List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote);

        Task ValidateProductsInGoodsRecevingNoteWhenChangeSupplierId(
            int goodsReceivingNoteId,
            int newSupplierId);
    }
}
