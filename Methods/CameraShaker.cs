using System;
using Il2CppDummyDll;
using MilkShake;
using UnityEngine;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
public class CameraShaker : MonoBehaviour
{
	// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x303960", Offset = "0x302360", VA = "0x180303960")]
	private void Awake()
	{
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Update()
	{
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x303A90", Offset = "0x302490", VA = "0x180303A90")]
	public void GunShake(float shakeRatio)
	{
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x303B30", Offset = "0x302530", VA = "0x180303B30")]
	public void PushShake()
	{
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x3039D0", Offset = "0x3023D0", VA = "0x1803039D0")]
	public void DamageShake(float shakeRatio)
	{
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x303C30", Offset = "0x302630", VA = "0x180303C30")]
	public void ShakeWithPreset(ShakePreset preset)
	{
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x303BC0", Offset = "0x3025C0", VA = "0x180303BC0")]
	public void ShakeWithPresetAndRatio(ShakePreset preset, float shakeRatio)
	{
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public CameraShaker()
	{
	}

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x18")]
	public ShakePreset damagePreset;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x20")]
	public ShakePreset gunPreset;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x28")]
	public ShakePreset pushPreset;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x30")]
	private Shaker shaker;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x0")]
	public static CameraShaker Instance;
}
