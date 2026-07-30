using System.Reflection;

namespace System.Runtime.CompilerServices
{
	[DefaultMember("Item")]
	public interface ITuple
	{
		int Length { get; }
	}
}
