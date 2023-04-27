using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x20000A7")]
public class ItemManager : MonoBehaviour
{
	// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000379")]
	[Address(RVA = "0xE3CA60", Offset = "0xE3B460", VA = "0x180E3CA60")]
	private void Awake()
	{
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037A")]
	[Address(RVA = "0xE3D150", Offset = "0xE3BB50", VA = "0x180E3D150")]
	private void PopulateItemList()
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600037B")]
	[Address(RVA = "0xE3CEE0", Offset = "0xE3B8E0", VA = "0x180E3CEE0")]
	public static ItemData GetItemById(int itemId)
	{
		return null;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x600037C")]
	[Address(RVA = "0xE3CD10", Offset = "0xE3B710", VA = "0x180E3CD10")]
	public static int GetIdByName(string name)
	{
		return 0;
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600037D")]
	[Address(RVA = "0xE3CF80", Offset = "0xE3B980", VA = "0x180E3CF80")]
	public static ItemData GetItemByName(string name)
	{
		return null;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ItemManager()
	{
	}

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, ItemData> idToItem;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject moneyPrefab;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x8")]
	public static ItemManager Instance;
}
