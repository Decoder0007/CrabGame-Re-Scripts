using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000119 RID: 281
[Token(Token = "0x2000119")]
public class RevealPlayerNames : MonoBehaviour
{
	// Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x3D2C40", Offset = "0x3D1640", VA = "0x1803D2C40")]
	private void Awake()
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x3D2CE0", Offset = "0x3D16E0", VA = "0x1803D2CE0")]
	private void SlowUpdate()
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public RevealPlayerNames()
	{
	}

	// Token: 0x04000694 RID: 1684
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x18")]
	public List<PlayerManager> playersVisible;

	// Token: 0x04000695 RID: 1685
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask whatIsPlayer;
}
