namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal enum NullableCallLiftKind
	{
		NotLifted = 0,
		Operator = 1,
		EqualityOperator = 2,
		InequalityOperator = 3,
		UserDefinedConversion = 4,
		NullableConversion = 5,
		NullableConversionConstructor = 6,
		NullableIntermediateConversion = 7,
		NotLiftedIntermediateConversion = 8
	}
}
