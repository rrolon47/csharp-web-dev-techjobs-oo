using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTest
{
    [TestClass]
    public class TechJobTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        //Job job1;
        //Job job2;
        //Job jobConstructor;

        //[TestInitialize]
        //public void CreateJobObjects()
        //{
        //    job1 = new Job();
        //    job2 = new Job();
        //    jobConstructor = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
        //}


        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id +1 == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job jobConstructor = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(jobConstructor.Name, "Product tester");
            Assert.AreEqual(jobConstructor.EmployerName.Value, "ACME");
            Assert.AreEqual(jobConstructor.EmployerLocation.Value, "Desert");
            Assert.AreEqual(jobConstructor.JobType.Value, "Quality control");
            Assert.AreEqual(jobConstructor.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

    }
}
