using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F4 RID: 244
[Token(Token = "0x20000F4")]
public class SaveManager : MonoBehaviour
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000650 RID: 1616 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000651 RID: 1617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000034")]
	public static SaveManager Instance
	{
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x3D5110", Offset = "0x3D3B10", VA = "0x1803D5110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x3D5150", Offset = "0x3D3B50", VA = "0x1803D5150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x3D4C20", Offset = "0x3D3620", VA = "0x1803D4C20")]
	private void Awake()
	{
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x3D50B0", Offset = "0x3D3AB0", VA = "0x1803D50B0")]
	public void Save()
	{
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x3D4E00", Offset = "0x3D3800", VA = "0x1803D4E00")]
	public void Load()
	{
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000655")]
	[Address(RVA = "0x3D4E90", Offset = "0x3D3890", VA = "0x1803D4E90")]
	public void NewSave()
	{
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000656")]
	public string Serialize<T>(T toSerialize)
	{
		return null;
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000657")]
	public T Deserialize<T>(string toDeserialize)
	{
		return null;
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public SaveManager()
	{
	}

	// Token: 0x04000588 RID: 1416
	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x18")]
	public PlayerSave state;

	// Token: 0x04000589 RID: 1417
	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private static SaveManager <Instance>k__BackingField;
}
