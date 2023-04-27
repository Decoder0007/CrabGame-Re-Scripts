using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
public class BulletPrefab : MonoBehaviour
{
	// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x301E60", Offset = "0x300860", VA = "0x180301E60")]
	public void SetBullet(Vector3 hitPos, ItemData data)
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x301DB0", Offset = "0x3007B0", VA = "0x180301DB0")]
	private void MakeShotgunParticles(ParticleSystem ps, int bullets)
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x3025F0", Offset = "0x300FF0", VA = "0x1803025F0")]
	private void StopBullet()
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public BulletPrefab()
	{
	}

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x18")]
	private int nBullets;

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem bulletPs;

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem smokePs;

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x30")]
	public GameObject hitPrefab;
}
