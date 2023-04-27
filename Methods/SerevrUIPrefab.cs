using System;
using Il2CppDummyDll;
using SteamworksNative;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B3 RID: 179
[Token(Token = "0x20000B3")]
public class SerevrUIPrefab : MonoBehaviour
{
	// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x3D59D0", Offset = "0x3D43D0", VA = "0x1803D59D0")]
	public void SetUI(CSteamID lobbyId, int i)
	{
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x3D58B0", Offset = "0x3D42B0", VA = "0x1803D58B0")]
	public void UpdateMap()
	{
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x3D59C0", Offset = "0x3D43C0", VA = "0x1803D59C0")]
	public int PlayerCount()
	{
		return 0;
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x3D5940", Offset = "0x3D4340", VA = "0x1803D5940")]
	public void JoinLobby()
	{
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x3D58B0", Offset = "0x3D42B0", VA = "0x1803D58B0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x101C20", Offset = "0x101020")]
	private void DoSearch()
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public SerevrUIPrefab()
	{
	}

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x18")]
	public RawImage previewImg;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI title;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI players;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI lobbyState;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI versionNumber;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x40")]
	public RawImage micIcon;

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x48")]
	public Texture micOn;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x50")]
	public Texture micOff;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x58")]
	public Color blue;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x68")]
	public Color red;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x78")]
	public GameObject joinButton;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x80")]
	private CSteamID lobby;
}
