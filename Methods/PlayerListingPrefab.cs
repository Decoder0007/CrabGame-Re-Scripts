using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200005B")]
public class PlayerListingPrefab : MonoBehaviour
{
	// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x338C60", Offset = "0x337660", VA = "0x180338C60")]
	public void SetSpectator(ulong id)
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x338A20", Offset = "0x337420", VA = "0x180338A20")]
	public void SetPlayer(PlayerManager pm)
	{
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x338790", Offset = "0x337190", VA = "0x180338790")]
	public void ManagePlayer()
	{
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerListingPrefab()
	{
	}

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x18")]
	public RawImage background;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x20")]
	public RawImage icon;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI username;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI score;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI ping;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x40")]
	private PlayerManager pm;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x48")]
	private ulong id;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x50")]
	public Transform manageButton;
}
