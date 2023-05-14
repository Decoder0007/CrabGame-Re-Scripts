using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class CameraMove : MonoBehaviour
{
	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3034A0", Offset = "0x301EA0", VA = "0x1803034A0")]
	private void Update()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public CameraMove()
	{
	}

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x20")]
	public bool lerp;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x28")]
	public bool lookAtTarget;
}
