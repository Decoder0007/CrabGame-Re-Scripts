using System;
using Il2CppDummyDll;

// Token: 0x02000092 RID: 146
[Token(Token = "0x2000092")]
public class Money : SharedObject, IInteract
{
	// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x328720", Offset = "0x327120", VA = "0x180328720", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x3285D0", Offset = "0x326FD0", VA = "0x1803285D0", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x328570", Offset = "0x326F70", VA = "0x180328570", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1F8250", Offset = "0x1F6C50", VA = "0x1801F8250", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x328780", Offset = "0x327180", VA = "0x180328780")]
	public Money()
	{
	}

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x20")]
	public int amount;
}
