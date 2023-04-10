using Employee1.Data;
using Employee1.Interface;
using Employee1.Modal;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Employee1.Repository
{
    public class EmpRepo : IEmployee
    {
        private readonly Empcontext _context;

        public EmpRepo(Empcontext context)
        {
            _context = context;
        }

        public IEnumerable<Employeeclass> GetAll()
        {
            return _context.employee1.ToList();
        }

        public Employeeclass Get(int id)
        {
            return _context.employee1.Find(id);
        }

        public void Add(Employeeclass employee)
        {
            _context.employee1.Add(employee);
            _context.SaveChanges();
        }

        public void Update(Employeeclass employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _context.employee1.Find(id);
            _context.employee1.Remove(employee);
            _context.SaveChanges();
        }
        public class CustomException : Exception
        {
            public CustomException() { }
            public CustomException(string message) : base(message) { }
        }
        public class CustomExceptions : Exception
        {
            public CustomExceptions() { }
            public CustomExceptions(string message) : base(message) { }
        }
        public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
        {
            public override void OnException(ExceptionContext context)
            {
                if (context.Exception is CustomException)
                {
                    context.Result = new BadRequestObjectResult("Id should match exception occurred");
                }
                if (context.Exception is CustomExceptions)
                {
                    context.Result = new BadRequestObjectResult("No data found exception occurred");
                }
                else if (context.Exception is ArgumentNullException)
                {
                    context.Result = new BadRequestObjectResult("Argument Null Exception exception occurred");
                }
                else if (context.Exception is ArgumentException)
                {
                    context.Result = new BadRequestObjectResult("Argument Null Exception exception occurred");
                }
                context.ExceptionHandled = true;
            }
        }


    }
}
