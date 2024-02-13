using UnityEngine;

public class Car
{
    uint _year;
    string _make;
    string _model;
    uint _topSpeed = 100;
    public float Speed { get; private set; } = 0; 
    public uint Year
    {
        get { return _year; }
        private set 
        {
            _year = (uint)Mathf.Clamp(value, 1886, 2024);
        }
    }
    public string Model
    {
        get { return _model; }
        private set { _model = value; }
    }
    public string Make
    {
        get
        {
            return _make;
        }
        private set
        {
            _make = value;
        }
    }
    public Car(uint year, string make, string model)
    {
        Year = year;
        Make = make;
        Model = model;
    }

    public void Accelerate(float amountToAccelerate)
    {
        Speed = Mathf.Clamp(Speed+= amountToAccelerate, 0, _topSpeed);
    }
    public void Decelerate(float amountToDecelerate)
    {
        Speed = Mathf.Clamp(Speed-= amountToDecelerate, 0, _topSpeed);
    }
}