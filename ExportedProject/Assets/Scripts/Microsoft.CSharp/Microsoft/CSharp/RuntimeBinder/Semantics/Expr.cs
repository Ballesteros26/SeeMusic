using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class Expr
	{
		private CType _type;

		internal object RuntimeObject { get; set; }

		internal CType RuntimeObjectActualType { get; set; }

		public ExpressionKind Kind { get; }

		public EXPRFLAG Flags { get; set; }

		public bool IsOptionalArgument { get; set; }

		public string ErrorString { get; set; }

		public CType Type
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		[ExcludeFromCodeCoverage]
		public virtual object Object => null;

		protected Expr(ExpressionKind kind)
		{
		}
	}
}
