using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal class FSharpUtils
	{
		private static readonly object Lock;

		private static FSharpUtils? _instance;

		private MethodInfo _ofSeq;

		private Type _mapType;

		[CompilerGenerated]
		private Assembly _003CFSharpCoreAssembly_003Ek__BackingField;

		public static FSharpUtils Instance => null;

		private Assembly FSharpCoreAssembly
		{
			[CompilerGenerated]
			set
			{
				_003CFSharpCoreAssembly_003Ek__BackingField = value;
			}
		}

		public MethodCall<object?, object> IsUnion { get; private set; }

		public MethodCall<object?, object> GetUnionCases { get; private set; }

		public MethodCall<object?, object> PreComputeUnionTagReader { get; private set; }

		public MethodCall<object?, object> PreComputeUnionReader { get; private set; }

		public MethodCall<object?, object> PreComputeUnionConstructor { get; private set; }

		public Func<object, object> GetUnionCaseInfoDeclaringType { get; private set; }

		public Func<object, object> GetUnionCaseInfoName { get; private set; }

		public Func<object, object> GetUnionCaseInfoTag { get; private set; }

		public MethodCall<object, object?> GetUnionCaseInfoFields { get; private set; }

		private FSharpUtils(Assembly fsharpCoreAssembly)
		{
		}

		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
		}

		private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags)
		{
			return null;
		}

		private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName)
		{
			return null;
		}

		public ObjectConstructor<object> CreateSeq(Type t)
		{
			return null;
		}

		public ObjectConstructor<object> CreateMap(Type keyType, Type valueType)
		{
			return null;
		}

		public ObjectConstructor<object?>? BuildMapCreator<TKey, TValue>()
		{
			return null;
		}
	}
}
