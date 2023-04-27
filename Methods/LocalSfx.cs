using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
public class LocalSfx : MonoBehaviour
{
	// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x325450", Offset = "0x323E50", VA = "0x180325450")]
	private void Awake()
	{
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x325570", Offset = "0x323F70", VA = "0x180325570")]
	public void PlayClip(AudioClip clip, float volume = 1f)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public LocalSfx()
	{
	}

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip hitMarker;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip button;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource source;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x0")]
	public static LocalSfx Instance;
}
