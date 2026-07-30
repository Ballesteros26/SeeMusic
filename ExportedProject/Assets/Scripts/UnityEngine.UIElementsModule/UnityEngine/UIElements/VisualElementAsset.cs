using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	[Serializable]
	internal class VisualElementAsset : IUxmlAttributes, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_Id;

		[SerializeField]
		private int m_OrderInDocument;

		[SerializeField]
		private int m_ParentId;

		[SerializeField]
		private int m_RuleIndex;

		[SerializeField]
		private string m_Text;

		[SerializeField]
		private PickingMode m_PickingMode;

		[SerializeField]
		private string m_FullTypeName;

		[SerializeField]
		private string[] m_Classes;

		[SerializeField]
		private List<string> m_StylesheetPaths;

		[SerializeField]
		private List<StyleSheet> m_Stylesheets;

		[SerializeField]
		private List<string> m_Properties;

		public int id => 0;

		public int orderInDocument => 0;

		public int parentId => 0;

		public int ruleIndex => 0;

		public string fullTypeName => null;

		public string[] classes => null;

		public List<string> stylesheetPaths => null;

		public bool hasStylesheetPaths => false;

		public List<StyleSheet> stylesheets => null;

		public bool hasStylesheets => false;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void AddProperty(string propertyName, string propertyValue)
		{
		}

		private void SetOrAddProperty(string propertyName, string propertyValue)
		{
		}

		public bool TryGetAttributeValue(string propertyName, out string value)
		{
			value = null;
			return false;
		}
	}
}
