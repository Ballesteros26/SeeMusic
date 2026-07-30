using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
	internal class CustomEventData : IDisposable
	{
		[NonSerialized]
		internal IntPtr m_Ptr;

		public CustomEventData(string name)
		{
		}

		~CustomEventData()
		{
		}

		private void Destroy()
		{
		}

		public void Dispose()
		{
		}

		internal static IntPtr Internal_Create(CustomEventData ced, string name)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		internal static void Internal_Destroy(IntPtr ptr)
		{
		}

		public bool AddString(string key, string value)
		{
			return false;
		}

		public bool AddInt32(string key, int value)
		{
			return false;
		}

		public bool AddUInt32(string key, uint value)
		{
			return false;
		}

		public bool AddInt64(string key, long value)
		{
			return false;
		}

		public bool AddUInt64(string key, ulong value)
		{
			return false;
		}

		public bool AddBool(string key, bool value)
		{
			return false;
		}

		public bool AddDouble(string key, double value)
		{
			return false;
		}

		public bool AddDictionary(IDictionary<string, object> eventData)
		{
			return false;
		}
	}
}
