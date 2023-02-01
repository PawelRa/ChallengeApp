using NUnit.Framework;
using System.Runtime.Intrinsics.X86;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinTest()
        {
            //arrange
            Employee employee1 = new Employee("Jan", "Nowak");

            //act
            employee1.AddGrade(2);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(1);
            var minResult = employee1.GetStatistics();

            //assert            
            Assert.AreEqual(1, minResult.Min);
        }

        [Test]
        public void MaxTest()
        {
            //arrange
            Employee employee2 = new Employee("Zenon", "Kowalski");

            //act
            employee2.AddGrade(2);
            employee2.AddGrade(5);
            employee2.AddGrade(7);
            employee2.AddGrade(1);
            var maxResult = employee2.GetStatistics();

            //assert            
            Assert.AreEqual(7, maxResult.Max);
        }

        [Test]
        public void AverageTest()
        {
            //arrange
            Employee employee3 = new Employee("Zenon", "Kowalski");

            //act
            employee3.AddGrade(2);
            employee3.AddGrade(5);
            employee3.AddGrade(7);
            employee3.AddGrade(1);
            var averageResult = employee3.GetStatistics();

            //assert            
            Assert.AreEqual(3.75, averageResult.Average);
        }

        [Test]
        public void EmployeesComparisonTest()
        {
            //arrange
            Employee employee4 = new Employee("Zenon", "Kowalski");
            Employee employee5 = new Employee("Zenon", "Kowalski");

            //assert            
            Assert.AreNotEqual(employee4 ,employee5);
            Assert.AreEqual((employee4.Name, employee4.Surname), (employee5.Name, employee5.Surname));
        }
    }
}
