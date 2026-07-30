using System;
using UnityEngine;

namespace ImaginationOverflow.UniversalFileAssociation.Data
{
	[Serializable]
	public class FileExtension
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private string mimetype;

		[SerializeField]
		private string uti;

		[SerializeField]
		private string extension;

		public string MimeType => null;

		public string Extension => null;

		public bool IsCustomMimeType => false;
	}
}
