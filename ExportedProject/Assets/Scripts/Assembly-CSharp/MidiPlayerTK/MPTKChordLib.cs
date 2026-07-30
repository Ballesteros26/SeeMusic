using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MPTKChordLib
	{
		public int Index;

		public string Name;

		public string Modifier3;

		public string Modifier7;

		public int Count;

		private int[] chord;

		private char[] position;

		private static List<MPTKChordLib> chords;

		public int this[int index] => 0;

		public static List<MPTKChordLib> Chords => null;

		public static int ChordCount => 0;

		private static void Init(bool log = false)
		{
		}
	}
}
