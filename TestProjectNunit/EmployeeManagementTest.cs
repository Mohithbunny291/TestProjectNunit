using OurNunitLib;

namespace TestProjectNunit
{
    [TestFixture]
    public class EmployeeManagementTest
    {
        //EmpMgmt emp;
        [SetUp]
        public void Setup()
        {
            //emp = new EmpMgmt();
        }

        [Test]
        public void EmpNotNullTest()
        {
            foreach (var emp in EmpMgmt.GetEmps())
            {
                Assert.IsNotNull(emp.Id);
                Assert.IsNotNull(emp.Name);
                Assert.IsNotNull(emp.Salary);
                Assert.IsNotNull(emp.Designation);
            }
        }
        [Test]
        public void EmpExistsTest()
        {
            int id = 212;
            string name = "Kali";
            foreach (Emp emp in EmpMgmt.GetEmpById(212))
            {
                Assert.That(emp.Id, Is.EqualTo(id));
                Assert.That(emp.Name, Is.EqualTo(name));
            }
        }

    }
}