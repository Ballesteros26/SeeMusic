namespace MidiPlayerTK
{
	public class SFFile
	{
		public enum LogLevel
		{
			Panic = 0,
			Error = 1,
			Warn = 2,
			Info = 3,
			Debug = 4
		}

		public enum SfSource
		{
			SF2 = 0,
			MPTK = 1
		}

		public static string[] idlist;

		public const int SFPHDRSIZE = 38;

		public const int SFBAGSIZE = 4;

		public const int SFMODSIZE = 10;

		public const int SFGENSIZE = 4;

		public const int SFIHDRSIZE = 22;

		public const int SFSHDRSIZE = 46;

		public const int SF_SAMPLETYPE_MONO = 1;

		public const int SF_SAMPLETYPE_RIGHT = 2;

		public const int SF_SAMPLETYPE_LEFT = 4;

		public const int SF_SAMPLETYPE_LINKED = 8;

		public const int SF_SAMPLETYPE_ROM = 32768;

		public const int SF_SAMPMODES_LOOP = 1;

		public const int SF_SAMPMODES_UNROLL = 2;

		public const int SF_MIN_SAMPLERATE = 400;

		public const int SF_MAX_SAMPLERATE = 50000;

		public const int SF_MIN_SAMPLE_LENGTH = 32;

		public const int zero_size = 0;

		public static bool Verbose;

		public static string EscapeConvert(string name)
		{
			return null;
		}

		public static void Log(LogLevel level, string fmt, params object[] list)
		{
		}

		public static void DumpSFToFile(SFData sf, string filename)
		{
		}

		public static void Sort(SFData sfdata)
		{
		}
	}
}
