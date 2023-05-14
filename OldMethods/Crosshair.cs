using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0xDC390", Offset = "0xDB790")]
public class Crosshair : MonoBehaviour
{
	// Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x30E550", Offset = "0x30CF50", VA = "0x18030E550")]
	private void Update()
	{
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x30E7F0", Offset = "0x30D1F0", VA = "0x18030E7F0")]
	public Crosshair()
	{
	}

	// Token: 0x04000669 RID: 1641
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101F10", Offset = "0x101310")]
	public RectTransform dot;

	// Token: 0x0400066A RID: 1642
	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform left;

	// Token: 0x0400066B RID: 1643
	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform right;

	// Token: 0x0400066C RID: 1644
	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform top;

	// Token: 0x0400066D RID: 1645
	[Token(Token = "0x400066D")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform bot;

	// Token: 0x0400066E RID: 1646
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101F40", Offset = "0x101340")]
	public bool enableDot;

	// Token: 0x0400066F RID: 1647
	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0x44")]
	public int dotSize;

	// Token: 0x04000670 RID: 1648
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x48")]
	public int width;

	// Token: 0x04000671 RID: 1649
	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0x4C")]
	public int length;

	// Token: 0x04000672 RID: 1650
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x50")]
	public int gap;
}
