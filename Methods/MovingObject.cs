using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
public class MovingObject : MonoBehaviour
{
	// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x32B780", Offset = "0x32A180", VA = "0x18032B780")]
	private void Awake()
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x32B8E0", Offset = "0x32A2E0", VA = "0x18032B8E0")]
	private void Start()
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x32B7D0", Offset = "0x32A1D0", VA = "0x18032B7D0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MovingObject()
	{
	}

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 offsetPosition;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 startPosition;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x40")]
	public float offset;
}
