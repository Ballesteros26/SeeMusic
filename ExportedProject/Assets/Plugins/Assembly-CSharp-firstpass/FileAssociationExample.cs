using System.IO;
using ImaginationOverflow.UniversalFileAssociation.Data;
using UnityEngine;
using UnityEngine.UI;

public class FileAssociationExample : MonoBehaviour
{
	public int MaxFileContentOnUi;

	public Text FileName;

	public Text Size;

	public Text Path;

	public Text Content;

	private void Start()
	{
	}

	private void FileActivatedHandler(FileInformation fileActivated)
	{
	}

	private string GetFirstBytes(Stream s)
	{
		return null;
	}
}
