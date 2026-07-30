using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoPlaytimeUpdate_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VolumetricLightBeam _003C_003E4__this;

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
			public _003CCoPlaytimeUpdate_003Ed__126(int _003C_003E1__state)
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

		public bool colorFromLight;

		public ColorMode colorMode;

		[ColorUsage(true, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color;

		public Gradient colorGradient;

		public bool intensityFromLight;

		public bool intensityModeAdvanced;

		[FormerlySerializedAs("alphaInside")]
		[Range(0f, 8f)]
		public float intensityInside;

		[Range(0f, 8f)]
		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		public float intensityOutside;

		public BlendingMode blendingMode;

		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		public MeshType geomMeshType;

		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		public int geomCustomSegments;

		public bool geomCap;

		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		public AttenuationEquation attenuationEquation;

		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		public float depthBlendDistance;

		public float cameraClippingDistance;

		[Range(0f, 1f)]
		public float glareFrontal;

		[Range(0f, 1f)]
		public float glareBehind;

		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		public NoiseMode noiseMode;

		[FormerlySerializedAs("noiseEnabled")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Range(0f, 1f)]
		public float noiseIntensity;

		public bool noiseScaleUseGlobal;

		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		public bool noiseVelocityUseGlobal;

		public Vector3 noiseVelocityLocal;

		public float fadeOutBegin;

		public float fadeOutEnd;

		[SerializeField]
		private int pluginVersion;

		[SerializeField]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		private bool _TrackChangesDuringPlaytime;

		[SerializeField]
		private int _SortingLayerID;

		[SerializeField]
		private int _SortingOrder;

		private BeamGeometry m_BeamGeom;

		private Coroutine m_CoPlaytimeUpdate;

		private Light _CachedLight;

		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float intensityGlobal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float coneAngle => 0f;

		public float coneRadiusEnd => 0f;

		public float coneVolume => 0f;

		public float coneApexOffsetZ => 0f;

		public int geomSides
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int geomSegments
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float attenuationLerpLinearQuad => 0f;

		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isNoiseEnabled => false;

		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isFadeOutEnabled => false;

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool trackChangesDuringPlaytime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isCurrentlyTrackingChanges => false;

		public bool hasGeometry => false;

		public Bounds bounds => default(Bounds);

		public int blendingModeAsInt => 0;

		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		public string meshStats => null;

		public int meshVerticesCount => 0;

		public int meshTrianglesCount => 0;

		private Light lightSpotAttached => null;

		public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
		{
		}

		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return false;
		}

		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return 0f;
		}

		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return 0f;
		}

		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		public virtual void GenerateGeometry()
		{
		}

		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPlaytimeUpdate_003Ed__126))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void DestroyBeam()
		{
		}

		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		private void ClampProperties()
		{
		}

		private void ValidateProperties()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}
	}
}
