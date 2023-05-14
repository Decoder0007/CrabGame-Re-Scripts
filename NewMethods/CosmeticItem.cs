using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x382C0", Offset = "0x376C0")]
public class CosmeticItem : ScriptableObject
{
	// Token: 0x06002BD5 RID: 11221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BD5")]
	[Address(RVA = "0x104F040", Offset = "0x104DE40", VA = "0x18104F040")]
	public CosmeticItem()
	{
	}

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x18")]
	public int itemdefid;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x20")]
	public new string name;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TextAreaAttribute", RVA = "0x1E6E70", Offset = "0x1E6270")]
	public string description;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x30")]
	public CosmeticItem.Ⴃ\u109C\u109AႤႠႦႡႧ\u109B\u109FႣ type;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x34")]
	public CosmeticItem.\u109C\u109FႡႥ႙Ⴇ\u109AႢ\u109FႧႤ rarity;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x38")]
	public Texture icon;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x40")]
	public Mesh mesh;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x48")]
	public Material[] materials;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x50")]
	public int materialToChangeColorOn;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x54")]
	public int exchangeItemDefId;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 hatOffset;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 hatThresholdBeforeOffset;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x70")]
	public bool ignoreOffset;

	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public enum Ⴃ\u109C\u109AႤႠႦႡႧ\u109B\u109FႣ
	{
		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		None,
		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		Hair,
		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		Hat,
		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		Face,
		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		Shoes,
		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		Other,
		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		Box,
		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		Top,
		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		Backpack,
		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		Rags
	}

	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	public enum \u109C\u109FႡႥ႙Ⴇ\u109AႢ\u109FႧႤ
	{
		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		Common,
		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		Uncommon,
		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		Rare,
		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		Extraordinary,
		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		Legendary,
		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		Original,
		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		Unique
	}
}
