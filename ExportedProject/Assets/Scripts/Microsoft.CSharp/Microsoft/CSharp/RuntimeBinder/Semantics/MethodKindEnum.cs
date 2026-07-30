namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal enum MethodKindEnum
	{
		None = 0,
		Constructor = 1,
		Destructor = 2,
		PropAccessor = 3,
		EventAccessor = 4,
		ExplicitConv = 5,
		ImplicitConv = 6,
		Anonymous = 7,
		Invoke = 8,
		BeginInvoke = 9,
		EndInvoke = 10,
		AnonymousTypeToString = 11,
		AnonymousTypeEquals = 12,
		AnonymousTypeGetHashCode = 13,
		IteratorDispose = 14,
		IteratorReset = 15,
		IteratorGetEnumerator = 16,
		IteratorGetEnumeratorDelegating = 17,
		IteratorMoveNext = 18,
		Latent = 19,
		Actual = 20,
		IteratorFinally = 21
	}
}
