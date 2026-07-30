using System;
using System.Xml.Serialization;
using UnityEngine;

[Serializable]
[XmlRoot("SeeMusicSettingsSave")]
public class SeeMusicSettingsSave
{
	public string[] SavedVariables;

	public bool PieceVariablesIncluded;

	public bool IsParticlePreset;

	public bool IsNotePreset;

	public bool IsSaberPreset;

	public string AppVersion;

	public bool TooltipsOn;

	public bool UseDesktopUI;

	public bool MinimizeVisualOn;

	public float KeyboardScale;

	public float KeyboardPosition;

	public float KeyboardHorizontalOffset;

	public float KeyboardOpacity;

	public float KeyboardBaseOpacity;

	public float KeyboardBrightness;

	public bool BloomAffectsKeyboard;

	public float ParticleOpacity;

	public float ParticleLifetime;

	public float ParticleBrightness;

	public float ParticleCount;

	public float ParticleSmokeCount;

	public float ParticleStreakletCount;

	public float ParticleSize;

	public float ParticleSpeed;

	public float ParticleTurbulence;

	public float TurbulenceX;

	public float TurbulenceY;

	public float TurbulenceZ;

	public float TurbulenceOctaves;

	public float OctaveScale;

	public float OctaveMultiplier;

	public float StreakletTurbulence;

	public float TurbulenceFrequency;

	public float EvolutionSpeed;

	public float TurbulenceMovesWith;

	public float ParticleSpread;

	public float EmitterWidth;

	public float ParticleTwirl;

	public float TwirlVariance;

	public bool MotionTrailOn;

	public float LaunchSpeed;

	public float RandomizeDirection;

	public float RandomizeSpeed;

	public float AirFriction;

	public float GravityCurl;

	public bool ParticleRaysOn;

	public float ParticleRayLength;

	public float ParticleRayOpacity;

	public float ParticleRayAngle;

	public float ParticleRaySpread;

	public float ParticleAlphaFactor;

	public float ParticleAdditiveFactor;

	public float FireOpacity;

	public float SmokeOpacity;

	public float StreakletLifetime;

	public float StreakletWidth;

	public float StreakletOpacity;

	public float StreakletSpeed;

	public string SaberType;

	public string SaberVideoFile;

	public float SaberBrightness;

	public float SaberBrightnessColor;

	public float SaberSpeed;

	public float SaberOpacity;

	public float SaberThreshold;

	public float SaberSoftness;

	public float SaberBlendFactor;

	public float SaberCoreWidth;

	public float SaberCoreOpacity;

	public float SaberWindSpeed;

	public float SaberEvolutionSpeed;

	public float SaberDistortion;

	public float SaberDistortionFrequency;

	public float SaberStaticDistortion;

	public float SaberStaticFrequency;

	public float SaberStaticHeight;

	public float SaberStaticOpacity;

	public float CameraOpacity;

	public float CameraScale;

	public float CameraRotation;

	public float CameraDistortion;

	public float CameraCropTop;

	public float CameraCropBottom;

	public float CameraCropLeft;

	public float CameraCropRight;

	public float CameraPositionTopBottom;

	public float CameraPositionLeftRight;

	public float CameraBrightness;

	public float CameraContrast;

	public float CameraHue;

	public float CameraSaturation;

	public float CameraExposureBias;

	public string CameraExposureMode;

	public float CameraZoom;

	public string CameraOrder;

	public string CameraFramework;

	public string CameraResolution;

	public int CameraFramerate;

	public float MIDIStartTimeBuffer;

	public float MIDIReverbTime;

	public float MIDIReverbMix;

	public bool MIDIVelocityBoostOn;

	public float MIDIVelocityBoost;

	public float AnimationSpeed;

	public string AnimationDirection;

	public string NoteStyle;

	public string NoteDimensions;

	public string NoteShape3D;

	public float NoteSize;

	public float NoteMinimumLength;

	public float WhiteBlackWidthRatio;

	public float BlackKeyDarkness;

	public float NoteCornerRoundness;

	public float NoteEdgeWidth;

	public float NoteDepth;

	public float NoteOpacity;

	public float NotePositionDistortion;

	public float BumpTextureScale;

	public bool NoteColorReflectionsOn;

	public bool NoteTextureReflectionOn;

	public float NoteReflectivity;

	public float OutlineWidth;

	public float OutlineDepth;

	public float OutlineBlend;

	public float OutlineBrightness;

	public Color OutlineColor;

	public bool NoteLight1On;

	public float NoteLight1Intensity;

	public float NoteLight1AngleX;

	public float NoteLight1AngleY;

	public bool NoteLight2On;

	public float NoteLight2Intensity;

	public float NoteLight2AngleX;

	public float NoteLight2AngleY;

	public float NoteLightAmbient;

	public bool TextureLight1On;

	public float TextureLight1Intensity;

	public float TextureLight1AngleX;

	public float TextureLight1AngleY;

	public bool TextureLight2On;

	public float TextureLight2Intensity;

	public float TextureLight2AngleX;

	public float TextureLight2AngleY;

	public float TextureLightAmbient;

	public bool SustainHoldOn;

	public bool KeyboardSustainHoldOn;

	public bool KeyboardOn;

	public bool KeyTextureOn;

	public bool NoteLabelsOn;

	public bool ParticlesOn;

	public string NoteLabelType;

	public float NoteLabelSize;

	public float NoteLabelOpacity;

	public float NoteLabelSizeRatio;

	public bool MainParticlesOn;

	public bool ParticleStreakletsOn;

	public bool ParticleSmokeOn;

	public bool LightsOn;

	public bool LightGlowOn;

	public bool LightRaysOn;

	public bool BrightCenterLightsOn;

	public float LightGlowScale;

	public float LightGlowStrength;

	public float LightRayOpacity;

	public float BrightCenterScale;

	public float BrightCenterOpacity;

	public bool LightsAboveVideo;

	public bool ArtificialShadowsOn;

	public bool GlowMasterOn;

	public bool NoteGlowOn;

	public float GlowBrightness;

	public float GlowIntensity;

	public float GlowScatter;

	public float GlowOpacity;

	public string GlowSize;

	public bool BloomOn;

	public float BloomIntensity;

	public float BloomScatter;

	public float BloomThreshold;

	public bool BloomAffectsParticles;

	public bool NoteOutlineOn;

	public bool KeyboardSaberOn;

	public bool NotesOn;

	public string NotesPosition;

	public bool BarLinesOn;

	public float BarLinesOpacity;

	public bool KeyGuidesOn;

	public float KeyGuidesOpacity;

	public string KeyLabelsMode;

	public float KeyLabelsOpacity;

	public bool KeySignatureOn;

	public bool TimeSignatureOn;

	public bool KeyLabelsOn;

	public bool UseMIDIJack;

	public bool LiveMIDIDelayOn;

	public float LiveMIDIDelay;

	public bool RecordMIDI;

	public bool RecordAudio;

	public bool RecordVideo;

	public bool BackgroundOn;

	public bool BackgroundColorOn;

	public string BackgroundType;

	public bool LoadSamplePieces;

	public string AspectRatio;

	public string RenderAspectRatio;

	public string Resolution;

	public string RenderVideoCodec;

	public bool RenderTransparent;

	public string RenderAudioCodec;

	public string RenderExtension;

	public int Framerate;

	public int RenderFramerate;

	public bool PlayExternalNotes;

	public bool BackgroundChangesColor;

	public string VideoResolution;

	public string VideoQuality;

	public bool RenderAudio;

	public bool UseMovieCapture;

	public bool UseAVProVideo;

	public bool ShowRenderPreview;

	public float RenderVolumeBoost;

	public bool MIDIEditorVideoOn;

	public bool ShowWelcomeAtLaunch;

	public string MIDISound;

	public string SelectedMIDIInputName;

	public string SelectedAudioInputName;

	public string SelectedVideoInputName;

	public string EditorColorMode;

	public int RandomNumberOfChannels;

	public bool AspectGuideOn;

	public float SyncWindowLength;

	public float AutoSyncThreshold;

	public string Title;

	public string Composer;

	public string AudioFile;

	public string MIDIFile;

	public string VideoFile;

	public bool TempoOverrideOn;

	public float TempoBPM;

	public int AudioSoundOn;

	public int MIDISoundOn;

	public string ColorMode;

	public string GradientDirection;

	public float GradientAngle;

	public Color BackgroundColor;

	public Color KeyColor;

	public Color SaberColor;

	public bool CustomSaberColorOn;

	public float SaberPositionX;

	public float SaberScale;

	public Color[] PitchColors;

	public Color[] GradientColors;

	public float[] GradientPoints;

	public Color[] TrackColors;

	public int NumberOfTracks;

	public int NumberOfGradientColors;

	public bool UseChannelForTrackColor;

	public int[] TrackDividePoints;

	public string TrackColorMode;

	public bool RandomTrackColorOn;

	public string[] ColorModeSaved;

	public float[] ColorSaveTimes;

	public string[] GradientDirectionSaved;

	public float[] GradientAngleSaved;

	public Color[] BackgroundColorSaved;

	public bool[] BackgroundChangesColorSaved;

	public Color[] KeyColorSaved;

	public Color[] SaberColorSaved;

	public bool[] CustomSaberColorOnSaved;

	public Color[][] PitchColorsSaved;

	public Color[][] GradientColorsSaved;

	public float[][] GradientPointsSaved;

	public Color[][] TrackColorsSaved;

	public int[] NumberOfTracksSaved;

	public int[] NumberOfGradientColorsSaved;

	public int[][] TrackDividePointsSaved;

	public string[] TrackColorModeSaved;

	public bool[] RandomTrackColorOnSaved;

	public int[] RandomNumberOfChannelsSaved;

	public string Key;

	public bool KeySignatureOverride;

	public string KeyQuality;

	public int SaveVersion;

	public string AtonalAccidentals;

	public bool BackgroundImageOn;

	public float BackgroundImageOpacity;

	public float BackgroundImageScale;

	public float BackgroundImageRotation;

	public float BackgroundImagePositionLeftRight;

	public float BackgroundImagePositionTopBottom;

	public string BackgroundImageFile;

	public float BackgroundImageBrightness;

	public float BackgroundImageContrast;

	public float BackgroundImageHue;

	public float BackgroundImageSaturation;

	public float BackgroundImageCropTop;

	public float BackgroundImageCropBottom;

	public float BackgroundImageCropLeft;

	public float BackgroundImageCropRight;

	public float VideoOpacity;

	public float VideoScale;

	public float VideoRotation;

	public float VideoDistortion;

	public float VideoCropTop;

	public float VideoCropBottom;

	public float VideoCropLeft;

	public float VideoCropRight;

	public float VideoBrightness;

	public float VideoContrast;

	public float VideoHue;

	public float VideoSaturation;

	public float VideoPositionTopBottom;

	public float VideoPositionLeftRight;

	public bool VideoTransformBoxOn;

	public bool AlignGuideOn;

	public float VideoTimeOffset;

	public float AudioTimeOffset;

	public bool VideoSoundOn;

	public string TextureType;

	public float TextureDensity;

	public float TextureSpeed;

	public float TextureClarity;

	public float TextureTransparency;

	public string TextureQuality;

	public bool TextureMovesWithNotes;

	public bool RandomizeTexture;

	public bool TextureEmbossOn;

	public float TextureEmbossBlur;

	public float TextureEmbossDepth;

	public float TextureOriginalOpacity;

	public bool TextureCutOutOn;

	public float TextureCutOutThreshold;

	public float TextureCutOutOpacity;

	public string NoteTextureFile;

	public bool NoteTextureOn;

	public float NoteTextureOpacity;

	public float NoteTextureBlendColor;

	public float NoteTextureScale;

	public float NoteTextureRotation;

	public float NoteTexturePositionTopBottom;

	public float NoteTexturePositionLeftRight;

	public float NoteTextureBrightness;

	public float NoteTextureContrast;

	public float NoteTextureHue;

	public float NoteTextureSaturation;

	public bool NoteTextureMirroring;

	public static SeeMusicSettingsSave JFLNPJFABKF(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave NAFCDIEPLMJ(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave MBNDMBANKOB(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave COCNNDEEPFN(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave HNEJMGLFHBO(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave CMAKHFBLJGB(string LNMDPMBMJBI)
	{
		return null;
	}

	public void DBGMBNPGFJK(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave NGLOGCPKHLJ(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave NPEJPMGOJFC(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave JLNIGBNEDED(string LNMDPMBMJBI)
	{
		return null;
	}

	public void JKJIHGCMLIK(string LNMDPMBMJBI)
	{
	}

	public void OFKPNJEMECC(string LNMDPMBMJBI)
	{
	}

	public void BDNNADEGNGN(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave OADOPDGDGHN(string LNMDPMBMJBI)
	{
		return null;
	}

	public void NEPFJMDKDEF(string LNMDPMBMJBI)
	{
	}

	public void DPBMJOCPCEH(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave EGGBNMMCFGP(string LNMDPMBMJBI)
	{
		return null;
	}

	public void ALNHNILBLLD(string LNMDPMBMJBI)
	{
	}

	public void CLEBLOJOCAF(string LNMDPMBMJBI)
	{
	}

	public void LGFELPFIKJP(string LNMDPMBMJBI)
	{
	}

	public void INOKFKFBAMO(string LNMDPMBMJBI)
	{
	}

	public void GGBOIEEFHHO(string LNMDPMBMJBI)
	{
	}

	public void ELDKGODOGHE(string LNMDPMBMJBI)
	{
	}

	public void PKJHAAMLABE(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave PNCNDKJNCMC(string LNMDPMBMJBI)
	{
		return null;
	}

	public void GJEFNBBMGFL(string LNMDPMBMJBI)
	{
	}

	public void EMMDBBIMPCD(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave KKJBEFKBOPO(string LNMDPMBMJBI)
	{
		return null;
	}

	public void CDEJBAFODFA(string LNMDPMBMJBI)
	{
	}

	public void MCELABPGKHC(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave AIEFLFHNPHG(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave PIDOLIBOBGH(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave OPFJLKJNABE(string LNMDPMBMJBI)
	{
		return null;
	}

	public void HKPJIMGHBFI(string LNMDPMBMJBI)
	{
	}

	public void MIGDGBCEFNK(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave AGFLCJHDBFI(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave FJPDEGMKLPJ(string LNMDPMBMJBI)
	{
		return null;
	}

	public void GGLKJHJEBBG(string LNMDPMBMJBI)
	{
	}

	public void JOKKLBMPMBC(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave OGHAIGAGNFH(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave LEINOLCGICB(string LNMDPMBMJBI)
	{
		return null;
	}

	public void BKHDFBCLEBM(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave IMOPJDABLFA(string LNMDPMBMJBI)
	{
		return null;
	}

	public void LFBMNAOEFPL(string LNMDPMBMJBI)
	{
	}

	public void DHJMCHHLCJJ(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave CABGNCPBIOP(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave EMEFAHDJAHJ(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave LAAFNNCKLAA(string LNMDPMBMJBI)
	{
		return null;
	}

	public void JMHAHBMJIFP(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave GICCLNOOALB(string LNMDPMBMJBI)
	{
		return null;
	}

	public void EBFAIHBJLPO(string LNMDPMBMJBI)
	{
	}

	public static SeeMusicSettingsSave NBKHMOFEGLC(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave OLFJEIEEBJO(string LNMDPMBMJBI)
	{
		return null;
	}

	public static SeeMusicSettingsSave KMPAPJAAHDH(string LNMDPMBMJBI)
	{
		return null;
	}

	public void HMIHFGJBNNI(string LNMDPMBMJBI)
	{
	}

	public void DBIBNBNGHMD(string LNMDPMBMJBI)
	{
	}
}
