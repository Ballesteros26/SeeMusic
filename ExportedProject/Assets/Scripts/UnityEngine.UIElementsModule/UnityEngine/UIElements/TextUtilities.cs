using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal static class TextUtilities
	{
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			return 0f;
		}

		internal static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, ITextHandle textHandle)
		{
			return default(Vector2);
		}

		internal static FontAsset GetFontAsset(MeshGenerationContextUtils.TextParams textParam)
		{
			return null;
		}

		internal static FontAsset GetFontAsset(VisualElement ve)
		{
			return null;
		}

		internal static Font GetFont(MeshGenerationContextUtils.TextParams textParam)
		{
			return null;
		}

		internal static Font GetFont(VisualElement ve)
		{
			return null;
		}

		internal static bool IsFontAssigned(VisualElement ve)
		{
			return false;
		}

		internal static bool IsFontAssigned(MeshGenerationContextUtils.TextParams textParams)
		{
			return false;
		}

		internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve)
		{
			return null;
		}

		internal static PanelTextSettings GetTextSettingsFrom(MeshGenerationContextUtils.TextParams textParam)
		{
			return null;
		}

		internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve)
		{
			return default(TextCoreSettings);
		}
	}
}
