namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal enum BinOpFuncKind
	{
		BoolBinOp = 0,
		BoolBitwiseOp = 1,
		DecBinOp = 2,
		DelBinOp = 3,
		EnumBinOp = 4,
		IntBinOp = 5,
		RealBinOp = 6,
		RefCmpOp = 7,
		ShiftOp = 8,
		StrBinOp = 9,
		StrCmpOp = 10,
		None = 11
	}
}
