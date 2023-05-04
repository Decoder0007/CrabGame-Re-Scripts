using System;
using Il2CppDummyDll;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
public class GameModePush : GameMode
{
	// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026D")]
	[Address(RVA = "0xE2DF90", Offset = "0xE2C990", VA = "0x180E2DF90", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026E")]
	[Address(RVA = "0xE2E030", Offset = "0xE2CA30", VA = "0x180E2E030", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000273")]
	[Address(RVA = "0xE29050", Offset = "0xE27A50", VA = "0x180E29050")]
	public GameModePush()
	{
	}

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x38")]
	public ItemData item;
}
