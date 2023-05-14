using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013B RID: 315
[Token(Token = "0x200013B")]
public class TileManager : MonoBehaviour
{
	// Token: 0x060007D2 RID: 2002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x2F9630", Offset = "0x2F8030", VA = "0x1802F9630")]
	private void Awake()
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x2F9820", Offset = "0x2F8220", VA = "0x1802F9820")]
	private void InitTiles()
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x2F9990", Offset = "0x2F8390", VA = "0x1802F9990")]
	private void SendTileChanges()
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x2F9F40", Offset = "0x2F8940", VA = "0x1802F9F40")]
	public void ServerUpdateTile(int tileId, int teamId)
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x2FA0D0", Offset = "0x2F8AD0", VA = "0x1802FA0D0")]
	public Color TeamToColor(int team)
	{
		return default(Color);
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x2FA150", Offset = "0x2F8B50", VA = "0x1802FA150")]
	public string TeamToText(int team)
	{
		return null;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x2F9FB0", Offset = "0x2F89B0", VA = "0x1802F9FB0")]
	public void TeamToClothes(int team, PlayerManager pm)
	{
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x2F9950", Offset = "0x2F8350", VA = "0x1802F9950")]
	public void PlayTile(bool on)
	{
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x2FA200", Offset = "0x2F8C00", VA = "0x1802FA200")]
	public TileManager()
	{
	}

	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x18")]
	public Tile[] tiles;

	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x20")]
	public RandomSfx onSfx;

	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x28")]
	public RandomSfx offSfx;

	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<ulong, int> idToTeam;

	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x38")]
	public Color red;

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x48")]
	public Color blue;

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x58")]
	public Color green;

	// Token: 0x0400071D RID: 1821
	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x68")]
	public Color pink;

	// Token: 0x0400071E RID: 1822
	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x78")]
	public Texture[] sweaters;

	// Token: 0x0400071F RID: 1823
	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x80")]
	public Texture[] pants;

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x0")]
	public static TileManager Instance;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<int, int> currentTileChange;

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, int> lastTileChange;
}
