using System;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000CD")]
public class PlayerInfo : MonoBehaviour
{
	// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x3339B0", Offset = "0x3323B0", VA = "0x1803339B0")]
	public void SetPlayer(ulong id)
	{
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerInfo()
	{
	}

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x18")]
	public CSteamID steamId;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x20")]
	public int score;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x24")]
	public int ping;
}
