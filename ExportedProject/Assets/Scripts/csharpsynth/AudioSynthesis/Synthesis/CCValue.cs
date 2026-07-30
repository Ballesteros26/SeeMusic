namespace AudioSynthesis.Synthesis
{
	public struct CCValue
	{
		private byte coarseValue;

		private byte fineValue;

		private short combined;

		public byte Coarse
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte Fine
		{
			set
			{
			}
		}

		public short Combined
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		private void UpdateCombined()
		{
		}

		private void UpdateCoarseFinePair()
		{
		}
	}
}
