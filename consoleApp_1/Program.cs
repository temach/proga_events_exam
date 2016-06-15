using System;

namespace consoleApp_1
{

	class MainClass
	{

		public static void BadStuff()
		{
			var Milk = new BadCommodity ("milk", 30.0);
			var Wood = new BadCommodity ("wood", 0.009);
			var tmp = new BadWatchdog ();
			tmp.StartWatching (Milk);
			tmp.StartWatching (Wood);
			Milk.Price += 3210.0;
			Milk.Price += 9999.0;
			Wood.Price -= 9.0;
		}

		public static void GoodStuff()
		{
			var Milk = new GoodCommodity ("milk", 30.0);
			var Wood = new GoodCommodity ("wood", 0.009);
			var tmp = new GoodWatchdog ();
			tmp.StartWatching (Milk);
			tmp.StartWatching (Wood);
			Milk.Price += 3210.0;
			Milk.Price += 9999.0;
			Wood.Price -= 9.0;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("The bad.");
			BadStuff ();
			Console.WriteLine ("Now the Good!");
			GoodStuff ();
		}

	}
}
