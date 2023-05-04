using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
public class GameModeManager : MonoBehaviour
{
	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0xE2DEB0", Offset = "0xE2C8B0", VA = "0x180E2DEB0")]
	private void Awake()
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000091")]
	[Address(RVA = "0xE2DF50", Offset = "0xE2C950", VA = "0x180E2DF50")]
	public GameModeData GetGameMode(int index)
	{
		return null;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public GameModeManager()
	{
	}

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x18")]
	public GameModeData defaultMode;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x20")]
	public GameModeData[] allGameModes;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x28")]
	public GameModeData[] allPlayableGameModes;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x0")]
	public static GameModeManager Instance;
}
