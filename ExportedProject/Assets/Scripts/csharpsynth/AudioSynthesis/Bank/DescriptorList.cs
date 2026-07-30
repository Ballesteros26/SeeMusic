using System.IO;
using AudioSynthesis.Bank.Descriptors;

namespace AudioSynthesis.Bank
{
	public class DescriptorList
	{
		public EnvelopeDescriptor[] EnvelopeDescriptions;

		public FilterDescriptor[] FilterDescriptions;

		public LfoDescriptor[] LfoDescriptions;

		public GeneratorDescriptor[] GenDescriptions;

		public CustomDescriptor[] CustomDescriptions;

		public DescriptorList(BinaryReader reader)
		{
		}

		public CustomDescriptor FindCustomDescriptor(string name)
		{
			return null;
		}
	}
}
