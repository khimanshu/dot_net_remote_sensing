// RemotableType.cs
using System;
public class RemotableType : MarshalByRefObject
{
	
    public string WaterNorth()
    {
		Console.WriteLine("RemotableType.WaterNorth() was called!");
        return "water quality in north on a scale of 1 to 10 is 9";
    }
	public string WaterEast()
    {
		Console.WriteLine("RemotableType.WaterEast() was called!");
        return "water quality in east on a scale of 1 to 10 is 8";
    }
	public string WaterWest()
    {
		Console.WriteLine("RemotableType.WaterWest() was called!");
        return "water quality in west on a scale of 1 to 10 is 7";
    }
	public string WaterSouth()
    {
		Console.WriteLine("RemotableType.WaterSouth() was called!");
        return "water quality in south on a scale of 1 to 10 is 10";
    }
	 public string Air()
    {
        Console.WriteLine("RemotableType.Air() was called!");
        return "Air quality-> Ground Level:5 6 feet:9    20 feet:8    100 feet:10";
    }
	 public string Temperature()
    {
        Console.WriteLine("RemotableType.Temperature() was called!");
        return "Temperature is 34 is degree Celsius";
    }
}