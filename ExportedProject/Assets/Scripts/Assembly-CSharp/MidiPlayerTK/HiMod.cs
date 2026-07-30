using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class HiMod
	{
		public const int FLUID_NUM_MOD = 64;

		public byte Dest;

		public byte Src1;

		public byte Flags1;

		public byte Src2;

		public byte Flags2;

		public float Amount;

		public ushort SfSrc;

		public ushort SfAmtSrc;

		public ushort SfTrans;

		public float fluid_mod_get_value(fluid_channel chan, int key, int vel)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}

		public static void DebugLog(string info, List<HiMod> mods)
		{
		}
	}
}
