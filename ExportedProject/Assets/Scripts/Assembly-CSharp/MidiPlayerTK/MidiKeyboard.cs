using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace MidiPlayerTK
{
	public class MidiKeyboard
	{
		public enum PluginError
		{
			OK = 0,
			UNSPECIFIED = 1,
			BADDEVICEID = 2,
			DRIVERNOTENABLED = 3,
			DEVICEALLOCATED = 4,
			INVALHANDLE = 5,
			NODRIVER = 6,
			NOMEM = 7,
			NOTSUPPORTED = 8,
			BADERRNUM = 9,
			INVALFLAG = 10,
			INVALPARAM = 11,
			HANDLEBUSY = 12,
			INVALIDALIAS = 13,
			BADDB = 14,
			KEYNOTFOUND = 15,
			READERROR = 16,
			WRITEERROR = 17,
			DELETEERROR = 18,
			VALNOTFOUND = 19,
			NODRIVERCB = 20,
			MOREDATA = 21,
			LASTERROR = 21
		}

		public delegate void MidiMsgDelegate(ulong data);

		public delegate void DebugDelegate(IntPtr p1, int p2);

		private static string msgPluginsNotFound;

		public static PluginError MPTK_LastStatus => default(PluginError);

		[HideInInspector]
		public static event Action<MPTKEvent> OnActionInputMidi
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[PreserveSig]
		public static extern int MPTK_ClearReadQueue();

		public static MPTKEvent MPTK_Read()
		{
			return null;
		}

		[PreserveSig]
		private static extern ulong _mptkRead();

		[PreserveSig]
		public static extern int MPTK_SizeReadQueue();

		[PreserveSig]
		public static extern int MPTK_CountInp();

		[PreserveSig]
		public static extern int MPTK_CountOut();

		public static string MPTK_GetInpName(int index)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr _mptkGetInpName(int index);

		public static string MPTK_GetOutName(int index)
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr _mptkGetOutName(int index);

		[PreserveSig]
		public static extern void MPTK_OpenOut(int index);

		[PreserveSig]
		public static extern void MPTK_CloseOut(int index);

		public static void MPTK_PlayEvent(MPTKEvent evnt, int device)
		{
		}

		private static void delayedPlayThread(int device, ulong data, float delayMS)
		{
		}

		[PreserveSig]
		private static extern void _mptkWrite(int index, ulong data);

		[PreserveSig]
		public static extern void MPTK_OpenAllInp();

		[PreserveSig]
		public static extern void MPTK_CloseAllInp();

		public static void MPTK_ExcludeSystemMessage(bool exclude)
		{
		}

		[PreserveSig]
		private static extern void mptkExcludeSystemMessage(bool exclude);

		public static string MPTK_Version()
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr _mptkVersion();

		[PreserveSig]
		private static extern int MPTK_iVersion();

		public static void MPTK_SetRealTimeRead()
		{
		}

		[PreserveSig]
		private static extern void MPTKSetMidiMsgCB(MidiMsgDelegate fp);

		private static void MidiMsgCB(ulong data)
		{
		}

		public static void MPTK_UnsetRealTimeRead()
		{
		}

		[PreserveSig]
		private static extern void MPTKUnsetMidiMsgCB();

		private static void DebugCallBack(IntPtr n, int m)
		{
		}

		[PreserveSig]
		private static extern void SetDebugCB(DebugDelegate fp);

		[PreserveSig]
		private static extern void UnsetDebugCB();

		public static bool MPTK_Init()
		{
			return false;
		}

		[PreserveSig]
		private static extern void _mptkInit(int sig);

		[PreserveSig]
		private static extern int mptkLastStatus();
	}
}
