using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR
{
	internal class TextureSlotManager
	{
		private static readonly int k_SlotCount;

		internal static readonly int[] slotIds;

		internal static readonly int textureTableId;

		private TextureId[] m_Textures;

		private int[] m_Tickets;

		private int m_CurrentTicket;

		private int m_FirstUsedTicket;

		private Vector4[] m_GpuTextures;

		internal TextureRegistry textureRegistry;

		public int FreeSlots { get; private set; }

		static TextureSlotManager()
		{
		}

		public void Reset()
		{
		}

		public void StartNewBatch()
		{
		}

		public int IndexOf(TextureId id)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MarkUsed(int slotIndex)
		{
		}

		public int FindOldestSlot()
		{
			return 0;
		}

		public void Bind(TextureId id, int slot, MaterialPropertyBlock mat)
		{
		}
	}
}
