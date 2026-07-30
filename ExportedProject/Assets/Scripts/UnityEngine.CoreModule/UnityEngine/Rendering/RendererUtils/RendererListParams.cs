using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RendererUtils
{
	internal struct RendererListParams
	{
		private static readonly ShaderTagId s_EmptyName;

		public static readonly RendererListParams nullRendererList;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CisValid_003Ek__BackingField;

		internal CullingResults cullingResult;

		internal DrawingSettings drawSettings;

		internal FilteringSettings filteringSettings;

		internal RenderStateBlock? stateBlock;

		private bool isValid
		{
			[CompilerGenerated]
			set
			{
				_003CisValid_003Ek__BackingField = value;
			}
		}

		internal static RendererListParams Create(in RendererListDesc desc)
		{
			return default(RendererListParams);
		}
	}
}
