namespace NatML.Types
{
	public class MLStringType : MLFeatureType
	{
		public virtual int length { get; protected set; }

		public MLStringType(int length, string name = null)
			: base(null, null)
		{
		}
	}
}
