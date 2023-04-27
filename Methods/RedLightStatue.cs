using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000064 RID: 100
[Token(Token = "0x2000064")]
public class RedLightStatue : MonoBehaviour
{
	// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x3D2110", Offset = "0x3D0B10", VA = "0x1803D2110")]
	private void Awake()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x3D22D0", Offset = "0x3D0CD0", VA = "0x1803D22D0")]
	public void RedLight(float spinTime)
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x3D21E0", Offset = "0x3D0BE0", VA = "0x1803D21E0")]
	public void GreenLight(float spinTime)
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x3D2290", Offset = "0x3D0C90", VA = "0x1803D2290")]
	public void PlayAlarm()
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x3D2380", Offset = "0x3D0D80", VA = "0x1803D2380")]
	private void Update()
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public RedLightStatue()
	{
	}

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x18")]
	private Quaternion defaultRotation;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x28")]
	private Quaternion spinRotation;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x38")]
	private Quaternion startSpinRotation;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion desiredRotation;

	// Token: 0x04000178 RID: 376
	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x58")]
	private float spinTime;

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x5C")]
	private float currentTime;

	// Token: 0x0400017A RID: 378
	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1017B0", Offset = "0x100BB0")]
	public Transform head;

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x68")]
	public LayerMask whatIsRaycast;

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x70")]
	public AudioSource redLightSfx;

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x78")]
	public AudioSource otherSfx;

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x80")]
	public AudioSource scanSfx;

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x88")]
	public AudioSource babySfx;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x90")]
	public AudioClip redLight;

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x98")]
	public AudioClip greenLight;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0xA0")]
	public AudioClip turn;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0xA8")]
	public AudioClip spot;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x0")]
	public static RedLightStatue Instance;
}
