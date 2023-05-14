using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FA RID: 250
[Token(Token = "0x20000FA")]
public class PlayerSave
{
	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000696 RID: 1686 RVA: 0x00002D30 File Offset: 0x00000F30
	// (set) Token: 0x06000697 RID: 1687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000036")]
	public int volume
	{
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x3CDF60", Offset = "0x3CC960", VA = "0x1803CDF60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x3CDF90", Offset = "0x3CC990", VA = "0x1803CDF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000698 RID: 1688 RVA: 0x00002D48 File Offset: 0x00000F48
	// (set) Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000037")]
	public int music
	{
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x3CDF40", Offset = "0x3CC940", VA = "0x1803CDF40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x3CDF70", Offset = "0x3CC970", VA = "0x1803CDF70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600069A RID: 1690 RVA: 0x00002D60 File Offset: 0x00000F60
	// (set) Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000038")]
	public int voip
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x3CDF50", Offset = "0x3CC950", VA = "0x1803CDF50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x3CDF80", Offset = "0x3CC980", VA = "0x1803CDF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069C")]
	[Address(RVA = "0x3CDDE0", Offset = "0x3CC7E0", VA = "0x1803CDDE0")]
	public PlayerSave()
	{
	}

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x10")]
	public bool cameraShake;

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x14")]
	public int fov;

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x18")]
	public float sensMultiplier;

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x1C")]
	public bool invertedMouseHor;

	// Token: 0x040005AD RID: 1453
	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x1D")]
	public bool invertedMouseVert;

	// Token: 0x040005AE RID: 1454
	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x1E")]
	public bool grass;

	// Token: 0x040005AF RID: 1455
	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0x1F")]
	public bool tutorial;

	// Token: 0x040005B0 RID: 1456
	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x20")]
	public bool holdCrouch;

	// Token: 0x040005B1 RID: 1457
	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x21")]
	public bool firstTimeOpeningGame;

	// Token: 0x040005B2 RID: 1458
	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x22")]
	public bool chatEnabled;

	// Token: 0x040005B3 RID: 1459
	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x23")]
	public bool streamerMode;

	// Token: 0x040005B4 RID: 1460
	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x24")]
	public int forward;

	// Token: 0x040005B5 RID: 1461
	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x28")]
	public int backwards;

	// Token: 0x040005B6 RID: 1462
	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x2C")]
	public int left;

	// Token: 0x040005B7 RID: 1463
	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x30")]
	public int right;

	// Token: 0x040005B8 RID: 1464
	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x34")]
	public int jump;

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x38")]
	public int crouch;

	// Token: 0x040005BA RID: 1466
	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x3C")]
	public int sprint;

	// Token: 0x040005BB RID: 1467
	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x40")]
	public int interact;

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x44")]
	public int inventory;

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x48")]
	public int drop;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x4C")]
	public int map;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x50")]
	public int leftClick;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x54")]
	public int rightClick;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x58")]
	public int inventory1;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x5C")]
	public int inventory2;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x60")]
	public int inventory3;

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x64")]
	public int inventory4;

	// Token: 0x040005C5 RID: 1477
	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x68")]
	public int inventory5;

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x6C")]
	public int inventory6;

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x70")]
	public int inventory7;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x74")]
	public int inventory8;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x78")]
	public int voipKey;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x7C")]
	public int shadowQuality;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x80")]
	public int shadowResolution;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x84")]
	public int shadowDistance;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x88")]
	public int shadowCascade;

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x8C")]
	public int textureQuality;

	// Token: 0x040005CF RID: 1487
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x90")]
	public int antiAliasing;

	// Token: 0x040005D0 RID: 1488
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x94")]
	public bool softParticles;

	// Token: 0x040005D1 RID: 1489
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x98")]
	public int bloom;

	// Token: 0x040005D2 RID: 1490
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x9C")]
	public bool motionBlur;

	// Token: 0x040005D3 RID: 1491
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x9D")]
	public bool ambientOcclusion;

	// Token: 0x040005D4 RID: 1492
	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 resolution;

	// Token: 0x040005D5 RID: 1493
	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0xA8")]
	public int refreshRate;

	// Token: 0x040005D6 RID: 1494
	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0xAC")]
	public bool fullscreen;

	// Token: 0x040005D7 RID: 1495
	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0xB0")]
	public int fullscreenMode;

	// Token: 0x040005D8 RID: 1496
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0xB4")]
	public int vSync;

	// Token: 0x040005D9 RID: 1497
	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0xB8")]
	public int fpsLimit;

	// Token: 0x040005DA RID: 1498
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0xBC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <volume>k__BackingField;

	// Token: 0x040005DB RID: 1499
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <music>k__BackingField;

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <voip>k__BackingField;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0xC8")]
	public int micSetting;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0xCC")]
	public int deaf;
}
