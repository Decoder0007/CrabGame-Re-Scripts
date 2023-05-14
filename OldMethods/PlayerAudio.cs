using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
public class PlayerAudio : MonoBehaviour
{
	// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x3329F0", Offset = "0x3313F0", VA = "0x1803329F0")]
	private void Awake()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerAudio()
	{
	}

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x18")]
	public RandomSfx fallDamage;

	// Token: 0x04000149 RID: 329
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerAudio Instance;
}
