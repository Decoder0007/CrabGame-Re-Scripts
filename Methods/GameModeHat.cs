using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class GameModeHat : GameMode
{
	// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022F")]
	[Address(RVA = "0xE29300", Offset = "0xE27D00", VA = "0x180E29300", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000230")]
	[Address(RVA = "0xE29060", Offset = "0xE27A60", VA = "0x180E29060")]
	private void FindEliminationRatio(int nPlayers)
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000231")]
	[Address(RVA = "0xE294B0", Offset = "0xE27EB0", VA = "0x180E294B0", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000232")]
	[Address(RVA = "0xE290B0", Offset = "0xE27AB0", VA = "0x180E290B0", Slot = "8")]
	public override void GameModeAlert(int i)
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000233")]
	[Address(RVA = "0xE298E0", Offset = "0xE282E0", VA = "0x180E298E0", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000234")]
	[Address(RVA = "0xE2A400", Offset = "0xE28E00", VA = "0x180E2A400")]
	public void StealHat(ulong stealer, ulong stolenFrom)
	{
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000235")]
	[Address(RVA = "0xE2A830", Offset = "0xE29230", VA = "0x180E2A830")]
	public void TryTagPlayer(ulong stealer, ulong stolenFrom)
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000236")]
	[Address(RVA = "0xE2A390", Offset = "0xE28D90", VA = "0x180E2A390")]
	private void SendTagPlayer(ulong stealer, ulong stolenFrom)
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000237")]
	[Address(RVA = "0xE2A900", Offset = "0xE29300", VA = "0x180E2A900")]
	private void UpdateHat(bool b)
	{
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023B")]
	[Address(RVA = "0xE29E80", Offset = "0xE28880", VA = "0x180E29E80", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023C")]
	[Address(RVA = "0xE29D00", Offset = "0xE28700", VA = "0x180E29D00")]
	public void OutlineTagger(bool outline, ulong pId)
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600023D")]
	[Address(RVA = "0xE29110", Offset = "0xE27B10", VA = "0x180E29110")]
	private List<ulong> GetAllAlivePlayers()
	{
		return null;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023E")]
	[Address(RVA = "0xE29F80", Offset = "0xE28980", VA = "0x180E29F80")]
	private void ScoreUpdate()
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023F")]
	[Address(RVA = "0xE2A130", Offset = "0xE28B30", VA = "0x180E2A130")]
	private void SendScoreUpdate()
	{
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000240")]
	[Address(RVA = "0xE2A960", Offset = "0xE29360", VA = "0x180E2A960")]
	public GameModeHat()
	{
	}

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x38")]
	public List<ulong> taggedPlayers;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<ulong, int> playerScores;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x48")]
	private float scoreUpdateRate;

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x4C")]
	private float sendScoreUpdateRate;

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x50")]
	public float eliminationRatio;
}
