using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x020000F9 RID: 249
[Token(Token = "0x20000F9")]
public class PPController : MonoBehaviour
{
	// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x32F170", Offset = "0x32DB70", VA = "0x18032F170")]
	private void Awake()
	{
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x32F520", Offset = "0x32DF20", VA = "0x18032F520")]
	public void SetMotionBlur(bool b)
	{
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000691")]
	[Address(RVA = "0x32F3F0", Offset = "0x32DDF0", VA = "0x18032F3F0")]
	public void SetBloom(int i)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000692")]
	[Address(RVA = "0x32F3B0", Offset = "0x32DDB0", VA = "0x18032F3B0")]
	public void SetAO(bool b)
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x32F480", Offset = "0x32DE80", VA = "0x18032F480")]
	public void SetChromaticAberration(float f)
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000694")]
	[Address(RVA = "0x32F360", Offset = "0x32DD60", VA = "0x18032F360")]
	public void Reset()
	{
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000695")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PPController()
	{
	}

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x18")]
	private MotionBlur motionBlur;

	// Token: 0x040005A4 RID: 1444
	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x20")]
	private Bloom bloom;

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x28")]
	private AmbientOcclusion ao;

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x30")]
	private ChromaticAberration chromaticAberration;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x38")]
	private PostProcessProfile profile;

	// Token: 0x040005A8 RID: 1448
	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x0")]
	public static PPController Instance;
}
