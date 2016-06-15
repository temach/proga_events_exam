using System;

namespace consoleApp_1
{

	delegate void PriceChangedHandler(string name, double OldPrice, double NewPrice);

	class BadCommodity
	{
		public PriceChangedHandler NewPriceSetEvent;

		string _name;

		double _old_price;

		double _price;
		public double Price
		{
			get { return _price; }
			set { 
				_old_price = _price;
				_price = value;
				if (NewPriceSetEvent != null) {
					NewPriceSetEvent (_name, _old_price, _price);
				}
			}
		}

		public BadCommodity(string name, double price)
		{
			_price = price;
			_name = name;
		}

	}


	class BadWatchdog
	{
		public void WatchStock(string name, double old, double current)
		{
			Console.WriteLine ("Pricess for " + name + " changed from " + old + " to " + current);
		}

		public void StartWatching(BadCommodity com)
		{
			com.NewPriceSetEvent += WatchStock;
		}
	}

}

