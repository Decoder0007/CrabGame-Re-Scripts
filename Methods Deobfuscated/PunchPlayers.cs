using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
public class PunchPlayers : MonoBehaviour
{
	// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x3D0990", Offset = "0x3CF390", VA = "0x1803D0990")]
	public void Punch()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x3D0A40", Offset = "0x3CF440", VA = "0x1803D0A40")]
	private void RaycastPunch()
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x319950", Offset = "0x318350", VA = "0x180319950")]
	private void Cooldown()
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x3D0EC0", Offset = "0x3CF8C0", VA = "0x1803D0EC0")]
	public PunchPlayers()
	{
	}

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x18")]
	public RandomSfx sfx;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x20")]
	private bool ready;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask whatIsPlayers;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x28")]
	private float maxDistance;
}
