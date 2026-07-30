using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MidiSelectionUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MidiSelectionUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
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
		public _003CStart_003Ed__21(int _003C_003E1__state)
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

	private int _minWidth;

	private int _minHeight;

	public int minWidth;

	public int widthMargin;

	public int minHeight;

	public RectTransform midiPanel;

	public RectTransform inPanel;

	public RectTransform outPanel;

	public Toggle inActiveToggle;

	public Toggle inOutToggle;

	public Toggle inThroughToggle;

	public Toggle inSynthToggle;

	public Toggle inThreadedToggle;

	public Toggle outActiveToggle;

	public Toggle outSynthToggle;

	public Toggle outThreadedToggle;

	public Color connectedColor;

	public Color disconnectedColor;

	public GameObject PREFAB_MidiDeviceButton;

	private List<MidiSelectionUIDeviceButton> INs;

	private List<MidiSelectionUIDeviceButton> OUTs;

	[IteratorStateMachine(typeof(_003CStart_003Ed__21))]
	private IEnumerator Start()
	{
		return null;
	}

	public void OnInActiveToggle()
	{
	}

	public void OnInOutToggle()
	{
	}

	public void OnInThroughToggle()
	{
	}

	public void OnInSynthToggle()
	{
	}

	public void OnInThreadedToggle()
	{
	}

	public void OnOutActiveToggle()
	{
	}

	public void OnOutSynthToggle()
	{
	}

	public void OnOutThreadedToggle()
	{
	}

	private void UpdateToggles()
	{
	}

	private void Update()
	{
	}

	private void Init()
	{
	}

	public void Reset()
	{
	}

	public void Refresh()
	{
	}

	public void OnDeviceClick(MidiSelectionUIDeviceButton button)
	{
	}
}
