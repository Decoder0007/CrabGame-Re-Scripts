using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x20000B2")]
public class MenuUI : MonoBehaviour
{
	// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x327260", Offset = "0x325C60", VA = "0x180327260")]
	private void Awake()
	{
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x327860", Offset = "0x326260", VA = "0x180327860")]
	private void Start()
	{
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x3277F0", Offset = "0x3261F0", VA = "0x1803277F0")]
	public void StartNewLobby()
	{
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x327470", Offset = "0x325E70", VA = "0x180327470")]
	public void LeaveLobby()
	{
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x327780", Offset = "0x326180", VA = "0x180327780")]
	public void StartLobby()
	{
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void RefreshLobbies()
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x327610", Offset = "0x326010", VA = "0x180327610")]
	public void OpenLobbyUi()
	{
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x327740", Offset = "0x326140", VA = "0x180327740")]
	public void OpenMainMenuUi()
	{
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x327460", Offset = "0x325E60", VA = "0x180327460")]
	public void ExitGame()
	{
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x3274E0", Offset = "0x325EE0", VA = "0x1803274E0")]
	public void MakeNewLobbySettings()
	{
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x3275A0", Offset = "0x325FA0", VA = "0x1803275A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MenuUI()
	{
	}

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x18")]
	public GameObject lobbyUi;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x4000349")]
	[FieldOffset(Offset = "0x20")]
	public GameObject menuUi;

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject creatLobbyUi;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject serverListUi;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject micSetting;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x0")]
	public static MenuUI Instance;
}
