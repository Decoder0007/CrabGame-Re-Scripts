using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000080")]
public class GameModeHnS : GameMode
{
	// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000241")]
	[Address(RVA = "0xE2B280", Offset = "0xE29C80", VA = "0x180E2B280", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000242")]
	[Address(RVA = "0xE2B970", Offset = "0xE2A370", VA = "0x180E2B970", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000243")]
	[Address(RVA = "0xE2B6E0", Offset = "0xE2A0E0", VA = "0x180E2B6E0", Slot = "5")]
	public override void OnFreezeOverAlert()
	{
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000244")]
	[Address(RVA = "0xE2AE70", Offset = "0xE29870", VA = "0x180E2AE70", Slot = "8")]
	public override void GameModeAlert(int i)
	{
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000245")]
	[Address(RVA = "0xE2BD10", Offset = "0xE2A710", VA = "0x180E2BD10", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000249")]
	[Address(RVA = "0xE2C4E0", Offset = "0xE2AEE0", VA = "0x180E2C4E0", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024A")]
	[Address(RVA = "0xE2C5F0", Offset = "0xE2AFF0", VA = "0x180E2C5F0")]
	private void SendSeekerPlayer(ulong seeker, bool isSeeker)
	{
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024B")]
	[Address(RVA = "0xE2B3F0", Offset = "0xE29DF0", VA = "0x180E2B3F0")]
	public void MakeSeeker(ulong seekerId, bool isSeeker)
	{
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024C")]
	[Address(RVA = "0xE2C050", Offset = "0xE2AA50", VA = "0x180E2C050")]
	public void OutlineSeeker(ulong pId, bool isSeeker)
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024D")]
	[Address(RVA = "0xE2C3A0", Offset = "0xE2ADA0", VA = "0x180E2C3A0")]
	public void OutlineTagger(bool outline, ulong pId)
	{
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024E")]
	[Address(RVA = "0xE2A980", Offset = "0xE29380", VA = "0x180E2A980")]
	public void CheckGameOver()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600024F")]
	[Address(RVA = "0xE2AEF0", Offset = "0xE298F0", VA = "0x180E2AEF0")]
	private List<ulong> GetAllAlivePlayers()
	{
		return null;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x6000250")]
	[Address(RVA = "0xE2B0E0", Offset = "0xE29AE0", VA = "0x180E2B0E0", Slot = "7")]
	public override ValueTuple<int, int> GetGoodBadPlayers()
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000251")]
	[Address(RVA = "0xE29050", Offset = "0xE27A50", VA = "0x180E29050")]
	public GameModeHnS()
	{
	}

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x38")]
	public List<ulong> seekers;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x40")]
	public List<ulong> hiders;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<ulong, int> idToKills;
}
