using EBillApplication.Model;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;

namespace EBillApplication.InterfaceEBill
{
    public interface EBill_Interface
    {
        public  int Add1(EBillClass EBillClass);
 
        public void DeleteItem(int id);
        IEnumerable<EBillClass> Get();
        void Updatedata(EBillClass EBillClass);

    }
}
