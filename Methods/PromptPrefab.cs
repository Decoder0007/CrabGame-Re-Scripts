using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200005E")]
public class PromptPrefab : MonoBehaviour
{
	// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3D02A0", Offset = "0x3CECA0", VA = "0x1803D02A0")]
	private void Awake()
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x3D0440", Offset = "0x3CEE40", VA = "0x1803D0440")]
	public void SetPrompt(string header, string filler)
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x3D03C0", Offset = "0x3CEDC0", VA = "0x1803D03C0")]
	public void RemovePrompt()
	{
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x3D0360", Offset = "0x3CED60", VA = "0x1803D0360")]
	private void DestroySelf()
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x3D0190", Offset = "0x3CEB90", VA = "0x1803D0190")]
	private void Update()
	{
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x3D0190", Offset = "0x3CEB90", VA = "0x1803D0190")]
	private void AnimatePrompt()
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x3D04A0", Offset = "0x3CEEA0", VA = "0x1803D04A0")]
	public PromptPrefab()
	{
	}

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI header;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI filler;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 desiredScale;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 defaultScale;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x40")]
	private float animateSpeed;
}
