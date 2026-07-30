using System;
using System.Runtime.InteropServices;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
	public static class IJobExtensions
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		internal struct JobStruct<T> where T : struct, IJob
		{
			public delegate void ExecuteJobFunction(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

			public static readonly IntPtr jobReflectionData;

			public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
			}
		}

		public static JobHandle Schedule<T>(this T jobData, JobHandle dependsOn = default(JobHandle)) where T : struct, IJob
		{
			return default(JobHandle);
		}
	}
}
