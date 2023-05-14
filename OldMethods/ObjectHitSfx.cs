using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class ObjectHitSfx : MonoBehaviour
{
	// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x32CC70", Offset = "0x32B670", VA = "0x18032CC70")]
	public void SetSfx(ObjectHitSfx.SfxHitType type)
	{
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ObjectHitSfx()
	{
	}

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] genericHits;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] metalHits;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x28")]
	public RandomSfx sfx;

	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public enum SfxHitType
	{
		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		Generic,
		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		Metal
	}
}
