namespace System.Runtime.InteropServices
{
	public readonly struct OSPlatform : IEquatable<OSPlatform>
	{
		private readonly string _osPlatform;

		public static OSPlatform Linux { get; }

		public static OSPlatform OSX { get; }

		public static OSPlatform Windows { get; }

		private OSPlatform(string osPlatform)
		{
			_osPlatform = null;
		}

		public static OSPlatform Create(string osPlatform)
		{
			return default(OSPlatform);
		}

		public bool Equals(OSPlatform other)
		{
			return false;
		}

		internal bool Equals(string other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(OSPlatform left, OSPlatform right)
		{
			return false;
		}
	}
}
