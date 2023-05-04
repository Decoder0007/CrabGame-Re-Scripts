using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000FB RID: 251
[Token(Token = "0x20000FB")]
public class ResolutionSetting : Setting
{
	// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069D")]
	[Address(RVA = "0x3D29A0", Offset = "0x3D13A0", VA = "0x1803D29A0")]
	public void SetSettings(Resolution[] resolutions, Resolution current)
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069E")]
	[Address(RVA = "0x3D2990", Offset = "0x3D1390", VA = "0x1803D2990")]
	public void Scroll(int i)
	{
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069F")]
	[Address(RVA = "0x3D2AC0", Offset = "0x3D14C0", VA = "0x1803D2AC0")]
	private void UpdateSetting()
	{
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x316930", Offset = "0x315330", VA = "0x180316930")]
	private string ResolutionToText(Resolution r)
	{
		return null;
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x3D2890", Offset = "0x3D1290", VA = "0x1803D2890")]
	public void ApplySetting()
	{
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D15D0", VA = "0x1803D2BD0")]
	public ResolutionSetting()
	{
	}

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x28")]
	public RawImage scrollLeft;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x30")]
	public RawImage scrollRight;

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI settingText;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x40")]
	private Resolution[] resolutions;
}
