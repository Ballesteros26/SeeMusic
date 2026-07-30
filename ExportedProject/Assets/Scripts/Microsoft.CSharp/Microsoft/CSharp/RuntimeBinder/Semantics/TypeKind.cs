namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal enum TypeKind
	{
		TK_AggregateType = 0,
		TK_VoidType = 1,
		TK_NullType = 2,
		TK_MethodGroupType = 3,
		TK_ArgumentListType = 4,
		TK_ArrayType = 5,
		TK_PointerType = 6,
		TK_ParameterModifierType = 7,
		TK_NullableType = 8,
		TK_TypeParameterType = 9
	}
}
