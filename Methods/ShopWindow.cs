using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011D RID: 285
[Token(Token = "0x200011D")]
public class ShopWindow : MonoBehaviour
{
	// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x2EC190", Offset = "0x2EAB90", VA = "0x1802EC190")]
	public void InitShop()
	{
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x2EC000", Offset = "0x2EAA00", VA = "0x1802EC000")]
	private void AddItemToTab(ItemData itemData, Transform tab)
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x2EC4A0", Offset = "0x2EAEA0", VA = "0x1802EC4A0")]
	public void UpdateShop()
	{
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ShopWindow()
	{
	}

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject itemPrefabUi;

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject shopTabPrefab;

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject tabBtnPrefab;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x30")]
	public Transform tabBtnParent;

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x38")]
	public Transform shopTabParent;

	// Token: 0x040006A9 RID: 1705
	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x40")]
	public Transform baseContentParent;

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x48")]
	public TabNavigate tabNavigation;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x50")]
	public List<ShopItemPrefab> items;
}
