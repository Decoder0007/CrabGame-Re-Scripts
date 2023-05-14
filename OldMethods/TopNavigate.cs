using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public class TopNavigate : MonoBehaviour
{
	// Token: 0x060006E2 RID: 1762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x2FB870", Offset = "0x2FA270", VA = "0x1802FB870")]
	private void OnEnable()
	{
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x2FB880", Offset = "0x2FA280", VA = "0x1802FB880")]
	public void Select(int selected)
	{
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public TopNavigate()
	{
	}

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] settingMenus;

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x20")]
	public RawImage[] btns;

	// Token: 0x04000647 RID: 1607
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x28")]
	public Color selectedColor;

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x38")]
	public Color idleColor;
}
