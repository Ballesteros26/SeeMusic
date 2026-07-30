using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class ErrorContext
	{
		[CompilerGenerated]
		private readonly object? _003COriginalObject_003Ek__BackingField;

		[CompilerGenerated]
		private readonly object? _003CMember_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string _003CPath_003Ek__BackingField;

		internal bool Traced { get; set; }

		public Exception Error { get; }

		public bool Handled { get; }

		internal ErrorContext(object? originalObject, object? member, string path, Exception error)
		{
		}
	}
}
