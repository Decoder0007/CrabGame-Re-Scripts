using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class GameModeTileDrive : GameMode
{
	// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xE320E0", Offset = "0xE30AE0", VA = "0x180E320E0", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xE32650", Offset = "0xE31050", VA = "0x180E32650")]
	public void SendTeam()
	{
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xE31EF0", Offset = "0xE308F0", VA = "0x180E31EF0")]
	public void MakeTeam(ulong pid, int team)
	{
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xE322B0", Offset = "0xE30CB0", VA = "0x180E322B0", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xE31C70", Offset = "0xE30670", VA = "0x180E31C70")]
	public void ForceUpdateTile(int tileId, int teamId)
	{
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xE31D00", Offset = "0xE30700", VA = "0x180E31D00")]
	private List<ulong> GetAllAlivePlayers()
	{
		return null;
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xE32860", Offset = "0xE31260", VA = "0x180E32860")]
	public GameModeTileDrive()
	{
	}

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<ulong, int> idToTeam;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x40")]
	public int nTeams;
}
