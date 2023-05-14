using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F0 RID: 240
[Token(Token = "0x20000F0")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0xDC390", Offset = "0xDB790")]
public class PlayerEyes : MonoBehaviour
{
	// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000640")]
	[Address(RVA = "0x3332A0", Offset = "0x331CA0", VA = "0x1803332A0")]
	private void Awake()
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000641")]
	[Address(RVA = "0x333580", Offset = "0x331F80", VA = "0x180333580")]
	private void UpdateTarget()
	{
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000642")]
	[Address(RVA = "0x3332F0", Offset = "0x331CF0", VA = "0x1803332F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerEyes()
	{
	}

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x18")]
	public Transform leftEye;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x20")]
	public Transform rightEye;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x28")]
	public Transform head;

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x30")]
	public Transform target;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x38")]
	private bool canSee;
}
