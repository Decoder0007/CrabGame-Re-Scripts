using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000148 RID: 328
[Token(Token = "0x2000148")]
public class WinManager : MonoBehaviour
{
	// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x2FF110", Offset = "0x2FDB10", VA = "0x1802FF110")]
	private void Start()
	{
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x2FF0C0", Offset = "0x2FDAC0", VA = "0x1802FF0C0")]
	public void Continue()
	{
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public WinManager()
	{
	}

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI nameText;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI priceText;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI otherText;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI playerText;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x0")]
	public static ulong pricePool;

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x8")]
	public static string winnerName;
}
