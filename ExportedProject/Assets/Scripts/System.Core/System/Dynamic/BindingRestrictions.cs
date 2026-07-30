using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>Represents a set of binding restrictions on the <see cref="T:System.Dynamic.DynamicMetaObject" /> under which the dynamic binding is valid.</summary>
	[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
	[DebuggerDisplay("{DebugView}")]
	public abstract class BindingRestrictions
	{
		private sealed class TestBuilder
		{
			private struct AndNode
			{
				internal int Depth;

				internal Expression Node;
			}

			private readonly HashSet<BindingRestrictions> _unique;

			private readonly Stack<AndNode> _tests;

			internal void Append(BindingRestrictions restrictions)
			{
			}

			internal Expression ToExpression()
			{
				return null;
			}

			private void Push(Expression node, int depth)
			{
			}
		}

		private sealed class MergedRestriction : BindingRestrictions
		{
			internal readonly BindingRestrictions Left;

			internal readonly BindingRestrictions Right;

			internal MergedRestriction(BindingRestrictions left, BindingRestrictions right)
			{
			}

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class CustomRestriction : BindingRestrictions
		{
			private readonly Expression _expression;

			internal CustomRestriction(Expression expression)
			{
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class TypeRestriction : BindingRestrictions
		{
			private readonly Expression _expression;

			private readonly Type _type;

			internal TypeRestriction(Expression parameter, Type type)
			{
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class InstanceRestriction : BindingRestrictions
		{
			private readonly Expression _expression;

			private readonly object _instance;

			internal InstanceRestriction(Expression parameter, object instance)
			{
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			internal override Expression GetExpression()
			{
				return null;
			}
		}

		private sealed class BindingRestrictionsProxy
		{
		}

		/// <summary>Represents an empty set of binding restrictions. This field is read only.</summary>
		public static readonly BindingRestrictions Empty;

		private BindingRestrictions()
		{
		}

		internal abstract Expression GetExpression();

		/// <summary>Merges the set of binding restrictions with the current binding restrictions.</summary>
		/// <returns>The new set of binding restrictions.</returns>
		/// <param name="restrictions">The set of restrictions with which to merge the current binding restrictions.</param>
		public BindingRestrictions Merge(BindingRestrictions restrictions)
		{
			return null;
		}

		/// <summary>Creates the binding restriction that check the expression for runtime type identity.</summary>
		/// <returns>The new binding restrictions.</returns>
		/// <param name="expression">The expression to test.</param>
		/// <param name="type">The exact type to test.</param>
		public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
		{
			return null;
		}

		internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
		{
			return null;
		}

		/// <summary>Creates the binding restriction that checks the expression for object instance identity.</summary>
		/// <returns>The new binding restrictions.</returns>
		/// <param name="expression">The expression to test.</param>
		/// <param name="instance">The exact object instance to test.</param>
		public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
		{
			return null;
		}

		/// <summary>Creates the binding restriction that checks the expression for arbitrary immutable properties.</summary>
		/// <returns>The new binding restrictions.</returns>
		/// <param name="expression">The expression representing the restrictions.</param>
		public static BindingRestrictions GetExpressionRestriction(Expression expression)
		{
			return null;
		}

		/// <summary>Combines binding restrictions from the list of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances into one set of restrictions.</summary>
		/// <returns>The new set of binding restrictions.</returns>
		/// <param name="contributingObjects">The list of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances from which to combine restrictions.</param>
		public static BindingRestrictions Combine(IList<DynamicMetaObject> contributingObjects)
		{
			return null;
		}

		/// <summary>Creates the <see cref="T:System.Linq.Expressions.Expression" /> representing the binding restrictions.</summary>
		/// <returns>The expression tree representing the restrictions.</returns>
		public Expression ToExpression()
		{
			return null;
		}
	}
}
