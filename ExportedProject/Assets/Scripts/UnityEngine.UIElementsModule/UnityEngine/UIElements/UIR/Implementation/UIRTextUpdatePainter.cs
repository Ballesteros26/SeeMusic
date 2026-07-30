using System;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR.Implementation
{
	internal class UIRTextUpdatePainter : IStylePainter, IDisposable
	{
		private VisualElement m_CurrentElement;

		private int m_TextEntryIndex;

		private NativeArray<Vertex> m_DudVerts;

		private NativeArray<ushort> m_DudIndices;

		private NativeSlice<Vertex> m_MeshDataVerts;

		private Color32 m_XFormClipPages;

		private Color32 m_IDs;

		private Color32 m_Flags;

		private Color32 m_OpacityColorPages;

		public MeshGenerationContext meshGenerationContext { get; }

		public void Begin(VisualElement ve, UIRenderDevice device)
		{
		}

		public void End()
		{
		}

		public void Dispose()
		{
		}

		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		public void DrawImmediate(Action callback, bool cullingEnabled)
		{
		}

		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}
	}
}
