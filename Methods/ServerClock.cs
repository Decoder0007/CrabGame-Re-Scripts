using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011A RID: 282
[Token(Token = "0x200011A")]
public class ServerClock : MonoBehaviour
{
	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000715 RID: 1813 RVA: 0x00002DF0 File Offset: 0x00000FF0
	// (set) Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003A")]
	public static float clock
	{
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x3D63E0", Offset = "0x3D4DE0", VA = "0x1803D63E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x3D6420", Offset = "0x3D4E20", VA = "0x1803D6420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000717")]
	[Address(RVA = "0x3D5E80", Offset = "0x3D4880", VA = "0x1803D5E80")]
	private void Awake()
	{
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000718")]
	[Address(RVA = "0x3D62A0", Offset = "0x3D4CA0", VA = "0x1803D62A0")]
	public void Update()
	{
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000719")]
	[Address(RVA = "0x3D6000", Offset = "0x3D4A00", VA = "0x1803D6000")]
	public static void SetClock(float time)
	{
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x3D6050", Offset = "0x3D4A50", VA = "0x1803D6050")]
	public void SyncClock()
	{
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600071B")]
	[Address(RVA = "0x3D63D0", Offset = "0x3D4DD0", VA = "0x1803D63D0")]
	public ServerClock()
	{
	}

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private static float <clock>k__BackingField;

	// Token: 0x04000697 RID: 1687
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x18")]
	private float syncRate;

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x8")]
	public static ServerClock Instance;
}
