using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

internal static class Interop
{
	internal enum BOOL
	{
		FALSE = 0,
		TRUE = 1
	}

	internal static class Advapi32
	{
		[PreserveSig]
		internal static extern bool ImpersonateNamedPipeClient(SafePipeHandle hNamedPipe);

		[PreserveSig]
		internal static extern bool RevertToSelf();
	}

	internal class Kernel32
	{
		internal struct SECURITY_ATTRIBUTES
		{
			internal uint nLength;

			internal IntPtr lpSecurityDescriptor;

			internal BOOL bInheritHandle;
		}

		[PreserveSig]
		internal unsafe static extern bool CancelIoEx(SafeHandle handle, NativeOverlapped* lpOverlapped);

		[PreserveSig]
		internal static extern bool CloseHandle(IntPtr handle);

		[PreserveSig]
		internal unsafe static extern bool ConnectNamedPipe(SafePipeHandle handle, NativeOverlapped* overlapped);

		[PreserveSig]
		internal static extern bool ConnectNamedPipe(SafePipeHandle handle, IntPtr overlapped);

		[PreserveSig]
		internal static extern SafePipeHandle CreateNamedPipe(string pipeName, int openMode, int pipeMode, int maxInstances, int outBufferSize, int inBufferSize, int defaultTimeout, ref SECURITY_ATTRIBUTES securityAttributes);

		[PreserveSig]
		internal static extern SafePipeHandle CreateNamedPipeClient(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, ref SECURITY_ATTRIBUTES secAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

		[PreserveSig]
		internal unsafe static extern int ReadFile(SafeHandle handle, byte* bytes, int numBytesToRead, out int numBytesRead, IntPtr mustBeZero);

		[PreserveSig]
		internal unsafe static extern int ReadFile(SafeHandle handle, byte* bytes, int numBytesToRead, IntPtr numBytesRead_mustBeZero, NativeOverlapped* overlapped);

		[PreserveSig]
		internal static extern bool WaitNamedPipe(string name, int timeout);

		[PreserveSig]
		internal unsafe static extern int WriteFile(SafeHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

		[PreserveSig]
		internal unsafe static extern int WriteFile(SafeHandle handle, byte* bytes, int numBytesToWrite, IntPtr numBytesWritten_mustBeZero, NativeOverlapped* lpOverlapped);
	}
}
