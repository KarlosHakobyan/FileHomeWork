using System.Text.RegularExpressions;

internal partial class Program
{
    public class Employee : Person , IUniversity
    {
        public int _salary;
        public string UniName { get; set; }

        public Employee(string name,int age, int salary, string uniName) : base(name, age)
        {
            {   
                UniName = uniName;
                SetSalary(salary);
            }

            void SetSalary(int salary)
            {
                _salary = salary;
            }
            UniName = uniName;

        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {_salary}, University: {UniName}";
        }
    }
}