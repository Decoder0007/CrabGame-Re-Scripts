using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
public class KingScoreboard : MonoBehaviour
{
	// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3209B0", Offset = "0x31F3B0", VA = "0x1803209B0")]
	private void Start()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x320350", Offset = "0x31ED50", VA = "0x180320350")]
	private void SlowUpdate()
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x320950", Offset = "0x31F350", VA = "0x180320950")]
	private void SortList()
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public KingScoreboard()
	{
	}

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI scoreText;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x20")]
	private List<KingScoreboard.PlayerScore> idsSorted;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x28")]
	private GameModeKing gameMode;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x30")]
	private string selfColor;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x38")]
	private string dangerCol;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x40")]
	public Color cyan;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x50")]
	public Color danger;

	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class PlayerScore : IComparable<KingScoreboard.PlayerScore>
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2EA870", Offset = "0x2E9270", VA = "0x1802EA870")]
		public PlayerScore(ulong pid, int score, string name)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2EA840", Offset = "0x2E9240", VA = "0x1802EA840", Slot = "4")]
		public int CompareTo(KingScoreboard.PlayerScore that)
		{
			return 0;
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x10")]
		public ulong pid;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		public string username;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x20")]
		public int score;
	}
}
