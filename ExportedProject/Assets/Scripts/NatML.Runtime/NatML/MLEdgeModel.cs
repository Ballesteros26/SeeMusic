using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using NatML.API;
using NatML.API.Types;
using NatML.Features;
using NatML.Internal;
using UnityEngine;

namespace NatML
{
	public sealed class MLEdgeModel : MLModel
	{
		[Flags]
		public enum ComputeTarget
		{
			Default = 0,
			CPU = 1,
			GPU = 2,
			NPU = 4,
			All = 7
		}

		public sealed class Configuration
		{
			public ComputeTarget computeTarget;

			public IntPtr computeDevice;
		}

		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
		public sealed class EmbedAttribute : Attribute
		{
			internal readonly string tag;

			internal readonly string? accessKey;

			public EmbedAttribute(string tag, string? accessKey = null)
			{
			}
		}

		private sealed class ModelCreationRequest
		{
			public readonly PredictorSession session;

			public readonly TaskCompletionSource<MLEdgeModel> tcs;

			public ModelCreationRequest(PredictorSession session, TaskCompletionSource<MLEdgeModel> tcs)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreate_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MLEdgeModel> _003C_003Et__builder;

			public string tagOrPath;

			public NatMLClient client;

			public Configuration configuration;

			private PredictorSession _003Csession_003E5__2;

			private byte[] _003Cgraph_003E5__3;

			private TaskAwaiter<PredictorSession> _003C_003Eu__1;

			private TaskAwaiter<byte[]> _003C_003Eu__2;

			private TaskAwaiter _003C_003Eu__3;

			private GraphFormat? _003Cformat_003E5__4;

			private FileStream _003Cstream_003E5__5;

			private TaskAwaiter<int> _003C_003Eu__4;

			private TaskAwaiter<MLEdgeModel> _003C_003Eu__5;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSessionFromHub_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PredictorSession> _003C_003Et__builder;

			public NatMLClient client;

			public string tag;

			private TaskAwaiter<string> _003C_003Eu__1;

			private TaskAwaiter<PredictorSession> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadSessionGraph_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			public PredictorSession session;

			public NatMLClient client;

			private FileStream _003CfileStream_003E5__2;

			private byte[] _003Cgraph_003E5__3;

			private TaskAwaiter<int> _003C_003Eu__1;

			private TaskAwaiter<MemoryStream> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCacheSession_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PredictorSession session;

			public byte[] graph;

			private string _003CsessionPath_003E5__2;

			private FileStream _003CgraphStream_003E5__3;

			private StreamWriter _003CsessionStream_003E5__4;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private readonly IntPtr model;

		private readonly PredictorSession session;

		private readonly IntPtr[] rawInputFeatures;

		private readonly IntPtr[] rawOutputFeatures;

		private readonly MLEdgeFeature[] outputFeatures;

		private static string CachePath;

		private static RuntimePlatform Platform;

		private static string Device;

		private const string Extension = ".nml";

		public string[]? labels => null;

		public Normalization? normalization => null;

		public AspectMode aspectMode => default(AspectMode);

		public AudioFormat? audioFormat => null;

		public MLFeatureCollection<MLEdgeFeature> Predict(params MLEdgeFeature[] inputs)
		{
			return default(MLFeatureCollection<MLEdgeFeature>);
		}

		public override void Dispose()
		{
		}

		public static Task<MLEdgeModel> Create(string tagOrPath, Configuration? configuration = null, string? accessKey = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreate_003Ed__14))]
		public static Task<MLEdgeModel> Create(string tagOrPath, Configuration? configuration, NatMLClient client)
		{
			return null;
		}

		public static Task<MLEdgeModel> Create(MLModelData modelData, Configuration? configuration = null)
		{
			return null;
		}

		private MLEdgeModel(IntPtr model, PredictorSession session)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static Task<MLEdgeModel> Create(PredictorSession session, byte[] graph, Configuration? config)
		{
			return null;
		}

		internal static Task<string> CreateSecret()
		{
			return null;
		}

		internal static void ClearCache()
		{
		}

		[MonoPInvokeCallback(typeof(NatML.Internal.NatML.ModelCreationHandler))]
		private static void OnCreateModel(IntPtr context, IntPtr model)
		{
		}

		[MonoPInvokeCallback(typeof(NatML.Internal.NatML.SecretCreationHandler))]
		private static void OnCreateSecret(IntPtr context, IntPtr secret)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void OnInitialize()
		{
		}

		private static PredictorSession SessionFromCache(string tag)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSessionFromHub_003Ed__34))]
		private static Task<PredictorSession> SessionFromHub(string tag, NatMLClient client)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadSessionGraph_003Ed__35))]
		private static Task<byte[]> LoadSessionGraph(PredictorSession session, NatMLClient client)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCacheSession_003Ed__36))]
		private static Task CacheSession(PredictorSession session, byte[] graph)
		{
			return null;
		}

		private static string GetSessionCachePath(string tag)
		{
			return null;
		}

		private static string GetGraphCachePath(string fingerprint)
		{
			return null;
		}

		private static GraphFormat? FormatForFile(string path)
		{
			return null;
		}

		private static GraphFormat FormatForPlatform(RuntimePlatform platform)
		{
			return default(GraphFormat);
		}

		private static MLFeatureType? CreateFeatureType(in IntPtr type)
		{
			return null;
		}
	}
}
