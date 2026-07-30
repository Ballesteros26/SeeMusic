using System.Collections;
using System.Collections.Generic;

namespace RenderHeads.Media.AVProVideo
{
	public abstract class TrackCollection : IEnumerable
	{
		public virtual TrackType TrackType { get; private set; }

		public abstract int Count { get; }

		public abstract IEnumerator GetEnumerator();

		internal abstract void Clear();

		internal abstract void Add(TrackBase track);

		internal abstract bool HasActiveTrack();

		internal abstract bool IsActiveTrack(TrackBase track);

		internal abstract void SetActiveTrack(TrackBase track);

		internal abstract void SetFirstTrackActive();
	}
	public class TrackCollection<T> : TrackCollection where T : TrackBase
	{
		internal List<T> _tracks;

		public T this[int index] => null;

		internal T ActiveTrack { get; set; }

		public override int Count => 0;

		internal TrackCollection()
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		internal override bool HasActiveTrack()
		{
			return false;
		}

		internal override bool IsActiveTrack(TrackBase track)
		{
			return false;
		}

		internal override void Clear()
		{
		}

		internal override void Add(TrackBase track)
		{
		}

		internal override void SetActiveTrack(TrackBase track)
		{
		}

		internal override void SetFirstTrackActive()
		{
		}
	}
}
