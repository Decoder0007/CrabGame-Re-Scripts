using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class BlockManager : MonoBehaviour
{
	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x300470", Offset = "0x2FEE70", VA = "0x180300470")]
	private void Awake()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x300740", Offset = "0x2FF140", VA = "0x180300740")]
	public void MakePieces(int nPieces)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x300500", Offset = "0x2FEF00", VA = "0x180300500")]
	public int GetRandomPieceIndex()
	{
		return 0;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x300560", Offset = "0x2FEF60", VA = "0x180300560")]
	public Vector3 GetRandomSpawnPoint()
	{
		return default(Vector3);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x300A50", Offset = "0x2FF450", VA = "0x180300A50")]
	public GameObject RemovePiece(int n)
	{
		return null;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x300B10", Offset = "0x2FF510", VA = "0x180300B10")]
	public BlockManager()
	{
	}

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	public float pieceDistance;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public GameObject piece;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> pieces;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	public List<int> spawnIndexes;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject startPiece;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x40")]
	private System.Random random;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x0")]
	public static BlockManager Instance;
}
