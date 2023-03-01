using EBillApplication.Model;
using Microsoft.EntityFrameworkCore;
namespace EBillApplication.Injection
{
    public class EBill_Const_Class: DbContext
    {
        public EBill_Const_Class(DbContextOptions<EBill_Const_Class> options) : base(options) { }
        public DbSet<EBillClass> EBill { get; set; }
    }
}
