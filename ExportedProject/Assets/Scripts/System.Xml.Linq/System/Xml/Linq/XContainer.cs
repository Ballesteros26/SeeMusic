using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Xml.Linq
{
	/// <summary>Represents a node that can contain other nodes.</summary>
	/// <filterpriority>2</filterpriority>
	public abstract class XContainer : XNode
	{
		private sealed class ContentReader
		{
			private readonly NamespaceCache _eCache;

			private readonly NamespaceCache _aCache;

			private readonly IXmlLineInfo _lineInfo;

			private XContainer _currentContainer;

			private string _baseUri;

			public ContentReader(XContainer rootContainer)
			{
			}

			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
			}

			public bool ReadContentFrom(XContainer rootContainer, XmlReader r)
			{
				return false;
			}

			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CNodes_003Ed__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private XNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public XContainer _003C_003E4__this;

			private XNode _003Cn_003E5__2;

			XNode IEnumerator<XNode>.Current
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
			public _003CNodes_003Ed__18(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<XNode> IEnumerable<XNode>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetElements_003Ed__39 : IEnumerable<XElement>, IEnumerable, IEnumerator<XElement>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private XElement _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public XContainer _003C_003E4__this;

			private XName name;

			public XName _003C_003E3__name;

			private XNode _003Cn_003E5__2;

			XElement IEnumerator<XElement>.Current
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
			public _003CGetElements_003Ed__39(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<XElement> IEnumerable<XElement>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal object content;

		/// <summary>Get the last child node of this node.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XNode" /> containing the last child node of the <see cref="T:System.Xml.Linq.XContainer" />.</returns>
		/// <filterpriority>2</filterpriority>
		public XNode LastNode => null;

		internal XContainer()
		{
		}

		internal XContainer(XContainer other)
		{
		}

		/// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
		/// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
		public void Add(object content)
		{
		}

		/// <summary>Gets the first (in document order) child element with the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <returns>A <see cref="T:System.Xml.Linq.XElement" /> that matches the specified <see cref="T:System.Xml.Linq.XName" />, or null.</returns>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
		public XElement Element(XName name)
		{
			return null;
		}

		/// <summary>Returns a filtered collection of the child elements of this element or document, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the children of the <see cref="T:System.Xml.Linq.XContainer" /> that have a matching <see cref="T:System.Xml.Linq.XName" />, in document order.</returns>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
		public IEnumerable<XElement> Elements(XName name)
		{
			return null;
		}

		/// <summary>Returns a collection of the child nodes of this element or document, in document order.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the contents of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
		[IteratorStateMachine(typeof(_003CNodes_003Ed__18))]
		public IEnumerable<XNode> Nodes()
		{
			return null;
		}

		internal virtual void AddAttribute(XAttribute a)
		{
		}

		internal virtual void AddAttributeSkipNotify(XAttribute a)
		{
		}

		internal void AddContentSkipNotify(object content)
		{
		}

		internal void AddNode(XNode n)
		{
		}

		internal void AddNodeSkipNotify(XNode n)
		{
		}

		internal void AddString(string s)
		{
		}

		internal void AddStringSkipNotify(string s)
		{
		}

		internal void AppendNode(XNode n)
		{
		}

		internal void AppendNodeSkipNotify(XNode n)
		{
		}

		internal override void AppendText(StringBuilder sb)
		{
		}

		internal void ConvertTextToNode()
		{
		}

		[IteratorStateMachine(typeof(_003CGetElements_003Ed__39))]
		private IEnumerable<XElement> GetElements(XName name)
		{
			return null;
		}

		internal static string GetStringValue(object value)
		{
			return null;
		}

		internal void ReadContentFrom(XmlReader r)
		{
		}

		internal void ReadContentFrom(XmlReader r, LoadOptions o)
		{
		}

		internal void RemoveNode(XNode n)
		{
		}

		internal virtual void ValidateNode(XNode node, XNode previous)
		{
		}

		internal virtual void ValidateString(string s)
		{
		}

		internal void WriteContentTo(XmlWriter writer)
		{
		}
	}
}
