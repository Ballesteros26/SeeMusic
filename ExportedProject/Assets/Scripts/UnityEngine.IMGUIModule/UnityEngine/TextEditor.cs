using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public class TextEditor
	{
		public enum DblClickSnapping : byte
		{
			WORDS = 0,
			PARAGRAPHS = 1
		}

		private enum CharacterType
		{
			LetterLike = 0,
			Symbol = 1,
			Symbol2 = 2,
			WhiteSpace = 3
		}

		private enum Direction
		{
			Forward = 0,
			Backward = 1
		}

		private enum TextEditOp
		{
			MoveLeft = 0,
			MoveRight = 1,
			MoveUp = 2,
			MoveDown = 3,
			MoveLineStart = 4,
			MoveLineEnd = 5,
			MoveTextStart = 6,
			MoveTextEnd = 7,
			MovePageUp = 8,
			MovePageDown = 9,
			MoveGraphicalLineStart = 10,
			MoveGraphicalLineEnd = 11,
			MoveWordLeft = 12,
			MoveWordRight = 13,
			MoveParagraphForward = 14,
			MoveParagraphBackward = 15,
			MoveToStartOfNextWord = 16,
			MoveToEndOfPreviousWord = 17,
			SelectLeft = 18,
			SelectRight = 19,
			SelectUp = 20,
			SelectDown = 21,
			SelectTextStart = 22,
			SelectTextEnd = 23,
			SelectPageUp = 24,
			SelectPageDown = 25,
			ExpandSelectGraphicalLineStart = 26,
			ExpandSelectGraphicalLineEnd = 27,
			SelectGraphicalLineStart = 28,
			SelectGraphicalLineEnd = 29,
			SelectWordLeft = 30,
			SelectWordRight = 31,
			SelectToEndOfPreviousWord = 32,
			SelectToStartOfNextWord = 33,
			SelectParagraphBackward = 34,
			SelectParagraphForward = 35,
			Delete = 36,
			Backspace = 37,
			DeleteWordBack = 38,
			DeleteWordForward = 39,
			DeleteLineBack = 40,
			Cut = 41,
			Copy = 42,
			Paste = 43,
			SelectAll = 44,
			SelectNone = 45,
			ScrollStart = 46,
			ScrollEnd = 47,
			ScrollPageUp = 48,
			ScrollPageDown = 49
		}

		public TouchScreenKeyboard keyboardOnScreen;

		public int controlID;

		public GUIStyle style;

		public bool multiline;

		public bool hasHorizontalCursorPos;

		public bool isPasswordField;

		internal bool m_HasFocus;

		public Vector2 scrollOffset;

		private GUIContent m_Content;

		private Rect m_Position;

		private int m_CursorIndex;

		private int m_SelectIndex;

		private bool m_RevealCursor;

		public Vector2 graphicalCursorPos;

		public Vector2 graphicalSelectCursorPos;

		private bool m_MouseDragSelectsWholeWords;

		private int m_DblClickInitPos;

		private DblClickSnapping m_DblClickSnap;

		private bool m_bJustSelected;

		private int m_iAltCursorPos;

		private string oldText;

		private int oldPos;

		private int oldSelectPos;

		private static Dictionary<Event, TextEditOp> s_Keyactions;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect position
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		internal virtual Rect localPosition => default(Rect);

		public int cursorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int selectIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int altCursorPosition => 0;

		public bool hasSelection => false;

		public string SelectedText => null;

		private void ClearCursorPos()
		{
		}

		[RequiredByNativeCode]
		public TextEditor()
		{
		}

		public void OnFocus()
		{
		}

		public void OnLostFocus()
		{
		}

		private void GrabGraphicalCursorPos()
		{
		}

		public bool HandleKeyEvent(Event e)
		{
			return false;
		}

		[VisibleToOtherModules]
		internal bool HandleKeyEvent(Event e, bool textIsReadOnly)
		{
			return false;
		}

		public bool DeleteLineBack()
		{
			return false;
		}

		public bool DeleteWordBack()
		{
			return false;
		}

		public bool DeleteWordForward()
		{
			return false;
		}

		public bool Delete()
		{
			return false;
		}

		public bool CanPaste()
		{
			return false;
		}

		public bool Backspace()
		{
			return false;
		}

		public void SelectAll()
		{
		}

		public void SelectNone()
		{
		}

		public bool DeleteSelection()
		{
			return false;
		}

		public void ReplaceSelection(string replace)
		{
		}

		public void Insert(char c)
		{
		}

		public void MoveSelectionToAltCursor()
		{
		}

		public void MoveRight()
		{
		}

		public void MoveLeft()
		{
		}

		public void MoveUp()
		{
		}

		public void MoveDown()
		{
		}

		public void MoveLineStart()
		{
		}

		public void MoveLineEnd()
		{
		}

		public void MoveGraphicalLineStart()
		{
		}

		public void MoveGraphicalLineEnd()
		{
		}

		public void MoveTextStart()
		{
		}

		public void MoveTextEnd()
		{
		}

		private int IndexOfEndOfLine(int startIndex)
		{
			return 0;
		}

		public void MoveParagraphForward()
		{
		}

		public void MoveParagraphBackward()
		{
		}

		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
		}

		protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
		{
		}

		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
		}

		public void SelectToPosition(Vector2 cursorPosition)
		{
		}

		public void SelectLeft()
		{
		}

		public void SelectRight()
		{
		}

		public void SelectUp()
		{
		}

		public void SelectDown()
		{
		}

		public void SelectTextEnd()
		{
		}

		public void SelectTextStart()
		{
		}

		public void MouseDragSelectsWholeWords(bool on)
		{
		}

		public void DblClickSnap(DblClickSnapping snapping)
		{
		}

		private int GetGraphicalLineStart(int p)
		{
			return 0;
		}

		private int GetGraphicalLineEnd(int p)
		{
			return 0;
		}

		private int FindNextSeperator(int startPos)
		{
			return 0;
		}

		private int FindPrevSeperator(int startPos)
		{
			return 0;
		}

		public void MoveWordRight()
		{
		}

		public void MoveToStartOfNextWord()
		{
		}

		public void MoveToEndOfPreviousWord()
		{
		}

		public void SelectToStartOfNextWord()
		{
		}

		public void SelectToEndOfPreviousWord()
		{
		}

		private CharacterType ClassifyChar(int index)
		{
			return default(CharacterType);
		}

		public int FindStartOfNextWord(int p)
		{
			return 0;
		}

		private int FindEndOfPreviousWord(int p)
		{
			return 0;
		}

		public void MoveWordLeft()
		{
		}

		public void SelectWordRight()
		{
		}

		public void SelectWordLeft()
		{
		}

		public void ExpandSelectGraphicalLineStart()
		{
		}

		public void ExpandSelectGraphicalLineEnd()
		{
		}

		public void SelectGraphicalLineStart()
		{
		}

		public void SelectGraphicalLineEnd()
		{
		}

		public void SelectParagraphForward()
		{
		}

		public void SelectParagraphBackward()
		{
		}

		public void SelectCurrentWord()
		{
		}

		private int FindEndOfClassification(int p, Direction dir)
		{
			return 0;
		}

		public void SelectCurrentParagraph()
		{
		}

		public void UpdateScrollOffsetIfNeeded(Event evt)
		{
		}

		[VisibleToOtherModules]
		internal void UpdateScrollOffset()
		{
		}

		public void DrawCursor(string newText)
		{
		}

		private bool PerformOperation(TextEditOp operation, bool textIsReadOnly)
		{
			return false;
		}

		public void SaveBackup()
		{
		}

		public bool Cut()
		{
			return false;
		}

		public void Copy()
		{
		}

		private static string ReplaceNewlinesWithSpaces(string value)
		{
			return null;
		}

		public bool Paste()
		{
			return false;
		}

		private static void MapKey(string key, TextEditOp action)
		{
		}

		private void InitKeyActions()
		{
		}

		public void DetectFocusChange()
		{
		}

		internal virtual void OnDetectFocusChange()
		{
		}

		internal virtual void OnCursorIndexChange()
		{
		}

		internal virtual void OnSelectIndexChange()
		{
		}

		private void ClampTextIndex(ref int index)
		{
		}

		private void EnsureValidCodePointIndex(ref int index)
		{
		}

		private bool IsValidCodePointIndex(int index)
		{
			return false;
		}

		private int PreviousCodePointIndex(int index)
		{
			return 0;
		}

		private int NextCodePointIndex(int index)
		{
			return 0;
		}
	}
}
