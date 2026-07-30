using ForieroEngine.Settings;
using UnityEngine;

[SettingsManager]
public class ForieroDebug : Settings<ForieroDebug>, ISettingsProvider
{
	[Header("Debug")]
	public bool debug;

	[Header("General")]
	public bool general;

	[Header("Player")]
	public bool player;

	[Header("Languages")]
	public bool languages;

	[Header("Purchases")]
	public bool inAppPurchases;

	[Header("UI")]
	public bool ui;

	[Header("Camera")]
	public bool camera;

	[Header("Physics 2D")]
	public bool gameViewColliders2D;

	[Header("Level Design")]
	public bool interactive;

	public bool environment;

	[Header("Code")]
	public bool codePerformance;

	[Header("Graphics")]
	public bool rendering;

	public bool vfx;

	[Header("Audio")]
	public bool audio;

	public bool fmod;

	public bool wwise;

	[Header("Platforms")]
	public bool steam;

	public bool appleAppStore;

	public static bool Debug
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool General
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Player
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Languages
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool InAppPurchases
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool UI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Camera
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool GameViewColliders2D
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Interactive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Environment
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool CodePerformance
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Rendering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool VFX
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Audio
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool FMOD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool WWise
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool STEAM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool AppleAppStore
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void InitBefore()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void InitAfter()
	{
	}
}
