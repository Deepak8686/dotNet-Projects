using Employee1.Actionfilter;
//using Employee1.Exceptionfilter;
using Employee1.Interface;
using Employee1.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Employee1.Repository.EmpRepo;

namespace Employee1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomExceptionFilter]
    [ServiceFilter(typeof(Actionfilterclass))]
    //[ServiceFilter(typeof(Exceptionfilterclass))]
    public class Employeecontroller : ControllerBase
    {
        private readonly IEmployee _repository;

        public Employeecontroller(IEmployee repository)
        {
            _repository = repository;
        }

        [HttpGet]
        //[ServiceFilter(typeof(Actionfilterclass))]
        public IEnumerable<Employeeclass> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Employeeclass> Get(int id)
        {
            var employee = _repository.Get(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        [HttpPost]
        //[ServiceFilter(typeof(Actionfilterclass))]
        public ActionResult<Employeeclass> Post(Employeeclass employee)
        {
            _repository.Add(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Employeeclass employee)
        {
            if (id != employee.Id)
            {
               // return BadRequest();
               throw new CustomException();
            }
            _repository.Update(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _repository.Get(id);
            if (employee == null)
            {
                //return NotFound();
                throw new CustomExceptions();
            }
            _repository.Delete(id);
            return NoContent();
        }
    }
}
