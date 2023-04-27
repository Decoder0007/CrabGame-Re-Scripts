using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDC390", Offset = "0xDB790")]
public class GameModeData : ScriptableObject
{
	// Token: 0x060001C7 RID: 455 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xE275D0", Offset = "0xE25FD0", VA = "0x180E275D0")]
	public Type GameModeScript()
	{
		return null;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xE278D0", Offset = "0xE262D0", VA = "0x180E278D0")]
	public Map GetMap(int nPlayers)
	{
		return null;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xE277B0", Offset = "0xE261B0", VA = "0x180E277B0")]
	private List<Map> GetCompatibleMaps(List<Map.MapSize> sizes)
	{
		return null;
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xE27F60", Offset = "0xE26960", VA = "0x180E27F60")]
	public int GetModeTime(int nPlayers)
	{
		return 0;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xE275C0", Offset = "0xE25FC0", VA = "0x180E275C0")]
	public bool CanPlay(int nPlayers)
	{
		return default(bool);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xE27F80", Offset = "0xE26980", VA = "0x180E27F80")]
	public GameModeData()
	{
	}

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x18")]
	public GameModeData.GameModeType type;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x1C")]
	public MusicController.SongType musicType;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x20")]
	public int minPlayers;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x24")]
	public int maxPlayers;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101800", Offset = "0x100C00")]
	public int longModeTime;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101830", Offset = "0x100C30")]
	public int mediumModeTime;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101860", Offset = "0x100C60")]
	public int shortModeTime;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x34")]
	public int modeTime;

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x38")]
	public bool waitForRoundOverToDeclareSoloWinner;

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101890", Offset = "0x100C90")]
	public string modeName;

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "TextAreaAttribute", RVA = "0x1018C0", Offset = "0x100CC0")]
	public string modeDescription;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x50")]
	public Map[] compatibleMaps;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x58")]
	public Map[] largeMaps;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x60")]
	public Map[] mediumMaps;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x68")]
	public Map[] smallMaps;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x70")]
	public int id;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x74")]
	public int bigOnlyMapPlayers;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x78")]
	public int bigAndMediumMapPlayers;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x7C")]
	public int mediumAndSmallMapPlayers;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x80")]
	public int smallMapsOnlyPlayers;

	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public enum GameModeType
	{
		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		Waiting,
		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		RedLightGreenLight,
		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		Baseball,
		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		SteppingStones,
		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		Tag,
		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		HideAndSeek,
		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		BombTag,
		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		LightsOut,
		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		FallingPlatforms,
		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		KingOfTheHill,
		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		TileDrive,
		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		HatKing,
		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		Race,
		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		BustlingButtons
	}
}
