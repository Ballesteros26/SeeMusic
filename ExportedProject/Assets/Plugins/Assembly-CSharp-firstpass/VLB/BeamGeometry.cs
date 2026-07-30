using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	[AddComponentMenu(null)]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoUpdateFadeOut_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeamGeometry _003C_003E4__this;

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
			public _003CCoUpdateFadeOut_003Ed__26(int _003C_003E1__state)
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

		private VolumetricLightBeam m_Master;

		private Matrix4x4 m_ColorGradientMatrix;

		private MeshType m_CurrentMeshType;

		private Material m_CustomMaterial;

		private DynamicOcclusion _dynamicOcclusion;

		public MeshRenderer meshRenderer { get; private set; }

		public MeshFilter meshFilter { get; private set; }

		public Mesh coneMesh { get; private set; }

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public static bool isCustomRenderPipelineSupported => false;

		private bool isNoiseEnabled => false;

		private bool isClippingPlaneEnabled => false;

		private bool isDepthBlendEnabled => false;

		public DynamicOcclusion dynamicOcclusion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__26))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		private void ComputeFadeOutFactor()
		{
		}

		private void SetFadeOutFactorProp(float value)
		{
		}

		private void RestartFadeOutCoroutine()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private static bool IsUsingCustomRenderPipeline()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize(VolumetricLightBeam master)
		{
		}

		public void RegenerateMesh()
		{
		}

		private void ComputeLocalMatrix()
		{
		}

		private bool ApplyMaterial()
		{
			return false;
		}

		private void SetMaterialProp(int nameID, float value)
		{
		}

		private void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		private void SetMaterialProp(int nameID, Color value)
		{
		}

		private void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		private void MaterialChangeStart()
		{
		}

		private void MaterialChangeStop()
		{
		}

		private void SendMaterialClippingPlaneProp()
		{
		}

		public void UpdateMaterialAndBounds()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		private void OnWillRenderObject()
		{
		}

		private static bool IsEditorCamera(Camera cam)
		{
			return false;
		}

		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}
	}
}
