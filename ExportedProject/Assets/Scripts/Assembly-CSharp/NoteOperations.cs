using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NoteOperations : MonoBehaviour
{
	public enum APBLHAMNFGO
	{
		Move = 0,
		DragStart = 1,
		DragEnd = 2,
		Delete = 3,
		AssignTrack = 4,
		ChangeVelocity = 5
	}

	private static NoteOperations JOHCOGCAEAK;

	[CompilerGenerated]
	private static NoteOperations _003CHOLNFGBMPDC_003Ek__BackingField;

	public SceneSingleton SceneSingleton;

	public MIDIControl MIDIControl;

	public UIManager UIManager;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public NoteAnimation NoteAnimation;

	public GameObject notes;

	public BoxCollider MIDIEditorCollider;

	public GameObject SelectionBox;

	[NonSerialized]
	public bool IsAddingNote;

	[NonSerialized]
	private List<Note> NCFPHEINGAP;

	[NonSerialized]
	public float TimeBarTime;

	[NonSerialized]
	public bool isDraggingMinimizeBar;

	[NonSerialized]
	public List<PBLJKEAJEKJ> SavedSelection;

	public int SortAndSaveCall;

	[NonSerialized]
	private int KBIHBCOPCHM;

	[NonSerialized]
	private int DKHCEMDADIE;

	[NonSerialized]
	private OIIOKADEOMG MAGEBFCIIBC;

	[NonSerialized]
	private NJKPCOCPIFA AOKOHKFAPEI;

	[NonSerialized]
	private float NDJHEDJMABE;

	[NonSerialized]
	private long PAOGILOMJOI;

	[NonSerialized]
	private float NPPKGCJDOEL;

	[NonSerialized]
	private long CCGFMNKLPGA;

	[NonSerialized]
	public bool[] TracksInSelection;

	[NonSerialized]
	public int AverageVelocity;

	[NonSerialized]
	private Vector2 MPNDHHDFGNG;

	public float SpeedForWholePiece;

	[NonSerialized]
	public List<string> UndoFilenames;

	[NonSerialized]
	public int UndoCurrentIndex;

	public static NoteOperations Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void DeleteAction()
	{
	}

	private void OnMouseDown()
	{
	}

	public void UndoAction()
	{
	}

	public void EDGPCPPJLDG()
	{
	}

	public void ResetUndoState()
	{
	}

	private void Update()
	{
	}

	public void OperateOnSelectedNotes(APBLHAMNFGO EJHPNGOFLLO, float MNNDGNEADJN = 0f, int MJGNFINFKAJ = -1, int LFLLFJFBHLG = 0, int LJIFALONJAI = 0)
	{
	}

	public void StartNoteSelectionDrag()
	{
	}

	public string GetUndoFilename()
	{
		return null;
	}

	public string BNJIFPJMAAK()
	{
		return null;
	}

	public void ACHBBDPIJKK()
	{
	}

	private void Awake()
	{
	}

	public void RestoreUndoState()
	{
	}

	public void UpdateNoteEvents(int DDNLHAPIJNP, OIIOKADEOMG HCIIAPEAJMI, float EMPBCNPNBPB, float CFPEJMCMGHG, int FAEIFPDKFLC = -1)
	{
	}

	private void KLAIILMOGHJ()
	{
	}

	public void UpdateTrackButtons()
	{
	}

	public bool InSavedSelection(OIIOKADEOMG AIOFOGDKNGM)
	{
		return false;
	}

	private void Start()
	{
	}

	public float PianoRollToEventTime()
	{
		return 0f;
	}

	public void BDMGBOLEJBL()
	{
	}

	public void UpdateTracksInSelection(List<Note> ABEKMJGNINF = null)
	{
	}

	public void RedoAction()
	{
	}

	public void UpdateAverageVelocity(List<Note> ABEKMJGNINF = null)
	{
	}

	public void AddNoteDrag()
	{
	}

	public void NEALPAFCLDH()
	{
	}

	public string GetUndoFilePath()
	{
		return null;
	}

	public void CalculatePhysicalSpeedForWholePiece()
	{
	}

	public void SelectionUpdated()
	{
	}

	public float APOABIDGEMA()
	{
		return 0f;
	}

	public void SetEditorZoom()
	{
	}

	public void OJKEPMLLCBD()
	{
	}

	private void MBGONKMBOAK()
	{
	}

	public int PosToPitch()
	{
		return 0;
	}

	public void SetNoteEventTime(int BELKMNKKAMM, int EFJHPCNDHIF, float EMPBCNPNBPB = -1f, float CFPEJMCMGHG = -1f)
	{
	}

	public void UpdateEvents(OIIOKADEOMG HCIIAPEAJMI, float EMPBCNPNBPB, float CFPEJMCMGHG, MidiSequencer CFBOOJGHBGK, int FAEIFPDKFLC = -1)
	{
	}

	public void SaveSelection()
	{
	}

	public void AddNote(int FAEIFPDKFLC, float GLIMJLCAJBJ, float HFMBDCBJMNJ, int DDNLHAPIJNP, int EDMGABCIAPJ, int DIPNMKDAJIE = 100, bool GNFBMMDJFDJ = false)
	{
	}

	public void PrintNote(Note EJKLHDLLBKN, string JCIKFKIPFBK)
	{
	}

	private bool BPPMNFJCHMD()
	{
		return false;
	}

	public void SplitAction()
	{
	}

	public List<Note> GetSelectedNotes()
	{
		return null;
	}

	private void LKBBAGHNOOD()
	{
	}

	public void DMGDBHHPGLC()
	{
	}

	public void KABNEPPBAIK()
	{
	}

	public void SortAndSaveMIDI()
	{
	}

	public void AlignBeginningAction()
	{
	}

	public void LNCKGBOGBKH()
	{
	}

	private void OnMouseUp()
	{
	}

	public void DOOBOENLFAN()
	{
	}

	public void GGIMDBDDPMA(string INJPCDGIGOI, float MNNDGNEADJN)
	{
	}

	public void NOFIMHLOIGK(OIIOKADEOMG HCIIAPEAJMI, float EMPBCNPNBPB, float CFPEJMCMGHG, MidiSequencer CFBOOJGHBGK, int FAEIFPDKFLC = -1)
	{
	}

	public void FBBCGKHHALH(List<Note> ABEKMJGNINF = null)
	{
	}

	public void HANJEJLKKCA()
	{
	}

	public void JoinAction()
	{
	}

	public void CreateMIDIUndoState()
	{
	}

	public void CutAction()
	{
	}

	public void JACOMHEPKDA()
	{
	}

	public void AddMouseNote()
	{
	}

	public void RestoreSavedSelection()
	{
	}

	public void AJDBOPEAJOP()
	{
	}

	public void NoteSelectionDragAction()
	{
	}

	public void NIIKMPLBCPN()
	{
	}

	public float PosToTime()
	{
		return 0f;
	}

	public void NoteDragEdgeOperation(string INJPCDGIGOI, float MNNDGNEADJN)
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseUpAsButton()
	{
	}

	public void AlignEndAction()
	{
	}

	public void CopyAction()
	{
	}

	public void PasteAction()
	{
	}

	public void DeleteNoteEvents(List<Note> PPHAMEOGANN)
	{
	}

	[SpecialName]
	public static NoteOperations AMOLJOPEJME()
	{
		return null;
	}
}
