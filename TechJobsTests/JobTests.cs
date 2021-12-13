using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{


    [TestClass]
    public class JobTests
    {


        [TestMethod]
        public void TestSettingJobId()
        {
            Job new1 = new Job();
            Job new2 = new Job();

            
            Assert.IsTrue(new2.Id == new1.Id + 1 );
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue("Product tester" == job1.Name);
            Assert.IsTrue("ACME" == job1.EmployerName.Value);
            Assert.IsTrue("Desert" == job1.EmployerLocation.Value);
            Assert.IsTrue("Quality control" == job1.JobType.Value);
            Assert.IsTrue("Persistence" == job1.JobCoreCompetency.Value);
        }
        [TestMethod] 
        public void TestJobsForEquality()
        {
            Job new3 = new Job("John", new Employer("Cisco"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job new4 = new Job("John", new Employer("Cisco"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(new3.Id.Equals(new4));
            
        }
        [TestMethod]
        public void TestOutput()
        {
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            Assert.AreEqual(job3.ToString(), $"ID:{job3.Id}\n" +
                $"Name: {job3.Name}\n" +
                $"Employer: Data not available\n" +
                $"Location: {job3.EmployerLocation.Value}\n" +
                $"Position Type: {job3.JobType.Value}\n" +
                $"Core Competency: {job3.JobCoreCompetency.Value}"
            );
            
        }
        

    }
}



/*Assert.AreEqual("Web Developer", job2.Name);
Assert.AreEqual("Ice cream tester", job3.Name);

Assert.AreEqual("LaunchCode", job2.EmployerName.Value);
Assert.AreEqual("", job3.EmployerName.Value);

Assert.AreEqual("St. Louis", job2.EmployerLocation.Value);
Assert.AreEqual("Home", job3.EmployerLocation.Value);

Assert.AreEqual("Front-end developer", job2.JobType.Value);
Assert.AreEqual("UX", job3.JobType.Value);

Assert.AreEqual("JavaScript", job2.JobCoreCompetency.Value);
Assert.AreEqual("Tasting ability", job3.JobCoreCompetency.Value);*/



