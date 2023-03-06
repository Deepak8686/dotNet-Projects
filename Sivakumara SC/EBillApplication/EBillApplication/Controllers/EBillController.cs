using EBillApplication.InterfaceEBill;
using EBillApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBillApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBillController : ControllerBase
    {
        private readonly EBill_Interface _eBill_Interface;

        public EBillController(EBill_Interface eBill_Interface) 
        {
            _eBill_Interface=eBill_Interface;
        }
        [HttpGet]
        public IEnumerable<EBillClass> Get() 
        {
             return _eBill_Interface.Get();
        }
        [HttpPost]
        public int Add12([FromBody] EBillClass EBillClass)
        {
           return _eBill_Interface.Add1(EBillClass);
        }
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            _eBill_Interface.DeleteItem(id);
        }
        [HttpPut("{id}")]
        public void Put(EBillClass EBillClass) 
        {
            _eBill_Interface.Updatedata(EBillClass);
        }
    }
}
