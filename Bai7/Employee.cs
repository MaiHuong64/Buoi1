using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private static double basicSalary = 30000;

        public Employee() { }
        public Employee(int id, string name, int yearOfBirth, double salaryLevel)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
        }

        public int getID()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }

        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nam sinh: ");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bac luong: ");
            salaryLevel = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Thong tin nhan vien");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Ten: {name}");
            Console.WriteLine($"Nam sinh: {yearOfBirth}");
            Console.WriteLine($"Bac luong: {salaryLevel}");
            Console.WriteLine($"Thu nhap: "+GetIncome());
           
        }
        public static void SetBaSicSalary(double basicSalary)
        {
            Employee.basicSalary = basicSalary;
        }
        public void setSalaryLevel(double salaryLevel)
        {
            this.salaryLevel = salaryLevel;
        }
    }
}
