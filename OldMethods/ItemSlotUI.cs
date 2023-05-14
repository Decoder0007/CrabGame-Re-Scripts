using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class ItemSlotUI : MonoBehaviour
{
	// Token: 0x06000708 RID: 1800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000708")]
	[Address(RVA = "0xE3F3E0", Offset = "0xE3DDE0", VA = "0x180E3F3E0")]
	private void Awake()
	{
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000709")]
	[Address(RVA = "0xE3F4A0", Offset = "0xE3DEA0", VA = "0x180E3F4A0")]
	public void SetItem(Texture texture, string name)
	{
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070A")]
	[Address(RVA = "0xE3F460", Offset = "0xE3DE60", VA = "0x180E3F460")]
	public void Hide()
	{
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070B")]
	[Address(RVA = "0xE3F570", Offset = "0xE3DF70", VA = "0x180E3F570")]
	public void Show()
	{
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070C")]
	[Address(RVA = "0xE3F6F0", Offset = "0xE3E0F0", VA = "0x180E3F6F0")]
	private void Update()
	{
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ItemSlotUI()
	{
	}

	// Token: 0x0400068E RID: 1678
	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup canvas;

	// Token: 0x0400068F RID: 1679
	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI slot;

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x28")]
	public new TextMeshProUGUI name;

	// Token: 0x04000691 RID: 1681
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x30")]
	public RawImage image;

	// Token: 0x04000692 RID: 1682
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x38")]
	public RawImage selectionImg;

	// Token: 0x04000693 RID: 1683
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 defaultSelectionPosition;
}
