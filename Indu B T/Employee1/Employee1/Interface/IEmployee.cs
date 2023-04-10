using Employee1.Modal;

namespace Employee1.Interface
{
    public interface IEmployee
    {
        IEnumerable<Employeeclass> GetAll();
        Employeeclass Get(int id);
        void Add(Employeeclass employee);
        void Update(Employeeclass employee);
        void Delete(int id);
    }
}
