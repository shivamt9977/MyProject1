using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class Flat
    {
        int flatno;
        string wingName;
        Member member;
        public Flat()
        {

        }

        public Flat(int flatno, string wingName, Member member)
        {
            this.flatno = flatno;
            this.wingName = wingName;
            this.member = member;
        }

        public int FlatNo
        {
            set { flatno = value; }
            get { return flatno; }
        }
        public string WingName
        {
            set { wingName = value; }
            get { return wingName; }

        }
        public Member Member
        {
            set { member = value; }
            get { return member; }
        }

    }
    class Member
    {
        int memberid;
        string membername;
        string profession;
        int age;

        public Member()
        {

        }
        public Member(int memberid, string membername, string profession, int age)
        {
            this.memberid = memberid;
            this.membername = membername;
            this.profession = profession;
            this.age = age;
        }
        public int Memberid
        {
            set { memberid = value; }
            get { return memberid; }
        }
        public string Membername
        {
            set { membername = value; }
            get { return membername; }
        }
        public string Profession
        {
            set { profession = value; }
            get { return profession; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }

    class main2
    {

        static void Main(string[] args)
        {
            Member m = new Member(101, "Shivam", "Service", 23);
           

            Flat f = new Flat(3101, "Amara", m);
            Flat f1 = new Flat(1303, "Splendora", m);

            Console.WriteLine(f.Member.Membername);
        }
    
    }

}
