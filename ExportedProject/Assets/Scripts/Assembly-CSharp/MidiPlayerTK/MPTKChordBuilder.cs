using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MPTKChordBuilder
	{
		public enum Modifier3
		{
			Maj = 0,
			Min = 1,
			Dim = 2,
			DimHalf = 3,
			Aug = 4,
			Sus2 = 5,
			Sus4 = 6
		}

		public enum Modifier4
		{
			Maj6 = 0,
			Min6 = 1,
			Maj7 = 2,
			Min7 = 3
		}

		public int Tonic;

		public int Count;

		public int Degree;

		public int FromLib;

		public int Channel;

		public int Velocity;

		public long Duration;

		public long Delay;

		public long Arpeggio;

		public List<MPTKEvent> Events;

		private bool logChord;

		public MPTKChordBuilder(bool log = false)
		{
		}

		private long Clamp(long val, long min, long max)
		{
			return 0L;
		}

		public void MPTK_BuildFromRange(MPTKRangeLib range = null)
		{
		}

		public void MPTK_BuildFromLib(MPTKChordName chordName)
		{
		}

		public void MPTK_BuildFromLib(int pindex)
		{
		}
	}
}
