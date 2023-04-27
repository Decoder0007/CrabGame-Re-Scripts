using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public class InventoryUI : MonoBehaviour
{
	// Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000701")]
	[Address(RVA = "0xE394B0", Offset = "0xE37EB0", VA = "0x180E394B0")]
	private void Awake()
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000702")]
	[Address(RVA = "0xE39710", Offset = "0xE38110", VA = "0x180E39710")]
	public void SetPointer(int slot, int previousSlot)
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000703")]
	[Address(RVA = "0xE39580", Offset = "0xE37F80", VA = "0x180E39580")]
	public void SetItem(ItemData item, int slot)
	{
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000704")]
	[Address(RVA = "0xE39950", Offset = "0xE38350", VA = "0x180E39950")]
	public void ShowUI()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000705")]
	[Address(RVA = "0xE39540", Offset = "0xE37F40", VA = "0x180E39540")]
	public void HideUI()
	{
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000706")]
	[Address(RVA = "0xE399D0", Offset = "0xE383D0", VA = "0x180E399D0")]
	private void Update()
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000707")]
	[Address(RVA = "0xE39A50", Offset = "0xE38450", VA = "0x180E39A50")]
	public InventoryUI()
	{
	}

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform pointer;

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x20")]
	public Transform inventoryRow;

	// Token: 0x04000686 RID: 1670
	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x28")]
	private ItemSlotUI[] itemSlots;

	// Token: 0x04000687 RID: 1671
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x30")]
	public CanvasGroup canvas;

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x0")]
	public static InventoryUI Instance;

	// Token: 0x04000689 RID: 1673
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform parentRect;

	// Token: 0x0400068A RID: 1674
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x40")]
	private float fadeTime;

	// Token: 0x0400068B RID: 1675
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x44")]
	private float currentFadeTime;

	// Token: 0x0400068C RID: 1676
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x48")]
	private float startAlpha;

	// Token: 0x0400068D RID: 1677
	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x4C")]
	private float desiredAlpha;
}
