using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200014D RID: 333
[Token(Token = "0x200014D")]
public class PlayerInput : MonoBehaviour
{
	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x000020B8 File Offset: 0x000002B8
	// (set) Token: 0x06004BF8 RID: 19448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003E")]
	public static float sensitivity
	{
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x105F140", Offset = "0x105DF40", VA = "0x18105F140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x105F230", Offset = "0x105E030", VA = "0x18105F230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		set
		{
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x000020B8 File Offset: 0x000002B8
	// (set) Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003F")]
	public float x
	{
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x24FF00", Offset = "0x24ED00", VA = "0x18024FF00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x24FF80", Offset = "0x24ED80", VA = "0x18024FF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		private set
		{
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06004BFB RID: 19451 RVA: 0x000020B8 File Offset: 0x000002B8
	// (set) Token: 0x06004BFC RID: 19452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000040")]
	public float y
	{
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x24FFE0", Offset = "0x24EDE0", VA = "0x18024FFE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x250050", Offset = "0x24EE50", VA = "0x180250050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		private set
		{
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06004BFD RID: 19453 RVA: 0x00002088 File Offset: 0x00000288
	// (set) Token: 0x06004BFE RID: 19454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000041")]
	public bool jumping
	{
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x24FC60", Offset = "0x24EA60", VA = "0x18024FC60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x24FC80", Offset = "0x24EA80", VA = "0x18024FC80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		private set
		{
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06004BFF RID: 19455 RVA: 0x00002088 File Offset: 0x00000288
	// (set) Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000042")]
	public bool crouching
	{
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x41D2D0", Offset = "0x41C0D0", VA = "0x18041D2D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x105F220", Offset = "0x105E020", VA = "0x18105F220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		private set
		{
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06004C01 RID: 19457 RVA: 0x00002088 File Offset: 0x00000288
	// (set) Token: 0x06004C02 RID: 19458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000043")]
	public bool sprinting
	{
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x105F1A0", Offset = "0x105DFA0", VA = "0x18105F1A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x105F2A0", Offset = "0x105E0A0", VA = "0x18105F2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		private set
		{
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06004C03 RID: 19459 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000044")]
	public static PlayerInput Instance
	{
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x105F0E0", Offset = "0x105DEE0", VA = "0x18105F0E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x105F1B0", Offset = "0x105DFB0", VA = "0x18105F1B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		set
		{
		}
	}

	// Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C05")]
	[Address(RVA = "0x105DD40", Offset = "0x105CB40", VA = "0x18105DD40")]
	private void Awake()
	{
	}

	// Token: 0x06004C06 RID: 19462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C06")]
	[Address(RVA = "0x105EF50", Offset = "0x105DD50", VA = "0x18105EF50")]
	private void Update()
	{
	}

	// Token: 0x06004C07 RID: 19463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C07")]
	[Address(RVA = "0x105E080", Offset = "0x105CE80", VA = "0x18105E080")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06004C08 RID: 19464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C08")]
	[Address(RVA = "0x105EF00", Offset = "0x105DD00", VA = "0x18105EF00")]
	private void StopInput()
	{
	}

	// Token: 0x06004C09 RID: 19465 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6004C09")]
	[Address(RVA = "0x105DFB0", Offset = "0x105CDB0", VA = "0x18105DFB0")]
	public static bool CheckInputDown(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x06004C0A RID: 19466 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6004C0A")]
	[Address(RVA = "0x105E010", Offset = "0x105CE10", VA = "0x18105E010")]
	public static bool CheckInputUp(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x06004C0B RID: 19467 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6004C0B")]
	[Address(RVA = "0x105E020", Offset = "0x105CE20", VA = "0x18105E020")]
	public static bool CheckInput(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x06004C0C RID: 19468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C0C")]
	[Address(RVA = "0x105E580", Offset = "0x105D380", VA = "0x18105E580")]
	private void NotFrozenInput()
	{
	}

	// Token: 0x06004C0D RID: 19469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C0D")]
	[Address(RVA = "0x105D9A0", Offset = "0x105C7A0", VA = "0x18105D9A0")]
	private void AlwaysInput()
	{
	}

	// Token: 0x06004C0E RID: 19470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C0E")]
	[Address(RVA = "0x105E210", Offset = "0x105D010", VA = "0x18105E210")]
	private void Look()
	{
	}

	// Token: 0x06004C0F RID: 19471 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6004C0F")]
	[Address(RVA = "0x34E300", Offset = "0x34D100", VA = "0x18034E300")]
	public Vector2 GetAxisInput()
	{
		return default(Vector2);
	}

	// Token: 0x06004C10 RID: 19472 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6004C10")]
	[Address(RVA = "0x105E130", Offset = "0x105CF30", VA = "0x18105E130")]
	public float GetMouseX()
	{
		return 0f;
	}

	// Token: 0x06004C11 RID: 19473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C11")]
	[Address(RVA = "0x24FFB0", Offset = "0x24EDB0", VA = "0x18024FFB0")]
	public void SetMouseOffset(float o)
	{
	}

	// Token: 0x06004C12 RID: 19474 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6004C12")]
	[Address(RVA = "0x24FF50", Offset = "0x24ED50", VA = "0x18024FF50")]
	public float GetMouseOffset()
	{
		return 0f;
	}

	// Token: 0x06004C13 RID: 19475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004C13")]
	[Address(RVA = "0x105F0D0", Offset = "0x105DED0", VA = "0x18105F0D0")]
	public PlayerInput()
	{
	}

	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x18")]
	private float xRotation;

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private static float <sensitivity>k__BackingField;

	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x4")]
	public static float sensMultiplier;

	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x1C")]
	private float desiredX;

	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private float <x>k__BackingField;

	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private float <y>k__BackingField;

	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private bool <jumping>k__BackingField;

	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x29")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private bool <crouching>k__BackingField;

	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x2A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private bool <sprinting>k__BackingField;

	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x2C")]
	private float mouseScroll;

	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x30")]
	public bool active;

	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x38")]
	private Transform playerCam;

	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x40")]
	private Transform orientation;

	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x48")]
	private Ⴂ\u109A႙ႦႣ႙\u109D\u109F\u109EႢ\u109B playerMovement;

	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x50")]
	private DetectItems detectItems;

	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x58")]
	private Ⴈ႙႙႙ႤႤႨ\u109D\u109AႤႥ playerInventory;

	// Token: 0x04000835 RID: 2101
	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x60")]
	private ႠႠ\u109F႙ႨႨႨႧႡ\u109A\u109F punchPlayers;

	// Token: 0x04000836 RID: 2102
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private static PlayerInput <Instance>k__BackingField;

	// Token: 0x04000837 RID: 2103
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x68")]
	private float actualWallRotation;

	// Token: 0x04000838 RID: 2104
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x6C")]
	private float wallRotationVel;

	// Token: 0x04000839 RID: 2105
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 cameraRot;

	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x7C")]
	private float wallRunRotation;

	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x80")]
	public float mouseOffsetY;

	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public enum CustomKeyCode
	{
		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		MWheelDown = -1,
		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		MWheelUp = -2
	}
}
