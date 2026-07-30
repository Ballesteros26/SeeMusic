namespace System.Runtime.CompilerServices
{
	public static class FormattableStringFactory
	{
		private sealed class ConcreteFormattableString : FormattableString
		{
			private readonly string _format;

			private readonly object[] _arguments;

			public override string Format => null;

			public override int ArgumentCount => 0;

			internal ConcreteFormattableString(string format, object[] arguments)
			{
			}

			public override object[] GetArguments()
			{
				return null;
			}

			public override object GetArgument(int index)
			{
				return null;
			}

			public override string ToString(IFormatProvider formatProvider)
			{
				return null;
			}
		}

		public static FormattableString Create(string format, params object[] arguments)
		{
			return null;
		}
	}
}
