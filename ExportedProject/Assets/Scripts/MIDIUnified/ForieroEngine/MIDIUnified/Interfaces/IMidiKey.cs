using UnityEngine;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiKey : IMidiObject
	{
		ToneEnum Tone { get; }

		KeyType KeyType { get; }

		bool IsDown { get; }

		Color DefaultDownColor { get; }

		Color DefaultUpColor { get; }

		Color DownColor { get; }

		Color UpColor { get; }

		Color HighlightColor { get; }

		Color DefaultUpColorWhiteKey { get; }

		Color DefaultUpColorBlackKey { get; }

		void ColorKey(Color aColor);

		void ColorOn();

		void ColorOff();

		void SetKeyUp();

		void SetKeyDown();

		void TurnOffFace();

		void TurnOnFace();

		KeyType GetKeyType();

		Vector3 GetPosition();

		Vector3 GetLocalPosition();

		Color GetDownColor();

		Color GetUpColor();

		Color GetDownColorDefault();

		Color GetUpColorDefault();

		void SetDownColor(Color aColor);

		void SetUpColor(Color aColor);

		void SetDownColorDefault(Color aColor);

		void SetUpColorDefault(Color aColor);

		bool GetIsDown();

		GameObject GetGameObject();

		void SetTheorySystem(TheorySystemEnum theorySystem, KeySignatureEnum keySignatureEnum);
	}
}
