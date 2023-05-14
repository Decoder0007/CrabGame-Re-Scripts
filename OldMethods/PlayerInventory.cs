using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E3 RID: 227
[Token(Token = "0x20000E3")]
public class PlayerInventory : MonoBehaviour
{
	// Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x3353A0", Offset = "0x333DA0", VA = "0x1803353A0")]
	private void Awake()
	{
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000598")]
	[Address(RVA = "0x337070", Offset = "0x335A70", VA = "0x180337070")]
	private void Start()
	{
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x3354E0", Offset = "0x333EE0", VA = "0x1803354E0")]
	public void ClearInventory()
	{
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x336FB0", Offset = "0x3359B0", VA = "0x180336FB0")]
	public void ScrollItem(int dir)
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x3355C0", Offset = "0x333FC0", VA = "0x1803355C0")]
	public void EquipItem(int newSlot)
	{
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x3373F0", Offset = "0x335DF0", VA = "0x1803373F0")]
	public void UnEquip()
	{
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x336A40", Offset = "0x335440", VA = "0x180336A40")]
	public void PreviousItem()
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x3365E0", Offset = "0x334FE0", VA = "0x1803365E0")]
	public void PickupItem(ItemPrefab item)
	{
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x335E40", Offset = "0x334840", VA = "0x180335E40")]
	public void ForceGiveItem(ItemData item)
	{
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x336460", Offset = "0x334E60", VA = "0x180336460")]
	public void PickupAmmo(ItemPrefab item)
	{
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x337080", Offset = "0x335A80", VA = "0x180337080")]
	public void TryDropItem(int slot = -1)
	{
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x336C10", Offset = "0x335610", VA = "0x180336C10")]
	public void RemoveItem(int objectId)
	{
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x337780", Offset = "0x336180", VA = "0x180337780")]
	public void UseItem()
	{
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x336320", Offset = "0x334D20", VA = "0x180336320")]
	public void MouseUp()
	{
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x336A50", Offset = "0x335450", VA = "0x180336A50")]
	public void Reload()
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x336A20", Offset = "0x335420", VA = "0x180336A20")]
	private void PlayWosh()
	{
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x336870", Offset = "0x335270", VA = "0x180336870")]
	public void PlayEmptyShot()
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x3368B0", Offset = "0x3352B0", VA = "0x1803368B0")]
	public void PlayItemEquip()
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x3360C0", Offset = "0x334AC0", VA = "0x1803360C0")]
	public static int GetSlot(ItemData.ItemType type, ItemData[] inventory)
	{
		return 0;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002928 File Offset: 0x00000B28
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x335D00", Offset = "0x334700", VA = "0x180335D00")]
	public static int FindAvailableSlot(int[] slot)
	{
		return 0;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00002940 File Offset: 0x00000B40
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x336030", Offset = "0x334A30", VA = "0x180336030")]
	public int GetAmmoOfType(ItemAmmo.AmmoType type)
	{
		return 0;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00002958 File Offset: 0x00000B58
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x3376A0", Offset = "0x3360A0", VA = "0x1803376A0")]
	public int UseAmmo(ItemAmmo.AmmoType type, int ammoNeeded)
	{
		return 0;
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x3374B0", Offset = "0x335EB0", VA = "0x1803374B0")]
	public void UpdateAmmoUI()
	{
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x336250", Offset = "0x334C50", VA = "0x180336250")]
	public void LockInventory(bool b)
	{
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x337AF0", Offset = "0x3364F0", VA = "0x180337AF0")]
	public PlayerInventory()
	{
	}

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x0")]
	private static ItemData[] inventory;

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<ItemAmmo.AmmoType, int> ammoInventory;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x8")]
	public static int inventorySize;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x10")]
	private static int[] primarySlot;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x18")]
	private static int[] secondarySlot;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x20")]
	private static int[] meleeSlot;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x28")]
	private static int[] throwableSlot;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x30")]
	private static int[] otherSlot;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x20")]
	private int activeSlot;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x24")]
	private int previousSlot;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x28")]
	public Transform weaponParent;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject currentItem;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource itemAudio;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource woshSfx;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x38")]
	public static PlayerInventory Instance;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x48")]
	public PlayerManager pm;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x50")]
	private int lastSentItem;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip emptyShot;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x60")]
	private bool locked;
}
