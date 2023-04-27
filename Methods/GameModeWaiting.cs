using System;
using Il2CppDummyDll;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
[Serializable]
public class GameModeWaiting : GameMode
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060002B8 RID: 696 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000011")]
	public MyTimer timer
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2B1240", Offset = "0x2AFC40", VA = "0x1802B1240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x33EBB0", Offset = "0x33D5B0", VA = "0x18033EBB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xE33260", Offset = "0xE31C60", VA = "0x180E33260", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xE33360", Offset = "0xE31D60", VA = "0x180E33360", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xE33780", Offset = "0xE32180", VA = "0x180E33780")]
	private void Update()
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x7599A0", Offset = "0x7583A0", VA = "0x1807599A0")]
	public new float GetFreezeTime()
	{
		return 0f;
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void SetFreezeTime(float time)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xE33500", Offset = "0xE31F00", VA = "0x180E33500")]
	public void UpdateLobbyTimer()
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xE330C0", Offset = "0xE31AC0", VA = "0x180E330C0")]
	private int FindReadyPlayers()
	{
		return 0;
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xE33460", Offset = "0xE31E60", VA = "0x180E33460")]
	private void TimerDone()
	{
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xE29050", Offset = "0xE27A50", VA = "0x180E29050")]
	public GameModeWaiting()
	{
	}

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private MyTimer <timer>k__BackingField;
}
