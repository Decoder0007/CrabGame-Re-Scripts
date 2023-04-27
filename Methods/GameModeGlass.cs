using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
public class GameModeGlass : GameMode
{
	// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000223")]
	[Address(RVA = "0xE288E0", Offset = "0xE272E0", VA = "0x180E288E0", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000224")]
	[Address(RVA = "0xE28990", Offset = "0xE27390", VA = "0x180E28990", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000225")]
	[Address(RVA = "0xE28930", Offset = "0xE27330", VA = "0x180E28930", Slot = "5")]
	public override void OnFreezeOverAlert()
	{
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000226")]
	[Address(RVA = "0xE28BE0", Offset = "0xE275E0", VA = "0x180E28BE0", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000227")]
	[Address(RVA = "0xE284A0", Offset = "0xE26EA0", VA = "0x180E284A0")]
	public void CheckGameOver()
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022C")]
	[Address(RVA = "0xE28E60", Offset = "0xE27860", VA = "0x180E28E60")]
	public void SetGlassPieces(List<int> pieces)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600022D")]
	[Address(RVA = "0xE287D0", Offset = "0xE271D0", VA = "0x180E287D0")]
	private List<int> GetRealPieces()
	{
		return null;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022E")]
	[Address(RVA = "0xE29050", Offset = "0xE27A50", VA = "0x180E29050")]
	public GameModeGlass()
	{
	}
}
