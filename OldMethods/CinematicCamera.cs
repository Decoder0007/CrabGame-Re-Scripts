using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
public class CinematicCamera : MonoBehaviour
{
	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x304EB0", Offset = "0x3038B0", VA = "0x180304EB0")]
	private void Awake()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x304F00", Offset = "0x303900", VA = "0x180304F00")]
	private void NewShake()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x305090", Offset = "0x303A90", VA = "0x180305090")]
	private void Update()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3051A0", Offset = "0x303BA0", VA = "0x1803051A0")]
	public CinematicCamera()
	{
	}

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x1C")]
	public float size;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x20")]
	public float frequency;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 desiredPosition;
}
