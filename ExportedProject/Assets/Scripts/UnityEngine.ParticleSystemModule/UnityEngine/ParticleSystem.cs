using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	public sealed class ParticleSystem : Component
	{
		public struct MainModule
		{
			internal ParticleSystem m_ParticleSystem;

			public MinMaxCurve startLifetime
			{
				get
				{
					return default(MinMaxCurve);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startSpeed
			{
				get
				{
					return default(MinMaxCurve);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("StartSizeX")]
			public MinMaxCurve startSize
			{
				get
				{
					return default(MinMaxCurve);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxGradient startColor
			{
				get
				{
					return default(MinMaxGradient);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float simulationSpeed
			{
				[NativeThrows]
				set
				{
				}
			}

			public int maxParticles
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal MainModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret)
			{
				ret = default(MinMaxCurve);
			}

			[SpecialName]
			private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret)
			{
				ret = default(MinMaxCurve);
			}

			[SpecialName]
			private static void set_startSpeed_Injected(ref MainModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void get_startSize_Injected(ref MainModule _unity_self, out MinMaxCurve ret)
			{
				ret = default(MinMaxCurve);
			}

			[SpecialName]
			private static void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret)
			{
				ret = default(MinMaxGradient);
			}

			[SpecialName]
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value)
			{
			}

			[SpecialName]
			private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static int get_maxParticles_Injected(ref MainModule _unity_self)
			{
				return 0;
			}

			[SpecialName]
			private static void set_maxParticles_Injected(ref MainModule _unity_self, int value)
			{
			}
		}

		public struct EmissionModule
		{
			internal ParticleSystem m_ParticleSystem;

			public MinMaxCurve rateOverTime
			{
				get
				{
					return default(MinMaxCurve);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal EmissionModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret)
			{
				ret = default(MinMaxCurve);
			}

			[SpecialName]
			private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value)
			{
			}
		}

		public struct ShapeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public ParticleSystemShapeType shapeType
			{
				[NativeThrows]
				set
				{
				}
			}

			public float randomDirectionAmount
			{
				[NativeThrows]
				set
				{
				}
			}

			public float radius
			{
				[NativeThrows]
				set
				{
				}
			}

			public float angle
			{
				[NativeThrows]
				set
				{
				}
			}

			public float length
			{
				[NativeThrows]
				set
				{
				}
			}

			public float arc
			{
				[NativeThrows]
				set
				{
				}
			}

			internal ShapeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value)
			{
			}

			[SpecialName]
			private static void set_randomDirectionAmount_Injected(ref ShapeModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_radius_Injected(ref ShapeModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_angle_Injected(ref ShapeModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_length_Injected(ref ShapeModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_arc_Injected(ref ShapeModule _unity_self, float value)
			{
			}
		}

		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle
		{
			private Vector3 m_Position;

			private Vector3 m_Velocity;

			private Vector3 m_AnimatedVelocity;

			private Vector3 m_InitialVelocity;

			private Vector3 m_AxisOfRotation;

			private Vector3 m_Rotation;

			private Vector3 m_AngularVelocity;

			private Vector3 m_StartSize;

			private Color32 m_StartColor;

			private uint m_RandomSeed;

			private uint m_ParentRandomSeed;

			private float m_Lifetime;

			private float m_StartLifetime;

			private int m_MeshIndex;

			private float m_EmitAccumulator0;

			private float m_EmitAccumulator1;

			private uint m_Flags;

			[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
			public float lifetime
			{
				set
				{
				}
			}

			public Vector3 position
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 velocity
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public float remainingLifetime
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float startLifetime
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Color32 startColor
			{
				set
				{
				}
			}

			public uint randomSeed
			{
				set
				{
				}
			}

			public float startSize
			{
				set
				{
				}
			}

			public float rotation
			{
				set
				{
				}
			}

			public Vector3 rotation3D
			{
				set
				{
				}
			}

			public Vector3 angularVelocity3D
			{
				set
				{
				}
			}
		}

		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxCurve
		{
			[SerializeField]
			private ParticleSystemCurveMode m_Mode;

			[SerializeField]
			private float m_CurveMultiplier;

			[SerializeField]
			private AnimationCurve m_CurveMin;

			[SerializeField]
			private AnimationCurve m_CurveMax;

			[SerializeField]
			private float m_ConstantMin;

			[SerializeField]
			private float m_ConstantMax;

			public ParticleSystemCurveMode mode
			{
				set
				{
				}
			}

			public float constantMax
			{
				set
				{
				}
			}

			public float constantMin
			{
				set
				{
				}
			}

			public float constant
			{
				set
				{
				}
			}

			public MinMaxCurve(float constant)
			{
				m_Mode = default(ParticleSystemCurveMode);
				m_CurveMultiplier = 0f;
				m_CurveMin = null;
				m_CurveMax = null;
				m_ConstantMin = 0f;
				m_ConstantMax = 0f;
			}

			public static implicit operator MinMaxCurve(float constant)
			{
				return default(MinMaxCurve);
			}
		}

		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxGradient
		{
			[SerializeField]
			private ParticleSystemGradientMode m_Mode;

			[SerializeField]
			private Gradient m_GradientMin;

			[SerializeField]
			private Gradient m_GradientMax;

			[SerializeField]
			private Color m_ColorMin;

			[SerializeField]
			private Color m_ColorMax;

			public ParticleSystemGradientMode mode
			{
				set
				{
				}
			}

			public Color color
			{
				set
				{
				}
			}

			public Gradient gradient
			{
				set
				{
				}
			}

			public MinMaxGradient(Color color)
			{
				m_Mode = default(ParticleSystemGradientMode);
				m_GradientMin = null;
				m_GradientMax = null;
				m_ColorMin = default(Color);
				m_ColorMax = default(Color);
			}

			public MinMaxGradient(Gradient gradient)
			{
				m_Mode = default(ParticleSystemGradientMode);
				m_GradientMin = null;
				m_GradientMax = null;
				m_ColorMin = default(Color);
				m_ColorMax = default(Color);
			}

			public static implicit operator MinMaxGradient(Color color)
			{
				return default(MinMaxGradient);
			}

			public static implicit operator MinMaxGradient(Gradient gradient)
			{
				return default(MinMaxGradient);
			}
		}

		public struct EmitParams
		{
			[NativeName("particle")]
			private Particle m_Particle;

			[NativeName("positionSet")]
			private bool m_PositionSet;

			[NativeName("velocitySet")]
			private bool m_VelocitySet;

			[NativeName("axisOfRotationSet")]
			private bool m_AxisOfRotationSet;

			[NativeName("rotationSet")]
			private bool m_RotationSet;

			[NativeName("rotationalSpeedSet")]
			private bool m_AngularVelocitySet;

			[NativeName("startSizeSet")]
			private bool m_StartSizeSet;

			[NativeName("startColorSet")]
			private bool m_StartColorSet;

			[NativeName("randomSeedSet")]
			private bool m_RandomSeedSet;

			[NativeName("startLifetimeSet")]
			private bool m_StartLifetimeSet;

			[NativeName("meshIndexSet")]
			private bool m_MeshIndexSet;

			[NativeName("applyShapeToPosition")]
			private bool m_ApplyShapeToPosition;

			public Vector3 position
			{
				set
				{
				}
			}

			public bool applyShapeToPosition
			{
				set
				{
				}
			}

			public Vector3 velocity
			{
				set
				{
				}
			}

			public float startLifetime
			{
				set
				{
				}
			}

			public float startSize
			{
				set
				{
				}
			}

			public float rotation
			{
				set
				{
				}
			}

			public Color32 startColor
			{
				set
				{
				}
			}
		}

		public struct ColorOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public MinMaxGradient color
			{
				[NativeThrows]
				set
				{
				}
			}

			internal ColorOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static void set_color_Injected(ref ColorOverLifetimeModule _unity_self, ref MinMaxGradient value)
			{
			}
		}

		public struct NoiseModule
		{
			internal ParticleSystem m_ParticleSystem;

			[NativeName("StrengthX")]
			public MinMaxCurve strength
			{
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strengthX
			{
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strengthY
			{
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strengthZ
			{
				[NativeThrows]
				set
				{
				}
			}

			public float frequency
			{
				[NativeThrows]
				set
				{
				}
			}

			public int octaveCount
			{
				[NativeThrows]
				set
				{
				}
			}

			public float octaveMultiplier
			{
				[NativeThrows]
				set
				{
				}
			}

			public float octaveScale
			{
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve scrollSpeed
			{
				[NativeThrows]
				set
				{
				}
			}

			internal NoiseModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static void set_strength_Injected(ref NoiseModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void set_strengthX_Injected(ref NoiseModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void set_strengthY_Injected(ref NoiseModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void set_strengthZ_Injected(ref NoiseModule _unity_self, ref MinMaxCurve value)
			{
			}

			[SpecialName]
			private static void set_frequency_Injected(ref NoiseModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_octaveCount_Injected(ref NoiseModule _unity_self, int value)
			{
			}

			[SpecialName]
			private static void set_octaveMultiplier_Injected(ref NoiseModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_octaveScale_Injected(ref NoiseModule _unity_self, float value)
			{
			}

			[SpecialName]
			private static void set_scrollSpeed_Injected(ref NoiseModule _unity_self, ref MinMaxCurve value)
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("SyncJobs(false)->IsPlaying")]
			get
			{
				return false;
			}
		}

		public int particleCount
		{
			[NativeName("SyncJobs(false)->GetParticleCount")]
			get
			{
				return 0;
			}
		}

		public bool useAutoRandomSeed
		{
			[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
			set
			{
			}
		}

		public MainModule main => default(MainModule);

		public EmissionModule emission => default(EmissionModule);

		public ShapeModule shape => default(ShapeModule);

		public ColorOverLifetimeModule colorOverLifetime => default(ColorOverLifetimeModule);

		public NoiseModule noise => default(NoiseModule);

		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
		}

		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Particle particle)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
		public void SetParticles([Out] Particle[] particles, int size, int offset)
		{
		}

		public void SetParticles([Out] Particle[] particles, int size)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
		public int GetParticles([Out][NotNull("ArgumentNullException")] Particle[] particles, int size, int offset)
		{
			return 0;
		}

		public int GetParticles([Out] Particle[] particles, int size)
		{
			return 0;
		}

		public int GetParticles([Out] Particle[] particles)
		{
			return 0;
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public void SetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public int GetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			return 0;
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		public void Play([DefaultValue("true")] bool withChildren)
		{
		}

		public void Play()
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = true)]
		public void Pause([DefaultValue("true")] bool withChildren)
		{
		}

		public void Pause()
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = true)]
		public void Clear([DefaultValue("true")] bool withChildren)
		{
		}

		public void Clear()
		{
		}

		[RequiredByNativeCode]
		public void Emit(int count)
		{
		}

		[NativeName("SyncJobs()->Emit")]
		private void Emit_Internal(int count)
		{
		}

		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(EmitParams emitParams, int count)
		{
		}

		[NativeName("SyncJobs()->EmitParticleExternal")]
		private void EmitOld_Internal(ref Particle particle)
		{
		}

		private void Emit_Injected(ref EmitParams emitParams, int count)
		{
		}
	}
}
