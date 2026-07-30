using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class Operators
	{
		private sealed class OperatorInfo
		{
			public readonly TokenKind TokenKind;

			public readonly PredefinedName MethodName;

			public readonly ExpressionKind ExpressionKind;

			public OperatorInfo(TokenKind kind, PredefinedName pn, ExpressionKind e)
			{
			}
		}

		private static readonly OperatorInfo[] s_operatorInfos;

		private static Dictionary<Name, string> s_operatorsByName;

		private static Dictionary<Name, string> GetOperatorByName()
		{
			return null;
		}

		private static OperatorInfo GetInfo(OperatorKind op)
		{
			return null;
		}

		public static string OperatorOfMethodName(Name name)
		{
			return null;
		}

		public static string GetDisplayName(OperatorKind op)
		{
			return null;
		}

		public static ExpressionKind GetExpressionKind(OperatorKind op)
		{
			return default(ExpressionKind);
		}
	}
}
