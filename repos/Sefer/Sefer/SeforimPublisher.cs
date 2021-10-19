using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sefer
{
    class SeforimPublisher
    {
        public Action<string, float> NewUpdate;

        public string Name;

        private int _amountSold;

        public int AmountSold

        {
            get { return _amountSold; }
            set {
                if (NewUpdate != null)
                {
                    NewUpdate(this.Name, value);
                }



                _amountSold = value;
            }
        }



        private float _price;

        public float Price
        {
            get { return _price; }
            set {
                if (NewUpdate!=null)
                {
                    NewUpdate(this.Name, value); 
                }
                

                _price = value;
            }
        }


        //public SeforimPublisher(string name, float price)
        //{
        //    this.Name = name;
        //    this.Price = price;

  
        //}


    }
}
