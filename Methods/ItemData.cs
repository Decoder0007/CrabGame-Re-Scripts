using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009E RID: 158
[Token(Token = "0x200009E")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDC390", Offset = "0xDB790")]
public class ItemData : ScriptableObject
{
	// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000345")]
	[Address(RVA = "0xE39E50", Offset = "0xE38850", VA = "0x180E39E50")]
	public void MakeInstance()
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000346")]
	[Address(RVA = "0xE39E60", Offset = "0xE38860", VA = "0x180E39E60")]
	public ItemData()
	{
	}

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x18")]
	public int itemID;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x1C")]
	public int objectID;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x20")]
	public ItemData.ItemType type;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject itemPrefab;

	// Token: 0x040002C5 RID: 709
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x30")]
	public Texture icon;

	// Token: 0x040002C6 RID: 710
	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x38")]
	public Texture iconBig;

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x40")]
	public string itemName;

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x48")]
	public int currentAmmo;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x4C")]
	public int maxAmmo;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x50")]
	public ItemAmmo.AmmoType ammoType;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x54")]
	public float reloadTime;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101AC0", Offset = "0x100EC0")]
	public Vector3 positionOffset;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 rotationOffset;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101AF0", Offset = "0x100EF0")]
	public Vector3 onlinePositionOffset;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101B20", Offset = "0x100F20")]
	public int price;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x101B50", Offset = "0x100F50")]
	public GunComponent gunComponent;

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x88")]
	public SoundComponent soundComponent;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x90")]
	public int damage;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "HideInInspector", RVA = "0xDC390", Offset = "0xDB790")]
	public bool instanced;

	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	public enum ItemType
	{
		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		Primary,
		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		Secondary,
		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		Melee,
		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		Throwable,
		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		Other,
		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		Ammo
	}
}
