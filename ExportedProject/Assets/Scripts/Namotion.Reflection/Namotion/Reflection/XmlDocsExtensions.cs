using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Namotion.Reflection
{
	public static class XmlDocsExtensions
	{
		private static readonly ConcurrentDictionary<string, CachingXDocument?> Cache;

		private static readonly char[] ToXmlDocsContentTrimChars;

		private static readonly char[] RemoveLineBreakWhiteSpacesTrimChars;

		private static readonly Regex LineBreakRegex;

		private static readonly Regex runtimeConfigRegex;

		public static string GetXmlDocsSummary(this CachedType type, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsTag(this CachedType type, string tagName, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsTag(this ContextualMemberInfo member, string tagName, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsSummary(this Type type, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsTag(this Type type, string tagName, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsSummary(this MemberInfo member, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static XElement? GetXmlDocsElement(this MemberInfo member, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static XElement GetXmlDocsElement(this MemberInfo member, string pathToXmlFile, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsTag(this MemberInfo member, string tagName, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string GetXmlDocsRecordPropertySummary(this PropertyInfo member, XmlDocsOptions? options = null)
		{
			return null;
		}

		public static string? ToXmlDocsContent(this XElement? element, XmlDocsOptions? options = null)
		{
			return null;
		}

		private static CachingXDocument? TryGetXmlDocsDocument(AssemblyName assemblyName, string? pathToXmlFile, bool resolveExternalXmlDocs)
		{
			return null;
		}

		private static bool IsAssemblyIgnored(AssemblyName assemblyName, bool resolveExternalXmlDocs)
		{
			return false;
		}

		private static XElement GetXmlDocsElement(this MemberInfo member, CachingXDocument xml)
		{
			return null;
		}

		private static void ReplaceInheritdocElements(this MemberInfo member, XElement? element, XmlDocsOptions options)
		{
		}

		private static void ProcessInheritdocInterfaceElements(this MemberInfo member, XElement child, XmlDocsOptions options)
		{
		}

		private static string RemoveLineBreakWhiteSpaces(string? documentation)
		{
			return null;
		}

		internal static string GetMemberElementName(dynamic member)
		{
			return null;
		}

		public static string? GetXmlDocsPath(Assembly? assembly, XmlDocsOptions options)
		{
			return null;
		}

		private static void ProcessInheritDocTypeElements(this MemberInfo member, XElement child, XmlDocsOptions options)
		{
		}

		private static Type GetTypeByXmlDocTypeName(string xmlDocTypeName, Assembly assembly)
		{
			return null;
		}

		private static string NormalizeTypeName(string typeName)
		{
			return null;
		}

		private static string? GetPathByOs(dynamic? assembly, AssemblyName assemblyName)
		{
			return null;
		}

		private static string GetXmlDocsPathFromNuGetCacheOrDotNetSdk(string assemblyDirectory, AssemblyName assemblyName)
		{
			return null;
		}

		private static string GetXmlDocsPathFromNuGetCacheFile(string nuGetCacheFile, AssemblyName assemblyName)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string GetCacheKey(string assemblyFullName, bool resolveExternalXmlDocs)
		{
			return null;
		}
	}
}
