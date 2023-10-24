using System;

public class Program
{
	public static void Main()
	{
		GSM.DisplayNokiaN95Info();
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

	public GSM()
	{
		this.phoneModel = null;
		this.manufacturer = null;
		this.price = 0;
		this.owner = null;
	}

	public GSM(string phoneModel, string manufacturer, double price, string owner)
	{
		this.phoneModel = phoneModel;
		this.manufacturer = manufacturer;
		this.price = price;
		this.owner = owner;
	}

	private static GSM nokiaN95 = new GSM("Nokia N95", "Nokia", 500, null);
	public static void DisplayNokiaN95Info()
	{
		Console.WriteLine($"Phone model: {nokiaN95.PhoneModel}");
		Console.WriteLine($"Manufacturer: {nokiaN95.Manufacturer}");
		Console.WriteLine($"Price: {nokiaN95.Price}");
	}
}

public class Battery
{
    private BatteryType batteryModel;
    private double idleTime;

    public BatteryType BatteryModel { get => batteryModel; set => batteryModel = value; }
    public double IdleTime { get => idleTime; set => idleTime = value; }

    public Battery()
    {
        this.batteryModel = BatteryType.LiIon;
        this.idleTime = 0;
    }

    public Battery(BatteryType batteryModel, double idleTime)
    {
        this.batteryModel = batteryModel;
        this.idleTime = idleTime;
    }
}

public class Display
{
	private double size;
	private string color;
	public double Size { get => size; set => size = value; }

	public string Color { get => color; set => color = value; }

	public Display()
	{
		this.size = 0;
		this.color = null;
	}

	public Display(double size, string color)
	{
		this.size = size;
		this.color = color;
	}
}

enum BatteryType
{
	LiIon,
	NiMH,
	NiCd
}
