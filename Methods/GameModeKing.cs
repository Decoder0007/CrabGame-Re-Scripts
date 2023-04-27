using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
public class GameModeKing : GameMode
{
	// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000252")]
	[Address(RVA = "0xE2C760", Offset = "0xE2B160", VA = "0x180E2C760", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000253")]
	[Address(RVA = "0xE2C6B0", Offset = "0xE2B0B0", VA = "0x180E2C6B0")]
	private void FindEliminationRatio(int nPlayers)
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000254")]
	[Address(RVA = "0xE2C700", Offset = "0xE2B100", VA = "0x180E2C700", Slot = "8")]
	public override void GameModeAlert(int i)
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "6")]
	public override void OnPlayerGameModeLoaded(ulong pId)
	{
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000256")]
	[Address(RVA = "0xE2C8C0", Offset = "0xE2B2C0", VA = "0x180E2C8C0", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000257")]
	[Address(RVA = "0xE2CB30", Offset = "0xE2B530", VA = "0x180E2CB30", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025A")]
	[Address(RVA = "0xE2CF80", Offset = "0xE2B980", VA = "0x180E2CF80")]
	private void ScoreUpdate()
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025B")]
	[Address(RVA = "0xE2D200", Offset = "0xE2BC00", VA = "0x180E2D200")]
	private void SendScoreUpdate()
	{
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025C")]
	[Address(RVA = "0xE2D460", Offset = "0xE2BE60", VA = "0x180E2D460", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025D")]
	[Address(RVA = "0xE2CF50", Offset = "0xE2B950", VA = "0x180E2CF50", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025E")]
	[Address(RVA = "0xE2D470", Offset = "0xE2BE70", VA = "0x180E2D470")]
	public GameModeKing()
	{
	}

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<ulong, int> playerScores;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x40")]
	private float scoreUpdateRate;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x44")]
	private float sendScoreUpdateRate;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x48")]
	public float eliminationRatio;
}
