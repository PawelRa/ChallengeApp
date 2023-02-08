using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void EmployeesMinMaxAverageTest()
        {
            //arrange
            Employee employee = new Employee("Jan", "Nowak");

            //act
            employee.AddGrade("20");
            employee.AddGrade(50);
            employee.AddGrade("b");
            employee.AddGrade(150);
            var result = employee.GetStatisticsWithDoWhile();

            //assert            
            Assert.AreEqual(20, result.Min);
            Assert.AreEqual(80, result.Max);
            Assert.AreEqual(50, result.Average);
            Assert.AreEqual('C', result.AverageLetter);
        }

        [Test]
        public void EmployeesNoGradeTest()
        {
            //arrange
            Employee employee1 = new Employee("Zenon", "Kowalski");

            //act
            var noGradeResult = employee1.GetStatisticsWithFor();

            //assert            
            Assert.AreEqual(noGradeResult.Average,float.NaN);
        }


        [Test]
        public void EmployeesComparisonTest()
        {
            //arrange
            Employee employee2 = new Employee("Zenon", "Kowalski");
            Employee employee3 = new Employee("Zenon", "Kowalski");

            //assert            
            Assert.AreNotEqual(employee2 ,employee3);
            Assert.AreEqual((employee2.Name, employee2.Surname), (employee3.Name, employee3.Surname));
        }
    }
}
