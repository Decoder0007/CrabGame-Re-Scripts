using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
public class PiecesManager : MonoBehaviour
{
	// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x332140", Offset = "0x330B40", VA = "0x180332140")]
	private void Awake()
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x332400", Offset = "0x330E00", VA = "0x180332400")]
	public void MakePieces(int nPieces)
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x3321C0", Offset = "0x330BC0", VA = "0x1803321C0")]
	public int GetRandomPieceIndex()
	{
		return 0;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x332220", Offset = "0x330C20", VA = "0x180332220")]
	public Vector3 GetRandomSpawnPoint()
	{
		return default(Vector3);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x332850", Offset = "0x331250", VA = "0x180332850")]
	public GameObject RemovePiece(int n)
	{
		return null;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x300B10", Offset = "0x2FF510", VA = "0x180300B10")]
	public PiecesManager()
	{
	}

	// Token: 0x04000141 RID: 321
	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x18")]
	public float pieceDistance;

	// Token: 0x04000142 RID: 322
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x20")]
	public GameObject piece;

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> pieces;

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x30")]
	public List<int> spawnIndexes;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x38")]
	public GameObject startPiece;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x40")]
	private System.Random random;

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x0")]
	public static PiecesManager Instance;
}
