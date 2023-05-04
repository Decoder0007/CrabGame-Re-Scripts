using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public class DropdownSetting : Setting
{
	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x316960", Offset = "0x315360", VA = "0x180316960")]
	public void SetSettings(Resolution[] resolutions, Resolution current)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x316950", Offset = "0x315350", VA = "0x180316950")]
	public void Scroll(int i)
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void UpdateSetting()
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x316B10", Offset = "0x315510", VA = "0x180316B10")]
	public void UpdateResolution()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x316930", Offset = "0x315330", VA = "0x180316930")]
	private string ResolutionToText(Resolution r)
	{
		return null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x316830", Offset = "0x315230", VA = "0x180316830")]
	public void ApplySetting()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void ApplyMic()
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2EC7B0", Offset = "0x2EB1B0", VA = "0x1802EC7B0")]
	public DropdownSetting()
	{
	}

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Dropdown dropdown;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI settingText;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x38")]
	private Resolution[] resolutions;
}
