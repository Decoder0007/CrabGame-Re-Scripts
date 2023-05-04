using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
public class TopRightStatusUi : MonoBehaviour
{
	// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x2FBF40", Offset = "0x2FA940", VA = "0x1802FBF40")]
	private void Start()
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x2FBF90", Offset = "0x2FA990", VA = "0x1802FBF90")]
	private void UpdatePlayersLeft()
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x2FBE00", Offset = "0x2FA800", VA = "0x1802FBE00")]
	private void PlayersLeftUI()
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x2FB9E0", Offset = "0x2FA3E0", VA = "0x1802FB9E0")]
	private void HnsUI()
	{
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public TopRightStatusUi()
	{
	}

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject playersGood;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject playersBad;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI playersGoodText;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI playersBadText;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1021A0", Offset = "0x1015A0")]
	public GameObject hnsUI;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x40")]
	public Color redColor;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x50")]
	public Color greenColor;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x60")]
	public RawImage bg;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI killsText;
}
