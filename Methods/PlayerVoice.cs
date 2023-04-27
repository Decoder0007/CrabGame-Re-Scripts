using System;
using Dissonance;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
public class PlayerVoice : MonoBehaviour
{
	// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x3CFA10", Offset = "0x3CE410", VA = "0x1803CFA10")]
	private void Awake()
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x3CFC40", Offset = "0x3CE640", VA = "0x1803CFC40")]
	private void SlowUpdate()
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x3CFC30", Offset = "0x3CE630", VA = "0x1803CFC30")]
	private void SetIcon(bool b)
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x3CFA60", Offset = "0x3CE460", VA = "0x1803CFA60")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerVoice()
	{
	}

	// Token: 0x040001CA RID: 458
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x18")]
	public Transform jaw;

	// Token: 0x040001CB RID: 459
	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x20")]
	private IDissonancePlayer player;

	// Token: 0x040001CC RID: 460
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x28")]
	private VoicePlayerState state;

	// Token: 0x040001CD RID: 461
	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x30")]
	public PlayerManager pm;

	// Token: 0x040001CE RID: 462
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x38")]
	private bool transmitting;
}
