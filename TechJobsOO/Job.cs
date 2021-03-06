using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job 
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            Id = nextId;
            nextId++;
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;



        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }
        public override string ToString()
        {

          


            if (Name == "" )
            {
               Name = "Data not available";


            }


             if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";

            }




             if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";

            }


             if (JobType.Value == "")
            {

                JobType.Value = "Data not available";

            }



             if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";


            }
            
                return $"ID:{Id}\nName: {Name}\nEmployer: {EmployerName.Value}\nLocation: {EmployerLocation.Value}\nPosition Type: {JobType.Value}\nCore Competency: {JobCoreCompetency.Value}";
            

        }
    }

}



