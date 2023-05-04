using System;
using Il2CppDummyDll;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000CE")]
public class ServerConfig
{
	// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
	public ServerConfig()
	{
	}

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x0")]
	public static int maxPlayers;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x4")]
	public static int recommendedPlayers;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x8")]
	public static int minPlayers;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0xC")]
	public static int countdownTime;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x10")]
	public static int shortCountdownTime;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x14")]
	public static int roundStartFreeze;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x18")]
	public static int roundStopCinematic;

	// Token: 0x04000475 RID: 1141
	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x1C")]
	public static int roundEndTimeout;

	// Token: 0x04000476 RID: 1142
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x20")]
	public static int gameOverTimeout;

	// Token: 0x04000477 RID: 1143
	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x24")]
	public static int loadTimeBeforeKicked;

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x28")]
	public static float speakAfterDeathTime;
}
