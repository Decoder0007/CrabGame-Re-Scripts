using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
public class HatScoreboard : MonoBehaviour
{
	// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE37DD0", Offset = "0xE367D0", VA = "0x180E37DD0")]
	private void Start()
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE37770", Offset = "0xE36170", VA = "0x180E37770")]
	private void SlowUpdate()
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE37D70", Offset = "0xE36770", VA = "0x180E37D70")]
	private void SortList()
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public HatScoreboard()
	{
	}

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI scoreText;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x20")]
	private List<HatScoreboard.PlayerScore> idsSorted;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x28")]
	private GameModeHat gameMode;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x30")]
	private string selfColor;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x38")]
	private string dangerCol;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x40")]
	public Color cyan;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x50")]
	public Color danger;

	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public class PlayerScore : IComparable<HatScoreboard.PlayerScore>
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2EA870", Offset = "0x2E9270", VA = "0x1802EA870")]
		public PlayerScore(ulong pid, int score, string name)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2EA840", Offset = "0x2E9240", VA = "0x1802EA840", Slot = "4")]
		public int CompareTo(HatScoreboard.PlayerScore that)
		{
			return 0;
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		public ulong pid;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x18")]
		public string username;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x20")]
		public int score;
	}
}
