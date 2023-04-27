using System;
using Il2CppDummyDll;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
public class GameSettings
{
	// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000381")]
	[Address(RVA = "0xE35630", Offset = "0xE34030", VA = "0x180E35630")]
	public GameSettings()
	{
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000382")]
	[Address(RVA = "0xE35590", Offset = "0xE33F90", VA = "0x180E35590")]
	public void ReadSettings(Packet packet)
	{
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000383")]
	[Address(RVA = "0xE355E0", Offset = "0xE33FE0", VA = "0x180E355E0")]
	public void WriteSettings(Packet packet)
	{
	}

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x10")]
	public GameSettings.LobbyType lobbyType;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x14")]
	public int nRounds;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x18")]
	public int joinableInGame;

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x1C")]
	public int mapIndex;

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x20")]
	public int proximityChat;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x24")]
	public int maxPlayers;

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x28")]
	public ulong mapId;

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x30")]
	public string mapName;

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x38")]
	public ulong[] assets;

	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public enum LobbyType
	{
		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		LobbyCodeOnly,
		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		Friends,
		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		Public
	}
}
