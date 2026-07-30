using System;

namespace MakeIt.Random
{
	public class SystemRandomWrapper : System.Random
	{
		private IRandom _random;

		public SystemRandomWrapper(IRandom random)
		{
		}

		protected override double Sample()
		{
			return 0.0;
		}

		public override int Next()
		{
			return 0;
		}

		public override int Next(int minValue, int maxValue)
		{
			return 0;
		}

		public override void NextBytes(byte[] buffer)
		{
		}

		public override double NextDouble()
		{
			return 0.0;
		}
	}
}
