namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal enum SYMKIND
	{
		SK_NamespaceSymbol = 0,
		SK_AggregateSymbol = 1,
		SK_TypeParameterSymbol = 2,
		SK_FieldSymbol = 3,
		SK_LocalVariableSymbol = 4,
		SK_MethodSymbol = 5,
		SK_PropertySymbol = 6,
		SK_EventSymbol = 7,
		SK_Scope = 8,
		SK_IndexerSymbol = 9
	}
}
