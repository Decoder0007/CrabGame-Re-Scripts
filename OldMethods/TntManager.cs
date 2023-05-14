using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013D RID: 317
[Token(Token = "0x200013D")]
public class TntManager : MonoBehaviour
{
	// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x2FB1A0", Offset = "0x2F9BA0", VA = "0x1802FB1A0")]
	private void Awake()
	{
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x2FB470", Offset = "0x2F9E70", VA = "0x1802FB470")]
	public void MakePieces(int nPieces)
	{
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x2FB230", Offset = "0x2F9C30", VA = "0x1802FB230")]
	public int GetRandomPieceIndex()
	{
		return 0;
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x2FB290", Offset = "0x2F9C90", VA = "0x1802FB290")]
	public Vector3 GetRandomSpawnPoint()
	{
		return default(Vector3);
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x2FB790", Offset = "0x2FA190", VA = "0x1802FB790")]
	public GameObject RemovePiece(int n)
	{
		return null;
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x2FB850", Offset = "0x2FA250", VA = "0x1802FB850")]
	public TntManager()
	{
	}

	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x18")]
	public float pieceDistance;

	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x20")]
	public GameObject piece;

	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> pieces;

	// Token: 0x04000729 RID: 1833
	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x30")]
	public List<int> spawnIndexes;

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x38")]
	private float pieceSize;

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x40")]
	private System.Random random;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x0")]
	public static TntManager Instance;
}
