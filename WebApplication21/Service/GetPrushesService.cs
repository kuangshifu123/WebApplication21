using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication21.VM;

namespace WebApplication21.Service
{
    
    public class GetPrushesService
    {
        generalContext db = new generalContext();

        public IEnumerable<PurchaseM> getPrushes()
        {
            return db.EipBigTable.Where(e => e.SupplierCode == "1000009098").Select(e=>new
                 PurchaseM(){buyerName =e.SupplierName,poItemId = e.PoItemId,poItemNo =e.PoItemNo,poNo = e.PoNo}).ToList();
        }
    }
}
