using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000113 RID: 275
[Token(Token = "0x2000113")]
public class DisplayNameUI : MonoBehaviour
{
	// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x315BB0", Offset = "0x3145B0", VA = "0x180315BB0")]
	private void Awake()
	{
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x315C30", Offset = "0x314630", VA = "0x180315C30")]
	public void Show()
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x315BF0", Offset = "0x3145F0", VA = "0x180315BF0")]
	private void Hide()
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x2FFD10", Offset = "0x2FE710", VA = "0x1802FFD10")]
	public void SetName(string name)
	{
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x315CD0", Offset = "0x3146D0", VA = "0x180315CD0")]
	public DisplayNameUI()
	{
	}

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI nameText;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x20")]
	private bool hidden;
}
