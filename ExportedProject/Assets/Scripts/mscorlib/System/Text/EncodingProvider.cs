namespace System.Text
{
	public abstract class EncodingProvider
	{
		private static object s_InternalSyncObject;

		private static EncodingProvider[] s_providers;

		public abstract Encoding GetEncoding(string name);

		public abstract Encoding GetEncoding(int codepage);

		public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			return null;
		}

		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			return null;
		}

		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			return null;
		}

		internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			return null;
		}
	}
}
