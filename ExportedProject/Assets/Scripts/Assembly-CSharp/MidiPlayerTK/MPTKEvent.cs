using System;
using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MPTKEvent : ICloneable
	{
		public enum EnumLength
		{
			Whole = 0,
			Half = 1,
			Quarter = 2,
			Eighth = 3,
			Sixteenth = 4
		}

		public long Track;

		public long Tick;

		public int Index;

		public long CreateTime;

		public float RealTime;

		public MPTKCommand Command;

		public MPTKController Controller;

		public MPTKMeta Meta;

		public string Info;

		public int Value;

		public int Channel;

		public int Velocity;

		public long Duration;

		public long Delay;

		public int Length;

		public uint Source;

		public int IdSession;

		public object Tag;

		public List<fluid_voice> Voices;

		public GenModifier[] GensModifier;

		public long durationTicks => 0L;

		public long DurationTicks => 0L;

		public bool IsOver => false;

		public long MPTK_LatenceTime => 0L;

		public long MPTK_LatenceTimeMillis => 0L;

		public virtual object Clone()
		{
			return null;
		}

		public MPTKEvent()
		{
		}

		public MPTKEvent(ulong data)
		{
		}

		public ulong ToData()
		{
			return 0uL;
		}

		public override string ToString()
		{
			return null;
		}

		public bool MTPK_ModifySynthParameter(fluid_gen_type genType, float value, MPTKModeGeneratorChange mode)
		{
			return false;
		}

		public void MTPK_StopEvent()
		{
		}

		private static int ConvertIdToIndex(fluid_gen_type genType)
		{
			return 0;
		}

		public float MTPK_GetSynthParameterDefaultValue(fluid_gen_type genType)
		{
			return 0f;
		}

		public static string MTPK_GetSynthParameterLabel(fluid_gen_type genType)
		{
			return null;
		}

		public static List<MPTKListItem> MTPK_GetSynthParameterListGenerator()
		{
			return null;
		}

		public void MTPK_ClearSynthParameter()
		{
		}
	}
}
