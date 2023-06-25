using System;

namespace program
{
    class length
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }

        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public length()
        {
            public length(int a,int b, int c, int d)
            {
                X1 = a;
                Y1 = b;
                X2 = c;
                Y2 = d;
            }
        }
            public double Calc()
            {
                double x = Math.Pow(x2 - x1, 2);
                double y = Math.Pow(y2 - y1, 2);
                double result = Math.Sqrt(x + y);
                return result;
            }
        
        }//end class length
        class  main
    {
        public static void Main()
        {
            length t = new length();
            t.X1 = Convert.ToInt32(Console.ReadLine());
            t.Y1 = Convert.ToInt32(Console.ReadLine());
            t.X2 = Convert.ToInt32(Console.ReadLine());
            t.Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t.Calc());

        }
    }




        
    }

