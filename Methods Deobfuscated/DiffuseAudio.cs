using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public class DiffuseAudio : MonoBehaviour
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060001AA RID: 426 RVA: 0x00002208 File Offset: 0x00000408
	// (set) Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000B")]
	public float defaultVolume
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x225E90", Offset = "0x224890", VA = "0x180225E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x225F10", Offset = "0x224910", VA = "0x180225F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x315650", Offset = "0x314050", VA = "0x180315650")]
	private void Awake()
	{
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x315A30", Offset = "0x314430", VA = "0x180315A30")]
	private void Update()
	{
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x315760", Offset = "0x314160", VA = "0x180315760")]
	private void SlowUpdate()
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x315B20", Offset = "0x314520", VA = "0x180315B20")]
	public DiffuseAudio()
	{
	}

	// Token: 0x040001A9 RID: 425
	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x18")]
	private float multiplier;

	// Token: 0x040001AA RID: 426
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <defaultVolume>k__BackingField;

	// Token: 0x040001AB RID: 427
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x20")]
	private float defaultHz;

	// Token: 0x040001AC RID: 428
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x24")]
	public bool muteStartVolume;

	// Token: 0x040001AD RID: 429
	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x28")]
	public float diffusedMinVolume;

	// Token: 0x040001AE RID: 430
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource source;

	// Token: 0x040001AF RID: 431
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x38")]
	public AudioLowPassFilter filter;

	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x40")]
	private float volumeMultiplier;

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x44")]
	private float filterMultiplier;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x48")]
	public LayerMask whatIsHitable;
}
