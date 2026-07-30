using System.Reflection;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprMethodInfo : ExprWithType
	{
		public MethWithInst Method { get; }

		public MethodInfo MethodInfo => null;

		public ConstructorInfo ConstructorInfo => null;

		public override object Object => null;

		public ExprMethodInfo(CType type, MethodSymbol method, AggregateType methodType, TypeArray methodParameters)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
