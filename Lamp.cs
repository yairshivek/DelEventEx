using System;

namespace delEventEx
{
    public interface ISwitchable
    {
        void OnSwitcChanged(SwitchPosition switchPosition);
    }

    public class Lamp : ISwitchable
    {
        bool _lightOn = false;
        string _name = null;

        public Lamp(string name)
        {
            this._name = name;
        }

        public void OnSwitcChanged(SwitchPosition switchPosition)
        {
            _lightOn = (switchPosition == SwitchPosition.On);
            Console.WriteLine("Lamp {0} is {1}", _name, _lightOn ? "Lightning" : "Dark");
        }

    }
}
