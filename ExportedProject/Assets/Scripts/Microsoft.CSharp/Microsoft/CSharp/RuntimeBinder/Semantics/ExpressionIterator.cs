namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExpressionIterator
	{
		private ExprList _pList;

		private Expr _pCurrent;

		public ExpressionIterator(Expr pExpr)
		{
		}

		public bool AtEnd()
		{
			return false;
		}

		public Expr Current()
		{
			return null;
		}

		public void MoveNext()
		{
		}

		public static int Count(Expr pExpr)
		{
			return 0;
		}

		private void Init(Expr pExpr)
		{
		}
	}
}
