using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
public class PlayerList : MonoBehaviour
{
	// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x337B00", Offset = "0x336500", VA = "0x180337B00")]
	private void Awake()
	{
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x337CC0", Offset = "0x3366C0", VA = "0x180337CC0")]
	public void Toggle()
	{
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x337BD0", Offset = "0x3365D0", VA = "0x180337BD0")]
	public void Toggle(bool on)
	{
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x337D10", Offset = "0x336710", VA = "0x180337D10")]
	public void UpdateList()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x338550", Offset = "0x336F50", VA = "0x180338550")]
	private void UpdatePlayerListing(ulong playerId)
	{
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerList()
	{
	}

	// Token: 0x0400014A RID: 330
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject parent;

	// Token: 0x0400014B RID: 331
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x20")]
	public Transform contentParent;

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject namePrefab;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, PlayerListingPrefab> players;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerList Instance;
}
