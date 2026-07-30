using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal abstract class BsonToken
	{
		[CompilerGenerated]
		private BsonToken _003CParent_003Ek__BackingField;

		public abstract BsonType Type { get; }

		public BsonToken Parent
		{
			[CompilerGenerated]
			set
			{
				_003CParent_003Ek__BackingField = value;
			}
		}
	}
}
