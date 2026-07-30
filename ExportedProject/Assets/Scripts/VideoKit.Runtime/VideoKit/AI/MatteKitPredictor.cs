using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatML;
using UnityEngine;

namespace VideoKit.AI
{
	public sealed class MatteKitPredictor : IMLPredictor<object>, IDisposable
	{
		public enum Variant
		{
			Default = 0,
			_1280x720 = 1,
			_720x1280 = 2
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreate_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatteKitPredictor> _003C_003Et__builder;

			public Variant variant;

			public MLEdgeModel.Configuration configuration;

			private TaskAwaiter<MLEdgeModel> _003C_003Eu__1;

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

		public readonly Texture2D humanTexture;

		private readonly MLEdgeModel model;

		public object Predict(params MLFeature[] features)
		{
			return null;
		}

		public void Dispose()
		{
		}

		[AsyncStateMachine(typeof(_003CCreate_003Ed__4))]
		public static Task<MatteKitPredictor> Create(Variant variant = Variant.Default, MLEdgeModel.Configuration configuration = null)
		{
			return null;
		}

		private MatteKitPredictor(MLEdgeModel model)
		{
		}

		private static string GetTag(Variant variant)
		{
			return null;
		}

		private static Variant GetDefaultVariant()
		{
			return default(Variant);
		}
	}
}
