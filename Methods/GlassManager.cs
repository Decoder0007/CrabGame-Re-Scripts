using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public class GlassManager : MonoBehaviour
{
	// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xE35F10", Offset = "0xE34910", VA = "0x180E35F10")]
	private void Awake()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public GlassManager()
	{
	}

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x18")]
	public GlassBreak[] pieces;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x0")]
	public static GlassManager Instance;
}
