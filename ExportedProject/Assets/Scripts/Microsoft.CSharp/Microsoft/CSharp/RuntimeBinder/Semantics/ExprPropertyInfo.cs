using System.Reflection;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprPropertyInfo : ExprWithType
	{
		public PropWithType Property { get; }

		public PropertyInfo PropertyInfo => null;

		public ExprPropertyInfo(CType type, PropertySymbol propertySymbol, AggregateType propertyType)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
