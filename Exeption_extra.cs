namespace Exception01
{
    class Exception01
    {
        public static void Registor(string name, int age)
        {

            if (string.IsNullOrEmpty(name))
            {

                throw new Exception007();
            }
            if (age < 18 || age > 100)
            {
                Exception exception01 = new Exception("Age must be >18 and <100");
                throw exception01;
            }
            System.Console.WriteLine($"Hi {name} {age}");
        }


    }

    public class Exception007 : Exception
    {
       
            public Exception007() : base("Tên khác rỗng")
            {

            }
    

    }
}