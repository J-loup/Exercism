using System;

class RemoteControlCar
{
    int totalDistance;
    int batteryLevel = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {totalDistance} meters";

    public string BatteryDisplay()
    {
        if(batteryLevel == 0)
        {
            return $"Battery empty";
        }
        return $"Battery at {batteryLevel}%";
    }

    public void Drive()
    {
        if(batteryLevel == 0)
        {
            Console.WriteLine("Battery empty");
            return;
        }
        totalDistance += 20;
        batteryLevel -= 1;
    }
}
