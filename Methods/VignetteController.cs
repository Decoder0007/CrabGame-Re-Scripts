using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
public class VignetteController : MonoBehaviour
{
	// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x2FE560", Offset = "0x2FCF60", VA = "0x1802FE560")]
	public static void Damage()
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x2FE650", Offset = "0x2FD050", VA = "0x1802FE650")]
	private void Update()
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x2FE5E0", Offset = "0x2FCFE0", VA = "0x1802FE5E0")]
	public void SetAlpha(RawImage image, float a)
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x2FE8D0", Offset = "0x2FD2D0", VA = "0x1802FE8D0")]
	public VignetteController()
	{
	}

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x18")]
	public RawImage damageVignette;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x0")]
	private static float currentFadeTime;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x20")]
	private float fadeTime;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x4")]
	private static float dmgAlpha;
}
