using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public class RaceUI : MonoBehaviour
{
	// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x3D11F0", Offset = "0x3CFBF0", VA = "0x1803D11F0")]
	private void Start()
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x3D0EE0", Offset = "0x3CF8E0", VA = "0x1803D0EE0")]
	private void SlowUpdate()
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public RaceUI()
	{
	}

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI score;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x20")]
	public RawImage overlay;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x28")]
	public Color safe;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x38")]
	public Color danger;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x48")]
	private GameModeRace gameMode;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x50")]
	private PlayerManager pm;
}
