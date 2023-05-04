using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
public abstract class GameMode : MonoBehaviour
{
	// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x31E720", Offset = "0x31D120", VA = "0x18031E720", Slot = "4")]
	public virtual void Init()
	{
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x31EF20", Offset = "0x31D920", VA = "0x18031EF20")]
	private void UpdateTimer()
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x31F130", Offset = "0x31DB30", VA = "0x18031F130")]
	private void Update()
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x31E700", Offset = "0x31D100", VA = "0x18031E700")]
	public void HandleStateChange(GameMode.ModeState state)
	{
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x31EA00", Offset = "0x31D400", VA = "0x18031EA00")]
	private void StartRound()
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
	public virtual void OnFreezeOverAlert()
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "6")]
	public virtual void OnPlayerGameModeLoaded(ulong pId)
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x31E680", Offset = "0x31D080", VA = "0x18031E680", Slot = "7")]
	public virtual ValueTuple<int, int> GetGoodBadPlayers()
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "8")]
	public virtual void GameModeAlert(int i)
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x31E390", Offset = "0x31CD90", VA = "0x18031E390")]
	public void EndRound()
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x31E950", Offset = "0x31D350", VA = "0x18031E950")]
	private void StartMusic()
	{
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x31EDE0", Offset = "0x31D7E0", VA = "0x18031EDE0")]
	private void UpdateMusic()
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x31E340", Offset = "0x31CD40", VA = "0x18031E340")]
	protected void EndMusic()
	{
	}

	// Token: 0x060001E0 RID: 480
	[Token(Token = "0x60001E0")]
	public abstract void InitMode();

	// Token: 0x060001E1 RID: 481
	[Token(Token = "0x60001E1")]
	public abstract void OnFreezeOver();

	// Token: 0x060001E2 RID: 482
	[Token(Token = "0x60001E2")]
	public abstract void OnRoundOver();

	// Token: 0x060001E3 RID: 483
	[Token(Token = "0x60001E3")]
	public abstract void OnPlayerSpawnOrDespawn(ulong playerId);

	// Token: 0x060001E4 RID: 484
	[Token(Token = "0x60001E4")]
	public abstract void ModeUpdate();

	// Token: 0x060001E5 RID: 485
	[Token(Token = "0x60001E5")]
	public abstract void StopGame();

	// Token: 0x060001E6 RID: 486
	[Token(Token = "0x60001E6")]
	public abstract void PlayerDied(ulong deadId, ulong killerId);

	// Token: 0x060001E7 RID: 487 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x31E660", Offset = "0x31D060", VA = "0x18031E660")]
	public float GetFreezeTime()
	{
		return 0f;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x31E8F0", Offset = "0x31D2F0", VA = "0x18031E8F0")]
	public void SetGameModeTimer(float time, int state)
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x31E5B0", Offset = "0x31CFB0", VA = "0x18031E5B0")]
	public void GameOver()
	{
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x31F780", Offset = "0x31E180", VA = "0x18031F780")]
	protected GameMode()
	{
	}

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x18")]
	protected MyTimer freezeTimer;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x20")]
	public GameMode.ModeState modeState;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x24")]
	protected float modeTime;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x28")]
	private int lastTick;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x2C")]
	private int forcedPlayersLeft;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x30")]
	private float totalRoundTime;

	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public enum ModeState
	{
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		Freeze,
		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		Playing,
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		Ended,
		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		GameOver
	}
}
