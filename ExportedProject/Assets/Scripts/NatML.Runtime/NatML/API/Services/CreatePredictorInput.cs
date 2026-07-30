using NatML.API.Types;

namespace NatML.API.Services
{
	internal sealed class CreatePredictorInput
	{
		public string tag;

		public string? description;

		public AccessMode? access;
	}
}
