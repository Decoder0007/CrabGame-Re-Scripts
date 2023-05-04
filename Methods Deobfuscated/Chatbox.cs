using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
public class Chatbox : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600002F RID: 47 RVA: 0x000020A0 File Offset: 0x000002A0
	// (set) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	public bool typing
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x304E90", Offset = "0x303890", VA = "0x180304E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x304EA0", Offset = "0x3038A0", VA = "0x180304EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x304100", Offset = "0x302B00", VA = "0x180304100")]
	private void Awake()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x304720", Offset = "0x303120", VA = "0x180304720")]
	public static string RemoveWhitespace(string input)
	{
		return null;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x303CE0", Offset = "0x3026E0", VA = "0x180303CE0")]
	public void AppendMessage(ulong fromUser, string message, string fromUsername)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x304890", Offset = "0x303290", VA = "0x180304890")]
	public void SendMessage(string message)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x304530", Offset = "0x302F30", VA = "0x180304530")]
	private void ClearMessage()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x304C70", Offset = "0x303670", VA = "0x180304C70")]
	private string TrimMessage(string message)
	{
		return null;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x304D00", Offset = "0x303700", VA = "0x180304D00")]
	private void UserInput()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x304D00", Offset = "0x303700", VA = "0x180304D00")]
	private void Update()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x304590", Offset = "0x302F90", VA = "0x180304590")]
	private void HideChat()
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x304B40", Offset = "0x303540", VA = "0x180304B40")]
	private void ShowChat()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3046C0", Offset = "0x3030C0", VA = "0x1803046C0")]
	public static string RemoveRichText(string s)
	{
		return null;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x304E40", Offset = "0x303840", VA = "0x180304E40")]
	public Chatbox()
	{
	}

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	public RawImage overlay;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField inputField;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI messages;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x30")]
	public Color localPlayer;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x40")]
	public Color onlinePlayer;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x50")]
	public Color deadPlayer;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x60")]
	public Color server;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x70")]
	private Color console;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x80")]
	private int maxMsgLength;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x84")]
	private int maxChars;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x88")]
	private int purgeAmount;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <typing>k__BackingField;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x0")]
	public static Chatbox Instance;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x90")]
	public TextAsset profanityList;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x98")]
	private List<string> profanity;

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public enum MessageType
	{
		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		Server = 1
	}

	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public <>c()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2FD9F0", Offset = "0x2FC3F0", VA = "0x1802FD9F0")]
		internal bool <RemoveWhitespace>b__19_0(char c)
		{
			return default(bool);
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Chatbox.<>c <>9;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x8")]
		public static Func<char, bool> <>9__19_0;
	}
}
