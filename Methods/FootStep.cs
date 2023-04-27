using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
public class FootStep : MonoBehaviour
{
	// Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x3197C0", Offset = "0x3181C0", VA = "0x1803197C0")]
	private void Start()
	{
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x3197C0", Offset = "0x3181C0", VA = "0x1803197C0")]
	private void FindGroundType()
	{
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public FootStep()
	{
	}

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask whatIsGround;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x20")]
	public RandomSfx randomSfx;

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] genericStep;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip[] grassStep;
}
