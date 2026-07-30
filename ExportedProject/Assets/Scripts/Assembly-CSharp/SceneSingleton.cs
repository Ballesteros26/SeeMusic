using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ImaginationOverflow.UniversalFileAssociation.Data;
using Parse;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class SceneSingleton : MonoBehaviour
{
	public delegate void AACHNBMPPDD(int DIBAPMEDADL, int AAMGOMOAJMB);

	private sealed class HFPKCPKKPKE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneSingleton _003C_003E4__this;

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
		public HFPKCPKKPKE(int _003C_003E1__state)
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

	private sealed class BIOJDFPCNBC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneSingleton _003C_003E4__this;

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
		public BIOJDFPCNBC(int _003C_003E1__state)
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

	private sealed class KNJBEKDIADJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneSingleton _003C_003E4__this;

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
		public KNJBEKDIADJ(int _003C_003E1__state)
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

	private sealed class GAHCKMDFDBL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneSingleton _003C_003E4__this;

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
		public GAHCKMDFDBL(int _003C_003E1__state)
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

	private sealed class EEBIHGGDOAL
	{
		public SceneSingleton _003C_003E4__this;

		public float timeStarted;

		internal bool FCFJNKNPOKI()
		{
			return false;
		}
	}

	private sealed class NOJDABDHHLO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneSingleton _003C_003E4__this;

		public bool continuePlaying;

		public int pieceIndex;

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
		public NOJDABDHHLO(int _003C_003E1__state)
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

	private static SceneSingleton JOHCOGCAEAK;

	[CompilerGenerated]
	private static SceneSingleton _003CHOLNFGBMPDC_003Ek__BackingField;

	public Account Account;

	public MIDIControl MIDIControl;

	public UIManager UIManager;

	public NoteAnimation NoteAnimation;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public NoteOperations NoteOperations;

	public Preferences Preferences;

	[NonSerialized]
	public string versionNotes;

	[NonSerialized]
	public string appVersion;

	[NonSerialized]
	public string mostRecentVersion;

	[NonSerialized]
	public bool updateAvailable;

	[NonSerialized]
	public bool TooltipsOn;

	[NonSerialized]
	public int RenderedVideos;

	[NonSerialized]
	public bool hasAskedForReview;

	public GameObject AppRater;

	[NonSerialized]
	public bool VFXEmittersOn;

	[NonSerialized]
	public bool PerlinTurbulenceOn;

	[NonSerialized]
	public bool VFXSaberOn;

	[NonSerialized]
	public float AnimationSpeed;

	[NonSerialized]
	public float animationSpeedFactor;

	[NonSerialized]
	public float physicalAnimationSpeed;

	[NonSerialized]
	public float EditorZoom;

	public Purchaser purchaser;

	[NonSerialized]
	private float NEGJKBHMFCN;

	[NonSerialized]
	private float ONAMMMBKHEE;

	[NonSerialized]
	private float AMHGKJKHIGI;

	[NonSerialized]
	private float DIFIPMFNKBM;

	[NonSerialized]
	private float FCEEDFLIJHK;

	[NonSerialized]
	private float[] IGEKCAOHKHG;

	[NonSerialized]
	public float sceneWidth;

	[NonSerialized]
	public float sceneHeight;

	[NonSerialized]
	public float VisualizationAspectRatio;

	[NonSerialized]
	public float animationWidth;

	[NonSerialized]
	public float animationHeight;

	[NonSerialized]
	public float animationAspect;

	[NonSerialized]
	public float RenderEndPadding;

	[NonSerialized]
	public float pianoRollDelay;

	[NonSerialized]
	public float PianoRollDistanceBuffer;

	[NonSerialized]
	public float PianoRollBuffer;

	[NonSerialized]
	public float MIDIStartTimeBuffer;

	[NonSerialized]
	public float keyboardWidth;

	[NonSerialized]
	public float keyboardHeight;

	[NonSerialized]
	public float KeyboardPosition;

	[NonSerialized]
	public float KeyboardHorizontalOffset;

	[NonSerialized]
	public float KeyboardScale;

	[NonSerialized]
	public float KeyboardOpacity;

	[NonSerialized]
	public float KeyboardBaseOpacity;

	[NonSerialized]
	public float KeyboardBrightness;

	[NonSerialized]
	public bool BloomAffectsKeyboard;

	[NonSerialized]
	public float ParticleOpacity;

	[NonSerialized]
	public float ParticleLifetime;

	[NonSerialized]
	public float ParticleBrightness;

	[NonSerialized]
	public float ParticleCount;

	[NonSerialized]
	public float ParticleSmokeCount;

	[NonSerialized]
	public float ParticleStreakletCount;

	[NonSerialized]
	public float ParticleSize;

	[NonSerialized]
	public float ParticleSpeed;

	[NonSerialized]
	public float ParticleTurbulence;

	[NonSerialized]
	public float TurbulenceX;

	[NonSerialized]
	public float TurbulenceY;

	[NonSerialized]
	public float TurbulenceZ;

	[NonSerialized]
	public float TurbulenceOctaves;

	[NonSerialized]
	public float OctaveScale;

	[NonSerialized]
	public float OctaveMultiplier;

	[NonSerialized]
	public float StreakletTurbulence;

	[NonSerialized]
	public float TurbulenceFrequency;

	[NonSerialized]
	public float EvolutionSpeed;

	[NonSerialized]
	public float ParticleSpread;

	[NonSerialized]
	public float EmitterWidth;

	[NonSerialized]
	public float ParticleTwirl;

	[NonSerialized]
	public float TwirlVariance;

	[NonSerialized]
	public float TurbulenceMovesWith;

	[NonSerialized]
	public bool MotionTrailOn;

	[NonSerialized]
	public float LaunchSpeed;

	[NonSerialized]
	public float RandomizeDirection;

	[NonSerialized]
	public float RandomizeSpeed;

	[NonSerialized]
	public float AirFriction;

	[NonSerialized]
	public float GravityCurl;

	[NonSerialized]
	public bool ParticleRaysOn;

	[NonSerialized]
	public float ParticleRayLength;

	[NonSerialized]
	public float ParticleRayOpacity;

	[NonSerialized]
	public float ParticleRayAngle;

	[NonSerialized]
	public float ParticleRaySpread;

	[NonSerialized]
	public float ParticleAlphaFactor;

	[NonSerialized]
	public float ParticleAdditiveFactor;

	[NonSerialized]
	public float FireOpacity;

	[NonSerialized]
	public float FireScale;

	[NonSerialized]
	public float SmokeOpacity;

	[NonSerialized]
	public float StreakletLifetime;

	[NonSerialized]
	public float StreakletWidth;

	[NonSerialized]
	public float StreakletOpacity;

	[NonSerialized]
	public float StreakletSpeed;

	[NonSerialized]
	public string SaberType;

	[NonSerialized]
	public float SaberBrightness;

	[NonSerialized]
	public float SaberBrightnessColor;

	[NonSerialized]
	public float SaberOpacity;

	[NonSerialized]
	public float SaberSpeed;

	[NonSerialized]
	public float SaberThreshold;

	[NonSerialized]
	public float SaberSoftness;

	[NonSerialized]
	public float SaberBlendFactor;

	[NonSerialized]
	public float SaberCoreWidth;

	[NonSerialized]
	public float SaberCoreOpacity;

	[NonSerialized]
	public float SaberWindSpeed;

	[NonSerialized]
	public float SaberEvolutionSpeed;

	[NonSerialized]
	public float SaberDistortion;

	[NonSerialized]
	public float SaberDistortionFrequency;

	[NonSerialized]
	public float SaberStaticDistortion;

	[NonSerialized]
	public float SaberStaticFrequency;

	[NonSerialized]
	public float SaberStaticHeight;

	[NonSerialized]
	public float SaberStaticOpacity;

	[NonSerialized]
	public string MIDIFile;

	[NonSerialized]
	public string AudioFile;

	[NonSerialized]
	public string VideoFile;

	[NonSerialized]
	public float VideoLoadRequest;

	[NonSerialized]
	public int SaberLoadRequest;

	[NonSerialized]
	public int TextureLoadRequest;

	[NonSerialized]
	public float BackgroundLoadRequest;

	[NonSerialized]
	public bool LoadVideoUnity;

	[NonSerialized]
	public bool LoadSaberUnity;

	[NonSerialized]
	public bool LoadTextureUnity;

	[NonSerialized]
	public bool LoadBackgroundUnity;

	[NonSerialized]
	public string NoteTextureFile;

	[NonSerialized]
	public string BackgroundFile;

	[NonSerialized]
	public bool TempoOverrideOn;

	[NonSerialized]
	public float TempoBPM;

	[NonSerialized]
	public float CameraOpacity;

	[NonSerialized]
	public float CameraScale;

	[NonSerialized]
	public float CameraRotation;

	[NonSerialized]
	public float CameraDistortion;

	[NonSerialized]
	public float CameraCropTop;

	[NonSerialized]
	public float CameraCropBottom;

	[NonSerialized]
	public float CameraCropLeft;

	[NonSerialized]
	public float CameraCropRight;

	[NonSerialized]
	public float CameraPositionTopBottom;

	[NonSerialized]
	public float CameraPositionLeftRight;

	[NonSerialized]
	public float CameraBrightness;

	[NonSerialized]
	public float CameraContrast;

	[NonSerialized]
	public float CameraHue;

	[NonSerialized]
	public float CameraSaturation;

	[NonSerialized]
	public float CameraExposureBias;

	[NonSerialized]
	public string CameraExposureMode;

	[NonSerialized]
	public float CameraZoom;

	[NonSerialized]
	public string CameraOrder;

	[NonSerialized]
	public string CameraFramework;

	[NonSerialized]
	public string CameraResolution;

	[NonSerialized]
	public int CameraFramerate;

	[NonSerialized]
	public bool Keyboard3DOn;

	[NonSerialized]
	public float videoAudioRenderTimeOffset;

	[NonSerialized]
	public float SyncWindowLength;

	[NonSerialized]
	public float AutoSyncThreshold;

	[NonSerialized]
	public bool SyncerOpen;

	[NonSerialized]
	public AudioClip VideoWaveformClip;

	[NonSerialized]
	public float[] VideoWaveformSamples;

	[NonSerialized]
	public float[] AudioWaveformSamples;

	[NonSerialized]
	public bool VideoSoundOn;

	[NonSerialized]
	public float VideoOpacity;

	[NonSerialized]
	public float VideoScale;

	[NonSerialized]
	public float VideoRotation;

	[NonSerialized]
	public float VideoDistortion;

	[NonSerialized]
	public float VideoCropTop;

	[NonSerialized]
	public float VideoCropBottom;

	[NonSerialized]
	public float VideoCropLeft;

	[NonSerialized]
	public float VideoCropRight;

	[NonSerialized]
	public float VideoBrightness;

	[NonSerialized]
	public float VideoContrast;

	[NonSerialized]
	public float VideoHue;

	[NonSerialized]
	public float VideoSaturation;

	[NonSerialized]
	public bool VideoTransformBoxOn;

	[NonSerialized]
	public bool AlignGuideOn;

	[NonSerialized]
	public float VideoPositionTopBottom;

	[NonSerialized]
	public float VideoPositionLeftRight;

	[NonSerialized]
	public float videoTimeSmallOffset;

	[NonSerialized]
	public float videoTimeLargeOffset;

	[NonSerialized]
	public float VideoTimeOffset;

	[NonSerialized]
	public float audioTimeSmallOffset;

	[NonSerialized]
	public float audioTimeLargeOffset;

	[NonSerialized]
	public float AudioTimeOffset;

	[NonSerialized]
	public float MIDIReverbTime;

	[NonSerialized]
	public float MIDIReverbMix;

	[NonSerialized]
	public List<MGFGDCEJHGB> saveFilesList;

	[NonSerialized]
	public List<string> sampleSaveFiles;

	[NonSerialized]
	public List<MGFGDCEJHGB> pieceNamesList;

	[NonSerialized]
	public List<SeeMusicPiece> piecesList;

	[NonSerialized]
	public int selectedSaveIndex;

	[NonSerialized]
	public int selectedPieceIndex;

	[NonSerialized]
	public string Title;

	[NonSerialized]
	public string Composer;

	[NonSerialized]
	public bool LoadSamplePieces;

	[NonSerialized]
	public bool ShowWelcomeAtLaunch;

	[NonSerialized]
	public string AnimationDirection;

	[NonSerialized]
	public bool BackgroundOn;

	[NonSerialized]
	public string BackgroundType;

	[NonSerialized]
	public bool BackgroundColorOn;

	[NonSerialized]
	public bool BackgroundChangesColor;

	[NonSerialized]
	public bool ClickCreatesNote;

	[NonSerialized]
	public bool MIDIEditingOn;

	[NonSerialized]
	public bool AddNotesOn;

	[NonSerialized]
	public string ColorMode;

	[NonSerialized]
	public string NoteStyle;

	[NonSerialized]
	public string NoteDimensions;

	[NonSerialized]
	public string NoteShape3D;

	[NonSerialized]
	public float NoteSize;

	[NonSerialized]
	public float NoteMinimumLength;

	[NonSerialized]
	public float WhiteBlackWidthRatio;

	[NonSerialized]
	public float NoteCornerRoundness;

	[NonSerialized]
	public float NoteEdgeWidth;

	[NonSerialized]
	public float NoteOpacity;

	[NonSerialized]
	public float NotePositionDistortion;

	[NonSerialized]
	public float NoteDepth;

	[NonSerialized]
	public float BumpTextureScale;

	[NonSerialized]
	public float BlackKeyDarkness;

	[NonSerialized]
	public bool NoteTextureReflectionOn;

	[NonSerialized]
	public bool NoteColorReflectionsOn;

	[NonSerialized]
	public float NoteReflectivity;

	public ReflectionProbe ReflectionProbe;

	public Color SelectedNoteColor;

	[NonSerialized]
	public bool BarLinesOn;

	[NonSerialized]
	public float BarLinesOpacity;

	[NonSerialized]
	public float BarLineWidthConstant;

	[NonSerialized]
	public bool KeyGuidesOn;

	[NonSerialized]
	public float KeyGuidesOpacity;

	[NonSerialized]
	public Preferences.FKDALFMFNJB KeyLabelsMode;

	[NonSerialized]
	public float KeyLabelsOpacity;

	[NonSerialized]
	public bool KeySignatureOverride;

	[NonSerialized]
	public bool KeySignatureOn;

	[NonSerialized]
	public bool TimeSignatureOn;

	[NonSerialized]
	public bool AspectGuideOn;

	[NonSerialized]
	public string GradientDirection;

	[NonSerialized]
	public float GradientAngle;

	[NonSerialized]
	public bool pianoRollMode;

	[NonSerialized]
	public bool SustainHoldOn;

	[NonSerialized]
	public bool KeyboardSustainHoldOn;

	[NonSerialized]
	public bool KeyboardOn;

	[NonSerialized]
	public bool KeyTextureOn;

	[NonSerialized]
	public bool NoteLabelsOn;

	[NonSerialized]
	public string NoteLabelType;

	[NonSerialized]
	public float NoteLabelSize;

	[NonSerialized]
	public float NoteLabelOpacity;

	[NonSerialized]
	public float NoteLabelSizeRatio;

	[NonSerialized]
	public bool ParticlesOn;

	[NonSerialized]
	public bool MainParticlesOn;

	[NonSerialized]
	public bool ParticleStreakletsOn;

	[NonSerialized]
	public bool ParticleSmokeOn;

	[NonSerialized]
	public bool LightsOn;

	[NonSerialized]
	public bool LightGlowOn;

	[NonSerialized]
	public bool LightRaysOn;

	[NonSerialized]
	public bool BrightCenterLightsOn;

	[NonSerialized]
	public float LightGlowScale;

	[NonSerialized]
	public float LightGlowStrength;

	[NonSerialized]
	public float LightRayOpacity;

	[NonSerialized]
	public float BrightCenterScale;

	[NonSerialized]
	public float BrightCenterOpacity;

	[NonSerialized]
	public bool LightsAboveVideo;

	[NonSerialized]
	public bool ArtificialShadowsOn;

	[NonSerialized]
	public bool KeyLabelsOn;

	[NonSerialized]
	public bool GlowMasterOn;

	[NonSerialized]
	public bool NoteGlowOn;

	[NonSerialized]
	public float GlowBrightness;

	[NonSerialized]
	public float GlowIntensity;

	[NonSerialized]
	public float GlowScatter;

	[NonSerialized]
	public float GlowOpacity;

	[NonSerialized]
	public string GlowSize;

	[NonSerialized]
	public bool BloomOn;

	[NonSerialized]
	public float BloomIntensity;

	[NonSerialized]
	public float BloomScatter;

	[NonSerialized]
	public float BloomThreshold;

	[NonSerialized]
	public bool BloomAffectsParticles;

	[NonSerialized]
	public bool NoteOutlineOn;

	[NonSerialized]
	public bool KeyboardSaberOn;

	[NonSerialized]
	public bool KeyboardSaberTurningOn;

	[NonSerialized]
	public float OutlineWidth;

	[NonSerialized]
	public Color OutlineColor;

	[NonSerialized]
	public float OutlineDepth;

	[NonSerialized]
	public float OutlineBlend;

	[NonSerialized]
	public float OutlineBrightness;

	[NonSerialized]
	public bool NoteLight1On;

	[NonSerialized]
	public float NoteLight1Intensity;

	[NonSerialized]
	public float NoteLight1AngleX;

	[NonSerialized]
	public float NoteLight1AngleY;

	[NonSerialized]
	public bool NoteLight2On;

	[NonSerialized]
	public float NoteLight2Intensity;

	[NonSerialized]
	public float NoteLight2AngleX;

	[NonSerialized]
	public float NoteLight2AngleY;

	[NonSerialized]
	public float NoteLightAmbient;

	[NonSerialized]
	public string SaberVideoFile;

	[NonSerialized]
	public float keyHue;

	[NonSerialized]
	public List<SeeMusicSettingsSave> undoHistory;

	[NonSerialized]
	public Color[] PitchColors;

	[NonSerialized]
	public Color[] TrackColors;

	[NonSerialized]
	public bool UseChannelForTrackColor;

	[NonSerialized]
	public int NumberOfTracks;

	[NonSerialized]
	public int NumberOfGradientColors;

	[NonSerialized]
	public string TrackColorMode;

	[NonSerialized]
	public bool RandomTrackColorOn;

	[NonSerialized]
	public int[] TrackDividePoints;

	[NonSerialized]
	public Color BackgroundColor;

	[NonSerialized]
	public Color KeyColor;

	[NonSerialized]
	public Color SaberColor;

	[NonSerialized]
	public Color dynamicColor;

	[NonSerialized]
	public bool CustomSaberColorOn;

	[NonSerialized]
	public float SaberPositionX;

	[NonSerialized]
	public float SaberScale;

	[NonSerialized]
	public int ColorSaveActiveIndex;

	[NonSerialized]
	public List<KCDPMOLPJNI> ColorSaves;

	[NonSerialized]
	public float colorBrightnessFactor;

	[NonSerialized]
	public float colorDarknessFactor;

	[NonSerialized]
	public Color[] GradientColors;

	[NonSerialized]
	public float[] GradientPoints;

	[NonSerialized]
	public Gradient gradient;

	[NonSerialized]
	public Gradient PaletteGradient;

	[NonSerialized]
	public Gradient SaberGradient;

	[NonSerialized]
	public Gradient KeyboardGradient;

	[NonSerialized]
	public List<Color> channelColors;

	[NonSerialized]
	public bool colorByChannelMode;

	[NonSerialized]
	public string Key;

	[NonSerialized]
	public string KeyQuality;

	[NonSerialized]
	public string AtonalAccidentals;

	[NonSerialized]
	public int undoHistoryIndex;

	[NonSerialized]
	public bool keyboardReady;

	[NonSerialized]
	public bool PitchDetectionOn;

	public VideoRenderer videoCaptureCam;

	[NonSerialized]
	public bool UseMovieCapture;

	[NonSerialized]
	public bool UseAVProVideo;

	[NonSerialized]
	public bool UseTextureFrameCount;

	[NonSerialized]
	public bool UseAVProSeekCompleted;

	[NonSerialized]
	public bool UseAVProCamera;

	[NonSerialized]
	public bool AVProVideoAllowed;

	[NonSerialized]
	public bool UseMIDIJack;

	[NonSerialized]
	public bool LiveMIDIDelayOn;

	[NonSerialized]
	public float LiveMIDIDelay;

	[NonSerialized]
	public bool MIDIVelocityBoostOn;

	[NonSerialized]
	public float MIDIVelocityBoost;

	[NonSerialized]
	public float RenderVolumeBoost;

	[NonSerialized]
	public bool RecordMIDI;

	[NonSerialized]
	public bool RecordAudio;

	[NonSerialized]
	public bool RecordVideo;

	[NonSerialized]
	public bool captureVideoByTrack;

	[NonSerialized]
	public bool videoMicEnabled;

	[NonSerialized]
	public bool isRecording;

	[NonSerialized]
	public bool isRecordingVideo;

	[NonSerialized]
	public bool isCreatingVideo;

	[NonSerialized]
	public bool recordCanceled;

	[NonSerialized]
	public bool RenderAudio;

	[NonSerialized]
	public bool renderAudioFirst;

	[NonSerialized]
	public bool exportAudioWav;

	[NonSerialized]
	public bool isRenderingVideo;

	[NonSerialized]
	public bool isRenderingAudio;

	[NonSerialized]
	public bool ShowRenderPreview;

	[NonSerialized]
	public bool MIDIEditorVideoOn;

	[NonSerialized]
	public bool VideoRendererEnabled;

	[NonSerialized]
	public bool CameraViewOn;

	[NonSerialized]
	public string AspectRatio;

	[NonSerialized]
	public string RenderAspectRatio;

	[NonSerialized]
	public string Resolution;

	[NonSerialized]
	public bool useBackingScaleFactor;

	[NonSerialized]
	public int Framerate;

	[NonSerialized]
	public bool perfectCaptureOn;

	[NonSerialized]
	public int RenderFramerate;

	[NonSerialized]
	public float currentFramerate;

	[NonSerialized]
	public string VideoResolution;

	[NonSerialized]
	public int videoWidth;

	[NonSerialized]
	public int videoHeight;

	[NonSerialized]
	public string VideoQuality;

	[NonSerialized]
	public int VideoBitrate;

	[NonSerialized]
	public string RenderVideoCodec;

	[NonSerialized]
	public bool RenderTransparent;

	[NonSerialized]
	public string RenderAudioCodec;

	[NonSerialized]
	public string RenderExtension;

	[NonSerialized]
	public List<string> VideoCodecsMac;

	[NonSerialized]
	public List<string> VideoCodecsWindows;

	[NonSerialized]
	public List<string> AudioCodecsMac;

	[NonSerialized]
	public List<string> AudioCodecsWindows;

	[NonSerialized]
	public List<string> RenderExtensionsMac;

	[NonSerialized]
	public List<string> RenderExtensionsWindows;

	[NonSerialized]
	public bool NoteTextureOn;

	[NonSerialized]
	public float NoteTextureOpacity;

	[NonSerialized]
	public float NoteTextureBlendColor;

	[NonSerialized]
	public float NoteTextureScale;

	[NonSerialized]
	public float NoteTextureRotation;

	[NonSerialized]
	public float NoteTexturePositionTopBottom;

	[NonSerialized]
	public float NoteTexturePositionLeftRight;

	[NonSerialized]
	public float NoteTextureBrightness;

	[NonSerialized]
	public float NoteTextureContrast;

	[NonSerialized]
	public float NoteTextureHue;

	[NonSerialized]
	public float NoteTextureSaturation;

	[NonSerialized]
	public bool NoteTextureMirroring;

	[NonSerialized]
	public bool TextureMovesWithNotes;

	[NonSerialized]
	public bool RandomizeTexture;

	[NonSerialized]
	public string TextureType;

	[NonSerialized]
	public float TextureDensity;

	[NonSerialized]
	public float TextureSpeed;

	[NonSerialized]
	public float TextureClarity;

	[NonSerialized]
	public float TextureTransparency;

	[NonSerialized]
	public string TextureQuality;

	[NonSerialized]
	public bool TextureEmbossOn;

	[NonSerialized]
	public float TextureEmbossBlur;

	[NonSerialized]
	public float TextureEmbossDepth;

	[NonSerialized]
	public float TextureOriginalOpacity;

	[NonSerialized]
	public bool TextureCutOutOn;

	[NonSerialized]
	public float TextureCutOutThreshold;

	[NonSerialized]
	public float TextureCutOutOpacity;

	[NonSerialized]
	public bool TextureLight1On;

	[NonSerialized]
	public float TextureLight1Intensity;

	[NonSerialized]
	public float TextureLight1AngleX;

	[NonSerialized]
	public float TextureLight1AngleY;

	[NonSerialized]
	public bool TextureLight2On;

	[NonSerialized]
	public float TextureLight2Intensity;

	[NonSerialized]
	public float TextureLight2AngleX;

	[NonSerialized]
	public float TextureLight2AngleY;

	[NonSerialized]
	public float TextureLightAmbient;

	[NonSerialized]
	public bool BackgroundImageOn;

	[NonSerialized]
	public float BackgroundImageOpacity;

	[NonSerialized]
	public float BackgroundImageScale;

	[NonSerialized]
	public float BackgroundImageRotation;

	[NonSerialized]
	public float BackgroundImagePositionTopBottom;

	[NonSerialized]
	public float BackgroundImagePositionLeftRight;

	[NonSerialized]
	public float BackgroundImageBrightness;

	[NonSerialized]
	public float BackgroundImageContrast;

	[NonSerialized]
	public float BackgroundImageHue;

	[NonSerialized]
	public float BackgroundImageSaturation;

	[NonSerialized]
	public float BackgroundImageCropTop;

	[NonSerialized]
	public float BackgroundImageCropBottom;

	[NonSerialized]
	public float BackgroundImageCropLeft;

	[NonSerialized]
	public float BackgroundImageCropRight;

	[NonSerialized]
	public bool PerformanceVideoOn;

	[NonSerialized]
	public float saberPlaybackSpeed;

	[NonSerialized]
	public float particleSimulationSpeed;

	[NonSerialized]
	public string MIDISound;

	[NonSerialized]
	public bool NotesOn;

	[NonSerialized]
	public string NotesPosition;

	[NonSerialized]
	public string EditorColorMode;

	[NonSerialized]
	public float EditorInterfacePosition;

	[NonSerialized]
	public bool visualizationPlaying;

	[NonSerialized]
	public bool VisualizationWasPlaying;

	[NonSerialized]
	public bool playing;

	[NonSerialized]
	public bool wasPlaying;

	[NonSerialized]
	public bool continuePlayingStored;

	[NonSerialized]
	public bool PlayExternalNotes;

	[NonSerialized]
	public bool LowAChangesPiece;

	[NonSerialized]
	public bool ClickChangesPiece;

	public Camera mainCamera;

	public Camera overlayCamera;

	public UniversalRendererData UniversalRenderDataMain;

	public UniversalRendererData UniversalRenderDataBloom;

	public GameObject ReflectorProbeObject;

	public Volume PostProcessingVolume;

	public BoxCollider EditorCollider;

	public GameObject simpleIAPCanvas;

	[NonSerialized]
	public string AppleEnvironment;

	[NonSerialized]
	public bool testWindowsPurchases;

	[NonSerialized]
	public bool testOneTimePurchases;

	[NonSerialized]
	public bool UsePabblyPurchases;

	[NonSerialized]
	public bool UsePaypalPurchases;

	[NonSerialized]
	public bool unlockedBuild;

	[NonSerialized]
	public bool screenshotBuild;

	[NonSerialized]
	public float screenshotAspect;

	[NonSerialized]
	public bool TutorialVideoBuild;

	[NonSerialized]
	public SeeMusicSettingsSave AppPreferences;

	public InternetReachabilityVerifier internetReachabilityVerifier;

	[NonSerialized]
	private string KAMGLEOEINM;

	[NonSerialized]
	private bool HLAFFHJIGDB;

	[NonSerialized]
	private string JKCHKAAHNFH;

	[NonSerialized]
	private UnityWebRequest IOMICOAGEJK;

	[NonSerialized]
	public bool internetUnreachable;

	[NonSerialized]
	public float unreachableTime;

	[NonSerialized]
	public float maxUnreachableTime;

	[NonSerialized]
	public int unreachableChecks;

	[NonSerialized]
	public bool firstRun;

	[NonSerialized]
	public bool parseInitialized;

	[NonSerialized]
	public bool sceneInitialized;

	[NonSerialized]
	public List<MGFGDCEJHGB> versionInformation;

	[NonSerialized]
	public bool IsArduinoBuild;

	[NonSerialized]
	public bool RecordDynamicColor;

	[NonSerialized]
	public bool readDynamicColorFromPitchWheel;

	[NonSerialized]
	public bool LightsAboveAndBelow;

	[NonSerialized]
	public bool LimitDynamicSaturation;

	[NonSerialized]
	public bool RandomChannelOut;

	[NonSerialized]
	public int RandomNumberOfChannels;

	[NonSerialized]
	public DateTime InstallDate;

	[NonSerialized]
	public float NavigationPanelHeightDesktop;

	[NonSerialized]
	public float ButtonDesktopScale;

	[NonSerialized]
	public float BackButtonDesktopScale;

	[NonSerialized]
	public bool TestMobileUI;

	[NonSerialized]
	public bool UseDesktopUI;

	[NonSerialized]
	public bool MinimizeVisualOn;

	[NonSerialized]
	public string PresetCategory;

	[NonSerialized]
	public bool stop;

	[NonSerialized]
	public float SettingsPanelWidth;

	[NonSerialized]
	public float SettingsPanelRightWidth;

	[CompilerGenerated]
	private AACHNBMPPDD JCFKBFEIPLG;

	private Vector2 AKEFALBMBOB;

	[NonSerialized]
	public float cameraSizeScaler;

	[NonSerialized]
	public float MaxEditorSpeed;

	public string Scheme;

	public string UniquePath;

	public static SceneSingleton Instance
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

	public event AACHNBMPPDD ScreenSizeChangeEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[CompilerGenerated]
	private void MNMMFCMLEDK(Task<ParseObject> LJGFOHONDJL)
	{
	}

	public void UpdateWatermark()
	{
	}

	public KCDPMOLPJNI MEFLPIPPGFK()
	{
		return null;
	}

	public void ParseCurrentPiece()
	{
	}

	public void AddUndoState()
	{
	}

	[CompilerGenerated]
	private void HMICELGDKBN()
	{
	}

	private void BKGHOCLKGHG(InternetReachabilityVerifier.BIHDCDFOHBK AADLDOKAKMB)
	{
	}

	private IEnumerator PNCDECPPAKK()
	{
		return null;
	}

	private bool MOCKGJJIDLI()
	{
		return false;
	}

	public void UpdateUndoState()
	{
	}

	public void SetFramerate()
	{
	}

	public void LEANPBEOMGC()
	{
	}

	[CompilerGenerated]
	private void JOHNMODEPMC()
	{
	}

	private void DJLKFEGABMC()
	{
	}

	protected virtual void MKGJNLAFILJ(int DIBAPMEDADL, int AAMGOMOAJMB)
	{
	}

	public void FirstRunSetAVProVideo()
	{
	}

	public Color[][] FloatStagToColorArray(float[][][] FMNOANFOIPN)
	{
		return null;
	}

	[CompilerGenerated]
	private void KHFABKPPOCA(Task<ParseObject> LJGFOHONDJL)
	{
	}

	public KCDPMOLPJNI CreateColorSave()
	{
		return null;
	}

	public void LoadPreferences(bool ELCFNGGANLE = false, bool NINGPHJIJAN = false)
	{
	}

	public IEnumerator LNNEAKMMGNG()
	{
		return null;
	}

	public void InitializeInternetReachabilityVerifier()
	{
	}

	[CompilerGenerated]
	private void GJDIEDEGFEI()
	{
	}

	[CompilerGenerated]
	private void BDLCPICKLCJ()
	{
	}

	public void ChangeSaveFileTo(int CNPDBLNOJCO, int IFAILJPFBDP = -1)
	{
	}

	public void RedoButtonAction()
	{
	}

	public void SetAspect(bool GBAKMLLBLEE = false, bool KLCIDGGKHEF = false, bool MJCJFKFJKHA = false)
	{
	}

	public void SetPhysicalAnimationSpeed()
	{
	}

	public bool CustomReachabilityDelegate(UnityWebRequest NKBNLABMICM, string PJKMDEGGJDP)
	{
		return false;
	}

	public void SavePiecesXML(bool POCCHALHGKP = true, bool LIMEJGBCHBC = false)
	{
	}

	private void Update()
	{
	}

	public bool GetMinimized()
	{
		return false;
	}

	[CompilerGenerated]
	private void CFGALEHLGFA()
	{
	}

	public void CopySampleFiles()
	{
	}

	public void DeleteOldRenderFiles()
	{
	}

	public void SliderEndDragAction()
	{
	}

	private void JKEEHAEMDLP()
	{
	}

	public Color[] FloatToColorArray(float[][] DFLNOHKOBIM)
	{
		return null;
	}

	private void DIPJLBFMGJL(int DIBAPMEDADL, int AAMGOMOAJMB)
	{
	}

	public void CheckForReview()
	{
	}

	[CompilerGenerated]
	private void GCKFFIOLJEP()
	{
	}

	protected virtual void GAFGNFKNMGH(int DIBAPMEDADL, int AAMGOMOAJMB)
	{
	}

	public bool GetUseAVProVideo()
	{
		return false;
	}

	[CompilerGenerated]
	private void PGFMODELOCD(Task<ParseObject> LJGFOHONDJL)
	{
	}

	public void CopySampleSave()
	{
	}

	[IteratorStateMachine(typeof(KNJBEKDIADJ))]
	public IEnumerator GetWK()
	{
		return null;
	}

	[CompilerGenerated]
	private void HFHABJJIJMC()
	{
	}

	public void LoadUndoState()
	{
	}

	[IteratorStateMachine(typeof(HFPKCPKKPKE))]
	private IEnumerator Start()
	{
		return null;
	}

	protected virtual void NIFKPGGMDEP(int DIBAPMEDADL, int AAMGOMOAJMB)
	{
	}

	public void LoadPiecesInSaveFile(bool HPOENMDGOOO = false)
	{
	}

	public void FFPBLLGPMIM()
	{
	}

	public void LoadSampleSaveFiles()
	{
	}

	public void SetBloom(float JEHONDDIMPC = 0.45f)
	{
	}

	[CompilerGenerated]
	private bool AMAJEDPECHH()
	{
		return false;
	}

	private void Awake()
	{
	}

	[CompilerGenerated]
	private void GPAHELFIJAD()
	{
	}

	[CompilerGenerated]
	private void HDGNBPGCLCL()
	{
	}

	public void SetQualityLevel()
	{
	}

	public void GetNetTime()
	{
	}

	public void SwitchResolution()
	{
	}

	[CompilerGenerated]
	private void COPKNDOBIHI()
	{
	}

	private void HGHEKGFKGFJ(Task<ParseObject> LJGFOHONDJL)
	{
	}

	public void SetWatermarkPosition()
	{
	}

	[IteratorStateMachine(typeof(BIOJDFPCNBC))]
	public IEnumerator GetK()
	{
		return null;
	}

	[IteratorStateMachine(typeof(NOJDABDHHLO))]
	public IEnumerator ChangePieceTo(int IFAILJPFBDP, bool CEDIANPFEIO = false, bool LDKOAFEIHOO = false)
	{
		return null;
	}

	public void JBOHOCMLCPO()
	{
	}

	public void HandlePlatformSpecificPrefs()
	{
	}

	[CompilerGenerated]
	private bool EKHPDCBAHGD()
	{
		return false;
	}

	private void HIIGNPPHBPF(string ABDBFAGAMLG)
	{
	}

	[CompilerGenerated]
	private void MEBPHBBJGJD()
	{
	}

	[IteratorStateMachine(typeof(GAHCKMDFDBL))]
	public IEnumerator UpdateVersionList()
	{
		return null;
	}

	private void LHHIIHFAOMJ(FileInformation IDOBLGEGBOL)
	{
	}

	private void PBNDOLCNDNJ()
	{
	}

	public void ChangeColorSave()
	{
	}

	[CompilerGenerated]
	private void CHEDGLLBAMP()
	{
	}

	public void UndoButtonAction()
	{
	}

	public void LoadSaveFiles()
	{
	}

	public void JKHEPNFMPJC()
	{
	}

	public void SetVideoResolution()
	{
	}
}
