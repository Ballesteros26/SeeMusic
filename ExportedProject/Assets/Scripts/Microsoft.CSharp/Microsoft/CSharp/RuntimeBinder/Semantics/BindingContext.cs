namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal readonly struct BindingContext
	{
		public AggregateSymbol ContextForMemberLookup { get; }

		public bool Checked { get; }

		public BindingContext(AggregateSymbol context, bool isChecked)
		{
			ContextForMemberLookup = null;
			Checked = false;
		}

		public BindingContext(BindingContext parent)
		{
			ContextForMemberLookup = null;
			Checked = false;
		}
	}
}
