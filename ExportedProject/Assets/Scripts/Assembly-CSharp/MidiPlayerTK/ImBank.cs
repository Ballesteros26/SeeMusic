using System.Collections.Generic;
using System.Xml.Serialization;

namespace MidiPlayerTK
{
	public class ImBank
	{
		public int BankNumber;

		public HiPreset[] defpresets;

		[XmlIgnore]
		public string Description;

		[XmlIgnore]
		public int PatchCount;

		public List<string> GetDescription()
		{
			return null;
		}
	}
}
