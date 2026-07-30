using System.Collections.Generic;
using Parse.Common.Internal;

namespace Parse
{
	public struct ParseGeoPoint : IJsonConvertible
	{
		private double latitude;

		private double longitude;

		public double Latitude
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Longitude
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public ParseGeoPoint(double latitude, double longitude)
		{
			this.latitude = 0.0;
			this.longitude = 0.0;
		}

		public ParseGeoDistance DistanceTo(ParseGeoPoint point)
		{
			return default(ParseGeoDistance);
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}
	}
}
