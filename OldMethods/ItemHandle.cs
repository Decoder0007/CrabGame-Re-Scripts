using System;
using DitzelGames.FastIK;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
public class ItemHandle : MonoBehaviour
{
	// Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058C")]
	[Address(RVA = "0xE3BBA0", Offset = "0xE3A5A0", VA = "0x180E3BBA0")]
	private void Awake()
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058D")]
	[Address(RVA = "0xE3C5D0", Offset = "0xE3AFD0", VA = "0x180E3C5D0")]
	private void Start()
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058E")]
	[Address(RVA = "0xE3BDB0", Offset = "0xE3A7B0", VA = "0x180E3BDB0")]
	public void EquipItem(int itemId, ulong fromClient)
	{
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058F")]
	[Address(RVA = "0xE3BC70", Offset = "0xE3A670", VA = "0x180E3BC70")]
	public void DisableIK(float time)
	{
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000590")]
	[Address(RVA = "0xE3C300", Offset = "0xE3AD00", VA = "0x180E3C300")]
	public void ResetIK()
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000591")]
	[Address(RVA = "0xE3C610", Offset = "0xE3B010", VA = "0x180E3C610")]
	private void Update()
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000592")]
	[Address(RVA = "0xE3C570", Offset = "0xE3AF70", VA = "0x180E3C570")]
	public void StartReload(float reloadTime)
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000593")]
	[Address(RVA = "0xE3C280", Offset = "0xE3AC80", VA = "0x180E3C280")]
	private void FinishReload()
	{
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000594")]
	[Address(RVA = "0xE3C900", Offset = "0xE3B300", VA = "0x180E3C900")]
	public void UseItem(int itemId, Vector3 dir, ulong fromClient)
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x6000595")]
	[Address(RVA = "0xE3C2A0", Offset = "0xE3ACA0", VA = "0x180E3C2A0")]
	public bool IsItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ItemHandle()
	{
	}

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x18")]
	private ItemPrefab currentItem;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x20")]
	public Transform itemParent;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x28")]
	public FastIKFabric leftHandIK;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x30")]
	public FastIKFabric rightHandIK;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 restingPosition;

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 desiredPosition;

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 reloadPosition;

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion restingRotation;
}
