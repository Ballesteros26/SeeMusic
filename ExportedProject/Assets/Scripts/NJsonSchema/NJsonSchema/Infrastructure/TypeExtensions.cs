using System;
using System.Collections.Generic;
using System.Threading;
using NJsonSchema.Generation;
using Namotion.Reflection;

namespace NJsonSchema.Infrastructure
{
	public static class TypeExtensions
	{
		private static ReaderWriterLockSlim _namesLock;

		private static Dictionary<ContextualMemberInfo, string> _names;

		internal static string GetName(this ContextualAccessorInfo accessorInfo)
		{
			return null;
		}

		private static string GetNameWithoutCache(ContextualAccessorInfo accessorInfo)
		{
			return null;
		}

		public static string GetDescription(this CachedType type, IXmlDocsSettings xmlDocsSettings)
		{
			return null;
		}

		public static string GetDescription(this ContextualAccessorInfo accessorInfo, IXmlDocsSettings xmlDocsSettings)
		{
			return null;
		}

		private static string GetDescription(IEnumerable<Attribute> attributes)
		{
			return null;
		}
	}
}
