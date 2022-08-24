using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class StudentData
    {
        string name;
        string qualification;
        int passoutYear;


        public void setname(string nm)
        {
            name = nm;
        }
        public string getname()
        {
            return name;
        }

        public void setQualificaton(string qual)
        {
            qualification = qual;
        }
        public string getQualification()
        {
            return qualification;
        }

        public void setPassoutYear(int yr)
        {
            passoutYear = yr;
        }
        public int getPassoutYear()
        {
            return passoutYear;
        }
    }



    class Main1
    {

        static void Main(string[] args)
        {
            StudentData s1 = new StudentData();
            s1.setname("Shivam");
            s1.setQualificaton("BE");
            s1.setPassoutYear(2021);
            Console.WriteLine(s1.getname());
            Console.WriteLine(s1.getQualification());
            Console.WriteLine(s1.getPassoutYear());

        }
    }

}
