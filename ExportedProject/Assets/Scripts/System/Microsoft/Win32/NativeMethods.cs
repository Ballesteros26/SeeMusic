using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32
{
	internal static class NativeMethods
	{
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			targetHandle = null;
			return false;
		}

		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			targetHandle = null;
			return false;
		}

		public static IntPtr GetCurrentProcess()
		{
			return (IntPtr)0;
		}

		public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode)
		{
			exitCode = default(int);
			return false;
		}

		public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode)
		{
			exitCode = default(int);
			return false;
		}

		public static bool TerminateProcess(IntPtr processHandle, int exitCode)
		{
			return false;
		}

		public static bool TerminateProcess(SafeProcessHandle processHandle, int exitCode)
		{
			return false;
		}

		public static int WaitForInputIdle(IntPtr handle, int milliseconds)
		{
			return 0;
		}

		public static int WaitForInputIdle(SafeProcessHandle handle, int milliseconds)
		{
			return 0;
		}

		public static bool GetProcessWorkingSetSize(IntPtr handle, out IntPtr min, out IntPtr max)
		{
			min = default(IntPtr);
			max = default(IntPtr);
			return false;
		}

		public static bool GetProcessWorkingSetSize(SafeProcessHandle handle, out IntPtr min, out IntPtr max)
		{
			min = default(IntPtr);
			max = default(IntPtr);
			return false;
		}

		public static bool SetProcessWorkingSetSize(IntPtr handle, IntPtr min, IntPtr max)
		{
			return false;
		}

		public static bool SetProcessWorkingSetSize(SafeProcessHandle handle, IntPtr min, IntPtr max)
		{
			return false;
		}

		public static bool GetProcessTimes(IntPtr handle, out long creation, out long exit, out long kernel, out long user)
		{
			creation = default(long);
			exit = default(long);
			kernel = default(long);
			user = default(long);
			return false;
		}

		public static bool GetProcessTimes(SafeProcessHandle handle, out long creation, out long exit, out long kernel, out long user)
		{
			creation = default(long);
			exit = default(long);
			kernel = default(long);
			user = default(long);
			return false;
		}

		public static int GetCurrentProcessId()
		{
			return 0;
		}

		public static int GetPriorityClass(IntPtr handle)
		{
			return 0;
		}

		public static int GetPriorityClass(SafeProcessHandle handle)
		{
			return 0;
		}

		public static bool SetPriorityClass(IntPtr handle, int priorityClass)
		{
			return false;
		}

		public static bool SetPriorityClass(SafeProcessHandle handle, int priorityClass)
		{
			return false;
		}

		public static bool CloseProcess(IntPtr handle)
		{
			return false;
		}
	}
}
