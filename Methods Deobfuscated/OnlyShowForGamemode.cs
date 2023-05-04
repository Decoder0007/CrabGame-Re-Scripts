using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000055 RID: 85
[Token(Token = "0x2000055")]
public class OnlyShowForGamemode : MonoBehaviour
{
	// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x32DC40", Offset = "0x32C640", VA = "0x18032DC40")]
	private void Awake()
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public OnlyShowForGamemode()
	{
	}

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x18")]
	public GameModeData.GameModeType gameMode;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] objects;
}
