using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000147 RID: 327
[Token(Token = "0x2000147")]
public class WaterSplash : MonoBehaviour
{
	// Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x2FECC0", Offset = "0x2FD6C0", VA = "0x1802FECC0")]
	private void Awake()
	{
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000812")]
	[Address(RVA = "0x2FED80", Offset = "0x2FD780", VA = "0x1802FED80")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x2FED30", Offset = "0x2FD730", VA = "0x1802FED30")]
	private void Cooldown()
	{
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000814")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public WaterSplash()
	{
	}

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject splashFx;

	// Token: 0x0400074C RID: 1868
	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x20")]
	private List<PlayerManager> onCooldown;
}
