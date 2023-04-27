using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x0200007A RID: 122
[Token(Token = "0x200007A")]
public class GameModeButtons : GameMode
{
	// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xE26960", Offset = "0xE25360", VA = "0x180E26960", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xE26BB0", Offset = "0xE255B0", VA = "0x180E26BB0", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xE26690", Offset = "0xE25090", VA = "0x180E26690")]
	private void FindPlayersToKill()
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xE274B0", Offset = "0xE25EB0", VA = "0x180E274B0")]
	private void UpdatePlayerOrder()
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000200")]
	[Address(RVA = "0xE27010", Offset = "0xE25A10", VA = "0x180E27010")]
	public void ResetButtons()
	{
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000201")]
	[Address(RVA = "0xE262B0", Offset = "0xE24CB0", VA = "0x180E262B0")]
	private void FindNextPlayer()
	{
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000202")]
	[Address(RVA = "0xE27270", Offset = "0xE25C70", VA = "0x180E27270")]
	public void SetNextPlayer(ulong currentPlayerId, ulong nextPlayerId)
	{
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000203")]
	[Address(RVA = "0xE271A0", Offset = "0xE25BA0", VA = "0x180E271A0")]
	public void ServerReceivedButtonPress(ulong playerId, int buttonId)
	{
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000204")]
	[Address(RVA = "0xE26DC0", Offset = "0xE257C0", VA = "0x180E26DC0")]
	public void PressButton(ulong playerId, int buttonId)
	{
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000205")]
	[Address(RVA = "0xE27470", Offset = "0xE25E70", VA = "0x180E27470")]
	private void Unfreeze()
	{
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000206")]
	[Address(RVA = "0xE27110", Offset = "0xE25B10", VA = "0x180E27110")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1018E0", Offset = "0x100CE0")]
	private IEnumerator RevealButton(ulong playerId, int buttonId)
	{
		return null;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000207")]
	[Address(RVA = "0xE26A20", Offset = "0xE25420", VA = "0x180E26A20")]
	private void InvokeFindNextPlayer(bool increment = true)
	{
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000208")]
	[Address(RVA = "0xE26910", Offset = "0xE25310", VA = "0x180E26910")]
	private void IncrementPlayerIndex()
	{
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000209")]
	[Address(RVA = "0xE26F90", Offset = "0xE25990", VA = "0x180E26F90")]
	public void ReceiveButtonStateChange(GameModeButtons.ButtonModeState state)
	{
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020B")]
	[Address(RVA = "0xE26CF0", Offset = "0xE256F0", VA = "0x180E26CF0", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020C")]
	[Address(RVA = "0xE26AB0", Offset = "0xE254B0", VA = "0x180E26AB0", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020E")]
	[Address(RVA = "0xE26D70", Offset = "0xE25770", VA = "0x180E26D70", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600020F")]
	[Address(RVA = "0xE26720", Offset = "0xE25120", VA = "0x180E26720")]
	private List<ulong> GetAllAlivePlayers()
	{
		return null;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000210")]
	[Address(RVA = "0xE27520", Offset = "0xE25F20", VA = "0x180E27520")]
	public GameModeButtons()
	{
	}

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x38")]
	private int dangerousButton;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x3C")]
	private float maxModeTime;

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x40")]
	private float timeToPressButton;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x44")]
	private float timeToGetOffStage;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x48")]
	private float timeToRevealExplosion;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x4C")]
	private int desiredPlayersLeft;

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x50")]
	public ulong currentButtonPresser;

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x58")]
	public ulong nextButtonPresser;

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x60")]
	private bool canPressButton;

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x68")]
	public List<ulong> playerOrder;

	// Token: 0x04000235 RID: 565
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x70")]
	public int playerIndex;

	// Token: 0x04000236 RID: 566
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x78")]
	public MyTimer killTimer;

	// Token: 0x04000237 RID: 567
	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x80")]
	public MyTimer maxModeTimer;

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x88")]
	private int lastTick;

	// Token: 0x04000239 RID: 569
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x90")]
	private Random random;

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x98")]
	private float killRatio;

	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public enum ButtonModeState
	{
		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		RevealGreen,
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		RevealRed,
		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		ShowTimer,
		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		ResetButtons
	}

	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <RevealButton>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <RevealButton>d__26(int <>1__state)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2FD340", Offset = "0x2FBD40", VA = "0x1802FD340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000D")]
		private object Current
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2FD4E0", Offset = "0x2FBEE0", VA = "0x1802FD4E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000E")]
		private object Current
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x20")]
		public GameModeButtons <>4__this;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x28")]
		public int buttonId;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x30")]
		public ulong playerId;
	}
}
