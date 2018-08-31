using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01_Events
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Bulb bulb = new Bulb();
            bulb.BulbOn += Bulb_BulbOn;

            bulb.Switch();
            Console.WriteLine(bulb.state);
            bulb.Switch();
            Console.WriteLine(bulb.state);
            bulb.Switch();
            Console.WriteLine(bulb.state);
            bulb.Switch();
            Console.WriteLine(bulb.state);
            bulb.Switch();
            Console.WriteLine(bulb.state);

        }

        static void Bulb_BulbOn(Bulb bulb)
        {
            Console.WriteLine("Bulb is on");
        }

        // Classes
        public delegate void BulbOnDelegate(Bulb bulb);
        public class Bulb
        {
            public bool state = false;
            public event BulbOnDelegate BulbOn;
            

            public void Switch()
            {
                this.state = !this.state;
                if ( this.state && this.BulbOn != null)
                {
                    this.BulbOn(this);
                }
            }
        }

       

    }
}
