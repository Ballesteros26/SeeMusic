using UnityEngine;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiController
	{
		string Id { get; }

		ControllerAlignment Alignment { get; }

		bool Colored { get; }

		Transform Transform { get; }

		RectTransform RectTransform { get; }

		IMidiKeys Keys { get; }

		IMidiPercussions Percussions { get; }

		IMidiButtons Buttons { get; }

		IMidiKnobs Knobs { get; }

		IMidiFaders Faders { get; }

		bool Hidden { get; }

		void Show(bool animated = true);

		void Hide(bool animated = true);

		void Align(ControllerAlignment alignment);

		Vector3 GetWorldPosition(ControllerPosition point);
	}
}
