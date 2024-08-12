using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    public abstract class Employees
    {
        // Property to identify
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

       
        // abstract metod created
        public abstract void Duty();

    }

    // project manager inherited employees
    public  class ProjectManager : Employees
    {
        

        // abstract metod override 
        public override void Duty()
        {
            Console.WriteLine($"{Name} {Surname} {Department} Proje Yoneticisi olarak calisiyorum."); 
        }
    }

    // softwareDeveloper inherited employees
    public class SoftwareDeveloper : Employees
    {
       

        // abstract metod override 
        public override void Duty()
        {
            Console.WriteLine($"{Name} {Surname} {Department} Yazilim Gelistirici olarak calisiyorum");
        }
    }

    // salesRepresentative inherited employees
    public class SalesRepresentative : Employees
    {
       

        // abstract metod override 
        public override void Duty() 
        {
            Console.WriteLine($"{Name} {Surname} {Department} Satis Temsilcisi olarak calisiyorum");
        }
    }

}
