namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal enum ConvKind
	{
		Identity = 1,
		Implicit = 2,
		Explicit = 3,
		Unknown = 4,
		None = 5
	}
}
