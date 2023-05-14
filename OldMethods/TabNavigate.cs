using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000126 RID: 294
[Token(Token = "0x2000126")]
public class TabNavigate : MonoBehaviour
{
	// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x2F7A20", Offset = "0x2F6420", VA = "0x1802F7A20")]
	public void Init()
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x2F7A10", Offset = "0x2F6410", VA = "0x1802F7A10")]
	private void Awake()
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x2F78A0", Offset = "0x2F62A0", VA = "0x1802F78A0")]
	public void AddNewTab(RawImage btnImage, GameObject tab)
	{
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x2F7CE0", Offset = "0x2F66E0", VA = "0x1802F7CE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x2F7CF0", Offset = "0x2F66F0", VA = "0x1802F7CF0")]
	public void Select(int selected)
	{
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public TabNavigate()
	{
	}

	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x18")]
	public Transform tabsParent;

	// Token: 0x040006DD RID: 1757
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x20")]
	public Transform btnsParent;

	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x28")]
	private List<RawImage> btns;

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> tabs;

	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x38")]
	public Color selectedColor;

	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x48")]
	public Color idleColor;

	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2FDBC0", Offset = "0x2FC5C0", VA = "0x1802FDBC0")]
		internal void <Init>b__0()
		{
		}

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x18")]
		public TabNavigate <>4__this;
	}

	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2FDBF0", Offset = "0x2FC5F0", VA = "0x1802FDBF0")]
		internal void <AddNewTab>b__0()
		{
		}

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x10")]
		public TabNavigate <>4__this;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x18")]
		public int index;
	}
}
