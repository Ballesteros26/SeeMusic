using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Function.Graph;
using Function.Types;

namespace Function.Services
{
	public sealed class PredictionService
	{
		private sealed class CreatePredictionInput
		{
			public string tag;

			public string client;

			public ValueInput[]? inputs;

			public int? dataUrlLimit;
		}

		private sealed class ValueInput : Value
		{
			public string name;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[StructLayout((LayoutKind)3)]
			private struct _003C_003CCreate_003Eb__0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<ValueInput> _003C_003Et__builder;

				public KeyValuePair<string, object> pair;

				public _003C_003Ec__DisplayClass0_0 _003C_003E4__this;

				private string _003Cname_003E5__2;

				private TaskAwaiter<Value> _003C_003Eu__1;

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
			private struct _003C_003CCreate_003Eb__1_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

				public object r;

				public _003C_003Ec__DisplayClass0_0 _003C_003E4__this;

				private TaskAwaiter<object> _003C_003Eu__1;

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

			public PredictionService _003C_003E4__this;

			public string key;

			public bool rawOutputs;

			[AsyncStateMachine(typeof(_003C_003CCreate_003Eb__0_003Ed))]
			internal Task<ValueInput> _003CCreate_003Eb__0(KeyValuePair<string, object> pair)
			{
				return null;
			}

			[AsyncStateMachine(typeof(_003C_003CCreate_003Eb__1_003Ed))]
			internal Task<object> _003CCreate_003Eb__1(object r)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreate_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Prediction> _003C_003Et__builder;

			public PredictionService _003C_003E4__this;

			public bool rawOutputs;

			public Dictionary<string, object> inputs;

			public string tag;

			public int? dataUrlLimit;

			private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

			private Prediction _003Cprediction_003E5__2;

			private TaskAwaiter<ValueInput[]> _003C_003Eu__1;

			private TaskAwaiter<Prediction?> _003C_003Eu__2;

			private CloudPrediction _003C_003E7__wrap2;

			private TaskAwaiter<object[]> _003C_003Eu__3;

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
		private struct _003CToObject_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

			public Value value;

			public PredictionService _003C_003E4__this;

			private TaskAwaiter<MemoryStream> _003C_003Eu__1;

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
		private struct _003CToValue_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Value> _003C_003Et__builder;

			public object value;

			public PredictionService _003C_003E4__this;

			public string name;

			public int minUploadSize;

			public string key;

			public int[] shape;

			public Dtype? type;

			private float[] _003Cx_003E5__2;

			private double[] _003Cx_003E5__3;

			private sbyte[] _003Cx_003E5__4;

			private short[] _003Cx_003E5__5;

			private int[] _003Cx_003E5__6;

			private long[] _003Cx_003E5__7;

			private byte[] _003Cx_003E5__8;

			private ushort[] _003Cx_003E5__9;

			private uint[] _003Cx_003E5__10;

			private ulong[] _003Cx_003E5__11;

			private bool[] _003Cx_003E5__12;

			private Value _003C_003E7__wrap12;

			private Value _003C_003E7__wrap13;

			private TaskAwaiter<string> _003C_003Eu__1;

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

		private readonly IGraphClient client;

		private readonly StorageService storage;

		public const string Fields = "\n        id\n        tag\n        type\n        created\n        ... on CloudPrediction {\n            results {\n                data\n                type\n                shape\n            }\n            latency\n            error\n            logs\n        }\n        ";

		[AsyncStateMachine(typeof(_003CCreate_003Ed__0))]
		public Task<Prediction> Create(string tag, Dictionary<string, object>? inputs = null, bool rawOutputs = false, int? dataUrlLimit = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToObject_003Ed__1))]
		public Task<object> ToObject(Value value)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CToValue_003Ed__2))]
		public Task<Value> ToValue(object value, string name, Dtype? type = null, int[] shape = null, int minUploadSize = 4096, string? key = null)
		{
			return null;
		}

		internal PredictionService(IGraphClient client, StorageService storage)
		{
		}

		private static Stream ToStream(string data)
		{
			return null;
		}

		private static Stream ToStream<T>(T[] data) where T : struct
		{
			return null;
		}

		private static T[] ToArray<T>(MemoryStream stream) where T : struct
		{
			return null;
		}

		private static T ToScalar<T>(MemoryStream stream) where T : struct
		{
			return default(T);
		}
	}
}
