using System;
using Dissonance;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
public class MicIcon : MonoBehaviour
{
	// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x327D30", Offset = "0x326730", VA = "0x180327D30")]
	private void Awake()
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x327DC0", Offset = "0x3267C0", VA = "0x180327DC0")]
	private void SlowUpdate()
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x327D80", Offset = "0x326780", VA = "0x180327D80")]
	private void SetIcon(bool b)
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MicIcon()
	{
	}

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x18")]
	private IDissonancePlayer player;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x20")]
	private VoicePlayerState state;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x28")]
	public RawImage icon;
}
