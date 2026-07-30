using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	[Serializable]
	public class VisualTreeAsset : ScriptableObject
	{
		[Serializable]
		internal struct UsingEntry
		{
			internal static readonly IComparer<UsingEntry> comparer;

			[SerializeField]
			public string alias;

			[SerializeField]
			public string path;

			[SerializeField]
			public VisualTreeAsset asset;

			public UsingEntry(string alias, string path)
			{
				this.alias = null;
				this.path = null;
				asset = null;
			}
		}

		private class UsingEntryComparer : IComparer<UsingEntry>
		{
			public int Compare(UsingEntry x, UsingEntry y)
			{
				return 0;
			}
		}

		[Serializable]
		internal struct SlotDefinition
		{
			[SerializeField]
			public string name;

			[SerializeField]
			public int insertionPointId;
		}

		[Serializable]
		internal struct SlotUsageEntry
		{
			[SerializeField]
			public string slotName;

			[SerializeField]
			public int assetId;
		}

		internal static string LinkedVEAInTemplatePropertyName;

		[SerializeField]
		private bool m_ImportedWithErrors;

		[SerializeField]
		private bool m_ImportedWithWarnings;

		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints;

		[SerializeField]
		private List<UsingEntry> m_Usings;

		[SerializeField]
		internal StyleSheet inlineSheet;

		[SerializeField]
		private List<VisualElementAsset> m_VisualElementAssets;

		[SerializeField]
		private List<TemplateAsset> m_TemplateAssets;

		[SerializeField]
		private List<SlotDefinition> m_Slots;

		[SerializeField]
		private int m_ContentContainerId;

		[SerializeField]
		private int m_ContentHash;

		public bool importedWithErrors
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool importedWithWarnings
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public IEnumerable<VisualTreeAsset> templateDependencies => null;

		public IEnumerable<StyleSheet> stylesheets => null;

		internal List<VisualElementAsset> visualElementAssets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<TemplateAsset> templateAssets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<SlotDefinition> slots
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int contentContainerId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int contentHash
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int GetNextChildSerialNumber()
		{
			return 0;
		}

		public TemplateContainer Instantiate()
		{
			return null;
		}

		public TemplateContainer Instantiate(string bindingPath)
		{
			return null;
		}

		public TemplateContainer CloneTree()
		{
			return null;
		}

		public TemplateContainer CloneTree(string bindingPath)
		{
			return null;
		}

		public void CloneTree(VisualElement target)
		{
		}

		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
			firstElementIndex = default(int);
			elementAddedCount = default(int);
		}

		internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides)
		{
		}

		private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context)
		{
			return null;
		}

		private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
		{
			return 0;
		}

		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			slotName = null;
			return false;
		}

		internal VisualTreeAsset ResolveTemplate(string templateName)
		{
			return null;
		}

		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
		{
			return null;
		}

		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
		}

		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
		}
	}
}
