using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
public class RotationObject : MonoBehaviour
{
	// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x3D3A50", Offset = "0x3D2450", VA = "0x1803D3A50")]
	private void Awake()
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x3D3EB0", Offset = "0x3D28B0", VA = "0x1803D3EB0")]
	private void Start()
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x3D3C60", Offset = "0x3D2660", VA = "0x1803D3C60")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x3D4050", Offset = "0x3D2A50", VA = "0x1803D4050")]
	public RotationObject()
	{
	}

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 axis;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 startEuler;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x40")]
	public float offset;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x44")]
	private bool firstMove;
}
