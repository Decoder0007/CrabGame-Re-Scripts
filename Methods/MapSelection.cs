using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
public class MapSelection : MonoBehaviour
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060003B5 RID: 949 RVA: 0x000025E0 File Offset: 0x000007E0
	// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001A")]
	public int selectedMap
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x327230", Offset = "0x325C30", VA = "0x180327230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x327240", Offset = "0x325C40", VA = "0x180327240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MapSelection()
	{
	}

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x18")]
	public GameObject mapBtnPrefab;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x20")]
	public GameObject btnParent;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x28")]
	public List<MapBtn> mapBtns;

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <selectedMap>k__BackingField;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x38")]
	private string workshopPath;
}
