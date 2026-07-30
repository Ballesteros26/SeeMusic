using NatML.API.Types;

namespace NatML.API.Services
{
	internal sealed class CreateUploadURLInput
	{
		public string name;

		public UploadType type;

		public string? key;
	}
}
