using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public class MicDropDown : Setting
{
	// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x327BC0", Offset = "0x3265C0", VA = "0x180327BC0")]
	public void SetSettings(string device, List<string> devices)
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x316950", Offset = "0x315350", VA = "0x180316950")]
	public void Scroll(int i)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void UpdateSetting()
	{
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x316930", Offset = "0x315330", VA = "0x180316930")]
	private string ResolutionToText(Resolution r)
	{
		return null;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x327B10", Offset = "0x326510", VA = "0x180327B10")]
	public void ApplySetting()
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void ApplyMic()
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x2EC7B0", Offset = "0x2EB1B0", VA = "0x1802EC7B0")]
	public MicDropDown()
	{
	}

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Dropdown dropdown;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI settingText;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x38")]
	private List<string> devices;
}
