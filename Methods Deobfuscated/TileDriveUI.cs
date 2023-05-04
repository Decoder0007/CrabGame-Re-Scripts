using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200013A RID: 314
[Token(Token = "0x200013A")]
public class TileDriveUI : MonoBehaviour
{
	// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x2F9000", Offset = "0x2F7A00", VA = "0x1802F9000")]
	private void Awake()
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x2F9180", Offset = "0x2F7B80", VA = "0x1802F9180")]
	public void SetTeam(int teamId, GameModeTileDrive mode)
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x2F92C0", Offset = "0x2F7CC0", VA = "0x1802F92C0")]
	public void SlowUpdate()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x2F9620", Offset = "0x2F8020", VA = "0x1802F9620")]
	public TileDriveUI()
	{
	}

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x18")]
	public RawImage backdrop;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI score;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI teamText;

	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x0")]
	public static TileDriveUI Instance;

	// Token: 0x04000714 RID: 1812
	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x30")]
	private bool initialized;

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x38")]
	private GameModeTileDrive mode;
}
