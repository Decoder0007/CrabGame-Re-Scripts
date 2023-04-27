using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
public class CameraRecoil : MonoBehaviour
{
	// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x303730", Offset = "0x302130", VA = "0x180303730")]
	public static void AddRecoil(Vector2 newRecoil)
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x3037A0", Offset = "0x3021A0", VA = "0x1803037A0")]
	private void Update()
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public CameraRecoil()
	{
	}

	// Token: 0x04000490 RID: 1168
	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2 desiredRecoil;

	// Token: 0x04000491 RID: 1169
	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 currentRotation;
}
