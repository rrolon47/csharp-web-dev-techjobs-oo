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

        Job job1;
        Job job2;
        Job job;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }


        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(job1.Id +1 == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName.Value, "ACME");
            Assert.AreEqual(job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job.JobType.Value, "Quality control");
            Assert.AreEqual(job.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringMethod1()
        {
            Assert.IsTrue(job.ToString().StartsWith("_____"));
            Assert.IsTrue(job.ToString().EndsWith("_____"));
        }

        [TestMethod]
        public void TestToStringMethod2()
        {
            Assert.AreEqual($"_____\n" +
                $"ID: {job.Id}\n" +
                $"Name: Product tester\n" +
                $"Employer: ACME\n" +
                $"Location: Desert\n" +
                $"Position Type: Quality control\n" +
                $"Core Competency: Persistence\n" +
                $"_____", job.ToString());
        }

        [TestMethod]
        public void TestToStringMethod3()
        {
            Job job = new Job( "", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual($"_____\n" +
                $"ID: {job.Id}\n" +
                $"Name: Data not avaliable.\n" +
                $"Employer: Data not avaliable.\n" +
                $"Location: Data not avaliable.\n" +
                $"Position Type: Data not avaliable.\n" +
                $"Core Competency: Data not avaliable.\n" +
                $"_____", job.ToString());
        }

        [TestMethod]
        public void TestToStringMethod4Bonus()
        {
            Job job = new Job();
            Assert.AreEqual("OOPS! This job does not seem to exist.", job.ToString());
        }


    }
}
