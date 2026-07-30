using System.Collections.Generic;
using System.Dynamic;

namespace System.Linq.Expressions.Compiler
{
	internal static class DelegateHelpers
	{
		internal class TypeInfo
		{
			public Type DelegateType;

			public Dictionary<Type, TypeInfo> TypeChain;
		}

		public delegate object VBCallSiteDelegate0<T>(T callSite, object instance);

		public delegate object VBCallSiteDelegate1<T>(T callSite, object instance, ref object arg1);

		public delegate object VBCallSiteDelegate2<T>(T callSite, object instance, ref object arg1, ref object arg2);

		public delegate object VBCallSiteDelegate3<T>(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3);

		public delegate object VBCallSiteDelegate4<T>(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4);

		public delegate object VBCallSiteDelegate5<T>(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5);

		public delegate object VBCallSiteDelegate6<T>(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6);

		public delegate object VBCallSiteDelegate7<T>(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, ref object arg7);

		private static TypeInfo _DelegateCache;

		private static TypeInfo NextTypeInfo(Type initialArg, TypeInfo curTypeInfo)
		{
			return null;
		}

		private static Type TryMakeVBStyledCallSite(Type[] types)
		{
			return null;
		}

		internal static Type MakeNewDelegate(Type[] types)
		{
			return null;
		}

		internal static Type GetFuncType(Type[] types)
		{
			return null;
		}

		internal static Type GetActionType(Type[] types)
		{
			return null;
		}

		internal static Type MakeDeferredSiteDelegate(DynamicMetaObject[] args, Type returnType)
		{
			return null;
		}

		private static bool IsByRef(DynamicMetaObject mo)
		{
			return false;
		}

		private static Type MakeNewCustomDelegate(Type[] types)
		{
			return null;
		}
	}
}
