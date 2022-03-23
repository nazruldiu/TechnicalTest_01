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
     
# Question 04
> Example of interface implementation

    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    
    public class Repository<T> : IRepository<T> where T : class
    {
        internal AppDBContext _db;
        internal DbSet<T> dbSet;

        public Repository(AppDBContext appDBContext)
        {
            _db = appDBContext;
            dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().AsEnumerable();
        }
    }
    
 > There are several benefit of using interface such as flowing class is loosely coupled. Useful for dependency injection. We can't create instance of interface class so it protected to do mistake. And we know we have to implement all of it declaration so if any class inherite they must have implement it.

# Question 05
> The basic aspects of object orientated programming is Inheritance (Example of Question 03), polymorphism (Example of Question 03), Encapsulation , Abstraction, Interface (Example of Question 04) etc.

Example of Abstraction:

        public abstract class BaseClass
        {
            public int Id { get; set; }
            public int IUser { get; set; }
            public int EUser { get; set; }
            public DateTime IDate { get; set; }
            public DateTime EDate { get; set; }
        }

        public class Student: BaseClass
        {
            public string StudentName { get; set; }
            public string RegNo { get; set; }
        }
        
Example of Encapsulation:
        
        class Demo
        {
            private int _mark;
            public int Mark
            {
                get
                {
                    return _mark;
                }
                set
                {
                    if (_mark > 0) _mark = value;
                    else _mark = 0;
                }
            }
         }
        
