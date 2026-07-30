using System;

namespace UnityEngine.UIElements
{
	internal interface IStylePainter
	{
		void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint);

		void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);

		void DrawImmediate(Action callback, bool cullingEnabled);
	}
}
