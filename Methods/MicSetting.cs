using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
public class MicSetting : MonoBehaviour
{
	// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x328380", Offset = "0x326D80", VA = "0x180328380")]
	private void Start()
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x3284F0", Offset = "0x326EF0", VA = "0x1803284F0")]
	private void UpdateMicSetting()
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x328330", Offset = "0x326D30", VA = "0x180328330")]
	public void CloseSetting()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MicSetting()
	{
	}

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x18")]
	public ScrollSettings micSetting;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject mainUI;
}
