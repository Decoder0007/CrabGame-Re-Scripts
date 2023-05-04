using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
public class ScrollSettings : Setting
{
	// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x3D5790", Offset = "0x3D4190", VA = "0x1803D5790")]
	public void SetSettings(string[] settings, int startVal)
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x3D5710", Offset = "0x3D4110", VA = "0x1803D5710")]
	public void SetSettings(List<string> settings, int startVal)
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x3D5700", Offset = "0x3D4100", VA = "0x1803D5700")]
	public void Scroll(int i)
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x3D57D0", Offset = "0x3D41D0", VA = "0x1803D57D0")]
	private void UpdateSetting()
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D15D0", VA = "0x1803D2BD0")]
	public ScrollSettings()
	{
	}

	// Token: 0x040005E3 RID: 1507
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI settingText;

	// Token: 0x040005E4 RID: 1508
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x30")]
	private string[] settingNames;

	// Token: 0x040005E5 RID: 1509
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x38")]
	public RawImage scrollLeft;

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x40")]
	public RawImage scrollRight;
}
