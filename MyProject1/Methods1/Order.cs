using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Order
    {
        int orderid;
        string orderdate;
        Customer cust;
        Item item;

        public Order()
        {


        }

         public Order(int orderid, string orderdate, Customer cust, Item item)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.cust = cust;
            this.item = item;
        }

        public int Orderid
        {
            set { orderid = value; }
            get { return orderid; }
        }
        public string Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }
        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }
        public Item Item
        {
            set { item = value; }
            get { return item; }
        }
            
    }
    class Customer
    {
        int custid;
        string custname;
        Address address;

        public Customer()
        {


        }
        public Customer(int custid, string custname, Address address)
        {
            this.custid = custid;
            this.custname = custname;
            this.address = address;
        }
        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public Address Address
        {
            set { address = value; }
            get { return address; }
        }


    }

    class Address
    {
        string addr1;
        string city;
        int pincode;

        public Address()
        {


        }
        public Address(string addr1, string city, int pincode)
        {
            this.addr1 = addr1;
            this.city = city;
            this.pincode = pincode;
        }
        public string Addr1
        {
            set { addr1 = value; }
            get { return addr1; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }

    }

    class Item
    {
        int itemid;
        string itemname;
        int price;
        public Item()
        {


        }
        public Item(int itemid, string itemname, int price)
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
        }
        public int Itemid
        {
            set { itemid = value; }
            get { return itemid; }
        }
        public string Itemname
        {
            set { itemname = value; }
            get { return itemname; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }


    }

    class main
    {
        static void Main(string[] args)
        {
            Address ad = new Address("Panchavati", "Nashik", 422003);
            Item it = new Item(201, "Pen", 50);
            Customer cus = new Customer(901, "Shivam", ad);
            Order or = new Order(789, "31Aug", cus, it);

            Console.WriteLine(ad.Addr1);
            Console.WriteLine(or.Orderdate);
            Console.WriteLine(or.Cust.Custname);
            

        }
    }

    



}
