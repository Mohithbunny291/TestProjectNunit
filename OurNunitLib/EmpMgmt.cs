namespace OurNunitLib
{
    public class EmpMgmt
    {
        static List<Emp> emps = new List<Emp>()
        {
            new Emp(){Id = 211, Name = "Ram", Designation = "HR", Salary = 92111.31},
            new Emp(){Id = 212, Name = "Kali", Designation = "Manager", Salary = 33211.31},
            new Emp(){Id = 214, Name = "Jalu", Designation = "Testing", Salary = 53211.31},
            new Emp(){Id = 215, Name = "Mak", Designation = "Devops", Salary = 12111.31},
            new Emp(){Id = 217, Name = "Oli", Designation = "ISO", Salary = 62111.31},
        };
        public static List<Emp> GetEmps()
        {
            return emps;
        }
        public static List<Emp> GetEmpById(int id)
        {
            List<Emp> searchList = emps.FindAll(emp => emp.Id == id);
            return searchList;
        }
    }
}
