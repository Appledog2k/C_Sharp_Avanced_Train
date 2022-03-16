namespace Event
{

    // create class publisher
    public delegate void InputEvent(int x);

    class DataInput : EventArgs {
        public int dataInput{set;get;}
        public DataInput(int x) => dataInput =x;
    }

    class UserInput
    {

        //! public InputEvent inputEvent { get; set; }
        // create delegate event
        //public event InputEvent inputEvent;

        //~  delegate void Name(object? sender, eventArgs)
        public event EventHandler inputEvent01; public void Input()
        {
            do
            {
                System.Console.WriteLine("input int:");
                int i = Convert.ToInt32(Console.ReadLine());
                // genator event
                inputEvent?.Invoke(this, new DataInput(i) );
            } while (true);
        }

    }


    class Square
    {
        // subs event input number
        public void Subs(UserInput input)
        {
            //!    input.inputEvent = square;
            input.inputEvent += square;
        }

        public void square(object sender, EventArgs e)
        {   DataInput dataInput = (DataInput)e;
            System.Console.WriteLine("square : " + i + " square: " + Math.Sqrt(i));
        }
    }

    class Square01
    {
        // subs event input number
        public void Subs(UserInput input)
        {

            //!    input.inputEvent = square01;
            // only += : sign up for event
            //      -= :  register to cancel the event
            input.inputEvent += square01;

        }

        public void square01(object sender, EventArgs e)

        {   InputEvent inputEvent  = (DataInput)e;
            System.Console.WriteLine("square01 : " + i + " square: " + i * i);
        }
    }
}