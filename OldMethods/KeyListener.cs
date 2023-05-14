using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000F7")]
public class KeyListener : MonoBehaviour
{
	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000682 RID: 1666 RVA: 0x00002D18 File Offset: 0x00000F18
	// (set) Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000035")]
	public bool justClosed
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2EF1B0", Offset = "0x2EDBB0", VA = "0x1802EF1B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x3A6E90", Offset = "0x3A5890", VA = "0x1803A6E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000684")]
	[Address(RVA = "0xE3FE10", Offset = "0xE3E810", VA = "0x180E3FE10")]
	private void Awake()
	{
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000685")]
	[Address(RVA = "0xE3FFD0", Offset = "0xE3E9D0", VA = "0x180E3FFD0")]
	public void ListenForKey(ControlSetting listener, string actionName)
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000686")]
	[Address(RVA = "0xE40090", Offset = "0xE3EA90", VA = "0x180E40090")]
	private void Update()
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000687")]
	[Address(RVA = "0xE3FF50", Offset = "0xE3E950", VA = "0x180E3FF50")]
	private void CloseListener()
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000688")]
	[Address(RVA = "0xC58940", Offset = "0xC57340", VA = "0x180C58940")]
	private void Cooldown()
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public KeyListener()
	{
	}

	// Token: 0x0400059D RID: 1437
	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x18")]
	public ControlSetting currentlyChanging;

	// Token: 0x0400059E RID: 1438
	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI alertText;

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject overlay;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <justClosed>k__BackingField;

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x0")]
	public static KeyListener Instance;
}
