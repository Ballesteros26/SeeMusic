using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public static class NativeGallery
{
	public struct ImageProperties
	{
		public readonly int width;

		public readonly int height;

		public readonly string mimeType;

		public readonly ImageOrientation orientation;

		public ImageProperties(int width, int height, string mimeType, ImageOrientation orientation)
		{
			this.width = 0;
			this.height = 0;
			this.mimeType = null;
			this.orientation = default(ImageOrientation);
		}
	}

	public struct VideoProperties
	{
		public readonly int width;

		public readonly int height;

		public readonly long duration;

		public readonly float rotation;

		public VideoProperties(int width, int height, long duration, float rotation)
		{
			this.width = 0;
			this.height = 0;
			this.duration = 0L;
			this.rotation = 0f;
		}
	}

	public enum PermissionType
	{
		Read = 0,
		Write = 1
	}

	public enum Permission
	{
		Denied = 0,
		Granted = 1,
		ShouldAsk = 2
	}

	[Flags]
	public enum MediaType
	{
		Image = 1,
		Video = 2,
		Audio = 4
	}

	public enum ImageOrientation
	{
		Unknown = -1,
		Normal = 0,
		Rotate90 = 1,
		Rotate180 = 2,
		Rotate270 = 3,
		FlipHorizontal = 4,
		Transpose = 5,
		FlipVertical = 6,
		Transverse = 7
	}

	public delegate void PermissionCallback(Permission permission);

	public delegate void MediaSaveCallback(bool success, string path);

	public delegate void MediaPickCallback(string path);

	public delegate void MediaPickMultipleCallback(string[] paths);

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0<T>
	{
		public T result;

		public Func<T> function;

		public bool hasResult;

		internal void _003CTryCallNativeAndroidFunctionOnSeparateThread_003Eb__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CTryCallNativeAndroidFunctionOnSeparateThread_003Ed__46<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public Func<T> function;

		private _003C_003Ec__DisplayClass46_0<T> _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadImageAtPathAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

		public string imagePath;

		public int maxSize;

		public bool markTextureNonReadable;

		private string _003CloadPath_003E5__2;

		private Texture2D _003Cresult_003E5__3;

		private UnityWebRequest _003Cwww_003E5__4;

		private UnityWebRequestAsyncOperation _003CasyncOperation_003E5__5;

		private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetVideoThumbnailAsync_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

		public int maxSize;

		public bool markTextureNonReadable;

		private TaskAwaiter<Texture2D> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const bool PermissionFreeMode = true;

	public static Permission CheckPermission(PermissionType permissionType, MediaType mediaTypes)
	{
		return default(Permission);
	}

	public static Permission RequestPermission(PermissionType permissionType, MediaType mediaTypes)
	{
		return default(Permission);
	}

	public static void RequestPermissionAsync(PermissionCallback callback, PermissionType permissionType, MediaType mediaTypes)
	{
	}

	public static Task<Permission> RequestPermissionAsync(PermissionType permissionType, MediaType mediaTypes)
	{
		return null;
	}

	private static Permission ProcessPermission(Permission permission)
	{
		return default(Permission);
	}

	private static void TryExtendLimitedAccessPermission()
	{
	}

	public static bool CanOpenSettings()
	{
		return false;
	}

	public static void OpenSettings()
	{
	}

	public static Permission SaveImageToGallery(byte[] mediaBytes, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	public static Permission SaveImageToGallery(string existingMediaPath, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	public static Permission SaveImageToGallery(Texture2D image, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	public static Permission SaveVideoToGallery(byte[] mediaBytes, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	public static Permission SaveVideoToGallery(string existingMediaPath, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	private static Permission SaveAudioToGallery(byte[] mediaBytes, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	private static Permission SaveAudioToGallery(string existingMediaPath, string album, string filename, MediaSaveCallback callback = null)
	{
		return default(Permission);
	}

	public static bool CanSelectMultipleFilesFromGallery()
	{
		return false;
	}

	public static bool CanSelectMultipleMediaTypesFromGallery()
	{
		return false;
	}

	public static Permission GetImageFromGallery(MediaPickCallback callback, string title = "", string mime = "image/*")
	{
		return default(Permission);
	}

	public static Permission GetVideoFromGallery(MediaPickCallback callback, string title = "", string mime = "video/*")
	{
		return default(Permission);
	}

	public static Permission GetAudioFromGallery(MediaPickCallback callback, string title = "", string mime = "audio/*")
	{
		return default(Permission);
	}

	public static Permission GetMixedMediaFromGallery(MediaPickCallback callback, MediaType mediaTypes, string title = "")
	{
		return default(Permission);
	}

	public static Permission GetImagesFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "image/*")
	{
		return default(Permission);
	}

	public static Permission GetVideosFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "video/*")
	{
		return default(Permission);
	}

	public static Permission GetAudiosFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "audio/*")
	{
		return default(Permission);
	}

	public static Permission GetMixedMediasFromGallery(MediaPickMultipleCallback callback, MediaType mediaTypes, string title = "")
	{
		return default(Permission);
	}

	public static bool IsMediaPickerBusy()
	{
		return false;
	}

	public static MediaType GetMediaTypeOfFile(string path)
	{
		return default(MediaType);
	}

	private static Permission SaveToGallery(byte[] mediaBytes, string album, string filename, MediaType mediaType, MediaSaveCallback callback)
	{
		return default(Permission);
	}

	private static Permission SaveToGallery(string existingMediaPath, string album, string filename, MediaType mediaType, MediaSaveCallback callback)
	{
		return default(Permission);
	}

	private static void SaveToGalleryInternal(string path, string album, MediaType mediaType, MediaSaveCallback callback)
	{
	}

	private static string GetTemporarySavePath(string filename)
	{
		return null;
	}

	private static Permission GetMediaFromGallery(MediaPickCallback callback, MediaType mediaType, string mime, string title)
	{
		return default(Permission);
	}

	private static Permission GetMultipleMediaFromGallery(MediaPickMultipleCallback callback, MediaType mediaType, string mime, string title)
	{
		return default(Permission);
	}

	private static byte[] GetTextureBytes(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	private static byte[] GetTextureBytesFromCopy(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CTryCallNativeAndroidFunctionOnSeparateThread_003Ed__46<>))]
	private static Task<T> TryCallNativeAndroidFunctionOnSeparateThread<T>(Func<T> function)
	{
		return null;
	}

	public static Texture2D LoadImageAtPath(string imagePath, int maxSize = -1, bool markTextureNonReadable = true, bool generateMipmaps = true, bool linearColorSpace = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadImageAtPathAsync_003Ed__48))]
	public static Task<Texture2D> LoadImageAtPathAsync(string imagePath, int maxSize = -1, bool markTextureNonReadable = true)
	{
		return null;
	}

	public static Texture2D GetVideoThumbnail(string videoPath, int maxSize = -1, double captureTimeInSeconds = -1.0, bool markTextureNonReadable = true, bool generateMipmaps = true, bool linearColorSpace = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetVideoThumbnailAsync_003Ed__50))]
	public static Task<Texture2D> GetVideoThumbnailAsync(string videoPath, int maxSize = -1, double captureTimeInSeconds = -1.0, bool markTextureNonReadable = true)
	{
		return null;
	}

	public static ImageProperties GetImageProperties(string imagePath)
	{
		return default(ImageProperties);
	}

	public static VideoProperties GetVideoProperties(string videoPath)
	{
		return default(VideoProperties);
	}
}
