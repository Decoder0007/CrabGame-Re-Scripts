using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDC390", Offset = "0xDB790")]
public class GunComponent : ScriptableObject
{
	// Token: 0x06000341 RID: 833 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x6000341")]
	[Address(RVA = "0xE36020", Offset = "0xE34A20", VA = "0x180E36020")]
	public Vector2 GetRecoil(float f)
	{
		return default(Vector2);
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x6000342")]
	[Address(RVA = "0xE35FB0", Offset = "0xE349B0", VA = "0x180E35FB0")]
	public int GetDamage(float distance)
	{
		return 0;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x6000343")]
	[Address(RVA = "0xE36010", Offset = "0xE34A10", VA = "0x180E36010")]
	public int GetMaxBulletDistance()
	{
		return 0;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000344")]
	[Address(RVA = "0xE36090", Offset = "0xE34A90", VA = "0x180E36090")]
	public GunComponent()
	{
	}

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101980", Offset = "0x100D80")]
	public bool automatic;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1019B0", Offset = "0x100DB0")]
	public float rpm;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xFB6A0", Offset = "0xFAAA0")]
	public float accuracy;

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x24")]
	public int bulletsPerShot;

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1019D0", Offset = "0x100DD0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1019D0", Offset = "0x100DD0")]
	public float recoilAmount;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x2C")]
	public float recoilResetSpeed;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve recoilPatternX;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve recoilPatternY;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101A30", Offset = "0x100E30")]
	public Vector2 positionAndRotationRecoilVisuals;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x48")]
	public float cameraShake;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101A60", Offset = "0x100E60")]
	public int maxDamage;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x50")]
	public int minDamage;

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x54")]
	public int startFalloffDistance;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x58")]
	public int endFalloffDistance;

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x5C")]
	public float multiplierDamage;

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101A90", Offset = "0x100E90")]
	public int pushOtherForce;

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x64")]
	public int pushSelfForce;
}
