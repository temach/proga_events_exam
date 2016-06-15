using System;

namespace consoleApp_1
{

	public sealed class GoodPriceEventArgs : EventArgs
	{
		public double OldPrice;
		public double Price;

		public GoodPriceEventArgs(double old_price, double price)
		{
		 	OldPrice = old_price;
		 	Price = price;
		}
	}

	class GoodCommodity
	{
		public event EventHandler<GoodPriceEventArgs> NewPriceSetEventHandler;

		string _name;
		public string Name 
		{
			get { return _name; }
		}

		double _old_price;

		double _price;
		public double Price
		{
			get { return _price; }
			set { 
				_old_price = _price;
				_price = value;
				if (NewPriceSetEventHandler != null) {
					NewPriceSetEventHandler (this, new GoodPriceEventArgs(_old_price, _price));
				}
			}
		}

		public GoodCommodity(string name, double price)
		{
			_price = price;
			_name = name;
		}

	}

	class GoodWatchdog
	{
		public void WatchStock(object o, GoodPriceEventArgs args)
		{
			Console.WriteLine ("Pricess for " + (o as GoodCommodity).Name
				+ " changed from " + args.OldPrice 
				+ " to " + args.Price);
		}

		public void StartWatching(GoodCommodity com)
		{
			com.NewPriceSetEventHandler += WatchStock;
		}
	}

}

