using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class GameModeBombTag : GameMode
{
	// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x31D070", Offset = "0x31BA70", VA = "0x18031D070", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x31D5D0", Offset = "0x31BFD0", VA = "0x18031D5D0", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x31D340", Offset = "0x31BD40", VA = "0x18031D340", Slot = "5")]
	public override void OnFreezeOverAlert()
	{
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x31CD50", Offset = "0x31B750", VA = "0x18031CD50", Slot = "8")]
	public override void GameModeAlert(int i)
	{
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x31DD30", Offset = "0x31C730", VA = "0x18031DD30")]
	private void SelectBomber()
	{
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x31DE70", Offset = "0x31C870", VA = "0x18031DE70")]
	private void SendTagPlayer(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x31DF50", Offset = "0x31C950", VA = "0x18031DF50")]
	public void TagPlayer(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x31E260", Offset = "0x31CC60", VA = "0x18031E260")]
	public void TryTagPlayer(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x31D9E0", Offset = "0x31C3E0", VA = "0x18031D9E0")]
	public void OutlineTagger(bool outline, ulong pId)
	{
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x31D840", Offset = "0x31C240", VA = "0x18031D840", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x31D110", Offset = "0x31BB10", VA = "0x18031D110", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x31CC10", Offset = "0x31B610", VA = "0x18031CC10")]
	private void ExplodeBomb()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x31CE80", Offset = "0x31B880", VA = "0x18031CE80")]
	private List<ulong> GetAllAlivePlayers()
	{
		return null;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x31E300", Offset = "0x31CD00", VA = "0x18031E300")]
	public GameModeBombTag()
	{
	}

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x38")]
	private int bombsLeft;

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x3C")]
	private float intervalTime;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x40")]
	private float fuseTime;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x44")]
	private int maxBombs;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x48")]
	private List<ulong> taggedPlayers;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x50")]
	private MyTimer bombTimer;

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x58")]
	private bool showedAlert;
}
