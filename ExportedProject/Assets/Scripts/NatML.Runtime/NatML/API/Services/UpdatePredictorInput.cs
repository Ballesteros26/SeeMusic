using NatML.API.Types;

namespace NatML.API.Services
{
	internal sealed class UpdatePredictorInput
	{
		public string tag;

		public string? description;

		public AccessMode? access;

		public string? license;

		public string[]? topics;

		public string? media;

		public string[]? labels;

		public Normalization? normalization;

		public AspectMode? aspectMode;

		public AudioFormat? audioFormat;
	}
}
