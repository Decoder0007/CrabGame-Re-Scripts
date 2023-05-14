using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class GameModeTag : GameMode
{
	// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029B")]
	[Address(RVA = "0xE30BB0", Offset = "0xE2F5B0", VA = "0x180E30BB0", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029C")]
	[Address(RVA = "0xE30F30", Offset = "0xE2F930", VA = "0x180E30F30", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029D")]
	[Address(RVA = "0xE30CA0", Offset = "0xE2F6A0", VA = "0x180E30CA0", Slot = "5")]
	public override void OnFreezeOverAlert()
	{
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029E")]
	[Address(RVA = "0xE307A0", Offset = "0xE2F1A0", VA = "0x180E307A0", Slot = "8")]
	public override void GameModeAlert(int i)
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029F")]
	[Address(RVA = "0xE311F0", Offset = "0xE2FBF0", VA = "0x180E311F0", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xE318C0", Offset = "0xE302C0", VA = "0x180E318C0")]
	public void TagPlayer(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xE31BD0", Offset = "0xE305D0", VA = "0x180E31BD0")]
	public void TryTagPlayer(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xE317E0", Offset = "0xE301E0", VA = "0x180E317E0")]
	private void SendTagPlayer(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xE30280", Offset = "0xE2EC80", VA = "0x180E30280")]
	public void CheckGameOver()
	{
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xE31490", Offset = "0xE2FE90", VA = "0x180E31490")]
	public void OutlineTagger(bool outline, ulong pId)
	{
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xE30820", Offset = "0xE2F220", VA = "0x180E30820")]
	private List<ulong> GetAllAlivePlayers()
	{
		return null;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xE30A10", Offset = "0xE2F410", VA = "0x180E30A10", Slot = "7")]
	public override ValueTuple<int, int> GetGoodBadPlayers()
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xE29050", Offset = "0xE27A50", VA = "0x180E29050")]
	public GameModeTag()
	{
	}

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x38")]
	private List<ulong> taggedPlayers;
}
