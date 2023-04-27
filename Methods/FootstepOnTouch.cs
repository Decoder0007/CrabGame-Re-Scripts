using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
public class FootstepOnTouch : MonoBehaviour
{
	// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x319960", Offset = "0x318360", VA = "0x180319960")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x319950", Offset = "0x318350", VA = "0x180319950")]
	private void GetReady()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x319BB0", Offset = "0x3185B0", VA = "0x180319BB0")]
	public FootstepOnTouch()
	{
	}

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject footstep;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x20")]
	private bool ready;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x24")]
	private float cooldown;
}
