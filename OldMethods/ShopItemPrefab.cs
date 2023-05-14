using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200011C RID: 284
[Token(Token = "0x200011C")]
public class ShopItemPrefab : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x0600071E RID: 1822 RVA: 0x00002E08 File Offset: 0x00001008
	// (set) Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003B")]
	public int itemId
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x225FE0", Offset = "0x2249E0", VA = "0x180225FE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x226030", Offset = "0x224A30", VA = "0x180226030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000720 RID: 1824 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003C")]
	public ItemData itemData
	{
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2B1250", Offset = "0x2AFC50", VA = "0x1802B1250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2B4490", Offset = "0x2B2E90", VA = "0x1802B4490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000722")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Start()
	{
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000723")]
	[Address(RVA = "0x2EBEF0", Offset = "0x2EA8F0", VA = "0x1802EBEF0")]
	private void Update()
	{
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void UpdateItem()
	{
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void TryBuy()
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x2EBEE0", Offset = "0x2EA8E0", VA = "0x1802EBEE0", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x2EBEE0", Offset = "0x2EA8E0", VA = "0x1802EBEE0", Slot = "6")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000729")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ShopItemPrefab()
	{
	}

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <itemId>k__BackingField;

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private ItemData <itemData>k__BackingField;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI itemName;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI itemPrice;

	// Token: 0x0400069E RID: 1694
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x38")]
	public RawImage itemIcon;

	// Token: 0x0400069F RID: 1695
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x40")]
	public RawImage cantAffordOverlay;

	// Token: 0x040006A0 RID: 1696
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x48")]
	public CanvasGroup overlayGroup;

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x50")]
	public Transform buyText;

	// Token: 0x040006A2 RID: 1698
	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x58")]
	private float currentBuyTransition;

	// Token: 0x040006A3 RID: 1699
	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x5C")]
	private float desiredBuyTransition;
}
