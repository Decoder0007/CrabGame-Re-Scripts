using System;
using CodeStage.AntiCheat.Detectors;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class CheckSfx : MonoBehaviour
{
	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Awake()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void SlowUpdate()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public CheckSfx()
	{
	}

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x18")]
	public ObscuredCheatingDetector sfx1;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x20")]
	public SpeedHackDetector sfx2;
}
