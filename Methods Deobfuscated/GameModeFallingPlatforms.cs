using System;
using Il2CppDummyDll;

// Token: 0x0200007D RID: 125
[Token(Token = "0x200007D")]
public class GameModeFallingPlatforms : GameMode
{
	// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000217")]
	[Address(RVA = "0xE28020", Offset = "0xE26A20", VA = "0x180E28020", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000218")]
	[Address(RVA = "0xE28330", Offset = "0xE26D30", VA = "0x180E28330")]
	public void SetPieces(int nPieces)
	{
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000219")]
	[Address(RVA = "0xE281A0", Offset = "0xE26BA0", VA = "0x180E281A0", Slot = "6")]
	public override void OnPlayerGameModeLoaded(ulong pId)
	{
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021A")]
	[Address(RVA = "0xE28100", Offset = "0xE26B00", VA = "0x180E28100", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021B")]
	[Address(RVA = "0xE28250", Offset = "0xE26C50", VA = "0x180E28250")]
	private void SendFallPiece()
	{
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021C")]
	[Address(RVA = "0xE27FD0", Offset = "0xE269D0", VA = "0x180E27FD0")]
	public void FallPiece(int pieceIndex)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021D")]
	[Address(RVA = "0xE28210", Offset = "0xE26C10", VA = "0x180E28210", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000220")]
	[Address(RVA = "0xE28440", Offset = "0xE26E40", VA = "0x180E28440", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000222")]
	[Address(RVA = "0xE28480", Offset = "0xE26E80", VA = "0x180E28480")]
	public GameModeFallingPlatforms()
	{
	}

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x38")]
	private int totalPieces;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x3C")]
	private int endPieces;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x40")]
	private int currentlyFallen;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x44")]
	private int fallPieces;

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x48")]
	private float fallInterval;

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x4C")]
	private float piecesRatio;
}
