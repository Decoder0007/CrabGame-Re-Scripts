using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class LobbySettings : MonoBehaviour
{
	// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3247C0", Offset = "0x3231C0", VA = "0x1803247C0")]
	private void Start()
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x324B20", Offset = "0x323520", VA = "0x180324B20")]
	private void UpdateSettings()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3247D0", Offset = "0x3231D0", VA = "0x1803247D0")]
	private void UpdateLobbyType()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x324A60", Offset = "0x323460", VA = "0x180324A60")]
	public void UpdateServerName()
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void UpdateGameMode()
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3249D0", Offset = "0x3233D0", VA = "0x1803249D0")]
	private void UpdateProximityChat()
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x324940", Offset = "0x323340", VA = "0x180324940")]
	private void UpdateMaxPlayers()
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public LobbySettings()
	{
	}

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x18")]
	public MyBoolSetting joinMidGame;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x20")]
	public SliderSetting maxPlayers;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x28")]
	public ScrollSettings lobbyType;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x30")]
	public ScrollSettings gameMode;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x38")]
	public TMP_InputField serverNameField;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x40")]
	public MyBoolSetting proximityChat;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x48")]
	private GameSettings.LobbyType storedLobbyType;
}
