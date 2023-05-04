using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
public class GoldVignette : MonoBehaviour
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE35F60", Offset = "0xE34960", VA = "0x180E35F60")]
	private void Awake()
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public GoldVignette()
	{
	}

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject vignette;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x0")]
	public static GoldVignette Instance;
}
