using System;
using System.Collections.Generic;
using UnityEngine;

namespace MidiPlayerTK
{
	public class PopupListItem
	{
		public bool Show;

		public string Title;

		public int ColCount;

		public int ColWidth;

		public int ColHeight;

		public bool KeepOpen;

		public object Tag;

		public int EspaceX;

		public int EspaceY;

		public int TitleHeight;

		public int itemHeight;

		private int selectedItem;

		private CustomStyle myStyle;

		private Vector2 positionbt;

		private List<MPTKListItem> list;

		private Vector2 scrollPosSoundFont;

		private int resizedWidth;

		private int resizedHeight;

		private int calculatedColCount;

		private int realItemCount;

		private int countRow;

		private string filterItem;

		public Action<object, int, int> OnSelect;

		private Rect windowRect;

		public int CountRow => 0;

		public void Draw(List<MPTKListItem> plist, int pselected, CustomStyle style)
		{
		}

		private void DrawWindow(int windowID)
		{
		}

		public void PositionWithScroll(ref Vector2 scrollerWindow)
		{
		}

		public void Position(Vector2 positionbt)
		{
		}
	}
}
