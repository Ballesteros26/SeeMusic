using System.IO;

namespace AudioSynthesis.Bank.Descriptors
{
	public class CustomDescriptor
	{
		private string id;

		private int size;

		private object[] objs;

		public string ID => null;

		public object[] Objects => null;

		public CustomDescriptor(string id, int size)
		{
		}

		public int Read(BinaryReader reader)
		{
			return 0;
		}
	}
}
