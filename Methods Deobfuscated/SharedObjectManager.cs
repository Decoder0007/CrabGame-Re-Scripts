using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
public class SharedObjectManager : MonoBehaviour
{
	// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x2EB4F0", Offset = "0x2E9EF0", VA = "0x1802EB4F0")]
	private void Awake()
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x2EB470", Offset = "0x2E9E70", VA = "0x1802EB470")]
	public void AddObject(SharedObject sharedObject)
	{
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x2EBAA0", Offset = "0x2EA4A0", VA = "0x1802EBAA0")]
	public void RemoveObject(int oId)
	{
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x2EB5F0", Offset = "0x2E9FF0", VA = "0x1802EB5F0")]
	public int GetNextId()
	{
		return 0;
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x2EB7A0", Offset = "0x2EA1A0", VA = "0x1802EB7A0")]
	private void RemoveNulls()
	{
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x2EB6C0", Offset = "0x2EA0C0", VA = "0x1802EB6C0")]
	public bool IsOIdTakenBySelf(int OId, GameObject gameObject)
	{
		return default(bool);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x2EB590", Offset = "0x2E9F90", VA = "0x1802EB590")]
	public bool Contains(int oId)
	{
		return default(bool);
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x2EB660", Offset = "0x2EA060", VA = "0x1802EB660")]
	public SharedObject GetSharedObject(int oId)
	{
		return null;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10")]
	public Dictionary<int, SharedObject> GetDictionary()
	{
		return null;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x2EBC80", Offset = "0x2EA680", VA = "0x1802EBC80")]
	public SharedObjectManager()
	{
	}

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, SharedObject> sharedObjects;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x20")]
	private int id;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x0")]
	public static SharedObjectManager Instance;
}
