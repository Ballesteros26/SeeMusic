using System;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public class MediaPath
	{
		[SerializeField]
		private MediaPathType _pathType;

		[SerializeField]
		private string _path;

		public MediaPathType PathType
		{
			get
			{
				return default(MediaPathType);
			}
			internal set
			{
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public MediaPath()
		{
		}

		public MediaPath(MediaPath copy)
		{
		}

		public MediaPath(string path, MediaPathType pathType)
		{
		}

		public string GetResolvedFullPath()
		{
			return null;
		}

		public static bool operator ==(MediaPath a, MediaPath b)
		{
			return false;
		}

		public static bool operator !=(MediaPath a, MediaPath b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
