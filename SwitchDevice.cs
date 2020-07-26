using System;
using System.Collections;
using System.Collections.Generic;

namespace delEventEx
{
    
    public enum SwitchPosition {Off, On}
    
    public delegate void DelSwitchAbleDevice (SwitchPosition switchPosition); 
    public class SwitchDevice
    {
        private const SwitchPosition on = SwitchPosition.On;
        private SwitchPosition _switchPosition;
        //public List<ISwitchable> _switchAbleDevices;
        //public DelSwitchAbleDevice delSwitchAbleDevice;
        public event DelSwitchAbleDevice delSwitchAbleDevice;

        
        public void Flip(){
            if (_switchPosition == SwitchPosition.Off){
                _switchPosition = SwitchPosition.On;
            } 
            else {
                _switchPosition = SwitchPosition.Off;
            }
            //System.Console.WriteLine("Switch is {0}", _switchPosition.ToString());
            if (delSwitchAbleDevice != null)
            {
                delSwitchAbleDevice(_switchPosition);
            }
        }
    }
}
