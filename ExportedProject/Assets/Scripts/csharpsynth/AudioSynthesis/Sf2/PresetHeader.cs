namespace AudioSynthesis.Sf2
{
	public class PresetHeader
	{
		private string name;

		private ushort patchNumber;

		private ushort bankNumber;

		private int library;

		private int genre;

		private int morphology;

		private Zone[] zones;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int PatchNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BankNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Library
		{
			set
			{
			}
		}

		public int Genre
		{
			set
			{
			}
		}

		public int Morphology
		{
			set
			{
			}
		}

		public Zone[] Zones
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}
