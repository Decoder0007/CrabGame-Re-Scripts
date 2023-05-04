using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
public class StationInteract : MonoBehaviour, IInteract
{
	// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2EDAC0", Offset = "0x2EC4C0", VA = "0x1802EDAC0", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2EDA40", Offset = "0x2EC440", VA = "0x1802EDA40", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2EDA80", Offset = "0x2EC480", VA = "0x1802EDA80", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2EDA00", Offset = "0x2EC400", VA = "0x1802EDA00", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1F8250", Offset = "0x1F6C50", VA = "0x1801F8250", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public StationInteract()
	{
	}

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x18")]
	public StationInteract.StationType type;

	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public enum StationType
	{
		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		Weapons
	}
}
