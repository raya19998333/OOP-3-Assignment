using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public enum DeviceType
{
    Light,
    Fan,
    AC,
    Heater
}
namespace Assignment333.Smart_Home
{
    // Interface for smart devices
    public interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        void ShowStatus();
    }
    // Light device
    public class Light : ISmartDevice
    {
        private bool isOn = false;

        public void TurnOn() => isOn = true;
        public void TurnOff() => isOn = false;
        public void ShowStatus() => Console.WriteLine($"Light is {(isOn ? "On" : "Off")}");
    }

    // Fan device
    public class Fan : ISmartDevice
    {
        private bool isOn = false;

        public void TurnOn() => isOn = true;
        public void TurnOff() => isOn = false;
        public void ShowStatus() => Console.WriteLine($"Fan is {(isOn ? "On" : "Off")}");
    }


    // AC device
    public class AC : ISmartDevice
    {
        private bool isOn = false;

        public void TurnOn() => isOn = true;
        public void TurnOff() => isOn = false;
        public void ShowStatus() => Console.WriteLine($"AC is {(isOn ? "On" : "Off")}");
    }

    // Heater device
    public class Heater : ISmartDevice
    {
        private bool isOn = false;

        public void TurnOn() => isOn = true;
        public void TurnOff() => isOn = false;
        public void ShowStatus() => Console.WriteLine($"Heater is {(isOn ? "On" : "Off")}");
    }


    // SmartHome class with indexer
    public class SmartHome
    {
        private Dictionary<DeviceType, ISmartDevice> devices = new Dictionary<DeviceType, ISmartDevice>();

        public SmartHome()
        {
            devices[DeviceType.Light] = new Light();
            devices[DeviceType.Fan] = new Fan();
            devices[DeviceType.AC] = new AC();
            devices[DeviceType.Heater] = new Heater();
        }

        // Indexer to access devices by type
        public ISmartDevice this[DeviceType type]
        {
            get => devices[type];
        }
    }



}
