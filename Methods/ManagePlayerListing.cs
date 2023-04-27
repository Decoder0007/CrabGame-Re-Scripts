using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public class ManagePlayerListing : MonoBehaviour
{
	// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x326060", Offset = "0x324A60", VA = "0x180326060")]
	private void Awake()
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x326560", Offset = "0x324F60", VA = "0x180326560")]
	public void SetPlayer(ulong id, string name, Vector3 pos)
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x326230", Offset = "0x324C30", VA = "0x180326230")]
	public void KickPlayer()
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x326170", Offset = "0x324B70", VA = "0x180326170")]
	public void BanPlayer()
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x326310", Offset = "0x324D10", VA = "0x180326310")]
	public void MutePlayer()
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x326800", Offset = "0x325200", VA = "0x180326800")]
	private void UpdateMuted(ulong pid)
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x326980", Offset = "0x325380", VA = "0x180326980")]
	private void Update()
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x3266F0", Offset = "0x3250F0", VA = "0x1803266F0")]
	public void Show(bool b)
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ManagePlayerListing()
	{
	}

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x18")]
	public Transform window;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform windowRect;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject kickBtn;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject banBtn;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI playerName;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI muteText;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x0")]
	public static ManagePlayerListing Instance;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x48")]
	private ulong id;
}
