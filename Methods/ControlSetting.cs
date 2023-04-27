using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x020000F5 RID: 245
[Token(Token = "0x20000F5")]
public class ControlSetting : Setting
{
	// Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000659")]
	[Address(RVA = "0x30E260", Offset = "0x30CC60", VA = "0x18030E260")]
	public void SetSetting(int keyCode, string actionName)
	{
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x30E350", Offset = "0x30CD50", VA = "0x18030E350")]
	private void UpdateSetting()
	{
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600065B")]
	[Address(RVA = "0x30E490", Offset = "0x30CE90", VA = "0x18030E490")]
	private string intToKeyCode(int key)
	{
		return null;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065C")]
	[Address(RVA = "0x30E220", Offset = "0x30CC20", VA = "0x18030E220")]
	public void SetKey(int k)
	{
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065D")]
	[Address(RVA = "0x30E2F0", Offset = "0x30CCF0", VA = "0x18030E2F0")]
	public void StartListening()
	{
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x2EC7B0", Offset = "0x2EB1B0", VA = "0x1802EC7B0")]
	public ControlSetting()
	{
	}

	// Token: 0x0400058A RID: 1418
	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI keyText;

	// Token: 0x0400058B RID: 1419
	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x30")]
	public int currentKey;

	// Token: 0x0400058C RID: 1420
	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x38")]
	private string actionName;
}
