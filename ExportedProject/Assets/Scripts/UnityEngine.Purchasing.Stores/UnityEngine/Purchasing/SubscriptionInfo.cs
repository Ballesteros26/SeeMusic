using System;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	public class SubscriptionInfo
	{
		private readonly Result is_subscribed;

		private readonly Result is_expired;

		private readonly Result is_cancelled;

		private readonly Result is_free_trial;

		private readonly Result is_auto_renewing;

		private readonly Result is_introductory_price_period;

		private readonly string productId;

		private readonly DateTime purchaseDate;

		private readonly DateTime subscriptionExpireDate;

		private readonly DateTime subscriptionCancelDate;

		private readonly TimeSpan remainedTime;

		private readonly string introductory_price;

		private readonly TimeSpan introductory_price_period;

		private readonly long introductory_price_cycles;

		private readonly TimeSpan freeTrialPeriod;

		private readonly TimeSpan subscriptionPeriod;

		private readonly string free_trial_period_string;

		private readonly string sku_details;

		public SubscriptionInfo(AppleInAppPurchaseReceipt r, string intro_json)
		{
		}

		public SubscriptionInfo(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata)
		{
		}

		public SubscriptionInfo(string productId)
		{
		}

		public DateTime getPurchaseDate()
		{
			return default(DateTime);
		}

		public Result isExpired()
		{
			return default(Result);
		}

		public Result isCancelled()
		{
			return default(Result);
		}

		public DateTime getExpireDate()
		{
			return default(DateTime);
		}

		private DateTime nextBillingDate(DateTime billing_begin_date, TimeSpanUnits units)
		{
			return default(DateTime);
		}

		private TimeSpan accumulateIntroductoryDuration(TimeSpanUnits units, long cycles)
		{
			return default(TimeSpan);
		}

		private TimeSpan computePeriodTimeSpan(TimeSpanUnits units)
		{
			return default(TimeSpan);
		}

		private double computeExtraTime(string metadata, double new_sku_period_in_seconds)
		{
			return 0.0;
		}

		private TimeSpan parseTimeSpan(string period_string)
		{
			return default(TimeSpan);
		}

		private TimeSpanUnits parsePeriodTimeSpanUnits(string time_span)
		{
			return null;
		}
	}
}
