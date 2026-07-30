namespace UnityEngine.Purchasing
{
	public class ProductMetadata
	{
		public string localizedPriceString { get; internal set; }

		public string localizedTitle { get; internal set; }

		public string localizedDescription { get; internal set; }

		public string isoCurrencyCode { get; internal set; }

		public decimal localizedPrice { get; internal set; }

		public ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
		{
		}

		public ProductMetadata(ProductMetadata productMetadata)
		{
		}

		public ProductMetadata()
		{
		}
	}
}
