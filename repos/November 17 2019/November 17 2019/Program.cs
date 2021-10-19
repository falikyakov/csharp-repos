using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//service locator
//facade
//READ UP ON BEHAVIORAL PATERNS AND STRUCTURAL AND DESIGN PATTERNS
//Design Principles
//Do not work with STATIC - people can mess with it 





    // Strategy - allows aggregation 
    //Strategy creates dependency at runtime only
    // DI -- dependency injection (dependency that's injected into code at runtime)
    //creates decoupling


//0.declare Car with DI
//   1. motor, reg. and turbo
//    2.with 'strategy', sometimes use turbo, sometimes reg.
//    3. declare generic Car which receives the diff. types of motors
  
    
    //    4. Collection - of apts. 
    //        size, price
    //    use Sort() to sort acc. to price

    //5. Queue - insert apts. into queue and stack (separately)
    //    and sort them acc. to the way they are removed.






namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r = new Robot(new Home());
            r.Run();
            r.Walk();
            Robot r1 = new Robot(new Garden());
            r1.Walk();
            r1.Run();



            Console.Read();
        }
    }
}
