using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace Unity.Jobs
{
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	public struct JobHandle
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr jobGroup;

		internal int version;

		public void Complete()
		{
		}

		public static void CompleteAll(NativeArray<JobHandle> jobs)
		{
		}

		[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = true, IsThreadSafe = true)]
		public static void ScheduleBatchedJobs()
		{
		}

		[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
		private static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
		{
		}

		[NativeMethod("ScheduleBatchedScriptingJobsAndCompleteAll", IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
		private unsafe static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
		{
		}

		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
		{
			return default(JobHandle);
		}

		[NativeMethod(IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
		private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
		{
			return default(JobHandle);
		}

		private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
