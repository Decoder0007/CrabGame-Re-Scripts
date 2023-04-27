using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
public class ItemAmmo : ItemPrefab
{
	// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xE39CE0", Offset = "0xE386E0", VA = "0x180E39CE0", Slot = "10")]
	public override void TryUse(Transform camForward)
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xE39C20", Offset = "0xE38620", VA = "0x180E39C20", Slot = "11")]
	public override void LocalUse(Transform cam)
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xE39BE0", Offset = "0xE385E0", VA = "0x180E39BE0", Slot = "12")]
	public override void AllUse(Vector3 dir)
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000300")]
	[Address(RVA = "0xE39CA0", Offset = "0xE386A0", VA = "0x180E39CA0", Slot = "13")]
	public override void OnlineUse(Vector3 dir, ulong fromClient)
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000301")]
	[Address(RVA = "0xE39C60", Offset = "0xE38660", VA = "0x180E39C60", Slot = "14")]
	public override void MouseUp()
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000302")]
	[Address(RVA = "0xE39D20", Offset = "0xE38720", VA = "0x180E39D20")]
	public ItemAmmo()
	{
	}

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x58")]
	public ItemAmmo.AmmoType ammoType;

	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public enum AmmoType
	{
		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		Small,
		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		Shotgun,
		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		Rifle,
		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		Sniper,
		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		Explosive
	}
}
