using NatML.API.Types;

namespace NatML.API.Services
{
	internal sealed class DeleteGraphInput
	{
		public string tag;

		public string graph;

		public GraphFormat format;
	}
}
