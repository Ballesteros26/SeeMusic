using System;
using NatML.API.Graph;
using Newtonsoft.Json;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	public sealed class Predictor
	{
		public string tag;

		public Profile owner;

		public string name;

		public string description;

		public PredictorStatus status;

		public AccessMode access;

		[JsonProperty]
		internal Graph[] graphs;

		public string license;

		public string[] topics;

		public string created;

		public string? media;

		public string[]? labels;

		public Normalization? normalization;

		public AspectMode? aspectMode;

		public AudioFormat? audioFormat;
	}
}
