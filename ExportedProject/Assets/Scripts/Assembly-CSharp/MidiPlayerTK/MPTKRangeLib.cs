using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MPTKRangeLib
	{
		public int Index;

		public string Name;

		public string Short;

		public string Flag;

		public bool Main;

		public int Count;

		private int[] octave;

		private string[] position;

		private static List<MPTKRangeLib> scales;

		public int this[int index] => 0;

		public static int RangeCount => 0;

		public static MPTKRangeLib Range(int index, bool log = false)
		{
			return null;
		}

		public static MPTKRangeLib Range(MPTKRangeName index, bool log = false)
		{
			return null;
		}

		private static void Init(bool log = false)
		{
		}

		private void BuildOctave(bool log = false)
		{
		}
	}
}
