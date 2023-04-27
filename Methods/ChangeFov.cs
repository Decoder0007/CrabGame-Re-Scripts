using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class ChangeFov : MonoBehaviour
{
	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x303C60", Offset = "0x302660", VA = "0x180303C60")]
	private void Update()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ChangeFov()
	{
	}

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x18")]
	public Camera camera;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x20")]
	public float desiredFov;
}
