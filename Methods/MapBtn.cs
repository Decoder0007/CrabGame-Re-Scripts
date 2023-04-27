using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x20000B7")]
public class MapBtn : MonoBehaviour
{
	// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x326B40", Offset = "0x325540", VA = "0x180326B40")]
	public void SetMap(Texture2D texture2D, string title, string workshopId)
	{
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x326AF0", Offset = "0x3254F0", VA = "0x180326AF0")]
	public void Select()
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x326AA0", Offset = "0x3254A0", VA = "0x180326AA0")]
	public void Deselect()
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MapBtn()
	{
	}

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI title;

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x20")]
	public RawImage image;

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x28")]
	public ulong workshopId;
}
