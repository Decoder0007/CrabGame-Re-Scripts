using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
public class DebugNet : MonoBehaviour
{
	// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x313E30", Offset = "0x312830", VA = "0x180313E30")]
	private void Start()
	{
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x313FF0", Offset = "0x3129F0", VA = "0x180313FF0")]
	public void ToggleConsole()
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x314050", Offset = "0x312A50", VA = "0x180314050")]
	private void Update()
	{
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x313510", Offset = "0x311F10", VA = "0x180313510")]
	private void Fps()
	{
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x313400", Offset = "0x311E00", VA = "0x180313400")]
	private void BandWidth()
	{
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x313E00", Offset = "0x312800", VA = "0x180313E00")]
	private void OpenConsole()
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x3134E0", Offset = "0x311EE0", VA = "0x1803134E0")]
	private void CloseConsole()
	{
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x3140E0", Offset = "0x312AE0", VA = "0x1803140E0")]
	public DebugNet()
	{
	}

	// Token: 0x04000673 RID: 1651
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI fps;

	// Token: 0x04000674 RID: 1652
	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x20")]
	public GameObject console;

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x28")]
	private bool fpsOn;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x29")]
	private bool speedOn;

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x2A")]
	private bool pingOn;

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x2B")]
	private bool bandwidthOn;

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x2C")]
	private float deltaTime;

	// Token: 0x0400067A RID: 1658
	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x0")]
	public static List<string> r;

	// Token: 0x0400067B RID: 1659
	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x8")]
	public static DebugNet Instance;

	// Token: 0x0400067C RID: 1660
	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x30")]
	private float byteUp;

	// Token: 0x0400067D RID: 1661
	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x34")]
	private float byteDown;

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x38")]
	private float pSent;

	// Token: 0x0400067F RID: 1663
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x3C")]
	private float pReceived;
}
