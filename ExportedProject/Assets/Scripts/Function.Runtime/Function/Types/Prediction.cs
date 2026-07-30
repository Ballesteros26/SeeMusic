using System;
using Function.Graph.Converters;
using Function.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	[JsonConverter(typeof(PredictionConverter))]
	public abstract class Prediction
	{
		public string id;

		public string tag;

		public PredictorType type;

		[JsonConverter(typeof(IsoDateTimeConverter))]
		public DateTime created;
	}
}
