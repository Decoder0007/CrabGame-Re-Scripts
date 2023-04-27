using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
public class LobbyUtility : MonoBehaviour
{
	// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x324EA0", Offset = "0x3238A0", VA = "0x180324EA0")]
	private void Awake()
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3252E0", Offset = "0x323CE0", VA = "0x1803252E0")]
	public static string RemoveWhitespace(string input)
	{
		return null;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x325170", Offset = "0x323B70", VA = "0x180325170")]
	public string ProfanityFilterString(string message)
	{
		return null;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public LobbyUtility()
	{
	}

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x18")]
	public TextAsset profanityList;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x20")]
	private List<string> profanity;

	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public <>c()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2FDA50", Offset = "0x2FC450", VA = "0x1802FDA50")]
		internal bool <RemoveWhitespace>b__3_0(char c)
		{
			return default(bool);
		}

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LobbyUtility.<>c <>9;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x8")]
		public static Func<char, bool> <>9__3_0;
	}
}
