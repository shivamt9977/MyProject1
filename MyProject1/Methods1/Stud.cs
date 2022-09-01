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

        public Batch B
        {
            set { b = value; }
            get { return b; }
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

        public Batch(string batchName,string technology,Trainerr trainer)
        {
            this.batchName = batchName;
            this.technology = technology;
            this.trainer = trainer;

        }
   

        public string Batchname
        {
            set { batchName = value;}
            get { return batchName; }
        }

        public string Technology
        {
            set { technology = value; }
            get { return technology; }
        }

        public Trainerr Trainer
        {
            set{ trainer = value; }
            get { return trainer; }
        }

    }
    class Trainerr
    {
        string tname;
        int texperiance;
        string tqualification;

        public Trainerr()
            {
            }

        public Trainerr(string tname,int texperiance,string tqualification)
        {
            this.tname = tname;
            this.texperiance = texperiance;
            this.tqualification = tqualification;
        }

        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }

        public int Texperiance
        {
            set { texperiance = value; }
            get { return texperiance; }
        }

        public string Tqualification
        {
            set { tqualification = value; }
            get { return tqualification; }
        }



    }

    class TestStud
    {
        static void Main(string[] args)
        {
           Stud s = new Stud();
            s.StudName = "Shivam";
            s.PassYear = 2021;
            

            Batch B = new Batch();
            s.B.Batchname = "Wipro";
            s.B.Technology = "C#";

            s.B.Trainer = new Trainerr();
            

           Trainerr t = new Trainerr();
            s.B.Trainer.Tname = "Deepa_Mam";
            s.B.Trainer.Texperiance = 15;
            s.B.Trainer.Tqualification = "BE";

            Console.WriteLine(s.StudName);


            Trainerr tr = new Trainerr("Deepa_Mam", 15, "BE");
            Batch b = new Batch("Wipro", "C#", tr);
            Stud st = new Stud("Shivam", 2021, b);

            Console.WriteLine(b.Batchname);
            Console.WriteLine(st.B.Batchname);
            Console.WriteLine(st.B.Trainer.Texperiance);



        }
    }
    

}
