using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
public class EffectManager : MonoBehaviour
{
	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x316B40", Offset = "0x315540", VA = "0x180316B40")]
	private void Awake()
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public EffectManager()
	{
	}

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x18")]
	public GameObject tagFx;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x0")]
	public static EffectManager Instance;
}
