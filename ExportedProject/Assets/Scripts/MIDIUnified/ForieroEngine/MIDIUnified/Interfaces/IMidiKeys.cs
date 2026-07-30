using System.Collections.Generic;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiKeys : IMidiObjects
	{
		SortedDictionary<int, IMidiKey> Keys { get; }

		bool KeyExists(int i)
		{
			return false;
		}

		void KeyDown(int i, int aVolume)
		{
		}

		void KeyUp(int i)
		{
		}

		Vector3 GetKeyPosition(int i)
		{
			return default(Vector3);
		}

		Vector3 GetKeyLocalPosition(int i)
		{
			return default(Vector3);
		}

		void ColorKey(int i, Color aColor)
		{
		}

		Color GetKeyDownColor(int i)
		{
			return default(Color);
		}

		Color GetKeyUpColor(int i)
		{
			return default(Color);
		}

		Color GetKeyDownColorDefault(int i)
		{
			return default(Color);
		}

		Color GetKeyUpColorDefault(int i)
		{
			return default(Color);
		}

		void SetKeyDownColor(int i, Color aColor)
		{
		}

		void SetKeyUpColor(int i, Color aColor)
		{
		}

		void ColorKeyDown(int i)
		{
		}

		void ColorKeyUp(int i)
		{
		}

		bool IsKeyDown(int i)
		{
			return false;
		}

		KeyType GetKeyType(int i)
		{
			return default(KeyType);
		}

		void SetTheorySystem(TheorySystemEnum theorySystem, KeySignatureEnum keySignature)
		{
		}

		void OctaveSetWhiteKeysUpColor(int anOctave, Color aColor)
		{
		}

		void OctaveSetWhiteKeysUpColorDefault(int anOctave)
		{
		}

		void AllKeysUp()
		{
		}

		void AllKeysDown()
		{
		}
	}
}
