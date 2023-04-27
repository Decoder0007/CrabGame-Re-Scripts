using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
public class GameAudio : MonoBehaviour
{
	// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x319C40", Offset = "0x318640", VA = "0x180319C40")]
	public void PlayRoundStart()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x319BD0", Offset = "0x3185D0", VA = "0x180319BD0")]
	public void PlayRiser()
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x319C00", Offset = "0x318600", VA = "0x180319C00")]
	public void PlayRoundEnd()
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x319C90", Offset = "0x318690", VA = "0x180319C90")]
	public void PlayerClockTick(int tick)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x319D20", Offset = "0x318720", VA = "0x180319D20")]
	public GameAudio()
	{
	}

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip roundStart;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip roundEnd;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource roundStartSfx;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x30")]
	public RandomSfx clockSfx;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x38")]
	public RandomSfx riserSfx;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x40")]
	private bool firstTick;
}
