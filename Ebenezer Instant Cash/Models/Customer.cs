using System;

namespace Ebenezar.Models
{
    public class Customer
    {
        private int trn;
        private string name { get; set; }
        private DateTime DOB;
        private int age;
        private string address;
        private int telephone;

        static public EICDataSet.BorrowerDataTable Customers = new EICDataSet.BorrowerDataTable();

        public Customer(int trn, string name, DateTime dob, int age, string address, int telephone)
        {
            this.trn = trn;
            this.name = name;
            this.DOB = dob;
            this.age = age;
            this.address = address;
            this.telephone = telephone;
        }

        public bool InsertCustomer(string name, DateTime dob, int age, string address, int telephone)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCustomer(int trn)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateCustomer(int trn)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
