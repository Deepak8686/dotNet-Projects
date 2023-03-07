using Azure.Core;
using EBillApplication.Injection;
using EBillApplication.InterfaceEBill;
using EBillApplication.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace EBillApplication.RepositoryEBill
{
    public class RepositoryClass: EBill_Interface
    {
        public static List<EBillClass> Demo = new List<EBillClass> { };

        private readonly EBill_Const_Class _eBill_Const_Class;

        public RepositoryClass(EBill_Const_Class eBill_Const_Class)
        {
            _eBill_Const_Class=eBill_Const_Class;
        }

        public int Add1(EBillClass EBillClass )
        {

            int unit = EBillClass.unit;
            int total = EBillClass.Total_Amount;
            int chg = unit <= 100 ? 0 :
                unit >= 101 && unit <= 1000 ? ((unit - 100) * 5) :
                unit >= 1001 && unit <= 10000 ? ((100 * 5) + ((unit - 1000) * 10)) :
                unit >= 10001 && unit <= 30000 ? ((100 * 5) + (100 * 10) + ((unit - 2000) * 20)) :
                ((100 * 5) + (100 * 10) + (100 * 20) + ((unit - 30000) * 35));
            try
            {
                switch (EBillClass.site)
                {
                    case '1':
                            try
                            {
                                switch (EBillClass.site1)
                                {
                                    case '1':
                                    total = chg * 5;
                                        break;

                                    case '2':
                                    total = chg * 2;
                                        break;

                                    case '3':
                                    total = chg * 0;
                                        break;

                                    default:
                                        break;
                                }
                            }
                            catch (Exception e)
                            {
                                throw new Exception(e.Message);
                            }
                        break;
                    case '2':
                        total = chg * 10;
                        break;

                    case '3':
                        total = chg * 0;
                        break;
                    default:
                        break;
                } 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
             _eBill_Const_Class.Add(EBillClass);
            return total;
        }
        public void DeleteItem(int id)
        {
            //var dbase = _eBill_Const_Class.Find(id);
            _eBill_Const_Class.Remove(id);
        }
        public void Updatedata(EBillClass EBillClass)
        {
            _eBill_Const_Class.Update(EBillClass);
        }
        public IEnumerable<EBillClass> Get()
        {
            return Demo.ToList();
        }
    }
}
