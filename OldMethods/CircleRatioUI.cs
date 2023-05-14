using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
public class CircleRatioUI : MonoBehaviour
{
	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3051C0", Offset = "0x303BC0", VA = "0x1803051C0")]
	public void SetRatio(int current, int max, int bottomTextValue = 0)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3051E0", Offset = "0x303BE0", VA = "0x1803051E0")]
	private void Update()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public CircleRatioUI()
	{
	}

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x18")]
	public Image circle;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI maxText;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x30")]
	private float currentValue;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x34")]
	private float desiredValue;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x38")]
	private float currentValueMax;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x3C")]
	private float desiredValueMax;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x40")]
	private int maxValue;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x44")]
	public bool useTextEasing;
}
