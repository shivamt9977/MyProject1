using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class Employee
    {
        string name;
        int eid;
        int mgid;
        string mgname;

        public Employee(string name,int eid,int mgid,string mgname)
        {
            this.name = name;
            this.eid = eid;
            this.mgid = mgid;
            this.mgname = mgname;


        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public int Mgid
        {
            set { mgid = value; }
            get { return mgid; }
        }
        public string Mgname
        {
            set { mgname = value; }
            get { return mgname; }
        }

        public void Showdata()
        {
            Console.WriteLine($"Employee Name:{Name} \n Employee Id:{Eid}\n Manager Id:{Mgid}\n Manager Name:{Mgname}\n");
        }
    }

    class emp
    {
        static void Main(string[] args)
        {
            Employee[] ampl = new Employee[5];

            ampl[0] = new Employee("Shivam", 101, 901, "Singhania");
            ampl[1] = new Employee("Thorat", 102, 901, "Singhania");
            ampl[2] = new Employee("Yash", 103, 901, "Singhania");
            ampl[3] = new Employee("More", 104, 901, "Singhania");
            ampl[4] = new Employee("Atul", 105, 901, "Singhania");

            ampl[0].Showdata();
            ampl[1].Showdata();
            ampl[2].Showdata();
            ampl[3].Showdata();
            ampl[4].Showdata();
        }
    }

}
