using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ContextMenu : Attribute
	{
		public readonly string menuItem;

		public readonly bool validate;

		public readonly int priority;

		public ContextMenu(string itemName)
		{
		}

		public ContextMenu(string itemName, bool isValidateFunction)
		{
		}

		public ContextMenu(string itemName, bool isValidateFunction, int priority)
		{
		}
	}
}
