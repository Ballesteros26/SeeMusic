using System.Runtime.CompilerServices;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprArrayInit : ExprWithType
	{
		[CompilerGenerated]
		private int _003CDimensionSize_003Ek__BackingField;

		public Expr OptionalArguments { get; set; }

		public Expr OptionalArgumentDimensions { get; set; }

		public int[] DimensionSizes { get; }

		public int DimensionSize
		{
			[CompilerGenerated]
			set
			{
				_003CDimensionSize_003Ek__BackingField = value;
			}
		}

		public bool GeneratedForParamArray { get; set; }

		public ExprArrayInit(CType type, Expr arguments, Expr argumentDimensions, int[] dimensionSizes, int dimensionSize)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
