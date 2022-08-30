using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Stud
    {
        string studName;
        int passoutYear;
        Batch b;

        public Stud()
        {
        }

        public Stud(string studName, int passoutYear, Batch b)
        {
            this.studName = studName;
            this.passoutYear = passoutYear;
            this.b = b;
        }
        public string StudName
        {
            set { studName = value; }
            get { return studName; }
        }
        public int PassYear
        {
            set { passoutYear = value; }
            get { return passoutYear; }
        }
        
         
    }

    class Batch
    {

        string batchName;
        string technology;
        Trainerr trainer;

        public Batch()
        {
        }

        public Batch(string batchName,string technology,Trainerr t)
        {
            this.batchName = batchName;
            this.technology = technology;
            this.trainer = t;

        }
   

        public string Batchname
        {
            set { batchName = value;}
            get { return batchName; }
        }

    }
    class Trainerr
    {
        string tname;

    }

    class TestStud
    {
        static void Main(string[] args)
        {
            Stud s = new Stud();
            s.StudName = "Shivam";
            s.PassYear = 2021;
            

            Batch B = new Batch();
            s.B.batchName = "Wipro";
            s.B.technology = "C#";

            s.B.T = new Trainerr();
            

            Trainerr t = new Trainerr();
        }
    }
    

}
