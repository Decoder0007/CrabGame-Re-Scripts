using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000074 RID: 116
[Token(Token = "0x2000074")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDC390", Offset = "0xDB790")]
public class Map : ScriptableObject
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060001CD RID: 461 RVA: 0x00002250 File Offset: 0x00000450
	// (set) Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000C")]
	public int id
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x327230", Offset = "0x325C30", VA = "0x180327230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x327240", Offset = "0x325C40", VA = "0x180327240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x327250", Offset = "0x325C50", VA = "0x180327250")]
	public Map()
	{
	}

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x18")]
	public Map.MapSize mapSize;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x20")]
	public string mapName;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D mapThumbnail;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <id>k__BackingField;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x34")]
	public bool playable;

	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public enum MapSize
	{
		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		small,
		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		medium,
		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		large,
		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		any
	}
}
