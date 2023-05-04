using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
public class ScoreVisuals : MonoBehaviour
{
	// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x3D51A0", Offset = "0x3D3BA0", VA = "0x1803D51A0")]
	private void Start()
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x3D53D0", Offset = "0x3D3DD0", VA = "0x1803D53D0")]
	private void UpdateSfx()
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3D5360", Offset = "0x3D3D60", VA = "0x1803D5360")]
	private void StopFx()
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ScoreVisuals()
	{
	}

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem ps;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem.EmissionModule emission;

	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource sfx;

	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x30")]
	private GameMode gameMode;

	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x38")]
	private PlayerManager pm;
}
