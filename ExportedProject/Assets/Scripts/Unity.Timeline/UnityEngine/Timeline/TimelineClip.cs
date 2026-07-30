using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
	{
		private static class TimelineClipUpgrade
		{
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
			{
			}
		}

		public enum ClipExtrapolation
		{
			None = 0,
			Hold = 1,
			Loop = 2,
			PingPong = 3,
			Continue = 4
		}

		public enum BlendCurveMode
		{
			Auto = 0,
			Manual = 1
		}

		private const int k_LatestVersion = 1;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		public static readonly ClipCaps kDefaultClipCaps;

		public static readonly float kDefaultClipDurationInSeconds;

		public static readonly double kTimeScaleMin;

		public static readonly double kTimeScaleMax;

		internal static readonly string kDefaultCurvesName;

		internal static readonly double kMinDuration;

		internal static readonly double kMaxTimeValue;

		[SerializeField]
		private double m_Start;

		[SerializeField]
		private double m_ClipIn;

		[SerializeField]
		private Object m_Asset;

		[FormerlySerializedAs("m_HackDuration")]
		[SerializeField]
		private double m_Duration;

		[SerializeField]
		private double m_TimeScale;

		[SerializeField]
		private TrackAsset m_ParentTrack;

		[SerializeField]
		private double m_EaseInDuration;

		[SerializeField]
		private double m_EaseOutDuration;

		[SerializeField]
		private double m_BlendInDuration;

		[SerializeField]
		private double m_BlendOutDuration;

		[SerializeField]
		private AnimationCurve m_MixInCurve;

		[SerializeField]
		private AnimationCurve m_MixOutCurve;

		[SerializeField]
		private BlendCurveMode m_BlendInCurveMode;

		[SerializeField]
		private BlendCurveMode m_BlendOutCurveMode;

		[SerializeField]
		private List<string> m_ExposedParameterNames;

		[SerializeField]
		private AnimationClip m_AnimationCurves;

		[SerializeField]
		private bool m_Recordable;

		[SerializeField]
		private ClipExtrapolation m_PostExtrapolationMode;

		[SerializeField]
		private ClipExtrapolation m_PreExtrapolationMode;

		[SerializeField]
		private double m_PostExtrapolationTime;

		[SerializeField]
		private double m_PreExtrapolationTime;

		[SerializeField]
		private string m_DisplayName;

		public double timeScale => 0.0;

		public double start
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double duration
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double end => 0.0;

		public double clipIn => 0.0;

		public string displayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AnimationClip curves => null;

		string ICurvesOwner.defaultCurvesName => null;

		public Object asset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Object ICurvesOwner.assetOwner => null;

		TrackAsset ICurvesOwner.targetTrack => null;

		public double easeInDuration => 0.0;

		public double easeOutDuration => 0.0;

		public double blendInDuration => 0.0;

		public double blendOutDuration => 0.0;

		public bool hasBlendIn => false;

		public bool hasBlendOut => false;

		public AnimationCurve mixInCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double mixInDuration => 0.0;

		public AnimationCurve mixOutCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double mixOutTime => 0.0;

		public double mixOutDuration => 0.0;

		public bool recordable
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public ClipCaps clipCaps => default(ClipCaps);

		public ClipExtrapolation postExtrapolationMode
		{
			get
			{
				return default(ClipExtrapolation);
			}
			internal set
			{
			}
		}

		public ClipExtrapolation preExtrapolationMode
		{
			get
			{
				return default(ClipExtrapolation);
			}
			internal set
			{
			}
		}

		public double extrapolatedStart => 0.0;

		public double extrapolatedDuration => 0.0;

		private void UpgradeToLatestVersion()
		{
		}

		internal TimelineClip(TrackAsset parent)
		{
		}

		public TrackAsset GetParentTrack()
		{
			return null;
		}

		internal void SetParentTrack_Internal(TrackAsset newParentTrack)
		{
		}

		internal int Hash()
		{
			return 0;
		}

		public float EvaluateMixOut(double time)
		{
			return 0f;
		}

		public float EvaluateMixIn(double time)
		{
			return 0f;
		}

		private static AnimationCurve GetDefaultMixInCurve()
		{
			return null;
		}

		private static AnimationCurve GetDefaultMixOutCurve()
		{
			return null;
		}

		public double ToLocalTime(double time)
		{
			return 0.0;
		}

		private static double SanitizeTimeValue(double value, double defaultValue)
		{
			return 0.0;
		}

		internal void SetPostExtrapolationTime(double time)
		{
		}

		internal void SetPreExtrapolationTime(double time)
		{
		}

		public bool IsPreExtrapolatedTime(double sequenceTime)
		{
			return false;
		}

		public bool IsPostExtrapolatedTime(double sequenceTime)
		{
			return false;
		}

		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration)
		{
			return 0.0;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void UpdateDirty(double oldValue, double newValue)
		{
		}
	}
}
