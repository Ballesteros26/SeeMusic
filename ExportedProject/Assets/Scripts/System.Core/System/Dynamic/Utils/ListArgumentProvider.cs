using System.Linq.Expressions;

namespace System.Dynamic.Utils
{
	internal sealed class ListArgumentProvider : ListProvider<Expression>
	{
		private readonly IArgumentProvider _provider;

		private readonly Expression _arg0;

		protected override Expression First => null;

		protected override int ElementCount => 0;

		internal ListArgumentProvider(IArgumentProvider provider, Expression arg0)
		{
		}

		protected override Expression GetElement(int index)
		{
			return null;
		}
	}
}
