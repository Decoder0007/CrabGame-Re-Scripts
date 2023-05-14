using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000057 RID: 87
[Token(Token = "0x2000057")]
public class PersistentPlayerData : MonoBehaviour
{
	// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x331090", Offset = "0x32FA90", VA = "0x180331090")]
	private void Awake()
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PersistentPlayerData()
	{
	}

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x0")]
	public static bool frozen;

	// Token: 0x04000140 RID: 320
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x8")]
	public static PersistentPlayerData Instance;
}
