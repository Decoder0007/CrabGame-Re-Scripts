using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
public class HatUI : MonoBehaviour
{
	// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE388A0", Offset = "0xE372A0", VA = "0x180E388A0")]
	private void Start()
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE385C0", Offset = "0xE36FC0", VA = "0x180E385C0")]
	private void SlowUpdate()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x320160", Offset = "0x31EB60", VA = "0x180320160")]
	private void UpdateScore(int newScore)
	{
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x320210", Offset = "0x31EC10", VA = "0x180320210")]
	private void Update()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE38110", Offset = "0xE36B10", VA = "0x180E38110")]
	private void AmBeingEliminated()
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xE37FD0", Offset = "0xE369D0", VA = "0x180E37FD0")]
	public static string AddOrdinal(int num)
	{
		return null;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public HatUI()
	{
	}

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI score;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI needed;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x28")]
	public RawImage overlay;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x30")]
	public Color safe;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x40")]
	public Color danger;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource sfx;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x58")]
	private GameModeHat gameMode;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x60")]
	private PlayerManager pm;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x68")]
	private int lastRecordedScore;
}
