using System;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class PredefinedTypeFacts
	{
		private sealed class PredefinedTypeInfo
		{
			public readonly string Name;

			public readonly FUNDTYPE FundType;

			public readonly Type AssociatedSystemType;

			internal PredefinedTypeInfo(PredefinedType type, Type associatedSystemType, string name, FUNDTYPE fundType)
			{
			}

			internal PredefinedTypeInfo(PredefinedType type, Type associatedSystemType, string name)
			{
			}
		}

		private static readonly PredefinedTypeInfo[] s_types;

		private static readonly Dictionary<string, PredefinedType> s_typesByName;

		internal static FUNDTYPE GetFundType(PredefinedType type)
		{
			return default(FUNDTYPE);
		}

		internal static Type GetAssociatedSystemType(PredefinedType type)
		{
			return null;
		}

		internal static bool IsSimpleType(PredefinedType type)
		{
			return false;
		}

		internal static bool IsNumericType(PredefinedType type)
		{
			return false;
		}

		internal static string GetNiceName(PredefinedType type)
		{
			return null;
		}

		public static PredefinedType TryGetPredefTypeIndex(string name)
		{
			return default(PredefinedType);
		}

		private static Dictionary<string, PredefinedType> CreatePredefinedTypeFacts()
		{
			return null;
		}
	}
}
