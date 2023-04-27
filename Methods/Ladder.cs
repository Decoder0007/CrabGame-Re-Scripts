using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
public class Ladder : MonoBehaviour
{
	// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x320BB0", Offset = "0x31F5B0", VA = "0x180320BB0")]
	private void Awake()
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x320C20", Offset = "0x31F620", VA = "0x180320C20")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public Ladder()
	{
	}

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x18")]
	public List<Collider> onLadder;
}
