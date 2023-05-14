using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public class RedLightSafeZone : MonoBehaviour
{
	// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x3D1DF0", Offset = "0x3D07F0", VA = "0x1803D1DF0")]
	private void Awake()
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x3D1E90", Offset = "0x3D0890", VA = "0x1803D1E90")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x3D1FD0", Offset = "0x3D09D0", VA = "0x1803D1FD0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public RedLightSafeZone()
	{
	}

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x18")]
	public List<PlayerManager> safePlayers;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x0")]
	public static RedLightSafeZone Instance;
}
