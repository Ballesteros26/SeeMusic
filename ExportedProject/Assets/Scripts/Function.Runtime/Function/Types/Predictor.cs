using System;
using Function.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class Predictor
	{
		public string tag;

		public Profile owner;

		public string name;

		public PredictorType type;

		public PredictorStatus status;

		public int predictions;

		[JsonConverter(typeof(IsoDateTimeConverter))]
		public DateTime created;

		public string? description;

		public string? card;

		public string? media;

		public Acceleration? acceleration;

		public Signature? signature;

		public string? error;

		public string? license;
	}
}
