namespace System.Xml.Linq
{
	internal struct Inserter
	{
		private XContainer _parent;

		private XNode _previous;

		private string _text;

		public Inserter(XContainer parent, XNode anchor)
		{
			_parent = null;
			_previous = null;
			_text = null;
		}

		public void Add(object content)
		{
		}

		private void AddContent(object content)
		{
		}

		private void AddNode(XNode n)
		{
		}

		private void AddString(string s)
		{
		}

		private void InsertNode(XNode n)
		{
		}
	}
}
