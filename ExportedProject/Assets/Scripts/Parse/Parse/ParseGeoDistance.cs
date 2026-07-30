namespace Parse
{
	public struct ParseGeoDistance
	{
		private const double EarthMeanRadiusKilometers = 6371.0;

		private const double EarthMeanRadiusMiles = 3958.8;

		public double Radians { get; private set; }

		public double Miles => 0.0;

		public double Kilometers => 0.0;

		public ParseGeoDistance(double radians)
		{
			Radians = 0.0;
		}

		public static ParseGeoDistance FromMiles(double miles)
		{
			return default(ParseGeoDistance);
		}

		public static ParseGeoDistance FromKilometers(double kilometers)
		{
			return default(ParseGeoDistance);
		}

		public static ParseGeoDistance FromRadians(double radians)
		{
			return default(ParseGeoDistance);
		}
	}
}
