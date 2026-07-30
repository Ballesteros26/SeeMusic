using System.Threading.Tasks;
using UnityEngine;
using VideoKit.Devices;

namespace VideoKit
{
	public abstract class VideoKitDeviceManager<T> : MonoBehaviour where T : MediaDevice?
	{
		public abstract T? device { get; set; }

		public abstract bool running { get; }

		public abstract Task StartRunning();

		public abstract void StopRunning();
	}
}
