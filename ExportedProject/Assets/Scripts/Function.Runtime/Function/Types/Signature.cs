using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class Signature
	{
		public Parameter[] inputs;

		public Parameter[] outputs;
	}
}
