namespace NatML.Features
{
	public sealed class MLStringFeature : MLFeature, IMLCloudFeature
	{
		public readonly string text;

		public MLStringFeature(string text)
			: base(null)
		{
		}

		public MLStringFeature(MLCloudFeature feature)
			: base(null)
		{
		}

		MLCloudFeature IMLCloudFeature.Create(MLFeatureType _)
		{
			return default(MLCloudFeature);
		}

		public static implicit operator string(MLStringFeature feature)
		{
			return null;
		}
	}
}
