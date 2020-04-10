using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipBigTable
    {
        public long EipBigId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string PoNo { get; set; }
        public long? PoItemId { get; set; }
        public string PoItemNo { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public DateTime? SellerSignTime { get; set; }
        public string ConCode { get; set; }
        public string ConLawCode { get; set; }
        public string ConName { get; set; }
        public string PurchaseName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialDesc { get; set; }
        public int? Amount { get; set; }
        public string SerialNumber { get; set; }
        public int? ConType { get; set; }
        public string PrjCode { get; set; }
        public string PrjName { get; set; }
        public string MatCode { get; set; }
        public string FixedTechId { get; set; }
        public string PkgNo { get; set; }
        public string BidBatCode { get; set; }
        public string ExtDes { get; set; }
        public string MatMaxCode { get; set; }
        public string MatMedCode { get; set; }
        public string MatMinCode { get; set; }
        public string MatMaxName { get; set; }
        public string MatMedName { get; set; }
        public string MatMinName { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
