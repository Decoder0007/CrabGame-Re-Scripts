using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000028 RID: 40
[Token(Token = "0x2000028")]
public class GameModeTimer : MonoBehaviour
{
	// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000093")]
	[Address(RVA = "0xE328E0", Offset = "0xE312E0", VA = "0x180E328E0")]
	private void Start()
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000094")]
	[Address(RVA = "0xE32C20", Offset = "0xE31620", VA = "0x180E32C20")]
	private void Update()
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE330B0", Offset = "0xE31AB0", VA = "0x180E330B0")]
	public GameModeTimer()
	{
	}

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI timer;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI freezeTimer;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x28")]
	private string emptyCountdown;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x30")]
	private string fullCountdown;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x38")]
	public bool formatTime;
}
