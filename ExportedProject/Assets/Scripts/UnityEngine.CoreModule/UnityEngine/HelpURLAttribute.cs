using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[UsedByNativeCode]
	public class HelpURLAttribute : Attribute
	{
		internal readonly string m_Url;

		internal readonly bool m_Dispatcher;

		internal readonly string m_DispatchingFieldName;

		public string URL => null;

		public HelpURLAttribute(string url)
		{
		}
	}
}
