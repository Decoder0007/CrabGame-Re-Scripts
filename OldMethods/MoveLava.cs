using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
public class MoveLava : MonoBehaviour
{
	// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x32B6D0", Offset = "0x32A0D0", VA = "0x18032B6D0")]
	private void Start()
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x32B4B0", Offset = "0x329EB0", VA = "0x18032B4B0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x32B380", Offset = "0x329D80", VA = "0x18032B380")]
	private float FindHeightOffset()
	{
		return 0f;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x32B6A0", Offset = "0x32A0A0", VA = "0x18032B6A0")]
	private void StartLava()
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x32B750", Offset = "0x32A150", VA = "0x18032B750")]
	public MoveLava()
	{
	}

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 startPosition;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x24")]
	public float offsetHeight;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x28")]
	public float lavaInterval;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x2C")]
	public float lavaTime;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x30")]
	public float lavaMoveTime;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x34")]
	private float lavaPeakStart;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x38")]
	private float lavaPeakEnd;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x3C")]
	public float lavaRotationTime;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource siren;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x48")]
	private bool started;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x4C")]
	private float sirenOffset;
}
