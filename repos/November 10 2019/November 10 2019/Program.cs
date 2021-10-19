using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_10_2019
{
    class Program
    {
        //stocks
        //rec. constant updates of change in val
        //if down 3 nis brokers want to know
        //function: alert down 3%
        //class: stocks - name TEVA


        static void Main(string[] args)
        {
            Broker broker1 = new Broker();
            broker1.Description = "Lehman Brothers";
            Broker broker2 = new Broker{Description = "Goldman Sachs"};


            Stock stock1 = new Stock("TEVA", 6.3f);

            stock1.ChangeNotification += broker1.GetNewValue;
            stock1.ChangeNotification += broker2.GetNewValue;
           
            float NewValue = 0.0f;

            while(stock1.Value > 0)
            {
                Console.WriteLine("Please enter new value");
                try
                {
                    NewValue = Convert.ToSingle(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please make sure to enter a number");
                }
               
                stock1.Value = NewValue;
              
            }



            //broker1.GetNewValue(45, "TEVA", 0);


            Console.Read();
        }
    }
}

//yakov falik<falikyakov@gmail.com>
//Sun, Nov 10, 9:24 PM (23 hours ago)
//to me

// class Program
//{
//    static void Main(string[] args)
//    {
//        Broker a = new Broker();
//        a.Description = "Goldman Sachs";
//        Broker b = new Broker();
//        b.Description = "Leaman Brothers";

//        Stock stock = new Stock("Teva", 6.3f);

//        stock.ChangeNotification += a.GetNewValue;
//        stock.ChangeNotification += b.GetNewValue;

//        float NewValue = 0.0f;
//        Trend CurrentTrend;

//        while (stock.Value > 0)
//        {
//            Console.WriteLine("Please enter new value");
//            NewValue = Convert.ToSingle(Console.ReadLine());
//            stock.Value = NewValue;
//        }
//    }
//}
//public class Broker
//{
//    public string Description { get; set; }
//    public void GetNewValue(float value, string StockName, Trend trend)
//    {
//        Console.WriteLine($"At {Description} we know that {StockName} value is" +
//            $" {value.ToString()} and it is going {trend} ");
//    }
//}

//public class Stock
//{
//    public Action<float, string, Trend> ChangeNotification { get; set; }
//    public string Name { get; set; }

//    private float _Value;
//    public float Value
//    {
//        get { return _Value; }
//        set
//        {
//            if ((_Value > value) && (ChangeNotification != null))
//                ChangeNotification(value, this.Name, Trend.Down);
//            _Value = value;
//            LastUpdate = DateTime.Now;
//        }
//    }
//    public DateTime LastUpdate { get; set; }
//    public Stock(string Name, float Value)
//    {
//        this.Name = Name;
//        this.Value = Value;
//        this.LastUpdate = DateTime.Now;
//    }


//}

//public enum Trend
//{
//    Up, Down
//}

