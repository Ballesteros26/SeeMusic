using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(AudioSource))]
public class AnimateSprite : MonoBehaviour
{
	public enum AnimateState
	{
		None = 0,
		Playing = 1,
		Pausing = 2,
		Completed = 3
	}

	public enum AnimateType
	{
		PlayOnce = 0,
		PingPongOnce = 1,
		Loop = 2,
		PingPong = 3
	}

	public enum AnimateDirection
	{
		Forward = 0,
		Backward = 1
	}

	public SpriteRenderer spriteRenderer;

	public Image image;

	[HideInInspector]
	public float _spritePerSecond;

	[HideInInspector]
	public float _spriteDuration;

	private AnimateState _state;

	public Action<AnimateState> OnStateChanged;

	public AnimateType type;

	public AnimateDirection direction;

	public bool playOnAwake;

	public bool delayed;

	public float delayMIN;

	public float delayMAX;

	[HideInInspector]
	public float delay;

	public bool playOnceRepeated;

	public AudioClip audioClip;

	[HideInInspector]
	public Sprite[] sprites;

	private int index;

	private AnimateDirection indexDirection;

	private float timeElapsed;

	private float delayElapsed;

	private int loops;

	private bool setSpriteIndexOnPlay;

	private bool firstSpriteAfterDelay;

	public float spritesPerSecond
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float spriteDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AnimateState state
	{
		get
		{
			return default(AnimateState);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void Stop()
	{
	}

	private void ResetSprite()
	{
	}

	private void Reset()
	{
	}

	private void SetSprite()
	{
	}

	private void Update()
	{
	}

	private void PlayAnimation()
	{
	}

	private void PlayAnimationFinished()
	{
	}
}
