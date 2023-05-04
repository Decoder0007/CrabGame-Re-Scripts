using System;
using Il2CppDummyDll;
using SteamworksNative;

// Token: 0x020000B9 RID: 185
[Token(Token = "0x20000B9")]
public class Client
{
	// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x30DE90", Offset = "0x30C890", VA = "0x18030DE90")]
	public void StartPunchCooldown()
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x30DDF0", Offset = "0x30C7F0", VA = "0x18030DDF0")]
	private void ResetClient()
	{
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x30DEF0", Offset = "0x30C8F0", VA = "0x18030DEF0")]
	public Client(CSteamID steamId)
	{
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x30DBB0", Offset = "0x30C5B0", VA = "0x18030DBB0")]
	public void HandleItem(ItemPrefab item)
	{
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x30D3C0", Offset = "0x30BDC0", VA = "0x18030D3C0")]
	public void AddItem(ItemPrefab item)
	{
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x30D6C0", Offset = "0x30C0C0", VA = "0x18030D6C0")]
	public void AddItem(ItemData item)
	{
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void AddAmmo(ItemPrefab item)
	{
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x30DCC0", Offset = "0x30C6C0", VA = "0x18030DCC0")]
	public void RemoveItem(int objectId)
	{
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x30DBE0", Offset = "0x30C5E0", VA = "0x18030DBE0")]
	public bool HasItem(int itemId, int objectId)
	{
		return default(bool);
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x30D980", Offset = "0x30C380", VA = "0x18030D980")]
	public void DropInventory()
	{
	}

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x10")]
	public bool activePlayer;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x11")]
	public bool readyToLoad;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x12")]
	public bool isLoading;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x14")]
	public int ping;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x18")]
	public CSteamID steamId;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x20")]
	public int colorId;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x28")]
	public ItemData[] inventory;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x30")]
	public int money;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x34")]
	public bool vcEnabled;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x35")]
	public bool kicked;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x36")]
	public bool punchCooldown;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x38")]
	private float punchCooldownTime;
}
