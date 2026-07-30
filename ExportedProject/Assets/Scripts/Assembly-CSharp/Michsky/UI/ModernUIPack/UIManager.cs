using TMPro;
using UnityEngine;

namespace Michsky.UI.ModernUIPack
{
	[CreateAssetMenu(fileName = "New UI Manager", menuName = "Modern UI Pack/New UI Manager")]
	public class UIManager : ScriptableObject
	{
		public enum AONLGDBLEIC
		{
			BASIC = 0,
			CUSTOM = 1
		}

		public enum HDHENDFIMBC
		{
			BASIC = 0,
			CUSTOM = 1
		}

		public enum FIBFIJEOIPI
		{
			FADING = 0,
			SLIDING = 1,
			STYLISH = 2
		}

		public enum OEGKOCCFOHB
		{
			BASIC = 0,
			CUSTOM = 1
		}

		public enum FMBCEANHFFB
		{
			BASIC = 0,
			CUSTOM = 1
		}

		public enum ECDANJBGOJP
		{
			BASIC = 0,
			CUSTOM = 1
		}

		public enum AFKBMINAGIE
		{
			BASIC = 0,
			CUSTOM = 1
		}

		[HideInInspector]
		public bool enableDynamicUpdate;

		[HideInInspector]
		public bool enableExtendedColorPicker;

		[HideInInspector]
		public bool editorHints;

		public Color animatedIconColor;

		public AONLGDBLEIC buttonThemeType;

		public TMP_FontAsset buttonFont;

		public float buttonFontSize;

		public Color buttonBorderColor;

		public Color buttonFilledColor;

		public Color buttonTextBasicColor;

		public Color buttonTextColor;

		public Color buttonTextHighlightedColor;

		public Color buttonIconBasicColor;

		public Color buttonIconColor;

		public Color buttonIconHighlightedColor;

		public TMP_FontAsset dropdownItemFont;

		public HDHENDFIMBC dropdownThemeType;

		public FIBFIJEOIPI dropdownAnimationType;

		public TMP_FontAsset dropdownFont;

		public Color dropdownColor;

		public Color dropdownTextColor;

		public Color dropdownIconColor;

		public Color dropdownItemColor;

		public Color dropdownItemTextColor;

		public Color dropdownItemIconColor;

		public TMP_FontAsset selectorFont;

		public Color selectorColor;

		public Color selectorHighlightedColor;

		public bool hSelectorInvertAnimation;

		public bool hSelectorLoopSelection;

		public TMP_FontAsset inputFieldFont;

		public Color inputFieldColor;

		public TMP_FontAsset modalWindowTitleFont;

		public TMP_FontAsset modalWindowContentFont;

		public HDHENDFIMBC modalThemeType;

		public Color modalWindowTitleColor;

		public Color modalWindowDescriptionColor;

		public Color modalWindowIconColor;

		public Color modalWindowBackgroundColor;

		public Color modalWindowContentPanelColor;

		public TMP_FontAsset notificationTitleFont;

		public TMP_FontAsset notificationDescriptionFont;

		public FMBCEANHFFB notificationThemeType;

		public Color notificationBackgroundColor;

		public Color notificationTitleColor;

		public Color notificationDescriptionColor;

		public Color notificationIconColor;

		public TMP_FontAsset progressBarLabelFont;

		public Color progressBarColor;

		public Color progressBarBackgroundColor;

		public Color progressBarLoopBackgroundColor;

		public Color progressBarLabelColor;

		public Color scrollbarColor;

		public Color scrollbarBackgroundColor;

		public TMP_FontAsset sliderLabelFont;

		public ECDANJBGOJP sliderThemeType;

		public Color sliderColor;

		public Color sliderBackgroundColor;

		public Color sliderLabelColor;

		public Color sliderPopupLabelColor;

		public Color sliderHandleColor;

		public Color switchBorderColor;

		public Color switchBackgroundColor;

		public Color switchHandleOnColor;

		public Color switchHandleOffColor;

		public TMP_FontAsset toggleFont;

		public AFKBMINAGIE toggleThemeType;

		public Color toggleTextColor;

		public Color toggleBorderColor;

		public Color toggleBackgroundColor;

		public Color toggleCheckColor;

		public TMP_FontAsset tooltipFont;

		public Color tooltipTextColor;

		public Color tooltipBackgroundColor;
	}
}
