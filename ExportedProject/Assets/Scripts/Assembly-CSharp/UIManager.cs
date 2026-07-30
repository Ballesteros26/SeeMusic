using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ImaginationOverflow.UniversalFileAssociation.Data;
using RenderHeads.Media.AVProVideo;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;
using VideoKit.Assets;

public class UIManager : MonoBehaviour
{
	public enum JMPHNIJFGNI
	{
		DragEnd = 0,
		Move = 1,
		Add = 2,
		Default = 3
	}

	private sealed class MOLLCAEELCL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public MOLLCAEELCL(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class EIEADDKLAMI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		private string _003CscreenshotFilename_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public EIEADDKLAMI(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class NHGJMHHPNNI
	{
		public UIManager _003C_003E4__this;

		public float timeWaitStarted;

		internal bool GEFIFKFACGO()
		{
			return false;
		}

		internal void OMJEJAPMFGC()
		{
		}

		internal void JOGLEPDJJMK()
		{
		}

		internal void IOAKMKMJDED()
		{
		}

		internal bool DGLMFHEFDPF()
		{
			return false;
		}
	}

	private sealed class FCPKIKHADDL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		private NHGJMHHPNNI _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public FCPKIKHADDL(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class KJAAJGIKDGP
	{
		public float timeWaitStarted;

		public UIManager _003C_003E4__this;

		internal bool JDLKMDJAADJ()
		{
			return false;
		}
	}

	private sealed class PNNEODHECEN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public PNNEODHECEN(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class LLFDECDAJMF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public LLFDECDAJMF(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class JIMMDHNIGNH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public JIMMDHNIGNH(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class CAICHHLNJFN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public CAICHHLNJFN(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private sealed class JMOCAICNKAL
	{
		public UIManager _003C_003E4__this;

		public string singlefile;

		internal void PJAHBDBFBBM()
		{
		}
	}

	private sealed class AMBCBDOLFBP
	{
		public UIManager _003C_003E4__this;

		public string savePath;

		internal void MJKIAFFNMCK()
		{
		}
	}

	private sealed class HNDLKLCBDBI
	{
		public UIManager _003C_003E4__this;

		public string savePath;

		internal void PHNBALAEEGJ()
		{
		}
	}

	private sealed class IGEBGBBPBEN
	{
		public UIManager _003C_003E4__this;

		public string path;

		public bool alert;

		public bool assignToMIDI;

		public bool assignToAudio;

		public bool assignToVideo;

		public bool assignToBackground;

		public bool assignToSoundfont;

		public bool assignToSaberVideo;

		public bool assignToNoteTexture;

		public bool assignIfPossible;

		public FileInformation fileActivated;

		public string filename;

		internal void LJHEMAANBJG()
		{
		}

		internal void DDCGNHNHOKN()
		{
		}

		internal void INDJKLNOONP()
		{
		}
	}

	private sealed class HDIMFDOKNPJ
	{
		public UIManager _003C_003E4__this;

		public string path;

		public bool alert;

		public bool assignToMIDI;

		public bool assignToAudio;

		public bool assignToVideo;

		public bool assignToBackground;

		public bool assignToSoundfont;

		public bool assignToSaberVideo;

		public bool assignToNoteTexture;

		public bool assignIfPossible;

		public FileInformation fileActivated;

		public string filename;

		internal void AFHAFBECEMA()
		{
		}

		internal void IHKHLPPMJEC()
		{
		}

		internal void OPMJAEJPAAP()
		{
		}

		internal void OJFPCHMMLKP()
		{
		}
	}

	private sealed class NOMJBOJPNPB
	{
		public UIManager _003C_003E4__this;

		public string newNameWithExtension;

		public string fileType;

		internal void ADKCIGKGNHL()
		{
		}

		internal void OJEGOMOMNMH()
		{
		}

		internal void DMLKILGJCFP()
		{
		}

		internal void FIILGBGCOAF()
		{
		}

		internal void CELEKHCFOIO()
		{
		}

		internal void CJMNDBAHKIK()
		{
		}

		internal void NCILINIOLAH()
		{
		}

		internal void FDIGEJNCKOE()
		{
		}

		internal void EEJJKJOMBGP()
		{
		}
	}

	private sealed class KDPOJEKDNOO
	{
		public UIManager _003C_003E4__this;

		public string type;

		public string filename;

		internal void KJOBCKBHOHL()
		{
		}

		internal void DKPBHAFIDFM()
		{
		}

		internal void PGPHPOLIHPN()
		{
		}

		internal void HEBKJIDHJIN()
		{
		}

		internal void DLKPLKBCMNE()
		{
		}

		internal void LGIKJFAJDON()
		{
		}

		internal void LGOJFEIHHEL()
		{
		}

		internal void NCCFDHKJLFO()
		{
		}
	}

	private static UIManager JOHCOGCAEAK;

	[CompilerGenerated]
	private static UIManager _003CHOLNFGBMPDC_003Ek__BackingField;

	public SceneSingleton SceneSingleton;

	public Account Account;

	public MIDIControl MIDIControl;

	public NoteAnimation NoteAnimation;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public Background Background;

	public LiveCamera LiveCamera;

	public NoteOperations NoteOperations;

	public BarAnimation BarAnimation;

	public Preferences Preferences;

	public GameObject SettingsCanvas;

	public CanvasScaler SettingsCanvasScaler;

	public GameObject TooltipManagerObject;

	public GameObject TooltipObject;

	public GameObject MainCamera;

	public CreateVideo CreateVideo;

	public GameObject CreateVideoParentPanel;

	public SaveUI SaveUI;

	public GameObject SaveUIPanel;

	public ResetSettings ResetSettings;

	public GameObject ResetSettingsPanel;

	public HelpClass HelpClass;

	public GameObject HelpParentPanel;

	public Subscription Subscription;

	public GameObject SubscriptionParentPanel;

	public GameObject SettingsColorTabPanel;

	public SettingsColor SettingsColor;

	public GameObject SettingsVisualTabPanel;

	public SettingsVisual SettingsVisual;

	public GameObject SettingsPieceTabPanel;

	public SettingsPiece SettingsPiece;

	public GameObject SettingsPlayerTabPanel;

	public SettingsPlayer SettingsPlayer;

	public GameObject SettingsInputTabPanel;

	public SettingsInput SettingsInput;

	public GameObject SettingsAdvancedTabPanel;

	public SettingsAdvanced SettingsAdvanced;

	public GameObject SettingsIndicatorPanel;

	public SettingsIndicator SettingsIndicator;

	public GameObject SettingsPanel;

	public SettingsPanelClass SettingsPanelClass;

	public Wizard Wizard;

	public GameObject MIDIEditorButtons;

	public EditorButtons EditorButtons;

	public GameObject MenuPanel;

	public Menu Menu;

	public GameObject SplashPanel;

	public NoteSettings NoteSettings;

	public GameObject NoteSettingsPanel;

	public KeyboardSettings KeyboardSettings;

	public GameObject KeyboardSettingsPanel;

	public LightSettings LightSettings;

	public GameObject LightSettingsPanel;

	public ParticleSettings ParticleSettings;

	public GameObject ParticleSettingsPanel;

	public MIDISettingsClass MIDISettingsClass;

	public GameObject MIDISettingsPanel;

	public AudioSettingsClass AudioSettingsClass;

	public GameObject AudioSettingsPanel;

	public VideoSettings VideoSettings;

	public GameObject VideoSettingsPanel;

	public Syncer Syncer;

	public GameObject SyncerPanel;

	public GlowSettings GlowSettings;

	public GameObject GlowSettingsPanel;

	public SaberSettings SaberSettings;

	public GameObject SaberSettingsPanel;

	public NoteTextureSettings NoteTextureSettings;

	public GameObject NoteTextureSettingsPanel;

	public CameraSettings CameraSettings;

	public GameObject CameraSettingsPanel;

	public BackgroundSettings BackgroundSettings;

	public GameObject BackgroundSettingsPanel;

	public SpecialAlert SpecialAlert;

	public GameObject SpecialAlertPanel;

	public GameObject KWindow;

	public ModalWindowAlert ModalWindowAlert;

	public GameObject ModalWindowAlertPanel;

	public ModalWindowCheckboxAlert ModalWindowCheckboxAlert;

	public GameObject ModalWindowCheckboxAlertPanel;

	public ModalWindowRecordSettings ModalWindowRecordSettings;

	public GameObject ModalWindowRecordSettingsPanel;

	public ModalWindowScrollSelection ModalWindowScrollSelection;

	public GameObject ModalWindowScrollSelectionPanel;

	public ModalWindowTutorial ModalWindowTutorial;

	public GameObject ModalWindowTutorialPanel;

	public DynamicSettingsPanelClass DynamicSettingsPanelClass;

	public GameObject DynamicSettingsPanel;

	public PresetGallery PresetGallery;

	public GameObject PresetGalleryPanel;

	public VideoPlayer performanceVideoPlayer;

	public GameObject performanceVideoObject;

	public GameObject performanceVideoContainer;

	public GameObject performanceVideoUI;

	public GameObject noteTexture;

	public VideoPlayer noteTexturePlayer;

	public MediaPlayer performanceMediaPlayer;

	public MediaPlayer saberMediaPlayer;

	public MediaPlayer textureMediaPlayer;

	public Texture2D overlayTexture;

	public ParticleSystem emitterSystem;

	public ParticleSystem streakletEmitterSystem;

	public ParticleSystem smokeEmitterSystem;

	public GameObject Letterbox;

	public GameObject LetterboxTop;

	public GameObject LetterboxBottom;

	[NonSerialized]
	public Texture2D saberTexture;

	public Material LiveCameraMaterial;

	public Canvas CameraCanvas;

	public GameObject keyboardSaber;

	public VideoPlayer keyboardSaberPlayer;

	public MeshRenderer keyboardSaberRenderer;

	public SpriteRenderer SaberRealtimeRenderer;

	public SpriteRenderer SaberRealtimeAdditiveRenderer;

	public SpriteRenderer SaberRealtimeAdditive2Renderer;

	public TMP_FontAsset openSansRegular;

	public TMP_FontAsset openSansSemibold;

	public TMP_FontAsset verdanaBold;

	[NonSerialized]
	public string saveFilesDirectory;

	[NonSerialized]
	public string saveFilesPath;

	[NonSerialized]
	public string preferencesDirectory;

	[NonSerialized]
	public string preferencesPath;

	[NonSerialized]
	public string defaultPreferencesDirectory;

	[NonSerialized]
	public string defaultPreferencesPath;

	[NonSerialized]
	public string settingsSaveDirectory;

	[NonSerialized]
	public string settingsSavePath;

	[NonSerialized]
	public string audioFilesDirectory;

	[NonSerialized]
	public string audioFilesPath;

	[NonSerialized]
	public string MIDIFilesDirectory;

	[NonSerialized]
	public string MIDIFilesPath;

	[NonSerialized]
	public string MIDIUndoDirectory;

	[NonSerialized]
	public string MIDIUndoPath;

	[NonSerialized]
	public string videoFilesDirectory;

	[NonSerialized]
	public string videoFilesPath;

	[NonSerialized]
	public string saberVideoFilesDirectory;

	[NonSerialized]
	public string saberVideoFilesPath;

	[NonSerialized]
	public string noteTextureFilesDirectory;

	[NonSerialized]
	public string noteTextureFilesPath;

	[NonSerialized]
	public string soundfontDirectory;

	[NonSerialized]
	public string soundfontPath;

	[NonSerialized]
	public string imageFilesDirectory;

	[NonSerialized]
	public string imageFilesPath;

	[NonSerialized]
	public string screenshotsDirectory;

	[NonSerialized]
	public string screenshotsPath;

	[NonSerialized]
	public string backgroundFilesDirectory;

	[NonSerialized]
	public string backgroundFilesPath;

	[NonSerialized]
	public string PresetDirectory;

	[NonSerialized]
	public string PresetPath;

	[NonSerialized]
	public string PresetNoteDirectory;

	[NonSerialized]
	public string PresetNotePath;

	[NonSerialized]
	public string PresetParticleDirectory;

	[NonSerialized]
	public string PresetParticlePath;

	[NonSerialized]
	public string PresetSaberDirectory;

	[NonSerialized]
	public string PresetSaberPath;

	[NonSerialized]
	public string PresetNoteSampleDirectory;

	[NonSerialized]
	public string PresetNoteSamplePath;

	[NonSerialized]
	public string PresetParticleSampleDirectory;

	[NonSerialized]
	public string PresetParticleSamplePath;

	[NonSerialized]
	public string PresetSaberSampleDirectory;

	[NonSerialized]
	public string PresetSaberSamplePath;

	[NonSerialized]
	public string sampleSaveFilesDirectory;

	[NonSerialized]
	public string sampleSaveFilesPath;

	[NonSerialized]
	public string sampleAudioFilesDirectory;

	[NonSerialized]
	public string sampleAudioFilesPath;

	[NonSerialized]
	public string sampleMIDIFilesDirectory;

	[NonSerialized]
	public string sampleMIDIFilesPath;

	[NonSerialized]
	public string sampleVideoFilesDirectory;

	[NonSerialized]
	public string sampleVideoFilesPath;

	[NonSerialized]
	public string sampleSaberVideoFilesDirectory;

	[NonSerialized]
	public string sampleSaberVideoFilesPath;

	[NonSerialized]
	public string sampleNoteTextureFilesDirectory;

	[NonSerialized]
	public string sampleNoteTextureFilesPath;

	[NonSerialized]
	public string sampleSoundfontDirectory;

	[NonSerialized]
	public string sampleSoundfontPath;

	[NonSerialized]
	public string saveExtension;

	[NonSerialized]
	public string settingsSaveExtension;

	public SeeMusicCellView SeeMusicCellViewPreFab;

	public List<int> selectedPieceRows;

	public SeeMusicPiece pieceToCopy;

	[NonSerialized]
	public bool shuffleOn;

	[NonSerialized]
	public List<int> shufflePlayedTracks;

	[NonSerialized]
	public int loopState;

	[NonSerialized]
	public bool wasPlaying;

	[NonSerialized]
	public int skipPieceStartPoint;

	[NonSerialized]
	public bool firstSkip;

	public GameObject InSceneFPS;

	public GameObject cameraView;

	public GameObject cameraViewPanel;

	public GameObject AVProCameraPanel;

	public Canvas backgroundCanvas;

	public GameObject AspectGuide;

	[NonSerialized]
	public float inactiveButtonAlpha;

	[NonSerialized]
	public float inactiveRecordButtonAlpha;

	public Sprite playButtonSprite;

	public Sprite pauseButtonSprite;

	public Sprite playButtonSpriteDesktop;

	public Sprite pauseButtonSpriteDesktop;

	public Sprite playButtonSpriteFlat;

	public Sprite pauseButtonSpriteFlat;

	public Sprite playSprite;

	public Sprite pauseSprite;

	public Sprite settingsSprite;

	[NonSerialized]
	public bool SettingsPanelOpen;

	[NonSerialized]
	public bool WizardOpen;

	[NonSerialized]
	public bool SettingsIndicatorOpen;

	[NonSerialized]
	private float EHHENKNJFOK;

	public Color UIBlueColor;

	public Color ParticlesIconColor;

	public Color UIBlueColorBright;

	public Color UIBlueColorText;

	public Color UIGreenColor;

	public Color deselectedGray;

	[NonSerialized]
	private bool MCDABCJEKFG;

	public GameObject WatermarkContainer;

	public TextMeshPro watermarkPrimaryText;

	[NonSerialized]
	public bool seeking;

	public List<GameObject> UndoButtons;

	public List<GameObject> RedoButtons;

	[NonSerialized]
	public bool IsDraggingNote;

	[NonSerialized]
	public bool IsSelectingNotes;

	[NonSerialized]
	public string[] pitchLabels;

	[NonSerialized]
	public string[] whiteKeys;

	public float lastCreateVideoProgressUpdate;

	private bool OOFKGPKCNCC;

	private bool OGHAIMJBFBO;

	public List<float> framerateHistory;

	public float avgFrameRate;

	public int under40Counter;

	private Texture2D KGIEDCEDJHF;

	private Rect GFBMPKNPIFP;

	private bool JLANJOGHDOG;

	private RenderTexture OEKMPOJBJOO;

	public Camera ScreenshotCamera;

	public DateTime LastScreenshotTime;

	private bool DIOBKFFKAEG;

	private string IINHOGEAMDD;

	private bool AMGJDMEJDNN;

	public float recordButtonAlpha;

	private float BPJBJLFIMKF;

	[NonSerialized]
	public bool VideoRecordingComplete;

	[NonSerialized]
	public string VideoRecordingPath;

	public string lastOpenTab;

	[NonSerialized]
	public bool unreachableTimeAlertCalled;

	[NonSerialized]
	public bool unreachableTimeWarningCalled;

	public BANBCCOCAED keyLabels;

	[NonSerialized]
	private Color[] EKFIHNKDGNG;

	[NonSerialized]
	private float[] LEMIOCBOBFE;

	[NonSerialized]
	private float KDIDBBCCMPI;

	[NonSerialized]
	private int NGKENNDMCDL;

	[NonSerialized]
	private float OGBFNOFDHAI;

	private float MHOFONMFCJD;

	private float AOEIBOIKGAL;

	[NonSerialized]
	public bool keyboardSaberFrameIsReady;

	[NonSerialized]
	public bool keyboardSaberSeekCompleted;

	[NonSerialized]
	public bool keyboardSaberStarted;

	[NonSerialized]
	public int keyboardSaberFrame;

	[NonSerialized]
	public bool videoTextureFrameIsReady;

	[NonSerialized]
	public bool videoTextureSeekCompleted;

	[NonSerialized]
	public bool videoTextureStarted;

	[NonSerialized]
	public int videoTextureFrame;

	[NonSerialized]
	public bool backgroundVideoFrameIsReady;

	[NonSerialized]
	public bool backgroundVideoSeekCompleted;

	[NonSerialized]
	public bool backgroundVideoStarted;

	public GameObject postProcessingObject;

	public Volume postProcessVolume;

	public float performanceVideoAspect;

	public float previousCropTop;

	public string[] AndroidImportMIMETypes;

	public string[] AndroidMIMEMIDI;

	public string[] AndroidMIMEAudio;

	public string[] AndroidMIMEVideo;

	public string[] iOSImportUTITypes;

	public string[] iOSUTIMIDI;

	public string[] iOSUTIAudio;

	public string[] iOSUTIVideo;

	[NonSerialized]
	public string nativeGalleryImportType;

	[NonSerialized]
	private bool JOACJFDMPEH;

	[NonSerialized]
	private bool DONEMINJMIB;

	[NonSerialized]
	private bool PPFEAKNCFEO;

	[NonSerialized]
	private bool AOMAANEKMMP;

	[NonSerialized]
	private bool DJJIJHOJINF;

	[NonSerialized]
	private bool AENPOGFBJAI;

	[NonSerialized]
	private bool GHNHAABGPEM;

	[NonSerialized]
	private bool KBFPKOOKGLL;

	[NonSerialized]
	private bool INOCNOOPGGP;

	[NonSerialized]
	private string GCGPGINNOAL;

	[NonSerialized]
	public string OpenFileAsyncFunction;

	[NonSerialized]
	public string SaveFileAsyncFunction;

	[NonSerialized]
	private string GPMOCLFLDCH;

	public GameObject EditorBackground;

	[NonSerialized]
	public float EditorInterfaceTop;

	public MeshRenderer performanceVideoRenderer;

	[NonSerialized]
	public float EditorInterfacePixelHeight;

	public Texture2D CursorDragEndsTexture;

	public Texture2D CursorDragEndsHorizontalTexture;

	public Texture2D CursorMoveTexture;

	public Texture2D CursorAddTexture;

	public Texture2D CursorDragEndsTextureRetina;

	public Texture2D CursorDragEndsHorizontalTextureRetina;

	public Texture2D CursorMoveTextureRetina;

	public Texture2D CursorAddTextureRetina;

	[NonSerialized]
	public CursorMode cursorMode;

	public GameObject EditorTimeBar;

	public static UIManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void ImportBackgroundAction()
	{
	}

	public void OpenModalScrollerWindow(List<MGFGDCEJHGB> LFOBOIFOLHH, bool LLGMBHPMOEG = true, bool HBLNDJEBAOJ = false, bool CIGABDAEDIM = false, bool IHOEKCGEOCC = false, bool CABAPFKLOCM = true, bool JMKPILPEHFM = false, TextAnchor FANBCPIJMAK = TextAnchor.MiddleCenter)
	{
	}

	public void UpdateMIDIEditorInterfaceTop()
	{
	}

	public void UpdateEditorTimeBar(bool LBEFNNPNJGI = true)
	{
	}

	public void LCEHGMLLHJO()
	{
	}

	public void UpdateSoundButtons()
	{
	}

	[CompilerGenerated]
	private void HMLAKLFHGID()
	{
	}

	public void NoteTextureSettingsButtonAction()
	{
	}

	public void UpdateMIDIEditorInterfacePosition()
	{
	}

	public void ImportAudioAction()
	{
	}

	public void SettingsTabButtonAction(string LFCHLGMAPLH)
	{
	}

	public void SaveFileScrollerRowSelected(int JCLFGKNOCFE)
	{
	}

	public void HEMGDCINEEE()
	{
	}

	public string TimeToMinutesSecondsPrecision(float CCKIOGLFDBF)
	{
		return null;
	}

	public void InstallHEVC2()
	{
	}

	public void SaberMasterSwitchAction()
	{
	}

	public string MinutesFromTime(float CCKIOGLFDBF)
	{
		return null;
	}

	public void VideoSettingsButtonAction()
	{
	}

	[CompilerGenerated]
	private void OLGEDEGHCOF()
	{
	}

	public void ResetNoteTextureSettings()
	{
	}

	public void ResetRenderStartEndTime()
	{
	}

	public string OGLPOKBLGIH(string GBFPDDEHPIN)
	{
		return null;
	}

	public void BHOOEGODCIA()
	{
	}

	private void PEKHEINMLAA()
	{
	}

	public void OpenSaveUIPanel()
	{
	}

	public void EIEKKHFPFPN(int AOCGNPPGDCO)
	{
	}

	public void SetRecordTypeButtonColors()
	{
	}

	public void OpenPresetGallery()
	{
	}

	public void CheckTextInputMaxMinTMP(TMP_InputField IJOIDANBHJJ, float NFAKKADEDBC, float IEAPNAGOCPL)
	{
	}

	public void CheckRedrawDynamicSettings()
	{
	}

	public void MGHMNCDMOGP()
	{
	}

	public void UpdateBackgroundMode(bool DGBOJHBJHBA = false)
	{
	}

	public void VideoTutorialsButtonAction()
	{
	}

	public void UpdatePitchLabels()
	{
	}

	public void segmentedControlHandler(string DJPDEGLFOGE, int AOCGNPPGDCO)
	{
	}

	public void AddFiles(bool BJCFOEHOHHB = true, bool OIIIPFPPLAL = true, bool FGHHPKJPJOA = true, bool AMONIHODNAG = true, bool FEGIPENPJDG = true, bool JCLKNAKBLEK = true, bool OCHJIAFAAPF = true, bool APDLCHDELGA = false, bool HBNEOHAAMCD = false, bool LCIOJBLOPIP = false, bool CNIKCPLFADP = false, bool ODMEHODKFIG = false, bool EJCDPKEMKEH = false, bool GIJEIGBNHIN = false, bool PABFCPAGHCN = false, bool AJIIHOCPMIB = false, string HJJGPMHKOIE = "")
	{
	}

	public void LBIAAHLCFBF()
	{
	}

	public void ToggleNoteTextureButtonAction()
	{
	}

	public void AddVideoFileMobile(string IAFFKBDJKCF)
	{
	}

	public void MIDISettingsButtonAction(string OPFLFMNLGED)
	{
	}

	public void OpenSubscriptionPanel(bool NDHIMDHIAPN = false, bool MKAAOACNIDN = false)
	{
	}

	public void ReplayTrack()
	{
	}

	public void PauseVisualizationButtonAction()
	{
	}

	private void EOFBGJHGCIM()
	{
	}

	public void ToggleCameraView()
	{
	}

	public void UnreachableTimeWarning()
	{
	}

	[IteratorStateMachine(typeof(PNNEODHECEN))]
	public IEnumerator ToggleRecording()
	{
		return null;
	}

	public void FAQButtonAction()
	{
	}

	public void ChangeTrackAudioTo(string AFPLMHLDKOI)
	{
	}

	public void ImportMIDIAction()
	{
	}

	public void ChangeTrackMIDITo(string BCHBPLFBEEF)
	{
	}

	public void LHELJLJPGIH(bool JMKPILPEHFM, bool BBCOIKEHNGB, bool EGPLAOHDIMI, bool LLGMBHPMOEG, bool HBLNDJEBAOJ, bool CIGABDAEDIM, bool CABAPFKLOCM)
	{
	}

	public bool EAOKJFALNAH()
	{
		return false;
	}

	public void DeleteFilesButtonAction()
	{
	}

	[CompilerGenerated]
	private void CHDINPPILBJ()
	{
	}

	[CompilerGenerated]
	private void KNOKGIIMAJL()
	{
	}

	public void ToggleVFXEmittersOn(bool LGHPBGOECJI = false)
	{
	}

	[CompilerGenerated]
	private void ONPFMFMCOPL()
	{
	}

	public void LOBDOPGJOPN()
	{
	}

	[CompilerGenerated]
	private void LLCEBHMFBGG()
	{
	}

	public void UpdateKey()
	{
	}

	public void PBKNHOPLDDO(bool DIPPIMKFJNO, string HNELMLGEBEM, string[] OEBOFPFDCND)
	{
	}

	[CompilerGenerated]
	private void IIINFGKBEIA()
	{
	}

	public void EADDLLKEECF()
	{
	}

	public void KeyButtonAction()
	{
	}

	public void HNDEPEDEOJI(string KAKOPBCJDIK, string JCAOLMALNPI)
	{
	}

	public void CloseBackgroundSettings()
	{
	}

	public void HideTransformBoxes()
	{
	}

	public void ChangeAccidentalsTo(string FIHNPNFLIGM)
	{
	}

	public void ChangeQualityTo(string FKDHHGIJLNP)
	{
	}

	[CompilerGenerated]
	private void MLGPIGFNDCC()
	{
	}

	[CompilerGenerated]
	private void ILEDNHMBLLF()
	{
	}

	private void MJAIIKGJOND()
	{
	}

	public void ResendConfirmationEmail()
	{
	}

	public void SetControls()
	{
	}

	public void NewPiece(string LOIHBMKNJLB, string NIGKFNJDMIJ = "", string POCLOGKIJDI = "", string EOFNOHHNKBC = "", string IFHDICLHNCJ = "", string BPNFAMACKBA = "")
	{
	}

	private void BBHJNBGCADE(string CGPCLCFOCCC)
	{
	}

	[CompilerGenerated]
	private void LBBFGANILOJ()
	{
	}

	public void ABMJMCCKCOO(bool AIFHGNOJNJP = true)
	{
	}

	public void InstallHEVC()
	{
	}

	public void CloseOpenWindows()
	{
	}

	public void LPBHGJODPKG()
	{
	}

	public void HelpButtonTapped()
	{
	}

	public void LoadSampleControlAction(int AOCGNPPGDCO)
	{
	}

	public void LightSettingsButtonAction()
	{
	}

	public void UnassignMIDI()
	{
	}

	public void ScrollerRowSelected(int JCLFGKNOCFE, string IPBBKFHJJBK)
	{
	}

	public void ParticleSettingsButtonAction()
	{
	}

	private void PNPLHDPFHMM()
	{
	}

	public void OpenKWindow()
	{
	}

	[CompilerGenerated]
	private void HNKPOAJALGK()
	{
	}

	public float GetCanvasScaleFactor()
	{
		return 0f;
	}

	public string checkCharacters(string GBFPDDEHPIN)
	{
		return null;
	}

	public void OpenSpecialAlertWindow(bool JMKPILPEHFM, bool DDALNOAOIBE, bool LLGMBHPMOEG, bool HBLNDJEBAOJ, bool CIGABDAEDIM, bool CABAPFKLOCM, float GMFLDCFDCKP = 18f)
	{
	}

	private void CCBALKJFAOL()
	{
	}

	public void EnableEffects()
	{
	}

	[CompilerGenerated]
	private void KAEFBDFMLKG()
	{
	}

	private void EMJNIENMLEF()
	{
	}

	public string TimeToMinutesSeconds(float CCKIOGLFDBF)
	{
		return null;
	}

	[CompilerGenerated]
	private void KHKEAIODKKM()
	{
	}

	public Color BalanceColor(Color OLJIIPPOIHN)
	{
		return default(Color);
	}

	public void ImportVideoAction()
	{
	}

	[CompilerGenerated]
	private void KDMAEIFNELH()
	{
	}

	public void CreateSaberSettingsDynamic()
	{
	}

	[CompilerGenerated]
	private void NFOCJHANFFF()
	{
	}

	[CompilerGenerated]
	private void FDAEIPGJNMO()
	{
	}

	private void PBNDOLCNDNJ()
	{
	}

	public void PNJHDLGMJNA(string AFPLMHLDKOI)
	{
	}

	public void ToggleVideoTransformBox()
	{
	}

	public void HPJBPNMCNOL()
	{
	}

	[CompilerGenerated]
	private void PAHHHKGFFAD()
	{
	}

	public void DeleteMediaFiles(bool JHEIPNDHFPE, bool LOHNHOOEICO, bool EOCDCPOEHJK)
	{
	}

	public void HideSettingsIndicator()
	{
	}

	public void CloseLightSettings()
	{
	}

	public void OpenHelp(bool EAFHKLOOKCB = false)
	{
	}

	public string CopyFileToLibrary(string LNMDPMBMJBI, bool PABFCPAGHCN = true, bool APDLCHDELGA = false, bool HBNEOHAAMCD = false, bool LCIOJBLOPIP = false, bool CNIKCPLFADP = false, bool ODMEHODKFIG = false, bool EJCDPKEMKEH = false, bool GIJEIGBNHIN = false, bool AJIIHOCPMIB = false, FileInformation IDOBLGEGBOL = null, string HJJGPMHKOIE = "", string OMKOADDLAMJ = "")
	{
		return null;
	}

	public void LIJCHHPCEMG()
	{
	}

	public void AccidentalsButtonAction()
	{
	}

	public void RecordButtonAction()
	{
	}

	public void ShareFilesAfterOpen(string LNMDPMBMJBI)
	{
	}

	[IteratorStateMachine(typeof(FCPKIKHADDL))]
	public IEnumerator CheckDateTime()
	{
		return null;
	}

	public Texture2D GenerateGradient(Color[] DEOAGNNKDGH, TextureWrapMode INILKNBDLDE = TextureWrapMode.Clamp, FilterMode HEAPABAEJKM = FilterMode.Point, bool HDIGMDKEIGM = false, bool NMPOHNOLIAD = false, float BBBOEPIDMHK = 500f, bool LLEONEGIPAM = false, int IONHNFBPJIO = -1, float PIMCNNNHDMC = -1f, float[] MOMGJFAOOJE = null)
	{
		return null;
	}

	private void JCMFBPPOMFG()
	{
	}

	public void UIModeControlAction(int AOCGNPPGDCO)
	{
	}

	public void CloseNoteSettings()
	{
	}

	public void AudioMobileAssignCallback(string OHKMPBJLIHH)
	{
	}

	public void CloseMenuPanelReturnToScene()
	{
	}

	public void RecordVideoButtonAction()
	{
	}

	[CompilerGenerated]
	private void FEBJHIHOLIB()
	{
	}

	public void AudioSoundOnButtonAction()
	{
	}

	public void ClosePresetGallery()
	{
	}

	public float GetVideoScaleY()
	{
		return 0f;
	}

	public void ResetNoteSettings()
	{
	}

	public bool RenderTransparentImpossible()
	{
		return false;
	}

	public void SettingsIndicatorTapped()
	{
	}

	public void AICJFFOJAEJ()
	{
	}

	[CompilerGenerated]
	private void GADABKGLGCL()
	{
	}

	public void UpdateVideoFrame()
	{
	}

	public void AddFilesButtonAction()
	{
	}

	public void ImportNoteTextureAction()
	{
	}

	[CompilerGenerated]
	private void LEAKGFLEKNI()
	{
	}

	[CompilerGenerated]
	private void IIDKPIECMKC()
	{
	}

	public void UnreachableTimeAlert(bool HHGCPIEKLPP = false)
	{
	}

	public void ChangeTrackVideoTo(string BAICIFCGHIO)
	{
	}

	public void GPUParticlesOnAlert(bool LGHPBGOECJI = false)
	{
	}

	public void CloseSaveUIPanel()
	{
	}

	public void CheckAlignContainer()
	{
	}

	public bool WillRecordVideo()
	{
		return false;
	}

	public void ExportFile(string PDCFIGMAIKA)
	{
	}

	[CompilerGenerated]
	private void PDEEECBPJBJ()
	{
	}

	public void KeyboardPresetButtonAction(int DKMMMGABJNC)
	{
	}

	public void PauseVisualization()
	{
	}

	public float GetSquareDistAtAngle(float GHJDPOPELNL)
	{
		return 0f;
	}

	public void RecordingCompleteAlert()
	{
	}

	[CompilerGenerated]
	private void PABLBFBCKHL()
	{
	}

	public void CloseMenuPanel(bool PFGDKGDCJNF = false)
	{
	}

	public void AskForVideoFileType(string LNMDPMBMJBI, bool PABFCPAGHCN = true, bool APDLCHDELGA = false, bool HBNEOHAAMCD = false, bool LCIOJBLOPIP = false, bool CNIKCPLFADP = false, bool ODMEHODKFIG = false, bool EJCDPKEMKEH = false, bool GIJEIGBNHIN = false, bool AJIIHOCPMIB = false, FileInformation IDOBLGEGBOL = null, string OMKOADDLAMJ = "")
	{
	}

	public void ResetVideoTimeSettings()
	{
	}

	public void AspectGuideControlAction(int AOCGNPPGDCO)
	{
	}

	public void UpdateUIControls()
	{
	}

	public void FDKNLNMPHLF()
	{
	}

	public Texture2D GenerateSolidTexture(Color HAHLIHPAMIJ)
	{
		return null;
	}

	public void KeyboardSaberFrameReady(VideoPlayer KIKPMNCJDFF, long PBPICCABKEL)
	{
	}

	public void SupportForumButtonAction()
	{
	}

	public void MoveAndRenameRenderFileMobile()
	{
	}

	public void BalanceColors()
	{
	}

	public void HKDEEABHIJI()
	{
	}

	public void EMEPHNEBOBA()
	{
	}

	public void NIMEKOACPMI()
	{
	}

	private void HDFPHFAAHHL()
	{
	}

	private void LJEMOKLHDIH()
	{
	}

	public void ShowSettingsIndicator()
	{
	}

	public void BackgroundVideoSeekCompleted(VideoPlayer KIKPMNCJDFF)
	{
	}

	[CompilerGenerated]
	private void FMIKNJLOFGD()
	{
	}

	public void FDDCNJOFCNF()
	{
	}

	public void AddMIDIFileMobile()
	{
	}

	public void VideoRecordingCompleted(MediaAsset HFMINHOFMAP)
	{
	}

	public void LightPresetButtonAction(string EEDNPPFPFJM)
	{
	}

	public void AssignImportedFile(string LNMDPMBMJBI, bool APDLCHDELGA = false, bool HBNEOHAAMCD = false, bool LCIOJBLOPIP = false, bool CNIKCPLFADP = false, bool ODMEHODKFIG = false, bool EJCDPKEMKEH = false, bool GIJEIGBNHIN = false, bool PABFCPAGHCN = false, bool AJIIHOCPMIB = false)
	{
	}

	public void CloseVideoSettings()
	{
	}

	public void PreviousTrackButtonAction()
	{
	}

	public void ImportSaberVideoAction()
	{
	}

	public void AddFilesButtonActioniOS()
	{
	}

	public void MOBPFCOOEJN(bool DGBOJHBJHBA = false)
	{
	}

	public void CloseSyncPanel()
	{
	}

	public void MIDISoundButtonAction()
	{
	}

	public void KeyboardSettingsButtonAction()
	{
	}

	public void ResetLightSettings(bool CFNLJNDAGOC = false)
	{
	}

	public void KCEAJKKEBGF()
	{
	}

	public void VideoTextureSeekCompleted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void IOLBGGJCKPC()
	{
	}

	public void PPHHDFOBKGF(string LFCHLGMAPLH)
	{
	}

	[CompilerGenerated]
	private void JFBPCPOHLOA()
	{
	}

	[CompilerGenerated]
	private void DJDEHPAEFID()
	{
	}

	private Vector3 FPILCDMGANA(RectTransform JJCJGGKNFIN, Vector2 OKAHFMJBCNN)
	{
		return default(Vector3);
	}

	public void StartVisualization()
	{
	}

	public void SetNoteGlow()
	{
	}

	[CompilerGenerated]
	private void JJHOCNABIEO()
	{
	}

	public void PickedFileMobileCallback(string OHKMPBJLIHH)
	{
	}

	public void OpenSettingsPanel(bool HNIKLKKNNBL = false)
	{
	}

	public void NextShuffleTrack()
	{
	}

	[CompilerGenerated]
	private void ENJAFHJLHLJ()
	{
	}

	public void FileAdded(string OMKOADDLAMJ, string JCAOLMALNPI, string HLGGHMOLEIK = "")
	{
	}

	public void DisableVideoMeshRenderer()
	{
	}

	public void JLPOGOAAGJC()
	{
	}

	[CompilerGenerated]
	private void DMIGCPIOMFN()
	{
	}

	public void AddFilesAfterOpen(string JLDKNFDKNDD)
	{
	}

	private void ACMINPHBNDI()
	{
	}

	public void OpenCreateVideoPanel()
	{
	}

	[CompilerGenerated]
	private void PECOBFKJGCN(bool GBEOLMNEGBA, string LNMDPMBMJBI)
	{
	}

	public void BackgroundVideoStarted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void UpdateColorUI(bool FBIHKGMFMCG = false)
	{
	}

	public List<bool> GetMinimizeList()
	{
		return null;
	}

	public void PieceScrollerRowSelected(int JCLFGKNOCFE)
	{
	}

	public void NoPieceAlert()
	{
	}

	public void ScrollTime(float HOMGJAFAICF)
	{
	}

	public void AnimateRecordButton()
	{
	}

	public void UpgradeButtonTapped()
	{
	}

	public void ShowHideMainSettingsPanel(bool KLBBCGCGNNN)
	{
	}

	[CompilerGenerated]
	private bool KIJAJPOKMNK()
	{
		return false;
	}

	public void UpdateAnimationDirection()
	{
	}

	private void GHFEDEEMCKJ()
	{
	}

	private void ENNLDNFKBIF()
	{
	}

	[IteratorStateMachine(typeof(MOLLCAEELCL))]
	public IEnumerator StartUIManager()
	{
		return null;
	}

	public void CloseDynamicSettingsAction()
	{
	}

	public void CloseSettingsPanel(bool AIFHGNOJNJP = true)
	{
	}

	public void OpenHWindow()
	{
	}

	public void ResolutionControlAction(int AOCGNPPGDCO)
	{
	}

	public void ELJPEPJMNJG()
	{
	}

	public void AddSoundfontFileAfterOpen(string LNMDPMBMJBI)
	{
	}

	public void VideoSoundOnButtonAction()
	{
	}

	[CompilerGenerated]
	private void OALDGDHJBIA()
	{
	}

	[CompilerGenerated]
	private void LKFKMHKBMDK()
	{
	}

	public void OpenFoldersCompleted(bool DIPPIMKFJNO, string HNELMLGEBEM, string[] OEBOFPFDCND)
	{
	}

	[CompilerGenerated]
	private void IPALPFKCEFB()
	{
	}

	public void ICDBHBBBNIE()
	{
	}

	public void JCDPDOAMNCO()
	{
	}

	public void PAONJBNMCEE(JMPHNIJFGNI HDAMBJMFIJH)
	{
	}

	public void CloseResetSettingsPanel()
	{
	}

	public void AddMixedMediaMobile(string IAFFKBDJKCF)
	{
	}

	public void OpenDynamicLightingSettings(string JCGMOOBKLDO, string HIBNDDLLHAG)
	{
	}

	public void ResetParticleSettings()
	{
	}

	public void MLFNEEEIKGH()
	{
	}

	public void DeleteVideoRecording()
	{
	}

	[CompilerGenerated]
	private void EFNAOCBFMLI()
	{
	}

	private void JAGCIADFPFH()
	{
	}

	public void ResetCameraSettings()
	{
	}

	private void BJHDODDFPAP()
	{
	}

	private void EIAOBDKDLBL()
	{
	}

	public void CreateNoteSettingsDynamic()
	{
	}

	public void SubscriptionUpdate()
	{
	}

	public void SaveRenderMobile()
	{
	}

	[CompilerGenerated]
	private void HEGDFOJGAAB()
	{
	}

	public void IPMPFBNPHFF(int AOCGNPPGDCO)
	{
	}

	[CompilerGenerated]
	private void NAEFDBBKAEN()
	{
	}

	private void CNNOOHPNNFA()
	{
	}

	public void OpenResetSettingsPanel()
	{
	}

	public void ChangeKeyTo(string LNIKNDOGIEO)
	{
	}

	public void ToggleAlignInterface(bool KKMPAFODEAH)
	{
	}

	public void CloseModalScrollerWindow(bool KLBBCGCGNNN = true)
	{
	}

	public void IFPNHCJFOPO()
	{
	}

	public void EJCPIDAJGDO(bool BEBIPOHAOHE = true)
	{
	}

	public void OpenMenuPanel()
	{
	}

	public void AccountButtionAction()
	{
	}

	public void NGKDPAPPLBM()
	{
	}

	public void VideoGalleryButtonAction()
	{
	}

	public void LightsMasterSwitchAction()
	{
	}

	public void CloseKeyboardSettings()
	{
	}

	public void BLJKNKJNCJB(bool ODOIAIPJDHA = false)
	{
	}

	public void CFNDLLLNEAA()
	{
	}

	public void EnableControlsAfterRecording()
	{
	}

	[CompilerGenerated]
	private void JIMMAKADEBE()
	{
	}

	public void UnassignFilesButtonAction()
	{
	}

	public void SetOverlayColor()
	{
	}

	public void BHNMEKGIAHL(bool AIFHGNOJNJP = true)
	{
	}

	public void PlayButtonAction()
	{
	}

	public void CheckTextInputMaxMin(InputField IJOIDANBHJJ, float NFAKKADEDBC, float IEAPNAGOCPL)
	{
	}

	public void AddAudioFileMobile()
	{
	}

	public void KNMDLLCHAID()
	{
	}

	public Color GetColorWithBrightness(Color EAPOBDJADGN, float PIIALKAGEAM)
	{
		return default(Color);
	}

	[CompilerGenerated]
	private void MGBLKDGEADK()
	{
	}

	public void MIDIEditorButtonAction()
	{
	}

	public void ToggleNoteTexture(bool BEBIPOHAOHE = true)
	{
	}

	public void KeyboardSaberStarted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void DisableEffects()
	{
	}

	public void OpenWizard(bool HNIKLKKNNBL = false)
	{
	}

	public void FIGMBNOHICJ()
	{
	}

	public void CloseAudioSettings()
	{
	}

	public void CBGHMOOJLMK()
	{
	}

	public void UpdateCameraView()
	{
	}

	public void CreateSaveFile(string HGOMMMNANGP)
	{
	}

	public void NotesPositionControlAction(int AOCGNPPGDCO)
	{
	}

	public void NoInternetAlert()
	{
	}

	public void MIDIAudioRecordingComplete(string KAKOPBCJDIK, string JCAOLMALNPI)
	{
	}

	private void BCNAMEFHAPD()
	{
	}

	private void LCMLPFOIONJ()
	{
	}

	public void CreateTextureSettingsDynamic()
	{
	}

	public void ShowMicPermissionsTutorialMacOS()
	{
	}

	public void Update()
	{
	}

	public void VideoFrameworkControlAction(int AOCGNPPGDCO)
	{
	}

	public void CloseNoteTextureSettings()
	{
	}

	[CompilerGenerated]
	private void IFKKLIPFLNG()
	{
	}

	[CompilerGenerated]
	private void NFGKJNJCKMA()
	{
	}

	public void HFNADBKELHF(MediaAsset HFMINHOFMAP)
	{
	}

	public void SetCursor(JMPHNIJFGNI HDAMBJMFIJH)
	{
	}

	public void LMAAEJLMPCN(bool PFGDKGDCJNF = false)
	{
	}

	public void ReloadScrollers()
	{
	}

	public void PDLGACLKAGF()
	{
	}

	[CompilerGenerated]
	private void KKDHNGJAMEC()
	{
	}

	public void OpenModalCheckboxWindow(bool JMKPILPEHFM, bool BBCOIKEHNGB, bool EGPLAOHDIMI, bool LLGMBHPMOEG, bool HBLNDJEBAOJ, bool CIGABDAEDIM, bool CABAPFKLOCM)
	{
	}

	public void SetKeyboardGradient(Color[] DEOAGNNKDGH)
	{
	}

	public void InternetRestoredAlert()
	{
	}

	public void KeyboardSaberSeekCompleted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void PMNMALFHJOK(VideoPlayer KIKPMNCJDFF, long PBPICCABKEL)
	{
	}

	[CompilerGenerated]
	private void CHGNIHDBCLC()
	{
	}

	public void DeletePiece()
	{
	}

	public void AddFilesButtonActionAndroid()
	{
	}

	public void CloseMIDISettings()
	{
	}

	public string GetPitchLabelWithKeySignature(int KHDFEOMPNOJ, CCNAJFPCGPE BHLCJBLMINB)
	{
		return null;
	}

	public void ToggleVideoSound()
	{
	}

	[IteratorStateMachine(typeof(CAICHHLNJFN))]
	public IEnumerator SetAspectAfterOneFrame()
	{
		return null;
	}

	public void ToggleBloom()
	{
	}

	public List<MGFGDCEJHGB> GetKeyScrollerData()
	{
		return null;
	}

	public void DeleteFileAlert(string GFMIKEPFCLG, string OMKOADDLAMJ)
	{
	}

	public void MBJJGHCEIDO(string LNMDPMBMJBI)
	{
	}

	public void UpdateParticleVariables()
	{
	}

	public void ShowCameraPermissionsTutorialMacOS()
	{
	}

	[CompilerGenerated]
	private void MHHAEMOAJOP()
	{
	}

	public void AEGACOBLOEB()
	{
	}

	public void NBIFKNBIOPG()
	{
	}

	[CompilerGenerated]
	private bool DMEFNMALONH()
	{
		return false;
	}

	public void KDFPHCEKDPP()
	{
	}

	public void OpenFilesCompleted(bool DIPPIMKFJNO, string JLDKNFDKNDD, string[] HJMHLCEMEHM)
	{
	}

	public void CheckPlayState()
	{
	}

	[CompilerGenerated]
	private void ACLEKHPINJI()
	{
	}

	public void NotesMasterSwitchAction()
	{
	}

	public void CreateDynamicSettingsPanel(List<List<List<object>>> LCNEAIGGDJD, string CKDLFJADACE)
	{
	}

	public void HJJIDBLKNPB()
	{
	}

	public void VideoTextureFrameReady(VideoPlayer KIKPMNCJDFF, long PBPICCABKEL)
	{
	}

	public void NIDCAJEIODK()
	{
	}

	public string SecondsFromTime(float CCKIOGLFDBF)
	{
		return null;
	}

	public void ShowEmailVerifiedAlert()
	{
	}

	public void PlayButtonTapped(bool PNMDKEKJNHF = false, bool GHPONIEFMCE = false)
	{
	}

	public void BackgroundSettingsButtonAction()
	{
	}

	public void SaberSettingsButtonAction()
	{
	}

	public void OpenModalTutorialWindow(bool JMKPILPEHFM, bool LLGMBHPMOEG, bool HBLNDJEBAOJ, bool CIGABDAEDIM, bool CABAPFKLOCM, bool KPNBPKGIAHO, float GMFLDCFDCKP = 18f, bool IHOEKCGEOCC = false, TextAnchor FANBCPIJMAK = TextAnchor.MiddleCenter, Color? JBNCPKIPPMA = null)
	{
	}

	public void FAGFENPPKNO()
	{
	}

	[IteratorStateMachine(typeof(LLFDECDAJMF))]
	public IEnumerator ContinueStartRecording()
	{
		return null;
	}

	public void SyncButtonAction()
	{
	}

	public void UpdateAnimationSpeed(float BPBFIPDNDIH, Slider HINADDIAGOI, UnityEngine.Object IJOIDANBHJJ)
	{
	}

	public void LKEKPDFLIFG(int AOCGNPPGDCO)
	{
	}

	public void NextTrackButtonAction()
	{
	}

	public void MJJFICNCECI()
	{
	}

	public void CMIGCJELAAC()
	{
	}

	[IteratorStateMachine(typeof(EIEADDKLAMI))]
	public IEnumerator TakeScreenshot()
	{
		return null;
	}

	public void OnGUI()
	{
	}

	public void CloseHelp()
	{
	}

	public void RecordSettingsSwitchAction()
	{
	}

	public void VideoTextureStarted(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void ODPJAHJCHFI(VideoPlayer KIKPMNCJDFF, long PBPICCABKEL)
	{
	}

	public Color LDFJKEHFMNK(Color OLJIIPPOIHN)
	{
		return default(Color);
	}

	public void ShareFilesButtonAction()
	{
	}

	public void MenuButtonAction()
	{
	}

	public void EditPieceName(string FLAMBHELJKM, string DLIHMMPNIJF)
	{
	}

	public void AskForImageFileType(string LNMDPMBMJBI, bool PABFCPAGHCN = true, bool APDLCHDELGA = false, bool HBNEOHAAMCD = false, bool LCIOJBLOPIP = false, bool CNIKCPLFADP = false, bool ODMEHODKFIG = false, bool EJCDPKEMKEH = false, bool GIJEIGBNHIN = false, bool AJIIHOCPMIB = false, FileInformation IDOBLGEGBOL = null, string OMKOADDLAMJ = "")
	{
	}

	public void BackgroundVideoFrameReady(VideoPlayer KIKPMNCJDFF, long PBPICCABKEL)
	{
	}

	public void VideoMicEnabledAction()
	{
	}

	public void ShowDynamicSettingsPanel()
	{
	}

	public void BKBIFGCCGKE()
	{
	}

	public void DAELLACNOGM()
	{
	}

	public void AuthorizationResult(string PNLPCLOLFGO, string LFOFEJGCAON, string DFOALGFEICP = "", string EDCDFNFGDDK = null, AggregateException IBCHKEMLLBB = null, bool GOEIIOKGLOA = false, string LNBCDKOBLOC = "")
	{
	}

	public void HIKNECHPLAJ(VideoPlayer KIKPMNCJDFF)
	{
	}

	public void MIDISoundOnButtonAction()
	{
	}

	public void SetCameraViewOrder()
	{
	}

	public Vector2 GetMouseCanvasPos()
	{
		return default(Vector2);
	}

	public void ShowSettingsPanel(bool ODOIAIPJDHA = false)
	{
	}

	[CompilerGenerated]
	private void MJMKIKGNDME()
	{
	}

	public void ShowConfirmEmailAlert()
	{
	}

	private void HAHFDJELBPD()
	{
	}

	public void CloseModalAlertWindow(bool AIFHGNOJNJP = true)
	{
	}

	public void ONGPHMIHHIG()
	{
	}

	public void RecordAudioButtonAction()
	{
	}

	public void ShowHidePreviousWindow(bool KLBBCGCGNNN)
	{
	}

	public void DeleteSaveFile()
	{
	}

	private void HNGCGHNIGAE()
	{
	}

	public void JAOHNFEOJEP()
	{
	}

	[CompilerGenerated]
	private void JEKGEEPCNIO()
	{
	}

	private void COPIBNFCBKF()
	{
	}

	public void AudioSettingsButtonAction()
	{
	}

	public void CloseSaberSettings()
	{
	}

	public void GKJPOIAFHOF(TMP_InputField IJOIDANBHJJ, float NFAKKADEDBC, float IEAPNAGOCPL)
	{
	}

	[CompilerGenerated]
	private void KPOOABOPLGM()
	{
	}

	private void NDPEIGHFIAG()
	{
	}

	public void ExportFileAfterSave(string LNMDPMBMJBI)
	{
	}

	public void GlowSettingsButtonAction()
	{
	}

	public void OBEKMHFIBCN()
	{
	}

	[CompilerGenerated]
	private void CCLFENKPLJA()
	{
	}

	public void JDEBAIDCMGB(bool KLBBCGCGNNN = true)
	{
	}

	public void ProceedWithOpenCreateVideoPanel()
	{
	}

	public void SaveFileCompleted(bool DIPPIMKFJNO, string HNELMLGEBEM)
	{
	}

	public void SetColorsByHueDiff(Color FEMGLJNGPJE)
	{
	}

	public void UnassignVideo()
	{
	}

	public void AddImageMobile()
	{
	}

	public void LFPDKNDJPFJ()
	{
	}

	private void FKCLJFDCGAF()
	{
	}

	public void QualityButtonAction()
	{
	}

	public Texture2D GenerateSaberGradient(Color[] DEOAGNNKDGH, TextureWrapMode INILKNBDLDE = TextureWrapMode.Clamp, FilterMode HEAPABAEJKM = FilterMode.Point, bool HDIGMDKEIGM = false, bool NMPOHNOLIAD = false)
	{
		return null;
	}

	[CompilerGenerated]
	private void BOCNBKLFHKJ()
	{
	}

	public void NativeGalleryFileSelectionCallback(string LNMDPMBMJBI)
	{
	}

	public void OpenModalAlertWindow(bool JMKPILPEHFM, bool MJGNBMJHOLC, bool IEPBMGGIOFJ, bool LLGMBHPMOEG, bool HBLNDJEBAOJ, bool CIGABDAEDIM, bool CABAPFKLOCM, float GMFLDCFDCKP = 18f, bool FIKNNJINFNL = false, bool IHOEKCGEOCC = false, Color? OLBKAPJLDML = null, bool IJEEHLFGDPO = false)
	{
	}

	public void ABBOKDNGAAL()
	{
	}

	public void VFXEmittersOnOff()
	{
	}

	public void UpdateCanvasScaler()
	{
	}

	public void PLGLEPOCBNC()
	{
	}

	public void FramerateControlAction(int AOCGNPPGDCO)
	{
	}

	public void EditSaveFileName(string FLAMBHELJKM)
	{
	}

	public void CloseCameraSettings()
	{
	}

	public List<MGFGDCEJHGB> GetAccidentalsScrollerData()
	{
		return null;
	}

	public void ShowMacOSRecordingPermissionsAlert()
	{
	}

	public void EBJPDDJMJIJ(string LNMDPMBMJBI)
	{
	}

	public void UpdateMIDIEditorInterface()
	{
	}

	public void ShowMicPermissionsTutorial()
	{
	}

	public void CheckSettingsCanvasActive()
	{
	}

	public bool isOverUI()
	{
		return false;
	}

	public void CloseParticleSettings()
	{
	}

	public void NotesEnabledControlAction(int AOCGNPPGDCO)
	{
	}

	public void CameraViewButtonTapped()
	{
	}

	public List<MGFGDCEJHGB> GetQualityScrollerData()
	{
		return null;
	}

	public void LCLPDLFMBOG(int AOCGNPPGDCO)
	{
	}

	public void AddVideoMobile(string IAFFKBDJKCF)
	{
	}

	public List<MGFGDCEJHGB> CNNEACNJAIN()
	{
		return null;
	}

	public void BackButtonDesktopAction()
	{
	}

	public void KBHEKBJAJKH()
	{
	}

	[CompilerGenerated]
	private void EAOENAJAMAF()
	{
	}

	public void CloseCreateVideo()
	{
	}

	public void AJFCCIOHKBJ()
	{
	}

	public void SetHelpButtonActive()
	{
	}

	public void RecordMIDIButtonAction()
	{
	}

	private void JECFCHNFPEI()
	{
	}

	public void DeleteFile(string GFMIKEPFCLG, string OMKOADDLAMJ)
	{
	}

	public void EGKHDDOGIDC()
	{
	}

	public string TimeToHoursMinutesSecondsPrecision(float CCKIOGLFDBF)
	{
		return null;
	}

	public void CloseSettingsButtonAction()
	{
	}

	public void OGMAMGEGAFJ()
	{
	}

	public void CloseSpecialAlertWindow()
	{
	}

	public void SaveNoteTextureSettingsToPreferences()
	{
	}

	public Vector2 PAPKLLGNIBC()
	{
		return default(Vector2);
	}

	public string GetFileTypeFromExtension(string MJFAFKABLMC)
	{
		return null;
	}

	[CompilerGenerated]
	private void IBIMOFJBKEC()
	{
	}

	public void AddSoundfontFile()
	{
	}

	private void Awake()
	{
	}

	public void OFGFIFDHDJF()
	{
	}

	public void UpdatePositionTopBottomFromCropTop(float MLPOGCHLKHK)
	{
	}

	public void UpdateAspectGuide()
	{
	}

	public void DisableControlsForRecording()
	{
	}

	[IteratorStateMachine(typeof(JIMMDHNIGNH))]
	public IEnumerator OpenSettingsPanelAfterOneFrame()
	{
		return null;
	}

	public void MIDIMobileAssignCallback(string OHKMPBJLIHH)
	{
	}

	public void CloseWizard()
	{
	}

	[CompilerGenerated]
	private void HKMBGPHHDMJ()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void CloseGlowSettings()
	{
	}

	public void CheckRenderTransparentBloom()
	{
	}

	public void BackgroundMasterSwitchAction()
	{
	}

	public void ScreenshotResolutionControlAction(int AOCGNPPGDCO)
	{
	}

	public void VideoMobileAssignCallback(string LNMDPMBMJBI)
	{
	}

	public void LIPKBLBCFBF()
	{
	}

	public void AspectRatioControlAction(int AOCGNPPGDCO)
	{
	}

	public void DestroyOpenMainSettingsPanels()
	{
	}

	public void NoteSettingsButtonAction()
	{
	}

	public void AECHEOHLNLM(string OPFLFMNLGED)
	{
	}

	public void ShowCameraPermissionsTutorial()
	{
	}

	public void ResetVideoSettings()
	{
	}

	public void LMFLJNKOIJC()
	{
	}

	private void ABLAFLPCNPD()
	{
	}

	[CompilerGenerated]
	private void BCOIPCAEPJA()
	{
	}

	public void ECECPPJAKNO()
	{
	}

	public void IIIAAENCJEL(bool HNIKLKKNNBL = false)
	{
	}

	public void ACGJKCJKDOG(string EEDNPPFPFJM)
	{
	}

	public void UpdateVideoForMIDIEditor()
	{
	}

	public void UnassignAudio()
	{
	}

	[CompilerGenerated]
	private void BLIFJFFBCLF()
	{
	}

	public void EnableVideoMeshRenderer()
	{
	}
}
