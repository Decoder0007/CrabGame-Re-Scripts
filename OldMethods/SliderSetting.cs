using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class SliderSetting : Setting
{
	// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x2EC590", Offset = "0x2EAF90", VA = "0x1802EC590")]
	public void SetSettings(int startVal)
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x2EC700", Offset = "0x2EB100", VA = "0x1802EC700")]
	public void UpdateSettings()
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x2EC660", Offset = "0x2EB060", VA = "0x1802EC660")]
	public static float Truncate(float value, int digits)
	{
		return 0f;
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x2EC7B0", Offset = "0x2EB1B0", VA = "0x1802EC7B0")]
	public SliderSetting()
	{
	}

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x28")]
	public Slider slider;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI value;
}
