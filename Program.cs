using System;

namespace delEventEx
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchDevice s = new SwitchDevice();
            ISwitchable l1 = new Lamp("red");
            ISwitchable l2 = new Lamp("green");
            
            s.delSwitchAbleDevice += l1.OnSwitcChanged;
            s.delSwitchAbleDevice += l2.OnSwitcChanged;

            s.Flip();
            s.Flip();
        }
    }
}
