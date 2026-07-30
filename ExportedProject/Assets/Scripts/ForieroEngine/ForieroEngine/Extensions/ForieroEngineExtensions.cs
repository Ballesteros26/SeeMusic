using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace ForieroEngine.Extensions
{
	public static class ForieroEngineExtensions
	{
		[Serializable]
		public struct HSBColor
		{
			public float h;

			public float s;

			public float b;

			public float a;

			public HSBColor(float h, float s, float b, float a)
			{
				this.h = 0f;
				this.s = 0f;
				this.b = 0f;
				this.a = 0f;
			}

			public HSBColor(float h, float s, float b)
			{
				this.h = 0f;
				this.s = 0f;
				this.b = 0f;
				a = 0f;
			}

			public HSBColor(Color col)
			{
				h = 0f;
				s = 0f;
				b = 0f;
				a = 0f;
			}

			public static Color GetHue(Color color)
			{
				return default(Color);
			}

			public static HSBColor FromColor(Color color)
			{
				return default(HSBColor);
			}

			public static Color ToColor(HSBColor hsbColor)
			{
				return default(Color);
			}

			public Color ToColor()
			{
				return default(Color);
			}

			public static HSBColor Lerp(HSBColor a, HSBColor b, float t)
			{
				return default(HSBColor);
			}

			private static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
			{
				H = default(float);
				S = default(float);
				V = default(float);
			}

			private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
			{
				H = default(float);
				S = default(float);
				V = default(float);
			}

			public static implicit operator HSBColor(Color color)
			{
				return default(HSBColor);
			}

			public static implicit operator HSBColor(Color32 color)
			{
				return default(HSBColor);
			}

			public static implicit operator Color(HSBColor hsb)
			{
				return default(Color);
			}

			public static implicit operator Color32(HSBColor hsb)
			{
				return default(Color32);
			}

			public override string ToString()
			{
				return null;
			}
		}

		public class FireCoroutine
		{
			[CompilerGenerated]
			private sealed class _003CFireFloatDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public FireCoroutine _003C_003E4__this;

				public float delay;

				public Action onFire;

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
				public _003CFireFloatDelay_003Ed__8(int _003C_003E1__state)
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

			[CompilerGenerated]
			private sealed class _003CFireFrameDelay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public FireCoroutine _003C_003E4__this;

				public int frameDelay;

				public Action onFire;

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
				public _003CFireFrameDelay_003Ed__9(int _003C_003E1__state)
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

			public readonly MonoBehaviour monoBehaviour;

			private bool paused;

			private bool killed;

			public FireCoroutine(MonoBehaviour m, int frameDelay, Action onFire)
			{
			}

			public FireCoroutine(MonoBehaviour m, float delay, Action onFire)
			{
			}

			public void Pause()
			{
			}

			public void Continue()
			{
			}

			public void Kill()
			{
			}

			[IteratorStateMachine(typeof(_003CFireFloatDelay_003Ed__8))]
			private IEnumerator FireFloatDelay(float delay, Action onFire)
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CFireFrameDelay_003Ed__9))]
			private IEnumerator FireFrameDelay(int frameDelay, Action onFire)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CPlayOneShotDelayed_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float aDelay;

			public AudioSource anAudioSource;

			public AudioClip anAudioClip;

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
			public _003CPlayOneShotDelayed_003Ed__14(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTakeOrDefault_003Ed__74<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> enumerable;

			public IEnumerable<T> _003C_003E3__enumerable;

			private int length;

			public int _003C_003E3__length;

			private int _003Ccount_003E5__2;

			private IEnumerator<T> _003C_003E7__wrap2;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CTakeOrDefault_003Ed__74(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static string hex;

		private static Dictionary<Type, Dictionary<Enum, string>> cachedEnums;

		private static readonly System.Random RandomGenerator;

		private static char apostrophe;

		private static List<char> apostrophes;

		public static sbyte[] ToSByte(this byte[] array)
		{
			return null;
		}

		public static byte[] ToByte(this sbyte[] array)
		{
			return null;
		}

		public static List<byte[]> Split(this byte[] bytes, int blockLength)
		{
			return null;
		}

		public static T[] Populate<T>(this T[] array, T defaultVaue)
		{
			return null;
		}

		public static T[] PopulateNullValues<T>(this T[] array, T defaultVaue)
		{
			return null;
		}

		public static T[] Populate<T>(this T[] array, int count, T defaultVaue)
		{
			return null;
		}

		public static T[] PopulateNullValues<T>(this T[] array, int count, T defaultVaue)
		{
			return null;
		}

		public static T[] AddLast<T>(this T[] array, T aNewItem)
		{
			return null;
		}

		public static T[] AddFirst<T>(this T[] array, T aNewItem)
		{
			return null;
		}

		public static void Log<T>(this T[] array)
		{
		}

		public static void LogWarning<T>(this T[] array)
		{
		}

		public static void LogError<T>(this T[] array)
		{
		}

		public static T[] Slice<T>(this T[] source, int index, int count)
		{
			return null;
		}

		public static T Random<T>(this T[] source)
		{
			return default(T);
		}

		[IteratorStateMachine(typeof(_003CPlayOneShotDelayed_003Ed__14))]
		public static IEnumerator PlayOneShotDelayed(this AudioSource anAudioSource, AudioClip anAudioClip, float aDelay)
		{
			return null;
		}

		public static AudioType PlatformAudioType()
		{
			return default(AudioType);
		}

		public static string PlatformAudioExtension()
		{
			return null;
		}

		public static string PlatformRuntimeAudioExtension()
		{
			return null;
		}

		public static string PlatformFileProtocol()
		{
			return null;
		}

		public static float ToDecibel(this float linear)
		{
			return 0f;
		}

		public static float ToLinear(this float dB)
		{
			return 0f;
		}

		public static byte[] ToBuffer(this AudioClip ac)
		{
			return null;
		}

		public static Vector2 Pixel2Units2D(this Camera c)
		{
			return default(Vector2);
		}

		public static Vector2 Unit2Pixels2D(this Camera c)
		{
			return default(Vector2);
		}

		public static Vector2 ToWorldSize(this Camera camera, Bounds bounds)
		{
			return default(Vector2);
		}

		public static Vector2 ToScreenSize(this Camera camera, Bounds bounds)
		{
			return default(Vector2);
		}

		public static Rect ToScreenRect(this Camera camera, Renderer renderer)
		{
			return default(Rect);
		}

		public static Rect ToWorldRect(this Camera camera, Renderer renderer)
		{
			return default(Rect);
		}

		public static Vector3 EdgePosition(this Camera camera, TextAnchor point, float distance)
		{
			return default(Vector3);
		}

		public static bool IndexInRange<T>(this IList<T> list, int index)
		{
			return false;
		}

		public static Dictionary<TKey, TValue> Shuffle<TKey, TValue>(this Dictionary<TKey, TValue> source)
		{
			return null;
		}

		public static Dictionary<TKey, TValue> SortByValue<TKey, TValue>(this Dictionary<TKey, TValue> source)
		{
			return null;
		}

		public static Dictionary<TKey, TValue> SortByKey<TKey, TValue>(this Dictionary<TKey, TValue> source)
		{
			return null;
		}

		public static void Shuffle<T>(this IList<T> list)
		{
		}

		public static T PeekOrDefault<T>(this Queue<T> q)
		{
			return default(T);
		}

		public static Color R(this Color color, float r)
		{
			return default(Color);
		}

		public static Color G(this Color color, float g)
		{
			return default(Color);
		}

		public static Color B(this Color color, float b)
		{
			return default(Color);
		}

		public static Color A(this Color color, float a)
		{
			return default(Color);
		}

		public static char IntToHex(this int i)
		{
			return '\0';
		}

		public static int HexToInt(this char hexChar)
		{
			return 0;
		}

		public static string ToHex(this Color color)
		{
			return null;
		}

		public static Color HexToColor(this string hexChars, bool x = true)
		{
			return default(Color);
		}

		public static string ToHex(this Color32 color)
		{
			return null;
		}

		public static Color ToColor(this string hex)
		{
			return default(Color);
		}

		public static Color32 ToColor32(this string hex)
		{
			return default(Color32);
		}

		public static Color Saturation(this Color color, float saturation)
		{
			return default(Color);
		}

		public static float Saturation(this Color color)
		{
			return 0f;
		}

		public static Color Brightness(this Color color, float brightness)
		{
			return default(Color);
		}

		public static float Brightness(this Color color)
		{
			return 0f;
		}

		public static Color Hue(this Color color, float hue)
		{
			return default(Color);
		}

		public static float Hue(this Color color)
		{
			return 0f;
		}

		public static Color Alfa(this Color color, float alfa)
		{
			return default(Color);
		}

		public static bool IsEnum(this Type type)
		{
			return false;
		}

		public static bool IsValueType(this Type type)
		{
			return false;
		}

		public static bool IsAssignableFrom(this Type first, Type second)
		{
			return false;
		}

		public static FireCoroutine FireAction(this MonoBehaviour m, float delay, Action onFire)
		{
			return null;
		}

		public static FireCoroutine FireAction(this MonoBehaviour m, int frameDelay, Action onFire)
		{
			return null;
		}

		public static string ToStringCached<T>(this T e) where T : Enum
		{
			return null;
		}

		public static int ToInt(this Enum enumValue)
		{
			return 0;
		}

		public static I GetInterfaceComponent<I>(this GameObject o) where I : class
		{
			return null;
		}

		public static List<I> FindObjectsOfInterface<I>(this GameObject o) where I : class
		{
			return null;
		}

		public static T AddOrGetComponent<T>(this GameObject o) where T : Component
		{
			return null;
		}

		public static T GetComponentUltimate<T>(this GameObject o) where T : class
		{
			return null;
		}

		public static T[] GetComponentsUltimate<T>(this GameObject o) where T : class
		{
			return null;
		}

		public static T GetSafeComponent<T>(this GameObject obj) where T : MonoBehaviour
		{
			return null;
		}

		public static void SetRenderer(this GameObject o, bool enabled, bool recursively = false)
		{
		}

		public static void SetCollider(this GameObject o, bool enabled, bool recursively = false)
		{
		}

		public static void ChangeLayersRecursively(this GameObject gameObject, int layer)
		{
		}

		public static GameObject Add(this GameObject parent, GameObject gameObject, bool reset = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTakeOrDefault_003Ed__74<>))]
		public static IEnumerable<T> TakeOrDefault<T>(this IEnumerable<T> enumerable, int length)
		{
			return null;
		}

		public static T RandomOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			return default(T);
		}

		public static T RandomOrDefault<T>(this IEnumerable<T> source)
		{
			return default(T);
		}

		public static int GreatestCommonDivider(this int a, int b)
		{
			return 0;
		}

		public static float Radians(this float value)
		{
			return 0f;
		}

		public static float Degrees(this float value)
		{
			return 0f;
		}

		public static float Cos(this float value)
		{
			return 0f;
		}

		public static float Sin(this float value)
		{
			return 0f;
		}

		public static float Tan(this float value)
		{
			return 0f;
		}

		public static T CloneBinaryFormater<T>(this T source)
		{
			return default(T);
		}

		public static T CloneNewtonsoftJson<T>(this T source)
		{
			return default(T);
		}

		public static T CloneUnityJson<T>(this T source)
		{
			return default(T);
		}

		public static bool isLinux()
		{
			return false;
		}

		public static string FixOSPath(this string s)
		{
			return null;
		}

		public static string FixAssetsPath(this string s)
		{
			return null;
		}

		public static string PrependPersistentPath(this string s)
		{
			return null;
		}

		public static float Distance(this float f1, float f2)
		{
			return 0f;
		}

		public static int ToInt(this float f)
		{
			return 0;
		}

		public static int ToInt(this bool b)
		{
			return 0;
		}

		public static float Distance(this int i1, int i2)
		{
			return 0f;
		}

		public static bool ToBool(this int i)
		{
			return false;
		}

		public static Rect Add(this Rect aRectA, Rect aRectB)
		{
			return default(Rect);
		}

		public static string ToStringCSV(this Rect rct)
		{
			return null;
		}

		public static Rect ParseCSV(this Rect vct, string aStringRect, Rect aDefaultRect)
		{
			return default(Rect);
		}

		public static Rect StayInAppWindow(this Rect rect)
		{
			return default(Rect);
		}

		public static Canvas GetCanvas(this RectTransform rt, bool root = true)
		{
			return null;
		}

		public static void Reset(this RectTransform t)
		{
		}

		public static void SetDefaultScale(this RectTransform trans)
		{
		}

		public static void SetPivotAndAnchors(this RectTransform trans, Vector2 aVec)
		{
		}

		public static void SetAnchors(this RectTransform trans, Vector2 aVec)
		{
		}

		public static Vector2 GetSize(this RectTransform trans)
		{
			return default(Vector2);
		}

		public static float GetWidth(this RectTransform trans)
		{
			return 0f;
		}

		public static float GetHeight(this RectTransform trans)
		{
			return 0f;
		}

		public static void SetPositionOfPivot(this RectTransform trans, Vector2 newPos)
		{
		}

		public static void SetLeftBottomPosition(this RectTransform trans, Vector2 newPos)
		{
		}

		public static void SetLeftTopPosition(this RectTransform trans, Vector2 newPos)
		{
		}

		public static void SetRightBottomPosition(this RectTransform trans, Vector2 newPos)
		{
		}

		public static void SetRightTopPosition(this RectTransform trans, Vector2 newPos)
		{
		}

		public static void SetSize(this RectTransform trans, Vector2 newSize)
		{
		}

		public static void SetWidth(this RectTransform trans, float newSize)
		{
		}

		public static void SetHeight(this RectTransform trans, float newSize)
		{
		}

		public static Rect GetScreenCoordinatesOfCorners(RectTransform rt)
		{
			return default(Rect);
		}

		public static Vector2 GetPixelPositionOfRect(RectTransform rt)
		{
			return default(Vector2);
		}

		public static void ResizeToScreen(this SpriteRenderer spriteRenderer, ScreenStretch screenStretch, Vector2 scaler, Camera camera)
		{
		}

		public static string UnifyApostrophes(this string s)
		{
			return null;
		}

		public static string UnifyCarriageReturnCR(this string s)
		{
			return null;
		}

		public static string UnifyLineFeedLF(this string s)
		{
			return null;
		}

		public static string UnifyCarriageReturnCRLineFeedLF(this string s)
		{
			return null;
		}

		public static char UnifyApostrophe(this char ch)
		{
			return '\0';
		}

		public static string GetLast(this string source, int tail_length)
		{
			return null;
		}

		public static bool IsNullOrEmpty(this string s)
		{
			return false;
		}

		public static string DumpCharType(this char aChar)
		{
			return null;
		}

		public static string EncodeTo64(this string toEncode)
		{
			return null;
		}

		public static string DecodeFrom64(this string encodedData)
		{
			return null;
		}

		public static MemoryStream ToASCIIStream(this string s)
		{
			return null;
		}

		public static MemoryStream ToUTF8Stream(this string s)
		{
			return null;
		}

		public static void SaveToTxt(this string aString, string aFilePath, Encoding anEncoding)
		{
		}

		public static string LoadFromTxt(this string astring, string aFilePath, Encoding anEncoding)
		{
			return null;
		}

		public static string CamelToWords(this string value)
		{
			return null;
		}

		public static string RemoveDiacritics(this string stIn)
		{
			return null;
		}

		public static char GetAccent(this string stIn)
		{
			return '\0';
		}

		public static bool IsDiacriticsed(this string stIn)
		{
			return false;
		}

		public static string FixNewLine(this string s)
		{
			return null;
		}

		public static string RemoveNewLine(this string s)
		{
			return null;
		}

		public static string StripTagsRegex(this string source)
		{
			return null;
		}

		public static string StripTagsCharArray(this string source)
		{
			return null;
		}

		public static string[] Split(this string s, string separator)
		{
			return null;
		}

		public static int OccurenceCount(this string str, string val)
		{
			return 0;
		}

		public static int NthIndexOf(this string target, string value, int n)
		{
			return 0;
		}

		public static bool Contains(this string source, string toCheck, StringComparison comp)
		{
			return false;
		}

		public static void DrawWaveGraph(this Texture2D text, AudioClip anAudioClip, Color aColor)
		{
		}

		public static void ClearTexture(this Texture2D text, Color aColor)
		{
		}

		public static void FlipPixelsHorizontally(this Texture2D text)
		{
		}

		public static void FlipPixelsVertically(this Texture2D text)
		{
		}

		public static void Reset(this Transform t)
		{
		}

		public static bool HasParent(this Transform t, Transform parent)
		{
			return false;
		}

		public static Transform Search(this Transform target, string name)
		{
			return null;
		}

		public static Transform SearchEndsWith(this Transform target, string name)
		{
			return null;
		}

		public static Transform SearchStartsWith(this Transform target, string name)
		{
			return null;
		}

		public static void CenterPivot(this Transform transform, bool recursive, bool twoD)
		{
		}

		public static void LookAt2D(this Transform t, Transform target)
		{
		}

		public static void LookAt2D(this Transform t, Vector3 target)
		{
		}

		public static void CorrectPixelPosition(this Transform transform, Camera camera = null)
		{
		}

		public static void CeilPixelPosition(this Transform transform, Camera camera = null)
		{
		}

		public static void FloorPixelPosition(this Transform transform, Camera camera = null)
		{
		}

		public static void SetPixelPosition(this Transform target, Vector2 pixels, float layer, Space space = Space.World, Camera camera = null)
		{
		}

		public static Vector3 GetPixelPosition(this Transform target, Space space = Space.World, Camera camera = null)
		{
			return default(Vector3);
		}

		public static Vector2 WorldToCanvas(this Canvas canvas, Vector3 world_position, Camera camera = null)
		{
			return default(Vector2);
		}

		public static Vector3 WorldToCanvasPosition(this Canvas canvas, Vector3 worldPosition, Camera camera = null)
		{
			return default(Vector3);
		}

		public static Vector3 ScreenToCanvasPosition(this Canvas canvas, Vector3 screenPosition)
		{
			return default(Vector3);
		}

		public static Vector3 ViewportToCanvasPosition(this Canvas canvas, Vector3 viewportPosition)
		{
			return default(Vector3);
		}

		public static Vector3 ToIntVector3(this Vector3 v)
		{
			return default(Vector3);
		}

		public static Vector3 ToIntXYVector3(this Vector3 v)
		{
			return default(Vector3);
		}

		public static Vector2 ToRoundVector2(this Vector2 v)
		{
			return default(Vector2);
		}

		public static Vector2 ToCeilVector2(this Vector2 v)
		{
			return default(Vector2);
		}

		public static Vector2 ToFloorVector2(this Vector2 v)
		{
			return default(Vector2);
		}

		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		public static Vector3 ToVector3(this Vector2 v, float z = 0f)
		{
			return default(Vector3);
		}

		public static Vector3 SetLayer(this Vector3 v, float layer)
		{
			return default(Vector3);
		}

		public static string ToStringCSV(this Vector3 vct)
		{
			return null;
		}

		public static Vector3 ParseCSV(this Vector3 vct, string aStringVector, Vector3 aDefaultVector)
		{
			return default(Vector3);
		}

		public static Vector2 SetX(this Vector2 v, float x)
		{
			return default(Vector2);
		}

		public static Vector2 SetY(this Vector2 v, float y)
		{
			return default(Vector2);
		}

		public static Vector3 SetX(this Vector3 v, float x)
		{
			return default(Vector3);
		}

		public static Vector3 SetY(this Vector3 v, float y)
		{
			return default(Vector3);
		}

		public static Vector3 SetZ(this Vector3 v, float z)
		{
			return default(Vector3);
		}

		public static Vector2 SnapCalculate(this Vector2 p, Vector2 s)
		{
			return default(Vector2);
		}

		public static bool HasError(this UnityWebRequest.Result r)
		{
			return false;
		}

		public static bool HasError(this UnityWebRequest r)
		{
			return false;
		}
	}
}
