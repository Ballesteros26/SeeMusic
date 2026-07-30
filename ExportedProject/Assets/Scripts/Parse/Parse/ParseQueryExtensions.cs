using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Parse
{
	public static class ParseQueryExtensions
	{
		private class ObjectNormalizer : ExpressionVisitor
		{
			protected override Expression VisitIndex(IndexExpression node)
			{
				return null;
			}

			protected override Expression VisitMember(MemberExpression node)
			{
				return null;
			}

			protected override Expression VisitUnary(UnaryExpression node)
			{
				return null;
			}

			protected override Expression VisitMethodCall(MethodCallExpression node)
			{
				return null;
			}
		}

		private class WhereNormalizer : ExpressionVisitor
		{
			protected override Expression VisitBinary(BinaryExpression node)
			{
				return null;
			}

			protected override Expression VisitUnary(UnaryExpression node)
			{
				return null;
			}

			protected override Expression VisitMethodCall(MethodCallExpression node)
			{
				return null;
			}
		}

		private static readonly MethodInfo getMethod;

		private static readonly MethodInfo stringContains;

		private static readonly MethodInfo stringStartsWith;

		private static readonly MethodInfo stringEndsWith;

		private static readonly MethodInfo containsMethod;

		private static readonly MethodInfo notContainsMethod;

		private static readonly MethodInfo containsKeyMethod;

		private static readonly MethodInfo notContainsKeyMethod;

		private static readonly Dictionary<MethodInfo, MethodInfo> functionMappings;

		static ParseQueryExtensions()
		{
		}

		private static MethodInfo GetMethod<T>(Expression<Action<T>> expression)
		{
			return null;
		}

		private static bool ContainsStub<T>(object collection, T value)
		{
			return false;
		}

		private static bool NotContainsStub<T>(object collection, T value)
		{
			return false;
		}

		private static bool ContainsKeyStub(ParseObject obj, string key)
		{
			return false;
		}

		private static bool NotContainsKeyStub(ParseObject obj, string key)
		{
			return false;
		}

		private static object GetValue(Expression exp)
		{
			return null;
		}

		private static bool IsParseObjectGet(MethodCallExpression node)
		{
			return false;
		}

		private static ParseQuery<T> WhereMethodCall<T>(this ParseQuery<T> source, Expression<Func<T, bool>> expression, MethodCallExpression node) where T : ParseObject
		{
			return null;
		}

		private static ParseQuery<T> WhereBinaryExpression<T>(this ParseQuery<T> source, Expression<Func<T, bool>> expression, BinaryExpression node) where T : ParseObject
		{
			return null;
		}

		public static ParseQuery<TSource> Where<TSource>(this ParseQuery<TSource> source, Expression<Func<TSource, bool>> predicate) where TSource : ParseObject
		{
			return null;
		}

		private static string GetOrderByPath<TSource, TSelector>(Expression<Func<TSource, TSelector>> keySelector)
		{
			return null;
		}

		public static ParseQuery<TSource> OrderBy<TSource, TSelector>(this ParseQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : ParseObject
		{
			return null;
		}

		public static ParseQuery<TSource> OrderByDescending<TSource, TSelector>(this ParseQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : ParseObject
		{
			return null;
		}

		public static ParseQuery<TSource> ThenBy<TSource, TSelector>(this ParseQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : ParseObject
		{
			return null;
		}

		public static ParseQuery<TSource> ThenByDescending<TSource, TSelector>(this ParseQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : ParseObject
		{
			return null;
		}

		public static ParseQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParseQuery<TOuter> outer, ParseQuery<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector) where TOuter : ParseObject where TInner : ParseObject where TResult : ParseObject
		{
			return null;
		}
	}
}
