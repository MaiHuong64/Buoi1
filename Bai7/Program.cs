namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Input();
            e1.Display();
            Employee e2 = new Employee(5, "Nguyen A", 2000, 1.5f);
            e2.Display();
            Employee.SetBaSicSalary(1000000);
            e2.setSalaryLevel(1);
            e2.Display();

        }
    }
}
