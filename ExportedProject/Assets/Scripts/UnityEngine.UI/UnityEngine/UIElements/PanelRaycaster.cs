using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
	public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
		private struct FloatIntBits
		{
			[FieldOffset(0)]
			public float f;

			[FieldOffset(0)]
			public int i;
		}

		private BaseRuntimePanel m_Panel;

		public IPanel panel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private GameObject selectableGameObject => null;

		public override int sortOrderPriority => 0;

		public override int renderOrderPriority => 0;

		public override Camera eventCamera => null;

		private void RegisterCallbacks()
		{
		}

		private void UnregisterCallbacks()
		{
		}

		private void OnPanelDestroyed()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private static int ConvertFloatBitsToInt(float f)
		{
			return 0;
		}
	}
}
