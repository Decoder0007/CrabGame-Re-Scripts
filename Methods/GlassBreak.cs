using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000091")]
public class GlassBreak : SharedObject, IInteract
{
	// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xE35E70", Offset = "0xE34870", VA = "0x180E35E70", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xE35AA0", Offset = "0xE344A0", VA = "0x180E35AA0", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1F8250", Offset = "0x1F6C50", VA = "0x1801F8250", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xE35DA0", Offset = "0xE347A0", VA = "0x180E35DA0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xE35C70", Offset = "0xE34670", VA = "0x180E35C70")]
	public void MakeSolid()
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xE35B00", Offset = "0xE34500", VA = "0x180E35B00")]
	private void BreakGlass()
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xE35ED0", Offset = "0xE348D0", VA = "0x180E35ED0")]
	public GlassBreak()
	{
	}

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject solidPiece;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject glassFx;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 fxOffset;
}
