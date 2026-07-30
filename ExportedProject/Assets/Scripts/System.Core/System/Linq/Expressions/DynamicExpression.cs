using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	/// <summary>Represents a dynamic operation.</summary>
	public class DynamicExpression : Expression, IArgumentProvider
	{
		public override bool CanReduce => false;

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.DynamicExpression.Type" /> that represents the static type of the expression.</returns>
		public override Type Type => null;

		/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
		public sealed override ExpressionType NodeType => default(ExpressionType);

		/// <summary>Gets the <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />, which determines the run-time behavior of the dynamic site.</summary>
		/// <returns>The <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" />, which determines the run-time behavior of the dynamic site.</returns>
		public CallSiteBinder Binder { get; }

		/// <summary>Gets the type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite" />.</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite" />.</returns>
		public Type DelegateType { get; }

		/// <summary>Gets the arguments to the dynamic operation.</summary>
		/// <returns>The read-only collections containing the arguments to the dynamic operation.</returns>
		public ReadOnlyCollection<Expression> Arguments => null;

		[ExcludeFromCodeCoverage]
		int IArgumentProvider.ArgumentCount => 0;

		internal DynamicExpression(Type delegateType, CallSiteBinder binder)
		{
		}

		public override Expression Reduce()
		{
			return null;
		}

		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, ReadOnlyCollection<Expression> arguments)
		{
			return null;
		}

		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0)
		{
			return null;
		}

		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
		{
			return null;
		}

		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return null;
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <returns>The result of visiting this node.</returns>
		/// <param name="visitor">The visitor to visit this node with.</param>
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		internal virtual DynamicExpression Rewrite(Expression[] args)
		{
			return null;
		}

		[ExcludeFromCodeCoverage]
		Expression IArgumentProvider.GetArgument(int index)
		{
			return null;
		}
	}
}
