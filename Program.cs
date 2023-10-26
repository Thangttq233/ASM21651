using ASM21651;
using System;
using System.Linq;


namespace abc
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("1. Them sach");
                Console.WriteLine("2. Them khach hang");
                Console.WriteLine("3. Hien thi sach trong thu vien");
                Console.WriteLine("4. Hien thi thong tin khach hang");
                Console.WriteLine("5. Muon sach");
                Console.WriteLine("6. Tra sach");
                Console.WriteLine("7. Tim kiem sach");
                Console.WriteLine("8. Hien thi thong tin nguoi muon sach");
                Console.WriteLine("9. Thoat");

                Console.Write("Nhap lua chon: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            bool i = true;
                            while (i)
                            {
                                Console.WriteLine("1. Them DevBook");
                                Console.WriteLine("2. Them Magazine");
                                //Console.WriteLine("3. Exit");
                                //Console.WriteLine("Choose Category:");
                                int choose = Convert.ToInt32(Console.ReadLine());
                                if (choose == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nhap ten sach:");
                                    string Name1 = Console.ReadLine();
                                    if (!library.Categories.Any(book => book.Name == Name1))
                                    {
                                        Console.WriteLine("Ten tac gia:");
                                        string Author = Console.ReadLine();
                                        Console.WriteLine("Ten NXB:");
                                        string NXB = Console.ReadLine();
                                        Console.WriteLine("Ngon ngu:");
                                        string Language = Console.ReadLine();
                                        Console.WriteLine("Ki hoc: ");
                                        string Semester = Console.ReadLine();
                                        DevBook devbook = new DevBook(Name1, Author, NXB, Language, Semester);
                                        library.Add(devbook);
                                        i = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sach nay da co trong thu vien");
                                    }

                                }
                                if (choose == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nhap ten sach:");
                                    string Name2 = Console.ReadLine();
                                    Console.WriteLine("Nhap ten tac gia:");
                                    string Author = Console.ReadLine();
                                    Console.WriteLine("Nhap NXB");
                                    string NXB = Console.ReadLine();
                                    Console.WriteLine("Nhap ISBN: ");
                                    string ISBN = Console.ReadLine();
                                    Console.WriteLine("Nhap ngay xuat ban: ");
                                    string Date = Console.ReadLine();
                                    Magazine magazine = new Magazine(Name2, Author, NXB, ISBN, Date);
                                    library.Add(magazine);
                                    i = false;
                                }
                                if (choose == 3)
                                {
                                    i = false;
                                }
                            }                   
                            break;
                        case 2:

                            Console.Clear();
                            Console.WriteLine("Nhap ten khach hang:");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Gioi tinh: ");
                            string Gender = Console.ReadLine();
                            Console.WriteLine("Dia chi:");
                            string Address = Console.ReadLine();
                            Console.WriteLine("Tuoi:");
                            int Old = int.Parse(Console.ReadLine());
                            Customer newCustomer = new Customer(Name, Gender, Address, Old);
                            library.AddCustomer(newCustomer);
                            break;
                        case 3:
                            Console.Clear();
                            if (library.Categories.Any(book => book.Name != null))
                            {
                                library.ShowCategories();
                            }
                            else { Console.WriteLine("Khong ton tai sach trong thu vien"); }
                            break;
                            
                        case 4:
                            Console.Clear();
                            if (library.Customers.Any(u => u.Name != null))
                            {
                                library.ShowCustomer();
                            }
                            else { Console.WriteLine("Khach hang khong ton tai"); }
                            break;
                            
                        case 5:
                            bool y = true;
                            while (y)
                            {
                                Console.Clear();
                                Console.WriteLine("1. Muon DevBook");
                                Console.WriteLine("2. Muon Magazine");
                                //Console.WriteLine("3. Exit");
                                Console.WriteLine("Chon loai sach:");
                                int choose = Convert.ToInt32(Console.ReadLine());
                                if (choose == 1)
                                {
                                    Console.Clear();
                                    Console.Write("Nhap ten khach hang : ");
                                    string Name1 = Console.ReadLine();
                                    Console.Write("Ten sach can muon: ");
                                    string Book = Console.ReadLine();
                                    Customer borrower = library.Customers.Find(n => n.Name == Name1);
                                    DevBook devbook = library.Categories.Find(b => b.Name == Book) as DevBook;
                                    if (borrower != null && devbook != null)
                                    {
                                        library.Borrow(devbook, borrower);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong tim thay ten khach hang hoac ten sach");
                                    }
                                    y = false;
                                }
                                if (choose == 2)
                                {
                                    Console.Clear();
                                    Console.Write("Nhap ten khach hang: ");
                                    string CustomerName = Console.ReadLine();
                                    Console.Write("Nhap ten sach: ");
                                    string Name2 = Console.ReadLine();
                                    Customer borrower = library.Customers.Find(n => n.Name == CustomerName);
                                    Magazine magazine = library.Categories.Find(m => m.Name == Name2) as Magazine;

                                    if (borrower != null && magazine != null)
                                    {
                                        library.Borrow(magazine, borrower);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong tim thay ten khach hang hoac ten sach");
                                    }
                                    y = false;
                                }
                                if (choose == 3)
                                {
                                    y = false;
                                }
                            }
                            break;

                        case 6:
                            bool x = true;
                            while (x)
                            {
                                Console.Clear();
                                Console.WriteLine("1. Tra DevBook");
                                Console.WriteLine("2. Tra Magazine");
                                //Console.WriteLine("3. Exit");
                                Console.WriteLine("Chon lua chon:");
                                int choose = Convert.ToInt32(Console.ReadLine());
                                if (choose == 1)
                                {
                                    Console.Clear();
                                    Console.Write("Nhap ten khach hang: ");
                                    string CustomerName = Console.ReadLine();
                                    Console.Write("Nhap sach can tra: ");
                                    string Name3 = Console.ReadLine();
                                    Customer returner = library.Customers.Find(n => n.Name == CustomerName);
                                    DevBook book = library.Categories.Find(b => b.Name == Name3) as DevBook;
                                    if (returner != null && book != null)
                                    {
                                        library.Return(book, returner);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong tim thay ten khach hang hoac ten sach");
                                    }
                                    x = false;
                                }
                                if (choose == 2)
                                {
                                    Console.Clear();
                                    Console.Write("Nhap ten khach hang: ");
                                    string CustomerName = Console.ReadLine();
                                    Console.Write("Nhap ten sach: ");
                                    string Name4 = Console.ReadLine();
                                    Customer retuner = library.Customers.Find(n => n.Name == CustomerName);
                                    Magazine magazine = library.Categories.Find(m => m.Name == Name4) as Magazine;

                                    if (retuner != null && magazine != null)
                                    {
                                        library.Return(magazine, retuner);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong tim thay ten khach hang hoac ten sach");
                                    }
                                    x = false;
                                }
                                if (choose == 3)
                                {
                                    x = false;
                                }
                            }
                            break;

                        case 7:
                            Console.Clear();
                            Console.Write("Nhap ten sach can tim: ");
                            string Name5 = Console.ReadLine();
                            Category category = library.Categories.Find(b => b.Name == Name5);
                            if (category != null)
                            {
                                library.Search(category);
                            }
                            else
                            {
                                Console.WriteLine(" Sach khong ton tai");
                            }
                            break;
                        case 8:
                            Console.Clear();
                            Console.Write("Nhap ten khach hang: ");
                            string Name6 = Console.ReadLine();

                            Customer showu = library.Customers.Find(n => n.Name == Name6);

                            if (showu != null)
                            {
                                library.ShowCustomerBorrowed(showu);
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay khach hang");
                            }
                            break;
                           
                            
                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Nhap lai!!!");
                            break;
                    }
                }
            }
        }

    }
}

