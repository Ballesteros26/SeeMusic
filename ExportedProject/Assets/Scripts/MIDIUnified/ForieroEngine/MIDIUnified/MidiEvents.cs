using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ForieroEngine.MIDIUnified
{
	public class MidiEvents
	{
		public struct NoteDef
		{
			public readonly ChannelEnum Channel;

			public readonly NoteEnum Note;

			public readonly AccidentalEnum Accidental;

			public readonly OctaveEnum Octave;

			public NoteDef(ChannelEnum channel, NoteEnum note, AccidentalEnum accidental, OctaveEnum octave)
			{
				Channel = default(ChannelEnum);
				Note = default(NoteEnum);
				Accidental = default(AccidentalEnum);
				Octave = default(OctaveEnum);
			}
		}

		public static class Evaluator
		{
			public static bool Matches(NoteDef n, int id, int value, int channel)
			{
				return false;
			}
		}

		public delegate void NoteEventHandler(int aMidiId, int aValue, int aChannel);

		public delegate void PedalEventHandler(PedalEnum aPedal, int aValue, int aChannel);

		public delegate void ControllerEventHandler(ControllerEnum aControllerCommand, int aValue, int aChannel);

		public string Name;

		public int DeviceId;

		public bool log;

		public Action<string> OnLog;

		private List<IMidiSender> _generators;

		public event ShortMessageEventHandler ShortMessageEvent
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

		public event NoteEventHandler NoteOnEvent
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

		public event NoteEventHandler NoteOffEvent
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

		public event NoteEventHandler NoteAfterTouchEvent
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

		public event NoteEventHandler ProgramChangedEvent
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

		public event NoteEventHandler ChannelAfterTouchEvent
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

		public event NoteEventHandler PitchBendEvent
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

		public event ControllerEventHandler ControllerEvent
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

		public event PedalEventHandler PedalOnEvent
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

		public event PedalEventHandler PedalOffEvent
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

		public event ControllerEventHandler BankSelectEvent
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

		public event ControllerEventHandler ModulationEvent
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

		public event ControllerEventHandler BreathControllerEvent
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

		public event ControllerEventHandler FootControllerEvent
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

		public event ControllerEventHandler PortamentoTimeEvent
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

		public event ControllerEventHandler DataEntryEvent
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

		public event ControllerEventHandler MainVolumeEvent
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

		public event ControllerEventHandler BalanceEvent
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

		public event ControllerEventHandler PanEvent
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

		public event ControllerEventHandler ExpressionControllerEvent
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

		public event ControllerEventHandler EffectControl1Event
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

		public event ControllerEventHandler EffectControl2Event
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

		public event ControllerEventHandler GeneralPurposeController1Event
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

		public event ControllerEventHandler GeneralPurposeController2Event
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

		public event ControllerEventHandler GeneralPurposeController3Event
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

		public event ControllerEventHandler GeneralPurposeController4Event
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

		public event ControllerEventHandler BankSelectLSBEvent
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

		public event ControllerEventHandler ModulationLSBEvent
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

		public event ControllerEventHandler BreathControllerLSBEvent
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

		public event ControllerEventHandler FootControllerLSBEvent
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

		public event ControllerEventHandler PortamentoTimeLSBEvent
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

		public event ControllerEventHandler DataEntryLSBEvent
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

		public event ControllerEventHandler MainVolumeLSBEvent
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

		public event ControllerEventHandler BalanceLSBEvent
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

		public event ControllerEventHandler PanLSBEvent
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

		public event ControllerEventHandler ExpressionControllerLSBEvent
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

		public event ControllerEventHandler EffectControl1LSBEvent
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

		public event ControllerEventHandler EffectControl2LSBEvent
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

		public event ControllerEventHandler DamperPedalEvent
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

		public event ControllerEventHandler PortamentoEvent
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

		public event ControllerEventHandler SostenutoEvent
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

		public event ControllerEventHandler SoftPedalEvent
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

		public event ControllerEventHandler LegatoFootswitchEvent
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

		public event ControllerEventHandler Hold2Event
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

		public event ControllerEventHandler SoundController1Event
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

		public event ControllerEventHandler SoundController2Event
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

		public event ControllerEventHandler SoundController3Event
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

		public event ControllerEventHandler SoundController4Event
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

		public event ControllerEventHandler SoundController5Event
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

		public event ControllerEventHandler SoundController6Event
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

		public event ControllerEventHandler SoundController7Event
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

		public event ControllerEventHandler SoundController8Event
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

		public event ControllerEventHandler SoundController9Event
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

		public event ControllerEventHandler SoundController10Event
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

		public event ControllerEventHandler GeneralPurposeController5Event
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

		public event ControllerEventHandler GeneralPurposeController6Event
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

		public event ControllerEventHandler GeneralPurposeController7Event
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

		public event ControllerEventHandler GeneralPurposeController8Event
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

		public event ControllerEventHandler PortamentoControlEvent
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

		public event ControllerEventHandler Effects1DepthEvent
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

		public event ControllerEventHandler Effects2DepthEvent
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

		public event ControllerEventHandler Effects3DepthEvent
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

		public event ControllerEventHandler Effects4DepthEvent
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

		public event ControllerEventHandler Effects5DepthEvent
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

		public event ControllerEventHandler DataIncrementEvent
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

		public event ControllerEventHandler DataDecrementEvent
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

		public event ControllerEventHandler NonRegisteredParameteLSBEvent
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

		public event ControllerEventHandler NonRegisteredParameteMSBEvent
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

		public event ControllerEventHandler RegisteredParameterLSBEvent
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

		public event ControllerEventHandler RegisteredParameterMSBEvent
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

		public event ControllerEventHandler AllSoundOffEvent
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

		public event ControllerEventHandler ResetControllersEvent
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

		public event ControllerEventHandler AllNotesOffEvent
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

		public event ControllerEventHandler OmniModeOffEvent
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

		public event ControllerEventHandler OmniModeOnEvent
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

		private void ShortMessage(int aCommand, int aData1, int aData2, int deviceId)
		{
		}

		public bool HasSender(IMidiSender aSender)
		{
			return false;
		}

		public bool AddSender(IMidiSender aSender)
		{
			return false;
		}

		public void RemoveSender(IMidiSender aSender)
		{
		}

		public void RemoveAllSenders()
		{
		}

		~MidiEvents()
		{
		}

		public void Dispose()
		{
		}

		public void AddShortMessage(int aCommand, int aData1, int aData2, int aDeviceId = -1)
		{
		}

		public void AddShortMessage(int aChannel, int aCommand, int aData1, int aData2, int aDeviceId = -1)
		{
		}

		public void AddNoteOn(int midiIndex, int volume, int channel, int aDeviceId = -1)
		{
		}

		public void AddNoteOff(int midiIndex, int channel, int aDeviceId = -1)
		{
		}

		private void ProcessMidiMessage(int aCommand, int aData1, int aData2)
		{
		}
	}
}
