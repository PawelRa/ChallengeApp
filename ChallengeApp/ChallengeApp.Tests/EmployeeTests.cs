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
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(1);
            var result = employee.GetStatisticsWithDoWhile();

            //assert            
            Assert.AreEqual(1, result.Min);
            Assert.AreEqual(7, result.Max);
            Assert.AreEqual(3.75, result.Average);
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
