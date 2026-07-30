using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MidiPlayerTK
{
	public class fluid_voice
	{
		[CompilerGenerated]
		private sealed class _003CRelease_003Ed__99 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public fluid_voice _003C_003E4__this;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRelease_003Ed__99(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public long TimeAtStart;

		public long TimeFromStart;

		public long TimeAtEnd;

		public long NewTimeWrite;

		public long LastTimeWrite;

		public long DeltaTimeWrite;

		private long ticks;

		public MidiSynth synth;

		public MPTKEvent MptkEvent;

		public int IndexActive;

		public long LatenceTick;

		public VoiceAudioSource VoiceAudio;

		public float StartVolume;

		public bool IsLoop;

		public static int LastId;

		public int IdVoice;

		public int IdSession;

		public long DurationTick;

		public long Duration;

		public const uint Nano100ToMilli = 10000u;

		public const int NO_CHANNEL = 255;

		public const float FLUID_MAX_AUDIBLE_FILTER_FC = 19000f;

		public const float FLUID_MIN_AUDIBLE_FILTER_Q = 1.2f;

		public const float FLUID_NOISE_FLOOR = 3E-05f;

		public const int FLUID_MIN_LOOP_SIZE = 2;

		public const int FLUID_MIN_LOOP_PAD = 0;

		public const float FLUID_MIN_VOLENVRELEASE = -7200f;

		public const float M_PI = (float)Math.PI;

		public fluid_voice_status status;

		public int chan;

		public int key;

		public int vel;

		public fluid_channel midiChannel;

		public mptk_channel mptkChannel;

		public HiGen[] gens;

		public List<HiMod> mods;

		public int mod_count;

		public bool has_looped;

		public HiSample sample;

		public int check_sample_sanity_flag;

		public float output_rate;

		public uint FluidTicks;

		public float amp;

		public ulong phase;

		public float phase_incr;

		public float amp_incr;

		public float[] dsp_buf;

		public float pitch_update;

		public float attenuation;

		public float min_attenuation_cB;

		public float root_pitch;

		public int start;

		public int end;

		public int loopstart;

		public int loopend;

		public fluid_env_data[] volenv_data;

		public long volenv_count;

		public fluid_voice_envelope_index volenv_section;

		public float volenv_val;

		public fluid_env_data[] modenv_data;

		public long modenv_count;

		public fluid_voice_envelope_index modenv_section;

		public float modenv_val;

		public float modenv_to_fc;

		public float modenv_to_pitch;

		public float modlfo_val;

		public uint modlfo_delay;

		public float modlfo_incr;

		public float modlfo_to_fc;

		public float modlfo_to_pitch;

		public float modlfo_to_vol;

		public float viblfo_val;

		public long viblfo_delay;

		public float viblfo_incr;

		public float viblfo_to_pitch;

		public float pan;

		private float amp_left;

		private float amp_right;

		private static int[] list_of_generators_to_initialize;

		private static int[] list_of_weakgenerators_to_initialize;

		public const float _ratioHalfTone = 1.0594631f;

		public bool weakDevice;

		public float q_dB;

		public float fres;

		public float reverb_send;

		private float amp_reverb;

		public float chorus_send;

		private float amp_chorus;

		public fluid_iir_filter resonant_filter;

		public static long TicksToMilli(long ticks)
		{
			return 0L;
		}

		public static float TicksToMilliF(long ticks)
		{
			return 0f;
		}

		public fluid_voice(MidiSynth psynth)
		{
		}

		public void fluid_voice_init(mptk_channel mchannel, fluid_channel pchannel, int pkey, int pvel)
		{
		}

		public void fluid_voice_add_mod(HiMod pmod, fluid_voice_addorover_mod mode)
		{
		}

		public void fluid_voice_start(MPTKEvent note)
		{
		}

		private void fluid_voice_calculate_runtime_synthesis_parameters()
		{
		}

		private float fluid_voice_get_lower_boundary_for_attenuation()
		{
			return 0f;
		}

		public void fluid_voice_update_param(int igen)
		{
		}

		private float CalculateGeneratorValue(int igen)
		{
			return 0f;
		}

		private uint calculate_hold_decay_buffers(int gen_base, int gen_key2base, bool is_decay)
		{
			return 0u;
		}

		private float calculate_hold_decay_ms(int gen_base, int gen_key2base, bool is_decay)
		{
			return 0f;
		}

		public void fluid_voice_modulate(int cc, int ctrl)
		{
		}

		public void fluid_voice_modulate_all()
		{
		}

		private void fluid_voice_check_sample_sanity()
		{
		}

		public int fluid_voice_write(long onAudioFilterTicks, float[] dsp_left_buf, float[] dsp_right_buf, float[] dsp_reverb_buf, float[] dsp_chorus_buf)
		{
			return 0;
		}

		private void fluid_voice_effects(int count, float[] dsp_left_buf, float[] dsp_right_buf, float[] dsp_reverb_buf, float[] dsp_chorus_buf)
		{
		}

		[IteratorStateMachine(typeof(_003CRelease_003Ed__99))]
		public IEnumerator<float> Release()
		{
			return null;
		}

		public void fluid_voice_noteoff(bool force = false)
		{
		}

		public int fluid_voice_kill_excl()
		{
			return 0;
		}

		public void fluid_voice_off()
		{
		}

		public void DebugKillByExclusive(string info)
		{
		}

		public void DebugSynth(string info)
		{
		}

		public void DebugOverload(string info)
		{
		}

		public void DebugVolume(string info)
		{
		}

		public void DebugVolEnv(string info)
		{
		}

		public void DebugModEnv(string info)
		{
		}

		public void DebugLFO(string info)
		{
		}

		public void DebugVib(string info)
		{
		}

		private void InitFilter()
		{
		}

		private void CalcAndApplyFilter(int count)
		{
		}

		private void ApplyEffect(int count, float[] dsp_reverb_buf, float[] dsp_chorus_buf)
		{
		}
	}
}
