using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class MapCamera : MonoBehaviour
{
	// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x326BB0", Offset = "0x3255B0", VA = "0x180326BB0")]
	private void Awake()
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x326E20", Offset = "0x325820", VA = "0x180326E20")]
	private void Update()
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x326CD0", Offset = "0x3256D0", VA = "0x180326CD0")]
	public void InvokeStop()
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x326CF0", Offset = "0x3256F0", VA = "0x180326CF0")]
	private void StopCinematicCamera()
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MapCamera()
	{
	}

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x18")]
	private bool stopped;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x0")]
	public static MapCamera Instance;
}
