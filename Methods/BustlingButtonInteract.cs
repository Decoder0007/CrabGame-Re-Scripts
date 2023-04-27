using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class BustlingButtonInteract : SharedObject, IInteract
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x302660", Offset = "0x301060", VA = "0x180302660")]
	private void Awake()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x302880", Offset = "0x301280", VA = "0x180302880", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2FB050", Offset = "0x2F9A50", VA = "0x1802FB050", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x302790", Offset = "0x301190", VA = "0x180302790")]
	public void Press(bool press, float moveTime)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3028E0", Offset = "0x3012E0", VA = "0x1803028E0")]
	private void Update()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x302A30", Offset = "0x301430", VA = "0x180302A30")]
	public BustlingButtonInteract()
	{
	}

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x20")]
	public int buttonId;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x24")]
	public bool active;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource moveSfx;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource btnSfx;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 activePosition;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 inactivePosition;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 desiredPosition;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 startPosition;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x68")]
	private float moveTime;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x6C")]
	private float currentTime;
}
