using System.IO;

namespace AudioSynthesis.Sf2
{
	public class SoundFontInfo
	{
		private short verMajorROM;

		private short verMinorROM;

		private short verMajorSF;

		private short verMinorSF;

		private string waveTableSoundEngine;

		private string bankName;

		private string dataROM;

		private string creationDate;

		private string author;

		private string targetProduct;

		private string copyright;

		private string comments;

		private string tools;

		public string BankName => null;

		public string Comments => null;

		public SoundFontInfo(BinaryReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
