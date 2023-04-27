using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
public class ExplodePlayer : MonoBehaviour
{
	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x316EF0", Offset = "0x3158F0", VA = "0x180316EF0")]
	private void Start()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x316FF0", Offset = "0x3159F0", VA = "0x180316FF0")]
	public ExplodePlayer()
	{
	}

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody[] bodyParts;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x20")]
	private float force;
}
