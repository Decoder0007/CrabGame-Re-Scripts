using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000071")]
public class VoiceChat : MonoBehaviour
{
	// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2FEAC0", Offset = "0x2FD4C0", VA = "0x1802FEAC0")]
	private void Awake()
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public VoiceChat()
	{
	}

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource source;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x20")]
	private MemoryStream stream;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x28")]
	private int optimalRate;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x2C")]
	private int playbackBuffer;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x30")]
	private int dataPosition;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x34")]
	private int dataReceived;

	// Token: 0x040001DB RID: 475
	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x0")]
	public static VoiceChat Instance;
}
