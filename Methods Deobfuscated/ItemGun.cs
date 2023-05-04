using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class ItemGun : ItemPrefab
{
	// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000303")]
	[Address(RVA = "0xE3B680", Offset = "0xE3A080", VA = "0x180E3B680", Slot = "10")]
	public override void TryUse(Transform camForward)
	{
	}

	// Token: 0x06000304 RID: 772 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x6000304")]
	[Address(RVA = "0xE3A4B0", Offset = "0xE38EB0", VA = "0x180E3A4B0")]
	private Vector2 GetAccuracyOffset()
	{
		return default(Vector2);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000305")]
	[Address(RVA = "0xE39E70", Offset = "0xE38870", VA = "0x180E39E70")]
	private void AddRecoilOffset()
	{
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000306")]
	[Address(RVA = "0xE3B290", Offset = "0xE39C90", VA = "0x180E3B290")]
	private void Update()
	{
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000307")]
	[Address(RVA = "0xE3B290", Offset = "0xE39C90", VA = "0x180E3B290")]
	private void ResetRecoil()
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000308")]
	[Address(RVA = "0xE3AA40", Offset = "0xE39440", VA = "0x180E3AA40", Slot = "11")]
	public override void LocalUse(Transform camForward)
	{
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000309")]
	[Address(RVA = "0xE3A710", Offset = "0xE39110", VA = "0x180E3A710")]
	private void HitPlayer(RaycastHit hit, float damageMultiplier = 1f)
	{
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030A")]
	[Address(RVA = "0xE39F30", Offset = "0xE38930", VA = "0x180E39F30", Slot = "12")]
	public override void AllUse(Vector3 hitPos)
	{
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "13")]
	public override void OnlineUse(Vector3 dir, ulong fromClient)
	{
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030C")]
	[Address(RVA = "0xE3B280", Offset = "0xE39C80", VA = "0x180E3B280", Slot = "14")]
	public override void MouseUp()
	{
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x600030D")]
	[Address(RVA = "0xE3B480", Offset = "0xE39E80", VA = "0x180E3B480", Slot = "15")]
	public override bool TryReload()
	{
		return default(bool);
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030E")]
	[Address(RVA = "0xE3B310", Offset = "0xE39D10", VA = "0x180E3B310")]
	private void StartReload()
	{
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030F")]
	[Address(RVA = "0xE3B440", Offset = "0xE39E40", VA = "0x180E3B440")]
	private void StopReload()
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000310")]
	[Address(RVA = "0xE3A3E0", Offset = "0xE38DE0", VA = "0x180E3A3E0")]
	private void FinishReload()
	{
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x46B0B0", Offset = "0x469AB0", VA = "0x18046B0B0")]
	private void GetReady()
	{
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x6000312")]
	[Address(RVA = "0xE3A510", Offset = "0xE38F10", VA = "0x180E3A510")]
	public RaycastHit GetHit(Transform camForward)
	{
		return default(RaycastHit);
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000313")]
	[Address(RVA = "0xE3BB80", Offset = "0xE3A580", VA = "0x180E3BB80")]
	public ItemGun()
	{
	}

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x58")]
	public Transform gunTip;

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x60")]
	public GameObject muzzlePrefab;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x68")]
	public GameObject bulletPrefab;

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x70")]
	private float maxShootDistance;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x74")]
	private bool shooting;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x78")]
	private float recoilProgress;
}
