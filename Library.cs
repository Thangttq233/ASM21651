using ASM21651;
using System.Collections.Generic;
using System;

internal class Library
{
    public List<Category> Categories { get; set; } = new List<Category>();
    public List<Customer> Customers { get; set; } = new List<Customer>();
    public void Add(Category category)
    {
        Categories.Add(category);
    }
    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void ShowCategories()
    {
        foreach (var category in Categories)
        {
            Console.WriteLine(category.ToString());
        }
    }

    public void ShowCustomerBorrowed(Customer customer)
    {
        foreach (var borrowedCategory in customer.Borrowed)
        {
            Console.WriteLine(borrowedCategory.ToString());
        }
    }

    public void ShowCustomer()
    {
        foreach (var customer in Customers)
        {
            Console.WriteLine(customer.ToString());
        }
    }
    public void Search(Category category)
    {
        Console.WriteLine($"ten sach: {category.Name} | ten tac gia: {category.Author} ");
    }
    
    
   

    public void Borrow(Category category, Customer customer)
    {
        if (category.IsAvailable)
        {
            category.IsAvailable = false;
            customer.Borrowed.Add(category);
            //Categories.Remove(category);
            Console.WriteLine($"{customer.Name} da muon {category.Name}.");
        }
        else
        {
            Console.WriteLine($"{category.Name} khong co loai sach nay");
        }
    }

    public void Return(Category category, Customer customer)
    {
        if (customer.Borrowed.Contains(category))
        {
            category.IsAvailable = true;
            customer.Borrowed.Remove(category);
            Console.WriteLine($"{customer.Name} da tra sach {category.Name}.");
        }
        else
        {
            Console.WriteLine($"{customer.Name} khong muon sach {category.Name}.");
        }
    }
}