using System;
using ForieroEngine.MIDIUnified;
using UnityEngine;

public static class MidiExtensions
{
	public static void Log(this byte[] data, int deviceId, string prefix = "", string format = "X")
	{
	}

	public static int ToInt(this Enum enumValue)
	{
		return 0;
	}

	public static ControllerEnum ToControllerEnum(this int i)
	{
		return default(ControllerEnum);
	}

	public static int ToRawMidiCommand(int command, int channel)
	{
		return 0;
	}

	public static int ToMidiCommand(this int i)
	{
		return 0;
	}

	public static int ToMidiChannel(this int i)
	{
		return 0;
	}

	public static int ToVolume(this float volume)
	{
		return 0;
	}

	public static float ToVolume(this int attack)
	{
		return 0f;
	}

	public static Color ToMidiColor(this int i)
	{
		return default(Color);
	}

	public static bool IsToneON(this int i)
	{
		return false;
	}

	public static bool IsToneOFF(this int i)
	{
		return false;
	}

	public static int ShiftL(this int i, int bits)
	{
		return 0;
	}

	public static int ShiftR(this int i, int bits)
	{
		return 0;
	}

	public static int WriteBit(this int i, byte bit, bool bitValue)
	{
		return 0;
	}

	public static bool ReadBit(this int i, byte bit)
	{
		return false;
	}

	public static bool IsInByteRange(this int i)
	{
		return false;
	}

	public static bool IsInMidiRange(this int pitch)
	{
		return false;
	}

	public static int Octave(this int i)
	{
		return 0;
	}

	public static int PositionInOctave(this int i)
	{
		return 0;
	}

	public static bool IsInChannelRange(this int i)
	{
		return false;
	}

	public static bool IsWhiteKey(this int i)
	{
		return false;
	}

	public static bool IsBlackKey(this int i)
	{
		return false;
	}

	public static int BaseMidiIndex(this int i)
	{
		return 0;
	}

	public static int MidiIndex(this OctaveEnum o, int shift = 24)
	{
		return 0;
	}

	public static int PrevWhiteKey(this int i)
	{
		return 0;
	}

	public static int NextWhiteKey(this int i)
	{
		return 0;
	}

	public static int PrevBlackKey(this int i)
	{
		return 0;
	}

	public static int NextBlackKey(this int i)
	{
		return 0;
	}

	public static byte ToRawMidiCommand(byte command, byte channel)
	{
		return 0;
	}

	public static ControllerEnum ToControllerEnum(this byte i)
	{
		return default(ControllerEnum);
	}

	public static byte ToMidiCommand(this byte i)
	{
		return 0;
	}

	public static byte ToMidiChannel(this byte i)
	{
		return 0;
	}

	public static Color ToMidiColor(this byte i)
	{
		return default(Color);
	}

	public static bool IsToneON(this byte i)
	{
		return false;
	}

	public static bool IsToneOFF(this byte i)
	{
		return false;
	}

	public static bool IsControlChange(this byte i)
	{
		return false;
	}

	public static byte ShiftL(this byte i, int bits)
	{
		return 0;
	}

	public static byte ShiftR(this byte i, int bits)
	{
		return 0;
	}

	public static bool IsInByteRange(this byte i)
	{
		return false;
	}

	public static bool IsInMidiRange(this byte pitch)
	{
		return false;
	}

	public static byte Octave(this byte i)
	{
		return 0;
	}

	public static byte PositionInOctave(this byte i)
	{
		return 0;
	}

	public static bool IsInChannelRange(this byte i)
	{
		return false;
	}

	public static bool IsWhiteKey(this byte i)
	{
		return false;
	}

	public static bool IsBlackKey(this byte i)
	{
		return false;
	}

	public static byte BaseMidiIndex(this byte i)
	{
		return 0;
	}

	public static byte PrevWhiteKey(this byte i)
	{
		return 0;
	}

	public static byte NextWhiteKey(this byte i)
	{
		return 0;
	}

	public static byte PrevBlackKey(this byte i)
	{
		return 0;
	}

	public static byte NextBlackKey(this byte i)
	{
		return 0;
	}
}
