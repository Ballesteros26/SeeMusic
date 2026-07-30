using System;

namespace Unity.Burst
{
	public sealed class BurstCompilerOptions
	{
		internal static readonly bool ForceDisableBurstCompilation;

		private static readonly bool ForceBurstCompilationSynchronously;

		internal static readonly bool IsSecondaryUnityProcess;

		private bool _enableBurstCompilation;

		private bool _enableBurstSafetyChecks;

		private bool IsGlobal { get; }

		public bool EnableBurstCompilation
		{
			set
			{
			}
		}

		public bool EnableBurstSafetyChecks
		{
			set
			{
			}
		}

		internal Action OptionsChanged { get; }

		internal BurstCompilerOptions(bool isGlobal)
		{
		}

		private void OnOptionsChanged()
		{
		}

		private void MaybeTriggerRecompilation()
		{
		}

		static BurstCompilerOptions()
		{
		}

		private static bool CheckIsSecondaryUnityProcess()
		{
			return false;
		}
	}
}
