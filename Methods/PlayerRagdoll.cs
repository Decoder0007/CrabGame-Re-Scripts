using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
public class PlayerRagdoll : MonoBehaviour
{
	// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x3CDCE0", Offset = "0x3CC6E0", VA = "0x1803CDCE0")]
	public void MakeRagdoll(PlayerManager pm, Vector3 dir)
	{
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerRagdoll()
	{
	}

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x18")]
	public MakeRagdoll makeRagdoll;

	// Token: 0x04000582 RID: 1410
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x20")]
	public Renderer shirt;
}
