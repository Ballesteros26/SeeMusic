using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonRegex : BsonToken
	{
		[CompilerGenerated]
		private BsonString _003CPattern_003Ek__BackingField;

		[CompilerGenerated]
		private BsonString _003COptions_003Ek__BackingField;

		public BsonString Pattern
		{
			[CompilerGenerated]
			set
			{
				_003CPattern_003Ek__BackingField = value;
			}
		}

		public BsonString Options
		{
			[CompilerGenerated]
			set
			{
				_003COptions_003Ek__BackingField = value;
			}
		}

		public override BsonType Type => default(BsonType);

		public BsonRegex(string pattern, string options)
		{
		}
	}
}
