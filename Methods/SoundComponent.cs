using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x20000A0")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDC390", Offset = "0xDB790")]
public class SoundComponent : ScriptableObject
{
	// Token: 0x06000347 RID: 839 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x2ECAD0", Offset = "0x2EB4D0", VA = "0x1802ECAD0")]
	public AudioClip GetRandomSound(AudioClip[] clips)
	{
		return null;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x225F70", Offset = "0x224970", VA = "0x180225F70")]
	public SoundComponent()
	{
	}

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] use;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] equip;

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] reload;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip[] hit;
}
