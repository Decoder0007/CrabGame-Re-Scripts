using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class BulletHit : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x301820", Offset = "0x300220", VA = "0x180301820")]
	public void SetHit(RaycastHit hit, SoundComponent soundComponent)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public BulletHit()
	{
	}

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x18")]
	public Decals.Decal bulletDecal;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x20")]
	public Decals.Decal bloodDecal;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject objectHitParticles;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject playerHitParticles;

	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public enum BulletHitType
	{
		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		Object,
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		Player
	}
}
