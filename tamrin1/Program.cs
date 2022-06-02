using System;

namespace tamrin1
{
    public class class1{
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _haghdariaft;
        public int haghdariaft
        {
            get { return _haghdariaft; }
            set { _haghdariaft = value; }
        }
        private int _saat;
        public int saat
        {
            get { return _saat; }
            set { _saat = value; }
        }


        public void data(string a,int b,int c)
        {
            Console.WriteLine("Name: "+a);
            Console.WriteLine("haghzahmeh: "+b);
            Console.WriteLine("saatKarDarroz : "+c);
            Console.WriteLine("daramad mahiuane: "+b*c*24);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            class1 cl=new class1();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your name: ");
            cl.name=Console.ReadLine();
            Console.Write("Enter your haghzahmat: ");
            cl.haghdariaft= Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter your hour: ");
            cl.saat=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine();
            cl.data(cl.name, cl.haghdariaft, cl.saat);
            
            }

        }
    }
}
