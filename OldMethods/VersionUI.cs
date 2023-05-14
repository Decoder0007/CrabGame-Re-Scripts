using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x20000B8")]
public class VersionUI : MonoBehaviour
{
	// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x2FE430", Offset = "0x2FCE30", VA = "0x1802FE430")]
	private void Awake()
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Start()
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x2FE4A0", Offset = "0x2FCEA0", VA = "0x1802FE4A0")]
	public void SetId(ulong id)
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public VersionUI()
	{
	}

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI versionText;

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x0")]
	public static VersionUI Instance;
}
