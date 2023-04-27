using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
public class PauseUI : MonoBehaviour
{
	// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x330CD0", Offset = "0x32F6D0", VA = "0x180330CD0")]
	private void Awake()
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x330EE0", Offset = "0x32F8E0", VA = "0x180330EE0")]
	private void Update()
	{
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x330DC0", Offset = "0x32F7C0", VA = "0x180330DC0")]
	public void TogglePause()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x330D10", Offset = "0x32F710", VA = "0x180330D10")]
	public void LeaveGame()
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PauseUI()
	{
	}

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x18")]
	public Transform pauseOverlay;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject settings;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x0")]
	public static bool paused;
}
