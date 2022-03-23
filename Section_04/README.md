# Section 04 

# Question 01
> Shared memory is memory access by many programs at a time. If we want to pass data from one program to another we can use it.

# Question 02
> Restrictions are limiting, deducing access over class, properties or method.

Example 01:
    
    class BaseClass
    {
        // properties
    }

    public class Student: BaseClass // will get error
    {
        // properties
    }
> In this example we can't access **BaseClass** class form **Student** class because **BaseClass** is less accessable than **Student** class.

Example 02:

    class BaseClass
    {
        protected virtual void Foo()
        {
          // properties
        }
    }
    
    class StudentClass1 : BaseClass
    {
        protected override void Foo()
        {    // OK
          // properties
        }
    }
    
    class StudentClass2 : BaseClass
    {
        public override void Foo()
        { // Error
          // properties
        }
    }
    
 > In this example we can't override **Foo** method form **StudentClass2** class because **Foo** method is protected inherited member.
    
  Example 03:
  
    class MyClass
    {

        int _number;

        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
            get
            {

                //error
                return this._number;
            }
        }
    }
> In this example we can't define get multiple time.

# Question 03

> When a method does different different task as per required such as the  **Salary()** method below it will perform different task for diffrent type of employee.
    
    public class EmployeeSalary
    {
        // Virtual method
        public virtual void Salary()
        {
            Console.WriteLine("Salary is 50");
        }
    }

    public class ShorttermEmployee : EmployeeSalary
    {
        public override void Salary()
        {
            Console.WriteLine("Salary is 100");
        }
    }

    public class PermanentEmployee : EmployeeSalary
    {
        public override void Salary()
        {
            Console.WriteLine("Salary is 150");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var regularSalary = new EmployeeSalary();
            var shorttermSalary = new ShorttermEmployee();
            var permanentSalary = new PermanentEmployee();
            regularSalary.Salary();
            shorttermSalary.Salary();
            permanentSalary.Salary();
        }
     }
