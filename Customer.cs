using System;
using System.Collections.Generic;

namespace ASM21651
{
    public class Customer
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Old { get; set; }

        public List<Category> Borrowed { get; set; }
        public Customer(string Name, string Gender, string Address, int Old)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Address = Address;
            this.Old = Old;
            Borrowed = new List<Category>();
        }

        public string ToString()
        {
            return $"Ten khach hang: {Name}, Gioi tinh : {Gender}, Dia chi: {Address}, Tuoi {Old} ";
        }
    }
}
