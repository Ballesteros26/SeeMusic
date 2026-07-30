using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	/// <summary>Provides the base class from which the classes that represent expression tree nodes are derived. It also contains static (Shared in Visual Basic) factory methods to create the various node types. This is an abstract class.</summary>
	public abstract class Expression
	{
		internal class BinaryExpressionProxy
		{
		}

		internal class BlockExpressionProxy
		{
		}

		internal class CatchBlockProxy
		{
		}

		internal class ConditionalExpressionProxy
		{
		}

		internal class ConstantExpressionProxy
		{
		}

		internal class DebugInfoExpressionProxy
		{
		}

		internal class DefaultExpressionProxy
		{
		}

		internal class GotoExpressionProxy
		{
		}

		internal class IndexExpressionProxy
		{
		}

		internal class InvocationExpressionProxy
		{
		}

		internal class LabelExpressionProxy
		{
		}

		internal class LambdaExpressionProxy
		{
		}

		internal class ListInitExpressionProxy
		{
		}

		internal class LoopExpressionProxy
		{
		}

		internal class MemberExpressionProxy
		{
		}

		internal class MemberInitExpressionProxy
		{
		}

		internal class MethodCallExpressionProxy
		{
		}

		internal class NewArrayExpressionProxy
		{
		}

		internal class NewExpressionProxy
		{
		}

		internal class ParameterExpressionProxy
		{
		}

		internal class RuntimeVariablesExpressionProxy
		{
		}

		internal class SwitchCaseProxy
		{
		}

		internal class SwitchExpressionProxy
		{
		}

		internal class TryExpressionProxy
		{
		}

		internal class TypeBinaryExpressionProxy
		{
		}

		internal class UnaryExpressionProxy
		{
		}

		private class ExtensionInfo
		{
			internal readonly ExpressionType NodeType;

			internal readonly Type Type;
		}

		private enum TryGetFuncActionArgsResult
		{
			Valid = 0,
			ArgumentNull = 1,
			ByRef = 2,
			PointerOrVoid = 3
		}

		private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache;

		private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories;

		private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable;

		/// <summary>Gets the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>One of the <see cref="T:System.Linq.Expressions.ExpressionType" /> values.</returns>
		public virtual ExpressionType NodeType => default(ExpressionType);

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="T:System.Type" /> that represents the static type of the expression.</returns>
		public virtual Type Type => null;

		/// <summary>Indicates that the node can be reduced to a simpler node. If this returns true, Reduce() can be called to produce the reduced form.</summary>
		/// <returns>True if the node can be reduced, otherwise false.</returns>
		public virtual bool CanReduce => false;

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an assignment operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Assign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		public static BinaryExpression Assign(Expression left, Expression right)
		{
			return null;
		}

		private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name)
		{
			return null;
		}

		private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType)
		{
			return false;
		}

		internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType)
		{
			return false;
		}

		private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name)
		{
		}

		private static void ValidateOperator(MethodInfo method)
		{
		}

		private static void ValidateMethodInfo(MethodInfo method, string paramName)
		{
		}

		private static bool IsNullComparison(Expression left, Expression right)
		{
			return false;
		}

		private static bool IsNullConstant(Expression e)
		{
			return false;
		}

		private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method)
		{
		}

		private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName)
		{
		}

		private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms)
		{
			return false;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" />, given the left and right operands, by calling an appropriate factory method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.BinaryExpression" /> that results from calling the appropriate factory method.</returns>
		/// <param name="binaryType">The <see cref="T:System.Linq.Expressions.ExpressionType" /> that specifies the type of binary operation.</param>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the left operand.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the right operand.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="binaryType" /> does not correspond to a binary expression node.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" />, given the left operand, right operand and implementing method, by calling the appropriate factory method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.BinaryExpression" /> that results from calling the appropriate factory method.</returns>
		/// <param name="binaryType">The <see cref="T:System.Linq.Expressions.ExpressionType" /> that specifies the type of binary operation.</param>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the left operand.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the right operand.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that specifies the implementing method.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="binaryType" /> does not correspond to a binary expression node.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" />, given the left operand, right operand, implementing method and type conversion function, by calling the appropriate factory method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.BinaryExpression" /> that results from calling the appropriate factory method.</returns>
		/// <param name="binaryType">The <see cref="T:System.Linq.Expressions.ExpressionType" /> that specifies the type of binary operation.</param>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the left operand.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the right operand.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that specifies the implementing method.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> that represents a type conversion function. This parameter is used only if <paramref name="binaryType" /> is <see cref="F:System.Linq.Expressions.ExpressionType.Coalesce" /> or compound assignment..</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="binaryType" /> does not correspond to a binary expression node.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an equality comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Equal" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The equality operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Equal(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an equality comparison. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Equal" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the equality operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a reference equality comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Equal" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		public static BinaryExpression ReferenceEqual(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an inequality comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NotEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The inequality operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression NotEqual(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an inequality comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NotEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the inequality operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a reference inequality comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NotEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		public static BinaryExpression ReferenceNotEqual(Expression left, Expression right)
		{
			return null;
		}

		private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "greater than" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThan" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The "greater than" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression GreaterThan(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "greater than" numeric comparison. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThan" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the "greater than" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "less than" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThan" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The "less than" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression LessThan(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "less than" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThan" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the "less than" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "greater than or equal" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThanOrEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The "greater than or equal" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "greater than or equal" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThanOrEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the "greater than or equal" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a " less than or equal" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThanOrEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The "less than or equal" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression LessThanOrEqual(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a "less than or equal" numeric comparison.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThanOrEqual" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull" /> to false.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the "less than or equal" operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a conditional AND operation that evaluates the second operand only if the first operand evaluates to true.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAlso" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The bitwise AND operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.-or-<paramref name="left" />.Type and <paramref name="right" />.Type are not the same Boolean type.</exception>
		public static BinaryExpression AndAlso(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a conditional AND operation that evaluates the second operand only if the first operand is resolved to true. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAlso" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the bitwise AND operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.-or-<paramref name="method" /> is null and <paramref name="left" />.Type and <paramref name="right" />.Type are not the same Boolean type.</exception>
		public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a conditional OR operation that evaluates the second operand only if the first operand evaluates to false.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrElse" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The bitwise OR operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.-or-<paramref name="left" />.Type and <paramref name="right" />.Type are not the same Boolean type.</exception>
		public static BinaryExpression OrElse(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a conditional OR operation that evaluates the second operand only if the first operand evaluates to false.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrElse" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the bitwise OR operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.-or-<paramref name="method" /> is null and <paramref name="left" />.Type and <paramref name="right" />.Type are not the same Boolean type.</exception>
		public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a coalescing operation, given a conversion function.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Coalesce" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="left" />.Type and <paramref name="right" />.Type are not convertible to each other.-or-<paramref name="conversion" /> is not null and <paramref name="conversion" />.Type is a delegate type that does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of <paramref name="left" /> does not represent a reference type or a nullable value type.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of <paramref name="left" /> represents a type that is not assignable to the parameter type of the delegate type <paramref name="conversion" />.Type.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of <paramref name="right" /> is not equal to the return type of the delegate type <paramref name="conversion" />.Type.</exception>
		public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
		{
			return null;
		}

		private static Type ValidateCoalesceArgTypes(Type left, Type right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic addition operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Add" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The addition operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Add(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic addition operation that does not have overflow checking. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Add" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the addition operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an addition assignment operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType)
		{
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an addition assignment operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssignChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic addition operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The addition operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression AddChecked(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic addition operation that has overflow checking. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the addition operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic subtraction operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Subtract" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The subtraction operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Subtract(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic subtraction operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Subtract" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the subtraction operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a subtraction assignment operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a subtraction assignment operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssignChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic subtraction operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The subtraction operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression SubtractChecked(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic subtraction operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the subtraction operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic division operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Divide" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The division operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Divide(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic division operation. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Divide" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the division operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a division assignment operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.DivideAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic remainder operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Modulo" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The modulus operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Modulo(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic remainder operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Modulo" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the modulus operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a remainder assignment operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ModuloAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic multiplication operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Multiply" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The multiplication operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Multiply(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic multiplication operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Multiply" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the multiplication operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a multiplication assignment operation that does not have overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a multiplication assignment operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssignChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic multiplication operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The multiplication operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression MultiplyChecked(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents an arithmetic multiplication operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyChecked" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the multiplication operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		private static bool IsSimpleShift(Type left, Type right)
		{
			return false;
		}

		private static Type GetResultTypeOfShift(Type left, Type right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise left-shift operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShift" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The left-shift operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression LeftShift(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise left-shift operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShift" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the left-shift operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise left-shift assignment operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShiftAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise right-shift operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShift" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The right-shift operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression RightShift(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise right-shift operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShift" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the right-shift operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise right-shift assignment operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShiftAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise AND operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.And" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The bitwise AND operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression And(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise AND operation. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.And" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the bitwise AND operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise AND assignment operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise OR operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Or" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The bitwise OR operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Or(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise OR operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Or" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the bitwise OR operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise OR assignment operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise XOR operation, using op_ExclusiveOr for user-defined types.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOr" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The XOR operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression ExclusiveOr(Expression left, Expression right)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise XOR operation, using op_ExclusiveOr for user-defined types. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOr" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the XOR operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.</exception>
		public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents a bitwise XOR assignment operation, using op_ExclusiveOr for user-defined types.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOrAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents raising a number to a power.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Power" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="left" /> or <paramref name="right" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the exponentiation operator is not defined for <paramref name="left" />.Type and <paramref name="right" />.Type.-or-<paramref name="method" /> is null and <paramref name="left" />.Type and/or <paramref name="right" />.Type are not <see cref="T:System.Double" />.</exception>
		public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents raising an expression to a power and assigning the result back to the expression.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.PowerAssign" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Right" />, <see cref="P:System.Linq.Expressions.BinaryExpression.Method" />, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> properties set to the specified values.</returns>
		/// <param name="left">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="right">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method" /> property equal to.</param>
		/// <param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property equal to.</param>
		public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BinaryExpression" /> that represents applying an array index operator to an array of rank one.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.BinaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ArrayIndex" /> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> properties set to the specified values.</returns>
		/// <param name="array">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property equal to.</param>
		/// <param name="index">A <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> or <paramref name="index" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" />.Type does not represent an array type.-or-<paramref name="array" />.Type represents an array type whose rank is not 1.-or-<paramref name="index" />.Type does not represent the <see cref="T:System.Int32" /> type.</exception>
		public static BinaryExpression ArrayIndex(Expression array, Expression index)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains two expressions and has no variables.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="arg0">The first expression in the block.</param>
		/// <param name="arg1">The second expression in the block.</param>
		public static BlockExpression Block(Expression arg0, Expression arg1)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains three expressions and has no variables.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="arg0">The first expression in the block.</param>
		/// <param name="arg1">The second expression in the block.</param>
		/// <param name="arg2">The third expression in the block.</param>
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains four expressions and has no variables.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="arg0">The first expression in the block.</param>
		/// <param name="arg1">The second expression in the block.</param>
		/// <param name="arg2">The third expression in the block.</param>
		/// <param name="arg3">The fourth expression in the block.</param>
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains five expressions and has no variables.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="arg0">The first expression in the block.</param>
		/// <param name="arg1">The second expression in the block.</param>
		/// <param name="arg2">The third expression in the block.</param>
		/// <param name="arg3">The fourth expression in the block.</param>
		/// <param name="arg4">The fifth expression in the block.</param>
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given expressions and has no variables.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(IEnumerable<Expression> expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given expressions, has no variables and has specific result type.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="type">The result type of the block.</param>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(Type type, params Expression[] expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given expressions, has no variables and has specific result type.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="type">The result type of the block.</param>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(Type type, IEnumerable<Expression> expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given variables and expressions.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="variables">The variables in the block.</param>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given variables and expressions.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="type">The result type of the block.</param>
		/// <param name="variables">The variables in the block.</param>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given variables and expressions.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="variables">The variables in the block.</param>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.BlockExpression" /> that contains the given variables and expressions.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.BlockExpression" />.</returns>
		/// <param name="type">The result type of the block.</param>
		/// <param name="variables">The variables in the block.</param>
		/// <param name="expressions">The expressions in the block.</param>
		public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions)
		{
			return null;
		}

		internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName)
		{
		}

		private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.CatchBlock" /> representing a catch statement with the specified elements.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.CatchBlock" />.</returns>
		/// <param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type" /> of <see cref="T:System.Exception" /> this <see cref="T:System.Linq.Expressions.CatchBlock" /> will handle.</param>
		/// <param name="variable">A <see cref="T:System.Linq.Expressions.ParameterExpression" /> representing a reference to the <see cref="T:System.Exception" /> object caught by this handler.</param>
		/// <param name="body">The body of the catch statement.</param>
		/// <param name="filter">The body of the <see cref="T:System.Exception" /> filter.</param>
		public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression" /> that represents a conditional statement.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ConditionalExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional" /> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" />, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" />, and <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> properties set to the specified values.</returns>
		/// <param name="test">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" /> property equal to.</param>
		/// <param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" /> property equal to.</param>
		/// <param name="ifFalse">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="test" /> or <paramref name="ifTrue" /> or <paramref name="ifFalse" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="test" />.Type is not <see cref="T:System.Boolean" />.-or-<paramref name="ifTrue" />.Type is not equal to <paramref name="ifFalse" />.Type.</exception>
		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression" /> that represents a conditional statement.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ConditionalExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional" /> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" />, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" />, and <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> properties set to the specified values.</returns>
		/// <param name="test">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" /> property equal to.</param>
		/// <param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" /> property equal to.</param>
		/// <param name="ifFalse">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> property equal to.</param>
		/// <param name="type">A <see cref="P:System.Linq.Expressions.Expression.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression" /> that represents a conditional block with an if statement.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ConditionalExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional" /> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" />, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" />, properties set to the specified values. The <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> property is set to default expression and the type of the resulting <see cref="T:System.Linq.Expressions.ConditionalExpression" /> returned by this method is <see cref="T:System.Void" />.</returns>
		/// <param name="test">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" /> property equal to.</param>
		/// <param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" /> property equal to.</param>
		public static ConditionalExpression IfThen(Expression test, Expression ifTrue)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ConstantExpression" /> that has the <see cref="P:System.Linq.Expressions.ConstantExpression.Value" /> property set to the specified value.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ConstantExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Constant" /> and the <see cref="P:System.Linq.Expressions.ConstantExpression.Value" /> property set to the specified value.</returns>
		/// <param name="value">An <see cref="T:System.Object" /> to set the <see cref="P:System.Linq.Expressions.ConstantExpression.Value" /> property equal to.</param>
		public static ConstantExpression Constant(object value)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ConstantExpression" /> that has the <see cref="P:System.Linq.Expressions.ConstantExpression.Value" /> and <see cref="P:System.Linq.Expressions.Expression.Type" /> properties set to the specified values.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ConstantExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Constant" /> and the <see cref="P:System.Linq.Expressions.ConstantExpression.Value" /> and <see cref="P:System.Linq.Expressions.Expression.Type" /> properties set to the specified values.</returns>
		/// <param name="value">An <see cref="T:System.Object" /> to set the <see cref="P:System.Linq.Expressions.ConstantExpression.Value" /> property equal to.</param>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not null and <paramref name="type" /> is not assignable from the dynamic type of <paramref name="value" />.</exception>
		public static ConstantExpression Constant(object value, Type type)
		{
			return null;
		}

		/// <summary>Creates an empty expression that has <see cref="T:System.Void" /> type.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.DefaultExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Default" /> and the <see cref="P:System.Linq.Expressions.Expression.Type" /> property set to <see cref="T:System.Void" />.</returns>
		public static DefaultExpression Empty()
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.DefaultExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.Type" /> property set to the specified type.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.DefaultExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Default" /> and the <see cref="P:System.Linq.Expressions.Expression.Type" /> property set to the specified type.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		public static DefaultExpression Default(Type type)
		{
			return null;
		}

		/// <summary>Constructs a new instance of <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		protected Expression()
		{
		}

		/// <summary>Reduces this node to a simpler expression. If CanReduce returns true, this should return a valid expression. This method can return another node which itself must be reduced.</summary>
		/// <returns>The reduced expression.</returns>
		public virtual Expression Reduce()
		{
			return null;
		}

		/// <summary>Reduces the node and then calls the visitor delegate on the reduced expression. The method throws an exception if the node is not reducible.</summary>
		/// <returns>The expression being visited, or an expression which should replace it in the tree.</returns>
		/// <param name="visitor">An instance of <see cref="T:System.Func`2" />.</param>
		protected internal virtual Expression VisitChildren(ExpressionVisitor visitor)
		{
			return null;
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <returns>The result of visiting this node.</returns>
		/// <param name="visitor">The visitor to visit this node with.</param>
		protected internal virtual Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		/// <summary>Reduces this node to a simpler expression. If CanReduce returns true, this should return a valid expression. This method can return another node which itself must be reduced.</summary>
		/// <returns>The reduced expression.</returns>
		public Expression ReduceAndCheck()
		{
			return null;
		}

		/// <summary>Returns a textual representation of the <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>A textual representation of the <see cref="T:System.Linq.Expressions.Expression" />.</returns>
		public override string ToString()
		{
			return null;
		}

		private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName)
		{
		}

		private static void RequiresCanWrite(Expression expression, string paramName)
		{
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.GotoExpression" /> representing a break statement.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.GotoExpression" /> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind" /> equal to Break, the <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property set to <paramref name="target" />, and a null value to be passed to the target label upon jumping.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> that the <see cref="T:System.Linq.Expressions.GotoExpression" /> will jump to.</param>
		public static GotoExpression Break(LabelTarget target)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.GotoExpression" /> representing a return statement.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.GotoExpression" /> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind" /> equal to Return, the <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property set to <paramref name="target" />, and a null value to be passed to the target label upon jumping.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> that the <see cref="T:System.Linq.Expressions.GotoExpression" /> will jump to.</param>
		public static GotoExpression Return(LabelTarget target)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.GotoExpression" /> representing a return statement. The value passed to the label upon jumping can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.GotoExpression" /> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind" /> equal to Continue, the <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property set to <paramref name="target" />, and <paramref name="value" /> to be passed to the target label upon jumping.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> that the <see cref="T:System.Linq.Expressions.GotoExpression" /> will jump to.</param>
		/// <param name="value">The value that will be passed to the associated label upon jumping.</param>
		public static GotoExpression Return(LabelTarget target, Expression value)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.GotoExpression" /> representing a "go to" statement with the specified type.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.GotoExpression" /> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind" /> equal to Goto, the <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property set to the specified value, the <see cref="P:System.Linq.Expressions.Expression.Type" /> property set to <paramref name="type" />, and a null value to be passed to the target label upon jumping.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> that the <see cref="T:System.Linq.Expressions.GotoExpression" /> will jump to.</param>
		/// <param name="type">An <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		public static GotoExpression Goto(LabelTarget target, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.GotoExpression" /> representing a "go to" statement. The value passed to the label upon jumping can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.GotoExpression" /> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind" /> equal to Goto, the <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property set to <paramref name="target" />, and <paramref name="value" /> to be passed to the target label upon jumping.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> that the <see cref="T:System.Linq.Expressions.GotoExpression" /> will jump to.</param>
		/// <param name="value">The value that will be passed to the associated label upon jumping.</param>
		public static GotoExpression Goto(LabelTarget target, Expression value)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.GotoExpression" /> representing a jump of the specified <see cref="T:System.Linq.Expressions.GotoExpressionKind" />. The value passed to the label upon jumping can also be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.GotoExpression" /> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind" /> equal to <paramref name="kind" />, the <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> property set to <paramref name="target" />, the <see cref="P:System.Linq.Expressions.Expression.Type" /> property set to <paramref name="type" />, and <paramref name="value" /> to be passed to the target label upon jumping.</returns>
		/// <param name="kind">The <see cref="T:System.Linq.Expressions.GotoExpressionKind" /> of the <see cref="T:System.Linq.Expressions.GotoExpression" />.</param>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> that the <see cref="T:System.Linq.Expressions.GotoExpression" /> will jump to.</param>
		/// <param name="value">The value that will be passed to the associated label upon jumping.</param>
		/// <param name="type">An <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
			return null;
		}

		private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type)
		{
		}

		private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName)
		{
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.IndexExpression" /> that represents accessing an indexed property in an object.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.IndexExpression" />.</returns>
		/// <param name="instance">The object to which the property belongs. It should be null if the property is static (shared in Visual Basic).</param>
		/// <param name="indexer">An <see cref="T:System.Linq.Expressions.Expression" /> representing the property to index.</param>
		/// <param name="arguments">An IEnumerable&lt;Expression&gt; (IEnumerable (Of Expression) in Visual Basic) that contains the arguments that will be used to index the property.</param>
		public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.IndexExpression" /> to access an array.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.IndexExpression" />.</returns>
		/// <param name="array">An expression representing the array to index.</param>
		/// <param name="indexes">An array that contains expressions used to index the array.</param>
		public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.IndexExpression" /> to access a multidimensional array.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.IndexExpression" />.</returns>
		/// <param name="array">An expression that represents the multidimensional array.</param>
		/// <param name="indexes">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> containing expressions used to index the array.</param>
		public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.IndexExpression" /> representing the access to an indexed property.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.IndexExpression" />.</returns>
		/// <param name="instance">The object to which the property belongs. If the property is static/shared, it must be null.</param>
		/// <param name="indexer">The <see cref="T:System.Reflection.PropertyInfo" /> that represents the property to index.</param>
		/// <param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects that are used to index the property.</param>
		public static IndexExpression Property(Expression instance, PropertyInfo indexer, params Expression[] arguments)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.IndexExpression" /> representing the access to an indexed property.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.IndexExpression" />.</returns>
		/// <param name="instance">The object to which the property belongs. If the property is static/shared, it must be null.</param>
		/// <param name="indexer">The <see cref="T:System.Reflection.PropertyInfo" /> that represents the property to index.</param>
		/// <param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Linq.Expressions.Expression" /> objects that are used to index the property.</param>
		public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList)
		{
			return null;
		}

		private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList)
		{
		}

		private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		internal static InvocationExpression Invoke(Expression expression)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.InvocationExpression" /> that applies a delegate or lambda expression to a list of argument expressions.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.InvocationExpression" /> that applies the specified delegate or lambda expression to the provided arguments.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the delegate or lambda expression to be applied.</param>
		/// <param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects that represent the arguments that the delegate or lambda expression is applied to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="expression" />.Type does not represent a delegate type or an <see cref="T:System.Linq.Expressions.Expression`1" />.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="arguments" /> is not assignable to the type of the corresponding parameter of the delegate represented by <paramref name="expression" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="arguments" /> does not contain the same number of elements as the list of parameters for the delegate represented by <paramref name="expression" />.</exception>
		public static InvocationExpression Invoke(Expression expression, params Expression[] arguments)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.InvocationExpression" /> that applies a delegate or lambda expression to a list of argument expressions.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.InvocationExpression" /> that applies the specified delegate or lambda expression to the provided arguments.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the delegate or lambda expression to be applied to.</param>
		/// <param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.Expression" /> objects that represent the arguments that the delegate or lambda expression is applied to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="expression" />.Type does not represent a delegate type or an <see cref="T:System.Linq.Expressions.Expression`1" />.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="arguments" /> is not assignable to the type of the corresponding parameter of the delegate represented by <paramref name="expression" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="arguments" /> does not contain the same number of elements as the list of parameters for the delegate represented by <paramref name="expression" />.</exception>
		public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments)
		{
			return null;
		}

		internal static MethodInfo GetInvokeMethod(Expression expression)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LabelExpression" /> representing a label without a default value.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.LabelExpression" /> without a default value.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> which this <see cref="T:System.Linq.Expressions.LabelExpression" /> will be associated with.</param>
		public static LabelExpression Label(LabelTarget target)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LabelExpression" /> representing a label with the given default value.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.LabelExpression" /> with the given default value.</returns>
		/// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget" /> which this <see cref="T:System.Linq.Expressions.LabelExpression" /> will be associated with.</param>
		/// <param name="defaultValue">The value of this <see cref="T:System.Linq.Expressions.LabelExpression" /> when the label is reached through regular control flow.</param>
		public static LabelExpression Label(LabelTarget target, Expression defaultValue)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LabelTarget" /> representing a label with void type and no name.</summary>
		/// <returns>The new <see cref="T:System.Linq.Expressions.LabelTarget" />.</returns>
		public static LabelTarget Label()
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LabelTarget" /> representing a label with void type and the given name.</summary>
		/// <returns>The new <see cref="T:System.Linq.Expressions.LabelTarget" />.</returns>
		/// <param name="name">The name of the label.</param>
		public static LabelTarget Label(string name)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LabelTarget" /> representing a label with the given type.</summary>
		/// <returns>The new <see cref="T:System.Linq.Expressions.LabelTarget" />.</returns>
		/// <param name="type">The type of value that is passed when jumping to the label.</param>
		public static LabelTarget Label(Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LabelTarget" /> representing a label with the given type and name.</summary>
		/// <returns>The new <see cref="T:System.Linq.Expressions.LabelTarget" />.</returns>
		/// <param name="type">The type of value that is passed when jumping to the label.</param>
		/// <param name="name">The name of the label.</param>
		public static LabelTarget Label(Type type, string name)
		{
			return null;
		}

		internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.Expression`1" /> where the delegate type is known at compile time.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression`1" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda" /> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> properties set to the specified values.</returns>
		/// <param name="body">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> property equal to.</param>
		/// <param name="parameters">An array of <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> collection.</param>
		/// <typeparam name="TDelegate">A delegate type.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="body" /> is null.-or-One or more elements in <paramref name="parameters" /> are null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="TDelegate" /> is not a delegate type.-or-<paramref name="body" />.Type represents a type that is not assignable to the return type of <paramref name="TDelegate" />.-or-<paramref name="parameters" /> does not contain the same number of elements as the list of parameters for <paramref name="TDelegate" />.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="parameters" /> is not assignable from the type of the corresponding parameter type of <paramref name="TDelegate" />.</exception>
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.Expression`1" /> where the delegate type is known at compile time.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression`1" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda" /> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> properties set to the specified values.</returns>
		/// <param name="body">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> property equal to.</param>
		/// <param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> collection.</param>
		/// <typeparam name="TDelegate">A delegate type.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="body" /> is null.-or-One or more elements in <paramref name="parameters" /> are null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="TDelegate" /> is not a delegate type.-or-<paramref name="body" />.Type represents a type that is not assignable to the return type of <paramref name="TDelegate" />.-or-<paramref name="parameters" /> does not contain the same number of elements as the list of parameters for <paramref name="TDelegate" />.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="parameters" /> is not assignable from the type of the corresponding parameter type of <paramref name="TDelegate" />.</exception>
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.Expression`1" /> where the delegate type is known at compile time.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression`1" /> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda" />and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> properties set to the specified values.</returns>
		/// <param name="body">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> property equal to.</param>
		/// <param name="tailCall">A <see cref="T:System.Boolean" /> that indicates if tail call optimization will be applied when compiling the created expression.</param>
		/// <param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> collection.</param>
		/// <typeparam name="TDelegate">The delegate type. </typeparam>
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Linq.Expressions.Expression`1" /> where the delegate type is known at compile time.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression`1" /> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda" /> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> properties set to the specified values.</returns>
		/// <param name="body">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> property equal to.</param>
		/// <param name="name">The name of the lambda. Used for generating debugging info.</param>
		/// <param name="tailCall">A <see cref="T:System.Boolean" /> that indicates if tail call optimization will be applied when compiling the created expression.</param>
		/// <param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> collection.</param>
		/// <typeparam name="TDelegate">The delegate type. </typeparam>
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LambdaExpression" /> by first constructing a delegate type. It can be used when the delegate type is not known at compile time.</summary>
		/// <returns>An object that represents a lambda expression which has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda" /> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> properties set to the specified values.</returns>
		/// <param name="delegateType">A <see cref="T:System.Type" /> that represents a delegate signature for the lambda.</param>
		/// <param name="body">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> property equal to.</param>
		/// <param name="parameters">An array of <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="delegateType" /> or <paramref name="body" /> is null.-or-One or more elements in <paramref name="parameters" /> are null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="delegateType" /> does not represent a delegate type.-or-<paramref name="body" />.Type represents a type that is not assignable to the return type of the delegate type represented by <paramref name="delegateType" />.-or-<paramref name="parameters" /> does not contain the same number of elements as the list of parameters for the delegate type represented by <paramref name="delegateType" />.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="parameters" /> is not assignable from the type of the corresponding parameter type of the delegate type represented by <paramref name="delegateType" />.</exception>
		public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		/// <summary>Creates a LambdaExpression by first constructing a delegate type.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.LambdaExpression" /> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType" /> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> properties set to the specified values.</returns>
		/// <param name="delegateType">A <see cref="P:System.Linq.Expressions.Expression.Type" /> representing the delegate signature for the lambda.</param>
		/// <param name="body">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body" /> property equal to. </param>
		/// <param name="name">The name for the lambda. Used for emitting debug information.</param>
		/// <param name="tailCall">A <see cref="T:System.Boolean" /> that indicates if tail call optimization will be applied when compiling the created expression. </param>
		/// <param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters" /> collection. </param>
		public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName)
		{
		}

		private static TryGetFuncActionArgsResult ValidateTryGetFuncActionArgs(Type[] typeArgs)
		{
			return default(TryGetFuncActionArgsResult);
		}

		/// <summary>Creates a <see cref="P:System.Linq.Expressions.Expression.Type" /> object that represents a generic System.Func delegate type that has specific type arguments. The last type argument specifies the return type of the created delegate.</summary>
		/// <returns>The type of a System.Func delegate that has the specified type arguments.</returns>
		/// <param name="typeArgs">An array of one to seventeen <see cref="T:System.Type" /> objects that specify the type arguments for the System.Func delegate type.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="typeArgs" /> contains fewer than one or more than seventeen elements.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeArgs" /> is null.</exception>
		public static Type GetFuncType(params Type[] typeArgs)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Type" /> object that represents a generic System.Action delegate type that has specific type arguments.</summary>
		/// <returns>The type of a System.Action delegate that has the specified type arguments.</returns>
		/// <param name="typeArgs">An array of up to sixteen <see cref="T:System.Type" /> objects that specify the type arguments for the System.Action delegate type.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="typeArgs" /> contains more than sixteen elements.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeArgs" /> is null.</exception>
		public static Type GetActionType(params Type[] typeArgs)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.LoopExpression" /> with the given body.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.LoopExpression" />.</returns>
		/// <param name="body">The body of the loop.</param>
		/// <param name="break">The break target used by the loop body.</param>
		/// <param name="continue">The continue target used by the loop body.</param>
		public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MemberExpression" /> that represents accessing a field.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MemberExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess" /> and the <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> and <see cref="P:System.Linq.Expressions.MemberExpression.Member" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> property equal to. For static (Shared in Visual Basic), <paramref name="expression" /> must be null.</param>
		/// <param name="field">The <see cref="T:System.Reflection.FieldInfo" /> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Member" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="field" /> is null.-or-The field represented by <paramref name="field" /> is not static (Shared in Visual Basic) and <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="expression" />.Type is not assignable to the declaring type of the field represented by <paramref name="field" />.</exception>
		public static MemberExpression Field(Expression expression, FieldInfo field)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MemberExpression" /> that represents accessing a field given the name of the field.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MemberExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess" />, the <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> property set to <paramref name="expression" />, and the <see cref="P:System.Linq.Expressions.MemberExpression.Member" /> property set to the <see cref="T:System.Reflection.FieldInfo" /> that represents the field denoted by <paramref name="fieldName" />.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> whose <see cref="P:System.Linq.Expressions.Expression.Type" /> contains a field named <paramref name="fieldName" />. This can be null for static fields.</param>
		/// <param name="fieldName">The name of a field to be accessed.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="fieldName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">No field named <paramref name="fieldName" /> is defined in <paramref name="expression" />.Type or its base types.</exception>
		public static MemberExpression Field(Expression expression, string fieldName)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MemberExpression" /> that represents accessing a property.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MemberExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess" />, the <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> property set to <paramref name="expression" />, and the <see cref="P:System.Linq.Expressions.MemberExpression.Member" /> property set to the <see cref="T:System.Reflection.PropertyInfo" /> that represents the property denoted by <paramref name="propertyName" />.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> whose <see cref="P:System.Linq.Expressions.Expression.Type" /> contains a property named <paramref name="propertyName" />. This can be null for static properties.</param>
		/// <param name="propertyName">The name of a property to be accessed.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="propertyName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">No property named <paramref name="propertyName" /> is defined in <paramref name="expression" />.Type or its base types.</exception>
		public static MemberExpression Property(Expression expression, string propertyName)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MemberExpression" /> that represents accessing a property.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MemberExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess" /> and the <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> and <see cref="P:System.Linq.Expressions.MemberExpression.Member" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> property equal to. This can be null for static properties.</param>
		/// <param name="property">The <see cref="T:System.Reflection.PropertyInfo" /> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Member" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="property" /> is null.-or-The property that <paramref name="property" /> represents is not static (Shared in Visual Basic) and <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="expression" />.Type is not assignable to the declaring type of the property that <paramref name="property" /> represents.</exception>
		public static MemberExpression Property(Expression expression, PropertyInfo property)
		{
			return null;
		}

		private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1)
		{
			return null;
		}

		private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod)
		{
			return false;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MemberExpression" /> that represents accessing either a field or a property.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.MemberExpression" /> that results from calling the appropriate factory method.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the object that the member belongs to. This can be null for static members.</param>
		/// <param name="member">The <see cref="T:System.Reflection.MemberInfo" /> that describes the field or property to be accessed.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="member" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="member" /> does not represent a field or property.</exception>
		public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
		{
			return null;
		}

		internal static MethodCallExpression Call(MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static (Shared in Visual Basic) method that takes one argument.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.</exception>
		public static MethodCallExpression Call(MethodInfo method, Expression arg0)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static method that takes two arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <param name="arg1">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the second argument.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.</exception>
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static method that takes three arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <param name="arg1">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the second argument.</param>
		/// <param name="arg2">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the third argument.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.</exception>
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static method that takes four arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <param name="arg1">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the second argument.</param>
		/// <param name="arg2">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the third argument.</param>
		/// <param name="arg3">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the fourth argument.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.</exception>
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static method that takes five arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <param name="arg1">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the second argument.</param>
		/// <param name="arg2">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the third argument.</param>
		/// <param name="arg3">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the fourth argument.</param>
		/// <param name="arg4">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the fifth argument.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.</exception>
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static (Shared in Visual Basic) method that has arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> properties set to the specified values.</returns>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents a static (Shared in Visual Basic) method to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in <paramref name="arguments" /> does not equal the number of parameters for the method represented by <paramref name="method" />.-or-One or more of the elements of <paramref name="arguments" /> is not assignable to the corresponding parameter for the method represented by <paramref name="method" />.</exception>
		public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a static (Shared in Visual Basic) method.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> that represents the target method.</param>
		/// <param name="arguments">A collection of <see cref="T:System.Linq.Expressions.Expression" /> that represents the call arguments.</param>
		public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a method that takes no arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression" /> that specifies the instance for an instance method call (pass null for a static (Shared in Visual Basic) method).</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.-or-<paramref name="instance" /> is null and <paramref name="method" /> represents an instance method.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="instance" />.Type is not assignable to the declaring type of the method represented by <paramref name="method" />.</exception>
		public static MethodCallExpression Call(Expression instance, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a method that takes arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" />, <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" />, and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> properties set to the specified values.</returns>
		/// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression" /> that specifies the instance fo an instance method call (pass null for a static (Shared in Visual Basic) method).</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.-or-<paramref name="instance" /> is null and <paramref name="method" /> represents an instance method.-or-<paramref name="arguments" /> is not null and one or more of its elements is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="instance" />.Type is not assignable to the declaring type of the method represented by <paramref name="method" />.-or-The number of elements in <paramref name="arguments" /> does not equal the number of parameters for the method represented by <paramref name="method" />.-or-One or more of the elements of <paramref name="arguments" /> is not assignable to the corresponding parameter for the method represented by <paramref name="method" />.</exception>
		public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments)
		{
			return null;
		}

		internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a method that takes two arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression" /> that specifies the instance for an instance call. (pass null for a static (Shared in Visual Basic) method).</param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> that represents the target method.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <param name="arg1">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the second argument.</param>
		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a method that takes three arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression" /> that specifies the instance for an instance call. (pass null for a static (Shared in Visual Basic) method).</param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> that represents the target method.</param>
		/// <param name="arg0">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the first argument.</param>
		/// <param name="arg1">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the second argument.</param>
		/// <param name="arg2">The <see cref="T:System.Linq.Expressions.Expression" /> that represents the third argument.</param>
		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a method by calling the appropriate factory method.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" />, the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> property equal to <paramref name="instance" />, <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> set to the <see cref="T:System.Reflection.MethodInfo" /> that represents the specified instance method, and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> set to the specified arguments.</returns>
		/// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression" /> whose <see cref="P:System.Linq.Expressions.Expression.Type" /> property value will be searched for a specific method.</param>
		/// <param name="methodName">The name of the method.</param>
		/// <param name="typeArguments">An array of <see cref="T:System.Type" /> objects that specify the type parameters of the generic method. This argument should be null when methodName specifies a non-generic method.</param>
		/// <param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects that represents the arguments to the method.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> or <paramref name="methodName" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">No method whose name is <paramref name="methodName" />, whose type parameters match <paramref name="typeArguments" />, and whose parameter types match <paramref name="arguments" /> is found in <paramref name="instance" />.Type or its base types.-or-More than one method whose name is <paramref name="methodName" />, whose type parameters match <paramref name="typeArguments" />, and whose parameter types match <paramref name="arguments" /> is found in <paramref name="instance" />.Type or its base types.</exception>
		public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that represents a call to a method that takes arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.MethodCallExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call" /> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" />, <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" />, and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> properties set to the specified values.</returns>
		/// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object" /> property equal to (pass null for a static (Shared in Visual Basic) method).</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method" /> property equal to.</param>
		/// <param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="method" /> is null.-or-<paramref name="instance" /> is null and <paramref name="method" /> represents an instance method.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="instance" />.Type is not assignable to the declaring type of the method represented by <paramref name="method" />.-or-The number of elements in <paramref name="arguments" /> does not equal the number of parameters for the method represented by <paramref name="method" />.-or-One or more of the elements of <paramref name="arguments" /> is not assignable to the corresponding parameter for the method represented by <paramref name="method" />.</exception>
		public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
		{
			return null;
		}

		private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method)
		{
			return null;
		}

		private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method)
		{
		}

		private static void ValidateCallInstanceType(Type instanceType, MethodInfo method)
		{
		}

		private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
		{
		}

		private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			return null;
		}

		private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
		}

		private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName)
		{
			return null;
		}

		private static bool TryQuote(Type parameterType, ref Expression argument)
		{
			return false;
		}

		private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags)
		{
			return null;
		}

		private static bool IsCompatible(MethodBase m, Expression[] arguments)
		{
			return false;
		}

		private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression" /> that represents creating a one-dimensional array and initializing it from a list of elements.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewArrayExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayInit" /> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> property set to the specified value.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the element type of the array.</param>
		/// <param name="initializers">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> or <paramref name="initializers" /> is null.-or-An element of <paramref name="initializers" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="initializers" /> represents a type that is not assignable to the type <paramref name="type" />.</exception>
		public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression" /> that represents creating a one-dimensional array and initializing it from a list of elements.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewArrayExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayInit" /> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> property set to the specified value.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the element type of the array.</param>
		/// <param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> or <paramref name="initializers" /> is null.-or-An element of <paramref name="initializers" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="initializers" /> represents a type that is not assignable to the type that <paramref name="type" /> represents.</exception>
		public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression" /> that represents creating an array that has a specified rank.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewArrayExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayBounds" /> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> property set to the specified value.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the element type of the array.</param>
		/// <param name="bounds">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> or <paramref name="bounds" /> is null.-or-An element of <paramref name="bounds" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="bounds" /> does not represent an integral type.</exception>
		public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.NewExpression" /> that represents calling the specified constructor with the specified arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New" /> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor" /> and <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> properties set to the specified values.</returns>
		/// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo" /> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor" /> property equal to.</param>
		/// <param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="constructor" /> is null.-or-An element of <paramref name="arguments" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="arguments" /> does match the number of parameters for the constructor that <paramref name="constructor" /> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="arguments" /> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor" /> represents.</exception>
		public static NewExpression New(ConstructorInfo constructor, params Expression[] arguments)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.NewExpression" /> that represents calling the specified constructor with the specified arguments.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New" /> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor" /> and <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> properties set to the specified values.</returns>
		/// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo" /> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor" /> property equal to.</param>
		/// <param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="constructor" /> is null.-or-An element of <paramref name="arguments" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="arguments" /> parameter does not contain the same number of elements as the number of parameters for the constructor that <paramref name="constructor" /> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="arguments" /> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor" /> represents.</exception>
		public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.NewExpression" /> that represents calling the specified constructor with the specified arguments. The members that access the constructor initialized fields are specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New" /> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor" />, <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> and <see cref="P:System.Linq.Expressions.NewExpression.Members" /> properties set to the specified values.</returns>
		/// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo" /> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor" /> property equal to.</param>
		/// <param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Linq.Expressions.Expression" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> collection.</param>
		/// <param name="members">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <see cref="T:System.Reflection.MemberInfo" /> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Members" /> collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="constructor" /> is null.-or-An element of <paramref name="arguments" /> is null.-or-An element of <paramref name="members" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="arguments" /> parameter does not contain the same number of elements as the number of parameters for the constructor that <paramref name="constructor" /> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of an element of <paramref name="arguments" /> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor" /> represents.-or-The <paramref name="members" /> parameter does not have the same number of elements as <paramref name="arguments" />.-or-An element of <paramref name="arguments" /> has a <see cref="P:System.Linq.Expressions.Expression.Type" /> property that represents a type that is not assignable to the type of the member that is represented by the corresponding element of <paramref name="members" />.</exception>
		public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members)
		{
			return null;
		}

		private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members)
		{
		}

		private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index)
		{
			memberType = null;
		}

		private static void ValidateConstructor(ConstructorInfo constructor, string paramName)
		{
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ParameterExpression" /> node that can be used to identify a parameter or a variable in an expression tree.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ParameterExpression" /> node with the specified name and type.</returns>
		/// <param name="type">The type of the parameter or variable.</param>
		public static ParameterExpression Parameter(Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ParameterExpression" /> node that can be used to identify a parameter or a variable in an expression tree.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ParameterExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Parameter" /> and the <see cref="P:System.Linq.Expressions.Expression.Type" /> and <see cref="P:System.Linq.Expressions.ParameterExpression.Name" /> properties set to the specified values.</returns>
		/// <param name="type">The type of the parameter or variable.</param>
		/// <param name="name">The name of the parameter or variable, used for debugging or printing purpose only.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.</exception>
		public static ParameterExpression Parameter(Type type, string name)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.ParameterExpression" /> node that can be used to identify a parameter or a variable in an expression tree.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.ParameterExpression" /> node with the specified name and type.</returns>
		/// <param name="type">The type of the parameter or variable.</param>
		/// <param name="name">The name of the parameter or variable. This name is used for debugging or printing purpose only.</param>
		public static ParameterExpression Variable(Type type, string name)
		{
			return null;
		}

		private static void Validate(Type type, bool allowByRef)
		{
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.TryExpression" /> representing a try block with a finally block and no catch statements.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.TryExpression" />.</returns>
		/// <param name="body">The body of the try block.</param>
		/// <param name="finally">The body of the finally block.</param>
		public static TryExpression TryFinally(Expression body, Expression @finally)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.TryExpression" /> representing a try block with the specified elements.</summary>
		/// <returns>The created <see cref="T:System.Linq.Expressions.TryExpression" />.</returns>
		/// <param name="type">The result type of the try expression. If null, bodh and all handlers must have identical type.</param>
		/// <param name="body">The body of the try block.</param>
		/// <param name="finally">The body of the finally block. Pass null if the try block has no finally block associated with it.</param>
		/// <param name="fault">The body of the fault block. Pass null if the try block has no fault block associated with it.</param>
		/// <param name="handlers">A collection of <see cref="T:System.Linq.Expressions.CatchBlock" />s representing the catch statements to be associated with the try block.</param>
		public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers)
		{
			return null;
		}

		private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers)
		{
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.TypeBinaryExpression" />.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.TypeBinaryExpression" /> for which the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property is equal to <see cref="F:System.Linq.Expressions.ExpressionType.TypeIs" /> and for which the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression" /> and <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand" /> properties are set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression" /> property equal to.</param>
		/// <param name="type">A <see cref="P:System.Linq.Expressions.Expression.Type" /> to set the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="type" /> is null.</exception>
		public static TypeBinaryExpression TypeIs(Expression expression, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.TypeBinaryExpression" /> that compares run-time type identity.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.TypeBinaryExpression" /> for which the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property is equal to <see cref="M:System.Linq.Expressions.Expression.TypeEqual(System.Linq.Expressions.Expression,System.Type)" /> and for which the <see cref="T:System.Linq.Expressions.Expression" /> and <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand" /> properties are set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="T:System.Linq.Expressions.Expression" /> property equal to.</param>
		/// <param name="type">A <see cref="P:System.Linq.Expressions.Expression.Type" /> to set the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand" /> property equal to.</param>
		public static TypeBinaryExpression TypeEqual(Expression expression, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" />, given an operand, by calling the appropriate factory method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.UnaryExpression" /> that results from calling the appropriate factory method.</returns>
		/// <param name="unaryType">The <see cref="T:System.Linq.Expressions.ExpressionType" /> that specifies the type of unary operation.</param>
		/// <param name="operand">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the operand.</param>
		/// <param name="type">The <see cref="T:System.Type" /> that specifies the type to be converted to (pass null if not applicable).</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="operand" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="unaryType" /> does not correspond to a unary expression node.</exception>
		public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" />, given an operand and implementing method, by calling the appropriate factory method.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.UnaryExpression" /> that results from calling the appropriate factory method.</returns>
		/// <param name="unaryType">The <see cref="T:System.Linq.Expressions.ExpressionType" /> that specifies the type of unary operation.</param>
		/// <param name="operand">An <see cref="T:System.Linq.Expressions.Expression" /> that represents the operand.</param>
		/// <param name="type">The <see cref="T:System.Type" /> that specifies the type to be converted to (pass null if not applicable).</param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="operand" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="unaryType" /> does not correspond to a unary expression node.</exception>
		public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an arithmetic negation operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Negate" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property set to the specified value.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The unary minus operator is not defined for <paramref name="expression" />.Type.</exception>
		public static UnaryExpression Negate(Expression expression)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an arithmetic negation operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Negate" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the unary minus operator is not defined for <paramref name="expression" />.Type.-or-<paramref name="expression" />.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method" />.</exception>
		public static UnaryExpression Negate(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a unary plus operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.UnaryPlus" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the unary plus operator is not defined for <paramref name="expression" />.Type.-or-<paramref name="expression" />.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method" />.</exception>
		public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an arithmetic negation operation that has overflow checking.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NegateChecked" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property set to the specified value.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The unary minus operator is not defined for <paramref name="expression" />.Type.</exception>
		public static UnaryExpression NegateChecked(Expression expression)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an arithmetic negation operation that has overflow checking. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NegateChecked" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the unary minus operator is not defined for <paramref name="expression" />.Type.-or-<paramref name="expression" />.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method" />.</exception>
		public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a bitwise complement operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Not" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property set to the specified value.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The unary not operator is not defined for <paramref name="expression" />.Type.</exception>
		public static UnaryExpression Not(Expression expression)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a bitwise complement operation. The implementing method can be specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Not" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="method" /> is null and the unary not operator is not defined for <paramref name="expression" />.Type.-or-<paramref name="expression" />.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method" />.</exception>
		public static UnaryExpression Not(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Returns whether the expression evaluates to false.</summary>
		/// <returns>An instance of <see cref="T:System.Linq.Expressions.UnaryExpression" />.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to evaluate.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression IsFalse(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Returns whether the expression evaluates to true.</summary>
		/// <returns>An instance of <see cref="T:System.Linq.Expressions.UnaryExpression" />.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to evaluate.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression IsTrue(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Returns the expression representing the ones complement.</summary>
		/// <returns>An instance of <see cref="T:System.Linq.Expressions.UnaryExpression" />.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" />.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression OnesComplement(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an explicit reference or boxing conversion where null is supplied if the conversion fails.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.TypeAs" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.Expression.Type" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="type" /> is null.</exception>
		public static UnaryExpression TypeAs(Expression expression, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an explicit unboxing.</summary>
		/// <returns>An instance of <see cref="T:System.Linq.Expressions.UnaryExpression" />.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to unbox.</param>
		/// <param name="type">The new <see cref="T:System.Type" /> of the expression.</param>
		public static UnaryExpression Unbox(Expression expression, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a type conversion operation.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Convert" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.Expression.Type" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="type" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression" />.Type and <paramref name="type" />.</exception>
		public static UnaryExpression Convert(Expression expression, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a conversion operation for which the implementing method is specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Convert" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" />, <see cref="P:System.Linq.Expressions.Expression.Type" />, and <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="type" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression" />.Type and <paramref name="type" />.-or-<paramref name="expression" />.Type is not assignable to the argument type of the method represented by <paramref name="method" />.-or-The return type of the method represented by <paramref name="method" /> is not assignable to <paramref name="type" />.-or-<paramref name="expression" />.Type or <paramref name="type" /> is a nullable value type and the corresponding non-nullable value type does not equal the argument type or the return type, respectively, of the method represented by <paramref name="method" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method that matches the <paramref name="method" /> description was found.</exception>
		public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a conversion operation that throws an exception if the target type is overflowed.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ConvertChecked" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> and <see cref="P:System.Linq.Expressions.Expression.Type" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="type" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression" />.Type and <paramref name="type" />.</exception>
		public static UnaryExpression ConvertChecked(Expression expression, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a conversion operation that throws an exception if the target type is overflowed and for which the implementing method is specified.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ConvertChecked" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" />, <see cref="P:System.Linq.Expressions.Expression.Type" />, and <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> properties set to the specified values.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <param name="type">A <see cref="T:System.Type" /> to set the <see cref="P:System.Linq.Expressions.Expression.Type" /> property equal to.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> or <paramref name="type" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception>
		/// <exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression" />.Type and <paramref name="type" />.-or-<paramref name="expression" />.Type is not assignable to the argument type of the method represented by <paramref name="method" />.-or-The return type of the method represented by <paramref name="method" /> is not assignable to <paramref name="type" />.-or-<paramref name="expression" />.Type or <paramref name="type" /> is a nullable value type and the corresponding non-nullable value type does not equal the argument type or the return type, respectively, of the method represented by <paramref name="method" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method that matches the <paramref name="method" /> description was found.</exception>
		public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an expression for obtaining the length of a one-dimensional array.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ArrayLength" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to <paramref name="array" />.</returns>
		/// <param name="array">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" />.Type does not represent an array type.</exception>
		public static UnaryExpression ArrayLength(Expression array)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents an expression that has a constant value of type <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType" /> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Quote" /> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property set to the specified value.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property equal to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="expression" /> is null.</exception>
		public static UnaryExpression Quote(Expression expression)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents a throwing of an exception with a given type.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the exception.</returns>
		/// <param name="value">An <see cref="T:System.Linq.Expressions.Expression" />.</param>
		/// <param name="type">The new <see cref="T:System.Type" /> of the expression.</param>
		public static UnaryExpression Throw(Expression value, Type type)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the incrementing of the expression by 1.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the incremented expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to increment.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression Increment(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the decrementing of the expression by 1.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the decremented expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to decrement.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression Decrement(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that increments the expression by 1 and assigns the result back to the expression.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the resultant expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to apply the operations on.</param>
		public static UnaryExpression PreIncrementAssign(Expression expression)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that increments the expression by 1 and assigns the result back to the expression.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the resultant expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to apply the operations on.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that decrements the expression by 1 and assigns the result back to the expression.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the resultant expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to apply the operations on.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the assignment of the expression followed by a subsequent increment by 1 of the original expression.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the resultant expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to apply the operations on.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the assignment of the expression followed by a subsequent decrement by 1 of the original expression.</summary>
		/// <returns>A <see cref="T:System.Linq.Expressions.UnaryExpression" /> that represents the resultant expression.</returns>
		/// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression" /> to apply the operations on.</param>
		/// <param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</param>
		public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method)
		{
			return null;
		}
	}
	/// <summary>Represents a strongly typed lambda expression as a data structure in the form of an expression tree. This class cannot be inherited.</summary>
	/// <typeparam name="TDelegate">The type of the delegate that the <see cref="T:System.Linq.Expressions.Expression`1" /> represents.</typeparam>
	public class Expression<TDelegate> : LambdaExpression
	{
		internal sealed override Type TypeCore => null;

		internal override Type PublicType => null;

		internal Expression(Expression body)
			: base(null)
		{
		}

		/// <summary>Compiles the lambda expression described by the expression tree into executable code and produces a delegate that represents the lambda expression.</summary>
		/// <returns>A delegate of type <paramref name="TDelegate" /> that represents the compiled lambda expression described by the <see cref="T:System.Linq.Expressions.Expression`1" />.</returns>
		public new TDelegate Compile()
		{
			return default(TDelegate);
		}

		public new TDelegate Compile(bool preferInterpretation)
		{
			return default(TDelegate);
		}

		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
