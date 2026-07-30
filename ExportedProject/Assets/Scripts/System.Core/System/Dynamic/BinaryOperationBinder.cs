using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>Represents the binary dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
	public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
	{
		/// <summary>The result type of the operation.</summary>
		/// <returns>The result type of the operation.</returns>
		public sealed override Type ReturnType => null;

		/// <summary>The binary operation kind.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> object representing the kind of binary operation.</returns>
		public ExpressionType Operation { get; }

		internal sealed override bool IsStandardBinder => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Dynamic.BinaryOperationBinder" /> class.</summary>
		/// <param name="operation">The binary operation kind.</param>
		protected BinaryOperationBinder(ExpressionType operation)
		{
		}

		/// <summary>Performs the binding of the binary dynamic operation if the target dynamic object cannot bind.</summary>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		/// <param name="target">The target of the dynamic binary operation.</param>
		/// <param name="arg">The right hand side operand of the dynamic binary operation.</param>
		public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
		{
			return null;
		}

		/// <summary>When overridden in the derived class, performs the binding of the binary dynamic operation if the target dynamic object cannot bind.</summary>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		/// <param name="target">The target of the dynamic binary operation.</param>
		/// <param name="arg">The right hand side operand of the dynamic binary operation.</param>
		/// <param name="errorSuggestion">The binding result if the binding fails, or null.</param>
		public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic binary operation.</summary>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		/// <param name="target">The target of the dynamic operation.</param>
		/// <param name="args">An array of arguments of the dynamic operation.</param>
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		internal static bool OperationIsValid(ExpressionType operation)
		{
			return false;
		}
	}
}
