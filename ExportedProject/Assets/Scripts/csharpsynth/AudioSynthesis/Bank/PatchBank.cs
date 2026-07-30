using System;
using System.Collections.Generic;
using System.IO;
using AudioSynthesis.Bank.Patches;
using AudioSynthesis.Sf2;

namespace AudioSynthesis.Bank
{
	public class PatchBank
	{
		public const float BankVersion = 1f;

		public const int DrumBank = 128;

		public const int BankSize = 128;

		private static Dictionary<string, Type> patchTypes;

		private Dictionary<int, Patch[]> bank;

		private AssetManager assets;

		private string bankName;

		private string comment;

		static PatchBank()
		{
		}

		public static void ClearCustomPatchTypes()
		{
		}

		public PatchBank(IResource bankFile)
		{
		}

		public void LoadBank(IResource bankFile)
		{
		}

		public Patch GetPatch(int bankNumber, int patchNumber)
		{
			return null;
		}

		public bool IsBankLoaded(int bankNumber)
		{
			return false;
		}

		private void LoadMyBank(Stream stream)
		{
		}

		private void LoadSf2(Stream stream)
		{
		}

		private Sf2Region[][] ReadSf2Instruments(Instrument[] instruments)
		{
			return null;
		}

		private void ReadSf2Region(Sf2Region region, Generator[] globals, Generator[] gens, bool isRelative)
		{
		}

		private void AssignPatchToBank(Patch patch, int bankNumber, int startRange, int endRange)
		{
		}
	}
}
