using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class FMODTimelineMarkers
{
	public class TriggerCondition
	{
		public int ParameterIndex { get; set; }

		public int Minimum { get; set; }

		public int Maximum { get; set; }
	}

	public class Marker
	{
		public enum MTypeEnum
		{
			Region = 0,
			TransitionRegion = 1,
			TempoMarker = 2,
			DestinationMarker = 3,
			TransitionMarker = 4
		}

		[JsonConverter(typeof(StringEnumConverter))]
		public MTypeEnum MType { get; set; }

		public double Length { get; set; }

		public int Looping { get; set; }

		public double? Position { get; set; }

		public string PositionString => null;

		public int? DestinationIndex { get; set; }

		public int? QuantizationInterval { get; set; }

		public List<TriggerCondition> TriggerConditions { get; set; }

		public int? Tempo { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return null;
		}
	}

	public string Id { get; set; }

	public List<Marker> Markers { get; set; }

	public static FMODTimelineMarkers FromJSON(string json)
	{
		return null;
	}
}
