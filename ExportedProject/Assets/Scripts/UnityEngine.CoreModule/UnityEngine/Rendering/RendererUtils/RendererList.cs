using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering.RendererUtils
{
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/RendererList.h")]
	public struct RendererList
	{
		internal UIntPtr context;

		internal uint index;

		internal uint frame;

		public static readonly RendererList nullRendererList;

		public bool isValid => false;

		internal RendererList(UIntPtr ctx, uint indx)
		{
			context = (UIntPtr)0u;
			index = 0u;
			frame = 0u;
		}

		[SpecialName]
		private static bool get_isValid_Injected(ref RendererList _unity_self)
		{
			return false;
		}
	}
}
