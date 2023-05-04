using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
public class RisingLava : MonoBehaviour
{
	// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x3D36B0", Offset = "0x3D20B0", VA = "0x1803D36B0")]
	private void Awake()
	{
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3D36F0", Offset = "0x3D20F0", VA = "0x1803D36F0")]
	private void Update()
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x3D3850", Offset = "0x3D2250", VA = "0x1803D3850")]
	public RisingLava()
	{
	}

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 spawnPos;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 desiredPos;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x30")]
	public float lavaTime;
}
