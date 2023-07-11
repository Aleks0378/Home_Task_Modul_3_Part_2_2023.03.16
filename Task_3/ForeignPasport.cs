using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class ForeignPasport
    {
        public string number;
        public string name;
        public DateTime data;
        public string visas;
        public ForeignPasport() { }
        public ForeignPasport(string number, string name, DateTime data, string visas)
        {
            this.number = number;
            this.name = name;
            this.data = data;
            this.visas = visas;
        }
        public string Number
        {
            get { return this.number; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("пустая строка или пробел!");
                }
                this.number = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("пустая строка или пробел!");
                }
                this.name = value;
            }
        }
        public DateTime Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public string Visas
        {
            get { return this.visas; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("пустая строка или пробел!");
                }
                this.visas = value;
            }
        }
        public override string ToString()
        {
            return ($"\n Passport number: {Number}\n\tName: {Name}\n\tIssued data: {Data}\n\tVisas: {Visas}\n");
        }
        public void Input()
        {
            Console.WriteLine("Enter the passport number:");
            Number = Console.ReadLine();
            Console.WriteLine("Enter the person name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the passport issue date:");
            Data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the information about visas:");
            Visas = Console.ReadLine();
        }
    }
}
