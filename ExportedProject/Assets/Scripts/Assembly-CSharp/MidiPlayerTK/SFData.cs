using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class SFData
	{
		public SFFile.SfSource Source;

		public SFVersion version;

		public SFVersion romver;

		public uint samplepos;

		public string fname;

		public List<SFInfo> info;

		public HiPreset[] preset;

		public HiInstrument[] inst;

		public HiSample[] Samples;

		public byte[] SampleData;
	}
}
