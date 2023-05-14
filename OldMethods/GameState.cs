using System;
using Il2CppDummyDll;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
public class GameState
{
	// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000453")]
	[Address(RVA = "0xE356C0", Offset = "0xE340C0", VA = "0x180E356C0")]
	public GameState()
	{
	}

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x10")]
	public int currentRound;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x14")]
	public bool started;
}
