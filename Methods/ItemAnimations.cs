using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public class ItemAnimations : MonoBehaviour
{
	// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE39D30", Offset = "0xE38730", VA = "0x180E39D30")]
	private void Awake()
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE39DD0", Offset = "0xE387D0", VA = "0x180E39DD0")]
	public void PlayMeleeAnimation(ItemData itemData, float animationSpeed)
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ItemAnimations()
	{
	}

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x18")]
	private Animator animator;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x20")]
	private RandomSfx sfx;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x0")]
	public static ItemAnimations Instance;
}
