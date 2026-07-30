using System.Collections.Generic;
using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Scripting/TextAsset.h")]
	public class TextAsset : Object
	{
		private static class EncodingUtility
		{
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

			internal static readonly Encoding targetEncoding;

			static EncodingUtility()
			{
			}
		}

		public byte[] bytes => null;

		public string text => null;

		public override string ToString()
		{
			return null;
		}

		internal static string DecodeString(byte[] bytes)
		{
			return null;
		}
	}
}
