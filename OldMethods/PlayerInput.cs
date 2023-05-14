using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E9 RID: 233
[Token(Token = "0x20000E9")]
public class PlayerInput : MonoBehaviour
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000029A0 File Offset: 0x00000BA0
	// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000028")]
	public float sensitivity
	{
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x225E90", Offset = "0x224890", VA = "0x180225E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x225F10", Offset = "0x224910", VA = "0x180225F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060005D8 RID: 1496 RVA: 0x000029B8 File Offset: 0x00000BB8
	// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000029")]
	public float x
	{
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x225F80", Offset = "0x224980", VA = "0x180225F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x225FF0", Offset = "0x2249F0", VA = "0x180225FF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060005DA RID: 1498 RVA: 0x000029D0 File Offset: 0x00000BD0
	// (set) Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002A")]
	public float y
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x225F90", Offset = "0x224990", VA = "0x180225F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x226000", Offset = "0x224A00", VA = "0x180226000")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060005DC RID: 1500 RVA: 0x000029E8 File Offset: 0x00000BE8
	// (set) Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002B")]
	public bool jumping
	{
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x3352E0", Offset = "0x333CE0", VA = "0x1803352E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x335380", Offset = "0x333D80", VA = "0x180335380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060005DE RID: 1502 RVA: 0x00002A00 File Offset: 0x00000C00
	// (set) Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002C")]
	public bool crouching
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x3352D0", Offset = "0x333CD0", VA = "0x1803352D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x335370", Offset = "0x333D70", VA = "0x180335370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00002A18 File Offset: 0x00000C18
	// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002D")]
	public bool sprinting
	{
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x3352F0", Offset = "0x333CF0", VA = "0x1803352F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x335390", Offset = "0x333D90", VA = "0x180335390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002E")]
	public static PlayerInput Instance
	{
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x335270", Offset = "0x333C70", VA = "0x180335270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x335300", Offset = "0x333D00", VA = "0x180335300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x333D00", Offset = "0x332700", VA = "0x180333D00")]
	private void Awake()
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x335110", Offset = "0x333B10", VA = "0x180335110")]
	private void Update()
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x3341B0", Offset = "0x332BB0", VA = "0x1803341B0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x3350C0", Offset = "0x333AC0", VA = "0x1803350C0")]
	private void StopInput()
	{
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x3340D0", Offset = "0x332AD0", VA = "0x1803340D0")]
	public bool CheckInputDown(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x334130", Offset = "0x332B30", VA = "0x180334130")]
	public bool CheckInputUp(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x334150", Offset = "0x332B50", VA = "0x180334150")]
	public bool CheckInput(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x334620", Offset = "0x333020", VA = "0x180334620")]
	private void NotFrozenInput()
	{
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x333A00", Offset = "0x332400", VA = "0x180333A00")]
	private void AlwaysInput()
	{
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x334320", Offset = "0x332D20", VA = "0x180334320")]
	private void Look()
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x334250", Offset = "0x332C50", VA = "0x180334250")]
	public Vector2 GetAxisInput()
	{
		return default(Vector2);
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x334270", Offset = "0x332C70", VA = "0x180334270")]
	public float GetMouseX()
	{
		return 0f;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x225F50", Offset = "0x224950", VA = "0x180225F50")]
	public void SetMouseOffset(float o)
	{
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x225EF0", Offset = "0x2248F0", VA = "0x180225EF0")]
	public float GetMouseOffset()
	{
		return 0f;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x335250", Offset = "0x333C50", VA = "0x180335250")]
	public PlayerInput()
	{
	}

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x18")]
	private float xRotation;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <sensitivity>k__BackingField;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x0")]
	public static float sensMultiplier;

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x20")]
	private float desiredX;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <x>k__BackingField;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <y>k__BackingField;

	// Token: 0x040004FF RID: 1279
	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <jumping>k__BackingField;

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x2D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <crouching>k__BackingField;

	// Token: 0x04000501 RID: 1281
	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x2E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <sprinting>k__BackingField;

	// Token: 0x04000502 RID: 1282
	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x30")]
	private float mouseScroll;

	// Token: 0x04000503 RID: 1283
	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x34")]
	public bool active;

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x38")]
	private Transform playerCam;

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x40")]
	private Transform orientation;

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x48")]
	private PlayerMovement playerMovement;

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x50")]
	private DetectItems detectItems;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x58")]
	private PlayerInventory playerInventory;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x60")]
	private PunchPlayers punchPlayers;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private static PlayerInput <Instance>k__BackingField;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x68")]
	private float actualWallRotation;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x6C")]
	private float wallRotationVel;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 cameraRot;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x7C")]
	private float wallRunRotation;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x80")]
	public float mouseOffsetY;

	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public enum CustomKeyCode
	{
		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		MWheelDown = -1,
		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		MWheelUp = -2
	}
}
