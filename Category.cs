using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM21651
{

    public abstract class Category
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string NXB { get; set; }
        public bool IsAvailable { get; set; }

        public abstract string ToString();

    }

    public class DevBook : Category
    {
        public string Language { get; set; }
        public string Semester { get; set; }

        public DevBook(string name, string author, string nxb, string language, string semester)
        {
            Name = name;
            Author = author;
            NXB = nxb;
            Language = language;
            Semester = semester;
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"Ten Sach: {Name} , Tac gia: {Author} , NXB: {NXB} , " +
                $"Ngon ngu: {Language} , Ki hoc: {Semester}";
        }
    }

    public class Magazine : Category
    {
        public string ISBN { get; set; }
        public string Date { get; set; }

        public Magazine(string name, string author, string nxb, string isbn, string date)
        {
            Name = name;
            Author = author;
            NXB = nxb;
            ISBN = isbn;
            Date = date;
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"Ten sach: {Name}, Ten tac gia: {Author}, NXB: {NXB}," +
                $" ISBN: {ISBN}, Ngay xuat ban: {Date}";
        }
    }
}
