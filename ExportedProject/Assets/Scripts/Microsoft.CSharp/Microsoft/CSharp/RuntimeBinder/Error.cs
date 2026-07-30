using System;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal static class Error
	{
		internal static Exception InternalCompilerError()
		{
			return null;
		}

		internal static Exception BindPropertyFailedMethodGroup(object p0)
		{
			return null;
		}

		internal static Exception BindPropertyFailedEvent(object p0)
		{
			return null;
		}

		internal static Exception BindInvokeFailedNonDelegate()
		{
			return null;
		}

		internal static Exception BindStaticRequiresType(string paramName)
		{
			return null;
		}

		internal static Exception NullReferenceOnMemberException()
		{
			return null;
		}

		internal static Exception BindCallToConditionalMethod(object p0)
		{
			return null;
		}

		internal static Exception BindToVoidMethodButExpectResult()
		{
			return null;
		}

		internal static Exception ArgumentNull(string paramName)
		{
			return null;
		}

		internal static Exception DynamicArgumentNeedsValue(string paramName)
		{
			return null;
		}
	}
}
