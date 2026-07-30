using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public abstract class UxmlTraits
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CcanHaveAnyAttribute_003Ek__BackingField;

		protected bool canHaveAnyAttribute
		{
			[CompilerGenerated]
			set
			{
				_003CcanHaveAnyAttribute_003Ek__BackingField = value;
			}
		}

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}
}
