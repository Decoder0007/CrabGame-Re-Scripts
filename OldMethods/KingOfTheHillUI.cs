using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
public class KingOfTheHillUI : MonoBehaviour
{
	// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x31FFD0", Offset = "0x31E9D0", VA = "0x18031FFD0")]
	private void Start()
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x31FDD0", Offset = "0x31E7D0", VA = "0x18031FDD0")]
	private void SlowUpdate()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x320160", Offset = "0x31EB60", VA = "0x180320160")]
	private void UpdateScore(int newScore)
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x320210", Offset = "0x31EC10", VA = "0x180320210")]
	private void Update()
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x31F920", Offset = "0x31E320", VA = "0x18031F920")]
	private void AmBeingEliminated()
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x31F7E0", Offset = "0x31E1E0", VA = "0x18031F7E0")]
	public static string AddOrdinal(int num)
	{
		return null;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public KingOfTheHillUI()
	{
	}

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI score;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI needed;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x28")]
	public RawImage overlay;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x30")]
	public Color safe;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x40")]
	public Color danger;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource sfx;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x58")]
	private GameModeKing gameMode;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x60")]
	private PlayerManager pm;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x68")]
	private int lastRecordedScore;
}
