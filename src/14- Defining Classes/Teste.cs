using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}

public class GSM
{
	private string phoneModel;
	private string manufacturer;
	private double price;
	private string owner;

	public string PhoneModel { get => phoneModel; set => phoneModel = value; }
	public string Manufacturer { get => manufacturer; set => manufacturer = value; }
	public double Price { get => price; set => price = value; }
	public string Owner { get => owner; set => owner = value; }
}

public class Battery
{
	private string batteryModel;
	private double idleTime;

	public string BatteryModel { get => batteryModel; set => batteryModel = value; }
	public double IdleTime { get => idleTime; set => idleTime = value; }
}

public class Display
{
	private double size;
	private string color;

	public double Size { get => size; set => size = value; }
	public string Color { get => color; set => color = value; }
}
