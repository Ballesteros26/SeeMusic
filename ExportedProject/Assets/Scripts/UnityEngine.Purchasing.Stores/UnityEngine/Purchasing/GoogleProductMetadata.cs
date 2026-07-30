using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	public class GoogleProductMetadata : ProductMetadata
	{
		[CompilerGenerated]
		private string _003CoriginalJson_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CsubscriptionPeriod_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CfreeTrialPeriod_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CintroductoryPrice_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CintroductoryPricePeriod_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CintroductoryPriceCycles_003Ek__BackingField;

		internal string originalJson
		{
			[CompilerGenerated]
			set
			{
				_003CoriginalJson_003Ek__BackingField = value;
			}
		}

		internal string subscriptionPeriod
		{
			[CompilerGenerated]
			set
			{
				_003CsubscriptionPeriod_003Ek__BackingField = value;
			}
		}

		internal string freeTrialPeriod
		{
			[CompilerGenerated]
			set
			{
				_003CfreeTrialPeriod_003Ek__BackingField = value;
			}
		}

		internal string introductoryPrice
		{
			[CompilerGenerated]
			set
			{
				_003CintroductoryPrice_003Ek__BackingField = value;
			}
		}

		internal string introductoryPricePeriod
		{
			[CompilerGenerated]
			set
			{
				_003CintroductoryPricePeriod_003Ek__BackingField = value;
			}
		}

		internal int introductoryPriceCycles
		{
			[CompilerGenerated]
			set
			{
				_003CintroductoryPriceCycles_003Ek__BackingField = value;
			}
		}

		internal GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
			: base(null, null, null, null, default(decimal))
		{
		}
	}
}
