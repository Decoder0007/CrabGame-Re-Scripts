using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class BoulderController : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x300B20", Offset = "0x2FF520", VA = "0x180300B20")]
	private void Awake()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x300B90", Offset = "0x2FF590", VA = "0x180300B90")]
	private void SendBoulder()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x300C80", Offset = "0x2FF680", VA = "0x180300C80")]
	public void SpawnBoulder(int spawnPoint)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x300E70", Offset = "0x2FF870", VA = "0x180300E70")]
	public BoulderController()
	{
	}

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] spawnPoints;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject boulder;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x28")]
	private float spawnRate;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x0")]
	public static BoulderController Instance;
}
