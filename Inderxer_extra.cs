using System.Numerics;
namespace Static
{
    public class CountNumber

    {
        // don't create obj new use method, prop , trường dữ liệu static

        public static int number = 0;

        public static void Info()
        {
            System.Console.WriteLine("Hi, everyone , số lần bạn truy cập " + number);


        }
        public void Count()
        {
            number++;
        }

    }
    class Student
    {


        // read only
        public readonly string name;
        public Student(string name)
        {
            this.name = name;
        }
    }

    class vector
    {
        double x;
        double y;
        public vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Coordinates()
        {
            System.Console.WriteLine($"x: {x}, y: {y}");
        }

        //! vector1 +vector 2 =vector 3
        public static vector operator +(vector v1, vector v2)
        {
            //   return new Vector(v1.x +v2.x , v1.y +v2.y);
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            vector v = new vector(x, y);
            return v;
        }

        //!create indexer
        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x= value;
                        break;
                    case 1:
                        y= value;
                        break;
                    default:
                        throw new Exception("index error");
                        break;
                }
            }

            get { 
                 switch (i)
                {
                    case 0:
                        return x;
                        
                    case 1:
                        return y;
                        
                    default:
                        throw new Exception("index error");
                        
                }
            }
        }
    }


}