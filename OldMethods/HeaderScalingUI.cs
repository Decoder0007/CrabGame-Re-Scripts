using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B6 RID: 182
[Token(Token = "0x20000B6")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0xDC390", Offset = "0xDB790")]
public class HeaderScalingUI : MonoBehaviour
{
	// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xE38A30", Offset = "0xE37430", VA = "0x180E38A30")]
	private void Update()
	{
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xE38B10", Offset = "0xE37510", VA = "0x180E38B10")]
	public HeaderScalingUI()
	{
	}

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform main;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform header;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform content;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x30")]
	public float contentPercentScale;
}
