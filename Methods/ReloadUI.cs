using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class ReloadUI : MonoBehaviour
{
	// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x3D2440", Offset = "0x3D0E40", VA = "0x1803D2440")]
	private void Awake()
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x3D2530", Offset = "0x3D0F30", VA = "0x1803D2530")]
	private void StopReload()
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x3D24B0", Offset = "0x3D0EB0", VA = "0x1803D24B0")]
	public void StartReload(float time)
	{
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x3D2560", Offset = "0x3D0F60", VA = "0x1803D2560")]
	private void Update()
	{
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ReloadUI()
	{
	}

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x18")]
	public RawImage currentBar;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x0")]
	public static ReloadUI Instance;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x20")]
	private float currentTime;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x24")]
	private float desiredTime;
}
