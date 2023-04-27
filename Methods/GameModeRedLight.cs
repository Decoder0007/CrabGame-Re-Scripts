using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class GameModeRedLight : GameMode
{
	// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027E")]
	[Address(RVA = "0xE2F880", Offset = "0xE2E280", VA = "0x180E2F880", Slot = "9")]
	public override void InitMode()
	{
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027F")]
	[Address(RVA = "0xE2FBF0", Offset = "0xE2E5F0", VA = "0x180E2FBF0", Slot = "10")]
	public override void OnFreezeOver()
	{
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000280")]
	[Address(RVA = "0xE2FB90", Offset = "0xE2E590", VA = "0x180E2FB90", Slot = "5")]
	public override void OnFreezeOverAlert()
	{
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000281")]
	[Address(RVA = "0xE2F910", Offset = "0xE2E310", VA = "0x180E2F910")]
	private void InvokeRedLight()
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000282")]
	[Address(RVA = "0xE301A0", Offset = "0xE2EBA0", VA = "0x180E301A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x101930", Offset = "0x100D30")]
	private IEnumerator SendRedLight(float time, ulong pId)
	{
		return null;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000283")]
	[Address(RVA = "0xE2FF10", Offset = "0xE2E910", VA = "0x180E2FF10")]
	public void RedLight(float reactionTime)
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000284")]
	[Address(RVA = "0xE2F720", Offset = "0xE2E120", VA = "0x180E2F720")]
	private void ForceMovementUpdate()
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000285")]
	[Address(RVA = "0xE30030", Offset = "0xE2EA30", VA = "0x180E30030")]
	private void SendGreenLight()
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000286")]
	[Address(RVA = "0xE2F790", Offset = "0xE2E190", VA = "0x180E2F790")]
	public void GreenLight(float reactionTime)
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000287")]
	[Address(RVA = "0xE2FC50", Offset = "0xE2E650", VA = "0x180E2FC50", Slot = "11")]
	public override void OnRoundOver()
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "12")]
	public override void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void ModeUpdate()
	{
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028A")]
	[Address(RVA = "0xE30230", Offset = "0xE2EC30", VA = "0x180E30230", Slot = "14")]
	public override void StopGame()
	{
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "15")]
	public override void PlayerDied(ulong deadId, ulong killerId)
	{
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028C")]
	[Address(RVA = "0xE2F100", Offset = "0xE2DB00", VA = "0x180E2F100")]
	public void CheckMovement()
	{
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028D")]
	[Address(RVA = "0xE2EDD0", Offset = "0xE2D7D0", VA = "0x180E2EDD0")]
	public void CheckGameOver()
	{
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028E")]
	[Address(RVA = "0xE2F600", Offset = "0xE2E000", VA = "0x180E2F600")]
	private void ExplodePlayer(PlayerManager pm)
	{
	}

	// Token: 0x0600028F RID: 655 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x600028F")]
	[Address(RVA = "0xE2F700", Offset = "0xE2E100", VA = "0x180E2F700")]
	private float FindNextTime()
	{
		return 0f;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000290")]
	[Address(RVA = "0xE2E7D0", Offset = "0xE2D1D0", VA = "0x180E2E7D0")]
	private void ActivateRedLight()
	{
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000291")]
	[Address(RVA = "0xE2FB20", Offset = "0xE2E520", VA = "0x180E2FB20")]
	private void InvokeStopRedLight()
	{
	}

	// Token: 0x06000292 RID: 658 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x6000292")]
	[Address(RVA = "0xE2EAB0", Offset = "0xE2D4B0", VA = "0x180E2EAB0")]
	private bool CanSeePlayer(ulong pId)
	{
		return default(bool);
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000293")]
	[Address(RVA = "0xE30250", Offset = "0xE2EC50", VA = "0x180E30250")]
	public GameModeRedLight()
	{
	}

	// Token: 0x0400025D RID: 605
	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x38")]
	private float serverReactionTime;

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x3C")]
	private bool redLightActive;

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<ulong, GameModeRedLight.SnapShot> freezePositions;

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x48")]
	private float minReactionTime;

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x4C")]
	private float maxReactionTime;

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x50")]
	private float reductionTime;

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x54")]
	public float moveThreshold;

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x58")]
	public float rotationThreshold;

	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	private class SnapShot
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2ECA80", Offset = "0x2EB480", VA = "0x1802ECA80")]
		public SnapShot(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;
	}

	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <SendRedLight>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <SendRedLight>d__12(int <>1__state)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2FD730", Offset = "0x2FC130", VA = "0x1802FD730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000F")]
		private object Current
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2FD830", Offset = "0x2FC230", VA = "0x1802FD830", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000010")]
		private object Current
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x28")]
		public ulong pId;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x30")]
		public GameModeRedLight <>4__this;
	}
}
