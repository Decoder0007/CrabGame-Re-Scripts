using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x20000B4")]
public class SaveManager : MonoBehaviour
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060029D8 RID: 10712 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060029D9 RID: 10713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000016")]
	public static SaveManager Instance
	{
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x1060E90", Offset = "0x105FC90", VA = "0x181060E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x1060ED0", Offset = "0x105FCD0", VA = "0x181060ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		set
		{
		}
	}

	// Token: 0x060029DA RID: 10714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DA")]
	[Address(RVA = "0x10607D0", Offset = "0x105F5D0", VA = "0x1810607D0")]
	private void Awake()
	{
	}

	// Token: 0x060029DB RID: 10715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x1060E30", Offset = "0x105FC30", VA = "0x181060E30")]
	public void Save()
	{
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x1060940", Offset = "0x105F740", VA = "0x181060940")]
	public void Load()
	{
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x1060BF0", Offset = "0x105F9F0", VA = "0x181060BF0")]
	public void NewSave()
	{
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60029DE")]
	public string Serialize<T>(T toSerialize)
	{
		return null;
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60029DF")]
	public T Deserialize<T>(string toDeserialize)
	{
		return null;
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x264FC0", Offset = "0x263DC0", VA = "0x180264FC0")]
	public SaveManager()
	{
	}

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x18")]
	public PlayerSave state;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private static SaveManager <Instance>k__BackingField;
}
