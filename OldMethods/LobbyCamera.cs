using System;
using Il2CppDummyDll;
using MilkShake;
using UnityEngine;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
public class LobbyCamera : MonoBehaviour
{
	// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x3220E0", Offset = "0x320AE0", VA = "0x1803220E0")]
	private void Awake()
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public LobbyCamera()
	{
	}

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x18")]
	public Shaker shaker;

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x20")]
	public ShakePreset menuCamera;
}
