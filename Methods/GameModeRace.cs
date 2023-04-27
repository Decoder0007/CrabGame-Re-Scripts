using System;
using Il2CppDummyDll;

// Token: 0x02000084 RID: 132
[Token(Token = "0x2000084")]
public class GameModeRace : GameMode
{
	// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000274")]
	[Address(RVA = "0xE2E390", Offset = "0xE2CD90", VA = "0x180E2E390", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000275")]
	[Address(RVA = "0xE2E490", Offset = "0xE2CE90", VA = "0x180E2E490", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000276")]
	[Address(RVA = "0xE2E310", Offset = "0xE2CD10", VA = "0x180E2E310")]
	private void FindQualifiers(int nPlayers)
	{
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000277")]
	[Address(RVA = "0xE2E4F0", Offset = "0xE2CEF0", VA = "0x180E2E4F0", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000278")]
	[Address(RVA = "0xE2E040", Offset = "0xE2CA40", VA = "0x180E2E040")]
	public void CheckGameOver()
	{
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027C")]
	[Address(RVA = "0xE2E760", Offset = "0xE2D160", VA = "0x180E2E760", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027D")]
	[Address(RVA = "0xE29050", Offset = "0xE27A50", VA = "0x180E29050")]
	public GameModeRace()
	{
	}

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x38")]
	public int qualifiers;
}
