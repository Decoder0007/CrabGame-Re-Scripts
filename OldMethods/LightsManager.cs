using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003F")]
public class LightsManager : MonoBehaviour
{
	// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x321590", Offset = "0x31FF90", VA = "0x180321590")]
	private void Awake()
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public LightsManager()
	{
	}

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] lights;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x20")]
	public ReflectionProbe reflection;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource sfx;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x0")]
	public static LightsManager Instance;
}
