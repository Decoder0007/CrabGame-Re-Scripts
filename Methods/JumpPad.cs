using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
public class JumpPad : MonoBehaviour
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE3FA80", Offset = "0xE3E480", VA = "0x180E3FA80")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x8642B0", Offset = "0x862CB0", VA = "0x1808642B0")]
	private void Cooldown()
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xE3FCC0", Offset = "0xE3E6C0", VA = "0x180E3FCC0")]
	public JumpPad()
	{
	}

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x18")]
	private float cooldown;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x1C")]
	private bool ready;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x20")]
	public float pushForce;
}
