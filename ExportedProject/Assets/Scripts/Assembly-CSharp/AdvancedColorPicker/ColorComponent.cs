using UnityEngine;
using UnityEngine.EventSystems;

namespace AdvancedColorPicker
{
	[ExecuteInEditMode]
	public abstract class ColorComponent : UIBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private ColorPicker picker;

		public ColorPicker Picker
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectTransform rectTransform => null;

		protected abstract void OAOOLMGAMOK();

		protected override void OnDisable()
		{
		}

		public void OnColorChanged(Color OLJIIPPOIHN)
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
