using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000093 RID: 147
[Token(Token = "0x2000093")]
public class MoveInteract : SharedObject, IInteract
{
	// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x32B2C0", Offset = "0x329CC0", VA = "0x18032B2C0")]
	private new void Start()
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x32B310", Offset = "0x329D10", VA = "0x18032B310", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x32B280", Offset = "0x329C80", VA = "0x18032B280", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x32B170", Offset = "0x329B70", VA = "0x18032B170", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x1F8250", Offset = "0x1F6C50", VA = "0x1801F8250", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x32B370", Offset = "0x329D70", VA = "0x18032B370")]
	public MoveInteract()
	{
	}

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x20")]
	public GameObject objectToMove;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x28")]
	public float moveSpeed;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 moveOffset;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 defaultPosition;
}
