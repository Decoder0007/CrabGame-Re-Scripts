using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
public class ServerList : MonoBehaviour
{
	// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x3D9CE0", Offset = "0x3D86E0", VA = "0x1803D9CE0")]
	public void OnEnable()
	{
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x3DA2D0", Offset = "0x3D8CD0", VA = "0x1803DA2D0")]
	public void RefreshLobbies()
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x3D9F20", Offset = "0x3D8920", VA = "0x1803D9F20")]
	private void OnLobbiesLoaded(GameLobbyJoinRequested_t gameLobbyJoinRequestedT)
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x3D9AD0", Offset = "0x3D84D0", VA = "0x1803D9AD0")]
	private void FindLobbies()
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x3D9F90", Offset = "0x3D8990", VA = "0x1803D9F90")]
	private void OnLobbyMatchList(LobbyMatchList_t pLobbyMatchList, bool bIOFailure)
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x3DA480", Offset = "0x3D8E80", VA = "0x1803DA480")]
	public void RefreshMultiplayerLobbies()
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x327D80", Offset = "0x326780", VA = "0x180327D80")]
	private void SetBuffering(bool b)
	{
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x3D99F0", Offset = "0x3D83F0", VA = "0x1803D99F0")]
	private void ClearList()
	{
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ServerList()
	{
	}

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject serverListingPrefab;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject listParent;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x28")]
	public VideoPlayer bufferIcon;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x30")]
	public Toggle closeToggle;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x38")]
	public Toggle minPlayersToggle;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x40")]
	public Toggle startedToggle;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x48")]
	private List<CSteamID> activeLobbies;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x50")]
	private CallResult<LobbyMatchList_t> m_CallResultLobbyMatchList;
}
