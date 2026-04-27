class RemoteControlCar
{

    int Odometer {get; set;} = 0;
    int Battery {get; set;} = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Odometer} meters";
    }

    public string BatteryDisplay()
    {
        if (Battery <= 0)
        {
            return "Battery empty";
        }
        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if (Battery > 0)
        {
            Odometer += 20;
            Battery -= 1;
        }
    }
}
