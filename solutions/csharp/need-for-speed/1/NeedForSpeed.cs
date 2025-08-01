using System;

class RemoteControlCar
{
    private int totalDistance;
    private int batterylevel = 100;
    private int speed;
    private int batteryDrain;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => batterylevel < batteryDrain;
    
    public int DistanceDriven() => totalDistance; 

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }
        totalDistance += speed;
        batterylevel -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do
        {
            if(car.BatteryDrained())
            {
                return false;    
            }
            car.Drive();
        } while (car.DistanceDriven() < this.distance);

        return true;
    }
}
