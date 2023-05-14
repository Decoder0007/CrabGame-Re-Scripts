using System;
using Il2CppDummyDll;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000082")]
public class GameModeLights : GameMode
{
	// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000260")]
	[Address(RVA = "0xE2D490", Offset = "0xE2BE90", VA = "0x180E2D490", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000261")]
	[Address(RVA = "0xE2D8F0", Offset = "0xE2C2F0", VA = "0x180E2D8F0")]
	private void SendStrobe()
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000262")]
	[Address(RVA = "0xE2D950", Offset = "0xE2C350", VA = "0x180E2D950")]
	public void Strobe()
	{
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000263")]
	[Address(RVA = "0xE2D940", Offset = "0xE2C340", VA = "0x180E2D940")]
	private void StrobeOff()
	{
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000264")]
	[Address(RVA = "0xE2D640", Offset = "0xE2C040", VA = "0x180E2D640")]
	private void SendLightsOut()
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000265")]
	[Address(RVA = "0xE2D570", Offset = "0xE2BF70", VA = "0x180E2D570", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026A")]
	[Address(RVA = "0xE2D9B0", Offset = "0xE2C3B0", VA = "0x180E2D9B0")]
	public void ToggleLights(bool b)
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026B")]
	[Address(RVA = "0xE2DB90", Offset = "0xE2C590", VA = "0x180E2DB90")]
	public GameModeLights()
	{
	}

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x38")]
	public float prepTime;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x3C")]
	private bool lightsOut;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x40")]
	private string[] weapons;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x48")]
	private bool firstToggle;
}
