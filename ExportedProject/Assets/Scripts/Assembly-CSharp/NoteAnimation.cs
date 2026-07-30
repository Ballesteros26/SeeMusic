using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MakeIt.Random;
using UnityEngine;

public class NoteAnimation : MonoBehaviour
{
	private sealed class IDDCBIFFFNK
	{
		public NoteAnimation _003C_003E4__this;

		public float timeWaitStarted;

		internal bool MEBDKAPJIMM()
		{
			return false;
		}
	}

	private sealed class DEMEHBAFMOK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NoteAnimation _003C_003E4__this;

		private IDDCBIFFFNK _003C_003E8__1;

		public bool Redraw;

		public bool ReopenNoteSettings;

		object IEnumerator<object>.Current
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
		public DEMEHBAFMOK(int _003C_003E1__state)
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
	}

	private sealed class LJCOFKOAGON
	{
		public NoteAnimation _003C_003E4__this;

		public int localRequest;

		internal bool EHKLHBCKJHI()
		{
			return false;
		}
	}

	private sealed class DNECJDNBBDJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NoteAnimation _003C_003E4__this;

		private LJCOFKOAGON _003C_003E8__1;

		object IEnumerator<object>.Current
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
		public DNECJDNBBDJ(int _003C_003E1__state)
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
	}

	private static NoteAnimation JOHCOGCAEAK;

	[CompilerGenerated]
	private static NoteAnimation _003CHOLNFGBMPDC_003Ek__BackingField;

	public SceneSingleton SceneSingleton;

	public MIDIControl MIDIControl;

	public UIManager UIManager;

	public KeyboardAnimation KeyboardAnimation;

	public ParticleAnimation ParticleAnimation;

	public NoteOperations NoteOperations;

	[NonSerialized]
	public GameObject engine;

	[NonSerialized]
	public GameObject notes;

	[NonSerialized]
	public GameObject noteTraces;

	[NonSerialized]
	public GameObject noteLabels;

	[NonSerialized]
	public float noteCornerRadius;

	[NonSerialized]
	public float whiteKeyWidthFactor;

	[NonSerialized]
	private Mesh[] GJJHLNOPLLJ;

	[NonSerialized]
	private GameObject GLPFBNFMBJA;

	[NonSerialized]
	public float decayTime;

	[NonSerialized]
	public float noteTraceDecayTime;

	[NonSerialized]
	public float fadeInLength;

	[NonSerialized]
	public float fadeLength;

	[NonSerialized]
	public float fadeLengthOriginal;

	[NonSerialized]
	public float traceFadeInLength;

	[NonSerialized]
	public float traceFadeLength;

	[NonSerialized]
	public float traceFadeLengthOriginal;

	[NonSerialized]
	public float gradientHueRangeLength;

	[NonSerialized]
	public float horizontalOffsetFactor;

	[NonSerialized]
	private Sprite EKLMGNFIOOA;

	[NonSerialized]
	private Sprite DNNPDPEEAOP;

	[NonSerialized]
	private Sprite PIGFJNHEGOI;

	[NonSerialized]
	private Sprite PBNNDGBEELD;

	[NonSerialized]
	private Sprite FLCPEAMEPJC;

	[NonSerialized]
	private Sprite MCAMPJABMLA;

	[NonSerialized]
	private Sprite CLDNBEEDHLL;

	[NonSerialized]
	private Sprite HNEAIHIOIJH;

	[NonSerialized]
	public Sprite SquareTexture;

	[NonSerialized]
	private Texture2D NCIPNOHHIJF;

	[NonSerialized]
	private Texture2D LHHKGDEFIJP;

	[NonSerialized]
	private Texture2D PLLNGLFMMPH;

	[NonSerialized]
	private Texture2D LONMCGFFNPD;

	[NonSerialized]
	private Texture2D NNLCJKPNEPI;

	[NonSerialized]
	private Texture2D NLIDKNNDEMA;

	[NonSerialized]
	private Texture2D DEDEODIJIBC;

	[NonSerialized]
	private Texture2D CMHADKLBIHK;

	[NonSerialized]
	private SnapshotCamera EPOOFOPCCCC;

	[NonSerialized]
	private SnapshotCamera LBNBKPCBHHP;

	[NonSerialized]
	private Texture2D KHBBLLOFIFA;

	[NonSerialized]
	private Texture2D DJLPHFJCADN;

	public Material SnapshotMaterial;

	public Material UnlitURPMaterial;

	public Material LockedTextureMaterial;

	public Material NoteSprite2023Material;

	public Material NoteOutline2023Material;

	public Material ReflectorLockedMaterial;

	public Material OutlineReflectionMaterial;

	public Material OutlineSnapshotMaterial;

	[HideInInspector]
	public GameObject objectToSnapshot;

	[HideInInspector]
	public Color backgroundColor;

	[HideInInspector]
	public Vector3 rotation;

	[HideInInspector]
	public Vector3 scale;

	[NonSerialized]
	private Sprite JGHLALNBINI;

	[NonSerialized]
	private Sprite KCNBPPIPABE;

	[NonSerialized]
	private Sprite MGENOPNPBEP;

	[NonSerialized]
	private Sprite JHJMIIBLMEG;

	[NonSerialized]
	private Sprite BLBAMICBDEL;

	[NonSerialized]
	private Sprite AMGLNBAPEHA;

	[NonSerialized]
	private Sprite MOEPCHNNIOF;

	[NonSerialized]
	private Sprite NDDENLIJICI;

	[NonSerialized]
	private Sprite GHJKLDNLCEI;

	[NonSerialized]
	private Sprite DEEOFDNJAMJ;

	public Material NoteMaterial;

	public Material NoteMaterialSprite;

	public Material NoteMaterialSpriteStencil;

	public Material NoteMaterialSpriteNormal;

	public Material NoteOutlineMaterial;

	public Material NoteGlowMaterial;

	public Material NoteMaterialSpriteEditor;

	public GameObject EditorNotePrefab;

	public GameObject TrackUINotePrefab;

	public Material NoteCrystalMaterial;

	public Material NoteReflectionMaterial;

	public Material NoteSpecularMaterial;

	public Texture2D NoteBumpMap;

	public GameObject NoteReflectionProbe;

	public GameObject NoteDirectionalLight1;

	public GameObject NoteDirectionalLight2;

	public GameObject NoteAmbientLight;

	public Material NoteLabelOpenSansMaterial;

	public Material LabelVerdanaMaterial;

	public Mesh PlaneMesh;

	public Mesh CubeMesh;

	public Mesh SphereMesh;

	public GameObject Guides;

	public MaterialPropertyBlock propertyBlock;

	[NonSerialized]
	private float LPDCLEDIPEO;

	[NonSerialized]
	private float FFOGBADDAKP;

	[NonSerialized]
	private int NLKOFNMEGGD;

	[NonSerialized]
	private float OIBKKINPHHK;

	[NonSerialized]
	private int JNPINJAFDEP;

	[NonSerialized]
	private int OGCJMJPMGFO;

	[NonSerialized]
	private float PPHPDPDPPLC;

	public float NoteSizeFactor;

	private float PECOBNEICLG;

	public Material NoteSpriteEditorURP;

	[NonSerialized]
	private IRandom BMPIOGAEGPA;

	[NonSerialized]
	private IRandom CJMJHNJPOMJ;

	[NonSerialized]
	private IRandom DFOPOEMGPNK;

	private float BODNJIJDMLN;

	private float BAOJEOMDNDE;

	[NonSerialized]
	private float AMJOIAPBOFN;

	[NonSerialized]
	private float EJOMCGDKEKN;

	[NonSerialized]
	private float KJGCPNDDJJG;

	[NonSerialized]
	private float MKLEHGPLGOF;

	[NonSerialized]
	private Mesh OAIBJENLKMG;

	[NonSerialized]
	private Mesh PEFPMADOMHC;

	[NonSerialized]
	private Mesh JBGAMLKJHAP;

	[NonSerialized]
	private Mesh DHDLOAOKKBC;

	[NonSerialized]
	private Mesh CMEHGPMLICK;

	[NonSerialized]
	private Mesh GLAJAHNCBNA;

	[NonSerialized]
	private Mesh MDJONLJOOKC;

	[NonSerialized]
	private float OKKGGDBPJHK;

	[NonSerialized]
	private float GGKCEKJBBGC;

	[NonSerialized]
	private float IENCOJBJMJN;

	[NonSerialized]
	private float EAJCNBLMDHI;

	[NonSerialized]
	private float COEGPFOFOHM;

	private int AMLHBEHHCPP;

	private bool NIGDIAAHOCN;

	[NonSerialized]
	private float EGKMBEDIKNP;

	public Light SnapshotLight1;

	public Light SnapshotLight2;

	[NonSerialized]
	private GameObject BJOLAFBAMJM;

	[NonSerialized]
	private string LFIPDJIMINN;

	[NonSerialized]
	private float BHFOAGFGOLK;

	[NonSerialized]
	private Vector3[] NHDDGIIPEIH;

	[NonSerialized]
	private int[] FODNOACCGEI;

	[NonSerialized]
	private Vector4[] JIMJAKAKJIN;

	[NonSerialized]
	private Vector2[] AJDEEPLNFML;

	[NonSerialized]
	private Vector2[] IAECPJBALIA;

	[NonSerialized]
	private Mesh[] JDKGLAKKPBL;

	[NonSerialized]
	private Mesh[] EHBNGEKBDMA;

	[NonSerialized]
	private float DGILKBMJNMH;

	[NonSerialized]
	private string EABPIGBOKGN;

	public float RoundEdges;

	public float RoundTopLeft;

	public float RoundTopRight;

	public float RoundBottomLeft;

	public float RoundBottomRight;

	public bool UsePercentage;

	public float Scale;

	public int CornerVertexCount;

	public bool CreateUV;

	public bool FlipBackFaceUV;

	public bool DoubleSided;

	private Vector3[] OIAMMKIKFLI;

	private Vector3[] HPCHPCLOBNG;

	private Vector2[] JOMJNEIOBOE;

	private int[] HHBFMLPNGCC;

	private float BOPELAGNDFB;

	public static NoteAnimation Instance
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

	public void RemoveAllChildren(GameObject NNMJNPBOFHB)
	{
	}

	private void LPGDMDBIFOG(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	public float GEONICLOOII(float KHDFEOMPNOJ)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(DNECJDNBBDJ))]
	public IEnumerator CreateNoteSprites()
	{
		return null;
	}

	public float GetUVRand()
	{
		return 0f;
	}

	public float GetSmallDrawWidth()
	{
		return 0f;
	}

	public void LPLLMOEEEHB(Note LNOJHCMJGFP, Sprite KFCDKAJDFMI, Texture2D OONJGAIGIBG)
	{
	}

	public float GetNoteTraceOpacity(Note EJKLHDLLBKN, float DILFCMAMPLC)
	{
		return 0f;
	}

	public void UpdateNoteSpriteRenderers(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP, bool JIFENDKDCMP = true)
	{
	}

	public Color GetLabelColor(int KHDFEOMPNOJ, float BELKMNKKAMM)
	{
		return default(Color);
	}

	public void LDMILMBNCED(GameObject IJMNGJPLJDL, Note LNOJHCMJGFP)
	{
	}

	public void MLGGOIHFAJB()
	{
	}

	public void SetNoteGlowSprite(Note LNOJHCMJGFP, Sprite KFCDKAJDFMI, Texture2D OONJGAIGIBG)
	{
	}

	public void GEIFCDKEMPD(GameObject BIKDLPOHNOC, float MDIGIIJHOCH, float LMBKJIDOGPJ, float KMGGJEMEFGF, float MKADHDJEKKE)
	{
	}

	public float IJOMEOMMJIC()
	{
		return 0f;
	}

	public float GGMPPGPPOFH(float KHDFEOMPNOJ)
	{
		return 0f;
	}

	public Color AIMJDOHNOLA(int KHDFEOMPNOJ, float BELKMNKKAMM)
	{
		return default(Color);
	}

	public void SetNoteDrawWidthHeight(Note LNOJHCMJGFP)
	{
	}

	public void SetNotePositionVariables(Note LNOJHCMJGFP)
	{
	}

	public void APFBHLABODN()
	{
	}

	private void CJPHMIPHANH()
	{
	}

	public void SetNotesUVOffset()
	{
	}

	public void UpdateMeshVertices(Mesh GIBMLHJOLIM, float GEMFGIFHIMN, float HFLBJJEGKNH, Vector3[] MIALPBLCFLJ, bool NIEHFOICLJH = false, bool JOFJFGHAAGI = false, int[] NHALFPPMKGC = null, Vector3[] JFLPLNGNJHB = null, Vector4[] FAJDFLKHPHF = null, Vector2[] EPHJKJGEEGG = null, Vector2[] ALCBNNOFCNP = null)
	{
	}

	public void FIFPIHJINCN(Note LNOJHCMJGFP)
	{
	}

	private Mesh BBKJHAPFDHB(float GEMFGIFHIMN, float HFLBJJEGKNH)
	{
		return null;
	}

	[SpecialName]
	private static void CANHMLKFMKH(NoteAnimation JEHONDDIMPC)
	{
	}

	public void AEKMHMEPCIO()
	{
	}

	public float MLLHFNKJBFG()
	{
		return 0f;
	}

	public void KJKEPMACCDM(Note LNOJHCMJGFP, Sprite KFCDKAJDFMI, Texture2D OONJGAIGIBG)
	{
	}

	public void AddGlowToNote(GameObject EJKLHDLLBKN, GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	private void Awake()
	{
	}

	public void HPGACEHHHMN()
	{
	}

	public void CreateNoteSnapshotMesh()
	{
	}

	public Color MIBCJCBKIFI(Color OLJIIPPOIHN)
	{
		return default(Color);
	}

	private void NAEIAKHDMOH()
	{
	}

	public void CEPKLOBOKHO()
	{
	}

	public Color DOJDDGPNECI(int KHDFEOMPNOJ, float BELKMNKKAMM)
	{
		return default(Color);
	}

	public Color32[] CFGOHCNPFLI(Color32[] LMNHMDHCOBK, int LHOEPINOJII)
	{
		return null;
	}

	public float OGJBCEKJOPG(int LMBMJCNMIKF)
	{
		return 0f;
	}

	public void NAPFOAMBNAG(GameObject NNMJNPBOFHB)
	{
	}

	private void HAPALPHODEG(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	public Color GetPitchColor(int KHDFEOMPNOJ, float BELKMNKKAMM, bool ICKNMDCOCLB = false)
	{
		return default(Color);
	}

	public void AGICPFONGOH(OIIOKADEOMG GIBBPAFCIDF, float FPIIBBIPJBN, GameObject BIKDLPOHNOC, float OHFDCGGBOJB, float MDIGIIJHOCH, float LMBKJIDOGPJ, float KMGGJEMEFGF, float MKADHDJEKKE)
	{
	}

	public float KGMAALDEDMJ(Note EJKLHDLLBKN, float DILFCMAMPLC)
	{
		return 0f;
	}

	public void SetBlackKeyDarkness()
	{
	}

	public void SetNoteColor(Note LNOJHCMJGFP, float FOKIPFENEIB = 1f, float FJOCNECHBGM = 0f, float OPECCMPENCC = -1f)
	{
	}

	public float DMANLIJNPKH()
	{
		return 0f;
	}

	private Color CPHDKEJNCDL(GameObject NGGGJLGDNMF)
	{
		return default(Color);
	}

	public Color32[] FeatherTexturePixelsOut(Color32[] LMNHMDHCOBK, bool EIOGCKONCFD = false)
	{
		return null;
	}

	public void CheckNoteWidthAgainstMinimum()
	{
	}

	public void SetWhiteKeyWidthFactor()
	{
	}

	public void KBKCGFMNCPH(bool OGKJNIKGIHO = false)
	{
	}

	public void UpdateNote(Note EJKLHDLLBKN, float CGKHKJDEADE, float FPIIBBIPJBN, int KODJEMMPOIP = -1, bool NMDDFOGLKMB = true, bool BLDDGIOAHMJ = false)
	{
	}

	public void SetAllNotesColor()
	{
	}

	public void HMHNEPKICCC(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	public void HODPOBEMJAJ(Mesh GIBMLHJOLIM, float BHFOAGFGOLK, Vector3[] MIALPBLCFLJ, bool OKJFFMPKGLF = false)
	{
	}

	public Color GetSelectionColor(Color OLJIIPPOIHN)
	{
		return default(Color);
	}

	public bool LBBMGLEJAMN()
	{
		return false;
	}

	public void SetCircleNoteColor(Note LNOJHCMJGFP)
	{
	}

	public Color GetNoteColor(Note LNOJHCMJGFP)
	{
		return default(Color);
	}

	public bool OGCLECGOEEP()
	{
		return false;
	}

	public bool OutlineIsOn()
	{
		return false;
	}

	private void GPJEGCMFMBC(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	public void LPLDBCGNOIB()
	{
	}

	public float GetNotePositionValue(float KHDFEOMPNOJ, bool CNBALLFPAPG = true, bool LMELKABOIHN = false)
	{
		return 0f;
	}

	public float GetWhiteKeyPitch(int LMBMJCNMIKF)
	{
		return 0f;
	}

	public void SetCornerRoundness3D(bool JOFJFGHAAGI = false)
	{
	}

	private void Update()
	{
	}

	public float GetOffsetForPitchPositionValue(float HOJMKEBLELJ)
	{
		return 0f;
	}

	public float HGGONOIJHHG(float KHDFEOMPNOJ, bool CNBALLFPAPG = true, bool LMELKABOIHN = false)
	{
		return 0f;
	}

	public void CreateGlowMeshes()
	{
	}

	public float MHIIJHPFHBN()
	{
		return 0f;
	}

	public float WorldToPixel()
	{
		return 0f;
	}

	public void SetNoteLabelPosition(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	public bool NFDEMEFBOOK()
	{
		return false;
	}

	public void CreateNoteSnapshotTexture()
	{
	}

	public void ReshapeMesh(Mesh GIBMLHJOLIM, float BHFOAGFGOLK, Vector3[] MIALPBLCFLJ, bool OKJFFMPKGLF = false)
	{
	}

	public float OAJLPGCDCCC()
	{
		return 0f;
	}

	public void BPNNCBPJNGN(bool JOFJFGHAAGI = false)
	{
	}

	public void GELCOONBCAI(GameObject IJMNGJPLJDL, Note LNOJHCMJGFP)
	{
	}

	public Color NoteColorWithDarkness(Color OLJIIPPOIHN)
	{
		return default(Color);
	}

	public float GetNotePositionUnscaled(float KHDFEOMPNOJ, bool MCOAJNHBJCC = false, bool CNBALLFPAPG = true)
	{
		return 0f;
	}

	public void NBBGECEJDIM()
	{
	}

	public void UpdateNoteOutline(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP)
	{
	}

	public float GetNotePosition(float KHDFEOMPNOJ, bool EBBLLNEBCNG = false, bool LMELKABOIHN = false, bool IABHHPNLINM = false)
	{
		return 0f;
	}

	public bool BHEHBLKBLKE()
	{
		return false;
	}

	public void Update3DNoteSetup()
	{
	}

	public void RemoveActiveNotesNotInSustain(bool JOLGPEDMMBA = true, bool LJOKJMJAFCM = false, bool JKGLJBNANKO = false)
	{
	}

	public float GetSmallestXOnMeshInnerEdge(Vector3[] MIALPBLCFLJ, float GKKNFKMMMPG)
	{
		return 0f;
	}

	public bool UseStencilNotes()
	{
		return false;
	}

	public void UpdateBoxCollider(Note LNOJHCMJGFP)
	{
	}

	public Color GetVelocityColor(float IIBKBKAKFBA, bool DIPPIMKFJNO = false)
	{
		return default(Color);
	}

	public void FeatherTexturePixels(Color32[] LMNHMDHCOBK, bool EIOGCKONCFD = false)
	{
	}

	public void OKJPBEOOADC(GameObject NNMJNPBOFHB)
	{
	}

	private void NBDKHKJHKGB()
	{
	}

	public float GetNotePositionForAlign(float KHDFEOMPNOJ, bool CNBALLFPAPG = true)
	{
		return 0f;
	}

	public void DrawMIDITrack(GameObject BIKDLPOHNOC, float MDIGIIJHOCH, float LMBKJIDOGPJ, float KMGGJEMEFGF, float MKADHDJEKKE)
	{
	}

	public float IGKNPBBMNBB(float HOJMKEBLELJ)
	{
		return 0f;
	}

	public Color PLAOPGKJPFF(int KHDFEOMPNOJ, float BELKMNKKAMM)
	{
		return default(Color);
	}

	public void IDAPINMEPEF(GameObject IJMNGJPLJDL, Note LNOJHCMJGFP)
	{
	}

	public float IsBlackKey(float KHDFEOMPNOJ)
	{
		return 0f;
	}

	public void AnimateNotes()
	{
	}

	private Mesh HMHDOFFDAFF(float GEMFGIFHIMN, float HFLBJJEGKNH)
	{
		return null;
	}

	public void CNKJKPMMJDK()
	{
	}

	public Mesh LAGAACCCGMF(Rect HGLMEHOIMAA, bool NIEHFOICLJH = false)
	{
		return null;
	}

	public float KILGBDDADIH()
	{
		return 0f;
	}

	public void AnimateNote(GameObject NGGGJLGDNMF)
	{
	}

	public void SetNoteBumpScale(Note LNOJHCMJGFP, bool GFAFHBMOELK = false)
	{
	}

	public void SetEdgeWidthToUse()
	{
	}

	public void FNMFIAOLNFE(bool JOFJFGHAAGI = false)
	{
	}

	public bool IsCircleNote()
	{
		return false;
	}

	public void KGNAFIPLLLE()
	{
	}

	public bool NLJAKKHEFAE()
	{
		return false;
	}

	private Mesh MODEPBKCDJI(float GEMFGIFHIMN, float HFLBJJEGKNH)
	{
		return null;
	}

	public void DrawNote(OIIOKADEOMG GIBBPAFCIDF, float FPIIBBIPJBN, int BELKMNKKAMM, int DLHLFANAOPO, int EFJHPCNDHIF)
	{
	}

	[SpecialName]
	public static NoteAnimation KHEKFKGDCOF()
	{
		return null;
	}

	[SpecialName]
	private static void MCFFNDDLDEC(NoteAnimation JEHONDDIMPC)
	{
	}

	public void JJMJGPCHOME(OIIOKADEOMG GIBBPAFCIDF, float FPIIBBIPJBN, GameObject BIKDLPOHNOC, float OHFDCGGBOJB, float MDIGIIJHOCH, float LMBKJIDOGPJ, float KMGGJEMEFGF, float MKADHDJEKKE)
	{
	}

	public void SetNoteToNotActive(Note EJKLHDLLBKN, bool JOLGPEDMMBA)
	{
	}

	public void BLLLOOJHECM(GameObject IJMNGJPLJDL, Note LNOJHCMJGFP)
	{
	}

	public float JIFNGJNKKHP(Vector3[] MIALPBLCFLJ, float GKKNFKMMMPG)
	{
		return 0f;
	}

	public void DCMFNMEKBEL(OIIOKADEOMG GIBBPAFCIDF, float FPIIBBIPJBN, int BELKMNKKAMM, int DLHLFANAOPO, int EFJHPCNDHIF)
	{
	}

	public Color32[] FeatherTexturePixelEdges(Color32[] LMNHMDHCOBK, int LHOEPINOJII)
	{
		return null;
	}

	public float PFJEMIDKCOA()
	{
		return 0f;
	}

	public void RedrawLiveNote(GameObject NGGGJLGDNMF)
	{
	}

	public void DestroyNote(GameObject IJMNGJPLJDL, Note LNOJHCMJGFP)
	{
	}

	public void IBBGAJIDNPJ(Note LNOJHCMJGFP)
	{
	}

	public void CreateOutlineMesh()
	{
	}

	public void SetNoteUVOffset(Note LNOJHCMJGFP, bool PFFIDIBIEKM, bool AGJDHAJHMPC, bool LCKFHADIJEA = false)
	{
	}

	public Mesh MNODALPJMKH(Rect HGLMEHOIMAA, bool NIEHFOICLJH = false)
	{
		return null;
	}

	public float CJNAHOALHJC(int LMBMJCNMIKF)
	{
		return 0f;
	}

	public float LIOHDNJBEIA()
	{
		return 0f;
	}

	public void RemoveAllNotes()
	{
	}

	public void ICKMPPHDOOJ(GameObject NGGGJLGDNMF, Note LNOJHCMJGFP, bool JIFENDKDCMP = true)
	{
	}

	private void LOFPBFBPJCC()
	{
	}

	public void JJLEMGDJKHD(Note EJKLHDLLBKN, float CGKHKJDEADE, float FPIIBBIPJBN, int KODJEMMPOIP = -1, bool NMDDFOGLKMB = true, bool BLDDGIOAHMJ = false)
	{
	}

	public Color LNJEADCBNEI(int KHDFEOMPNOJ, float BELKMNKKAMM, bool ICKNMDCOCLB = false)
	{
		return default(Color);
	}

	public float GetWhiteKeyNoteWidth()
	{
		return 0f;
	}

	public void ELHDJPILOKC()
	{
	}

	public bool GetCreateOutlineSprite()
	{
		return false;
	}

	public void IJNOGFMHOCF()
	{
	}

	[SpecialName]
	private static void OGHKIFKCOGO(NoteAnimation JEHONDDIMPC)
	{
	}

	public float CLBFDMEJEMM()
	{
		return 0f;
	}

	public void SetGravitySpeed()
	{
	}

	private Color NJILBGOHKCF(GameObject NGGGJLGDNMF)
	{
		return default(Color);
	}

	public void AFBKABGOKFK()
	{
	}

	public void JJOBLGADLLA()
	{
	}

	public float JHAPAJCHBHP(float KHDFEOMPNOJ, bool EBBLLNEBCNG = false, bool LMELKABOIHN = false, bool IABHHPNLINM = false)
	{
		return 0f;
	}

	public Color32[] ADJOGJJEPMB(Color32[] LMNHMDHCOBK, int LHOEPINOJII)
	{
		return null;
	}

	public void EHPKJAEJIFE()
	{
	}

	public Mesh CreateRoundedRectMesh(Rect HGLMEHOIMAA, bool NIEHFOICLJH = false)
	{
		return null;
	}

	public void EKFIAKPIONL()
	{
	}

	public float EGEKIBIPAFB(float KHDFEOMPNOJ, bool MCOAJNHBJCC = false, bool CNBALLFPAPG = true)
	{
		return 0f;
	}

	public Color BOLELCLIKAA(int KHDFEOMPNOJ, float BELKMNKKAMM)
	{
		return default(Color);
	}

	public float GetHorizontalLeftBoundary()
	{
		return 0f;
	}

	public void SetNoteSizeFactor()
	{
	}

	public void DrawNoteForTrack(OIIOKADEOMG GIBBPAFCIDF, float FPIIBBIPJBN, GameObject BIKDLPOHNOC, float OHFDCGGBOJB, float MDIGIIJHOCH, float LMBKJIDOGPJ, float KMGGJEMEFGF, float MKADHDJEKKE)
	{
	}

	public IEnumerator DMDKGNDIANO(bool FJMOMHJELGF = true, bool HELDCIHFPLC = false)
	{
		return null;
	}

	public void CreateOutlineTexture()
	{
	}

	public void RestoreSelection(List<Note> ABEKMJGNINF)
	{
	}

	public void DeselectAllNotes()
	{
	}

	public void DPJPLKFMMAN(GameObject BIKDLPOHNOC, float MDIGIIJHOCH, float LMBKJIDOGPJ, float KMGGJEMEFGF, float MKADHDJEKKE)
	{
	}

	public void CheckNoteWidthAgainstVariables(bool OGKJNIKGIHO = false)
	{
	}

	public float GetOffsetRand()
	{
		return 0f;
	}

	public void JPMINCFAAGM(GameObject NNMJNPBOFHB)
	{
	}

	public Color GKDDIDFLNNB(int KHDFEOMPNOJ, float BELKMNKKAMM)
	{
		return default(Color);
	}

	public float PixelToWorld()
	{
		return 0f;
	}

	public float GHOACKFCIAM(int LMBMJCNMIKF)
	{
		return 0f;
	}

	private void Start()
	{
	}

	public bool GetTextureReflectionOn()
	{
		return false;
	}

	public bool GetSimpleDraw()
	{
		return false;
	}

	public Color CMGJJNBKNNF(int KHDFEOMPNOJ, float BELKMNKKAMM, bool ICKNMDCOCLB = false)
	{
		return default(Color);
	}

	public void CLGLOPFAOPL(Note LNOJHCMJGFP)
	{
	}

	public IEnumerator LEPMKHDEHKF(bool FJMOMHJELGF = true, bool HELDCIHFPLC = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(DEMEHBAFMOK))]
	public IEnumerator UpdateNoteDimensions(bool FJMOMHJELGF = true, bool HELDCIHFPLC = false)
	{
		return null;
	}

	private void GHPNBBHEDCK()
	{
	}

	public void MBENCDBKLCK(Mesh GIBMLHJOLIM, float BHFOAGFGOLK, Vector3[] MIALPBLCFLJ, bool OKJFFMPKGLF = false)
	{
	}

	public void JNMJHGCPIFE(Mesh GIBMLHJOLIM, float GEMFGIFHIMN, float HFLBJJEGKNH, Vector3[] MIALPBLCFLJ, bool NIEHFOICLJH = false, bool JOFJFGHAAGI = false, int[] NHALFPPMKGC = null, Vector3[] JFLPLNGNJHB = null, Vector4[] FAJDFLKHPHF = null, Vector2[] EPHJKJGEEGG = null, Vector2[] ALCBNNOFCNP = null)
	{
	}
}
