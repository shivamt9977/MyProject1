using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._3_sep
{
    class Employee
    {
        int id;
        string name;
        Dept d;

        public Employee()
        {

        }
        public Employee(int id,string name,Dept d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Dept D
        {
            set { d = value; }
            get { return d; }
        }
    }
    class Dept
    {
        int deptid;
        string deptname;

        public Dept()
        {

        }
        public Dept(int deptid,string deptname)
        {
            this.deptid = deptid;
            this.deptname = deptname;

        }
        public int Deptid
        {
            set { deptid = value; }
            get { return deptid; }
        }
        public string Deptname
        {
            set { deptname = value; }
            get { return deptname; }
        }


    }

    class M1
    {
        static void Main(string[] args)
        {
            Dept de = new Dept(201, "QA");
            Employee e = new Employee(101, "Shivam", de);

            Console.WriteLine(e.D.Deptname);
        }
    }


}
