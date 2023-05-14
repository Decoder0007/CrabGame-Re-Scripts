using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000099 RID: 153
[Token(Token = "0x2000099")]
public class ItemMelee : ItemPrefab
{
	// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000314")]
	[Address(RVA = "0xE3DDF0", Offset = "0xE3C7F0", VA = "0x180E3DDF0", Slot = "9")]
	protected override void OtherStart()
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000315")]
	[Address(RVA = "0xE3E730", Offset = "0xE3D130", VA = "0x180E3E730", Slot = "10")]
	public override void TryUse(Transform camForward)
	{
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000316")]
	[Address(RVA = "0xE3DC60", Offset = "0xE3C660", VA = "0x180E3DC60", Slot = "11")]
	public override void LocalUse(Transform cam)
	{
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000317")]
	[Address(RVA = "0xE3D990", Offset = "0xE3C390", VA = "0x180E3D990")]
	private void LocalRaycast()
	{
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000318")]
	[Address(RVA = "0xE3D2A0", Offset = "0xE3BCA0", VA = "0x180E3D2A0", Slot = "12")]
	public override void AllUse(Vector3 dir)
	{
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000319")]
	[Address(RVA = "0xE3DE30", Offset = "0xE3C830", VA = "0x180E3DE30")]
	private void SpawnParticles()
	{
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031A")]
	[Address(RVA = "0xE3DD00", Offset = "0xE3C700", VA = "0x180E3DD00", Slot = "13")]
	public override void OnlineUse(Vector3 dir, ulong fromClient)
	{
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "14")]
	public override void MouseUp()
	{
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x46B0B0", Offset = "0x469AB0", VA = "0x18046B0B0")]
	private void GetReady()
	{
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031D")]
	[Address(RVA = "0xE3D360", Offset = "0xE3BD60", VA = "0x180E3D360")]
	private void HitPlayer(RaycastHit hit, float damageMultiplier = 1f)
	{
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031E")]
	[Address(RVA = "0xE39D20", Offset = "0xE38720", VA = "0x180E39D20")]
	public ItemMelee()
	{
	}

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x58")]
	public RandomSfx audio;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x60")]
	private Transform currentCamForward;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 attackDir;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x78")]
	public GameObject hitFx;
}
