using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
public class DamageNumbers : MonoBehaviour
{
	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x312F10", Offset = "0x311910", VA = "0x180312F10")]
	public void SetDamage(int dmg, Vector3 shooterPos)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x313030", Offset = "0x311A30", VA = "0x180313030")]
	private void Start()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x312FA0", Offset = "0x3119A0", VA = "0x180312FA0")]
	private void StartFade()
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3132E0", Offset = "0x311CE0", VA = "0x1803132E0")]
	private void Update()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public DamageNumbers()
	{
	}

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI text;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 desiredPos;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 shooterPos;
}
