using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************ex-1*******************");
            ex1 obj = new ex1();
            obj.Name = "hello hi";
            obj.PRINT();
            Console.WriteLine("******************ex-2******************");
            ex2 obj2 = new ex2();
            obj2.EmpName = Console.ReadLine();
            obj2.EmpID = 1001;
            obj2.Empsalary =" 50000";
            obj2.Details();
            Console.WriteLine("******************ex-3******************");
            var obj3 = new ex3();
            obj3.clothes = "Shirt";
            obj3.size = 'M';
            Console.WriteLine("Shirt {0}\nSize: {1}", obj3.clothes, obj3.size);
            Console.ReadKey();
        }
    }

    public class ex1
    {
        private string name { get; set; }
        public string Name { get {
                return this.name;
            }
            set {
                this.name = value;
            } }
        public void PRINT()
        {
            Console.WriteLine(name);
        }
    }



    public class ex2
    {
        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public string Empsalary { get; set; }

        public void Details()
        {
            Console.WriteLine("Employee name: {0}", EmpName);
            Console.WriteLine("Employee ID: {0}", EmpID);
            Console.WriteLine("Employee Salary: {0}", Empsalary);
        }


    }
    public class ex3{
     public string clothes { get; set; }
        public char size { get; set; }
        
}
}
