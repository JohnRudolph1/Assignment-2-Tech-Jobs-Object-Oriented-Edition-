using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public class JobField
    {
        //all common
        private int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        public JobField()
        {
            Id = nextId;
            nextId++;
        }//common

        public JobField(string v) : this()
        {
            Value = v;
        }//common

        public override bool Equals(object obj)
        {
            return obj is JobField competency &&
            Id == competency.Id;
        }//common

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }//common

        public override string ToString()
        {
            return Value;
        }//common
    }
}

