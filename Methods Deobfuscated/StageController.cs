using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011E RID: 286
[Token(Token = "0x200011E")]
public class StageController : MonoBehaviour
{
	// Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x2ED3E0", Offset = "0x2EBDE0", VA = "0x1802ED3E0")]
	private void Awake()
	{
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x2ED720", Offset = "0x2EC120", VA = "0x1802ED720")]
	public void SetButtonState(GameModeButtons.ButtonModeState state)
	{
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x2ED7C0", Offset = "0x2EC1C0", VA = "0x1802ED7C0")]
	public void UpdateText()
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x2ED640", Offset = "0x2EC040", VA = "0x1802ED640")]
	public void PressButton(int buttonId, bool press, float moveTime)
	{
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x2ED480", Offset = "0x2EBE80", VA = "0x1802ED480")]
	public bool CanPressButton(int buttonId)
	{
		return default(bool);
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x2ED690", Offset = "0x2EC090", VA = "0x1802ED690")]
	public void ResetButtons(float moveTime)
	{
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void GreenLight()
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void RedLight()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void ShowTimer()
	{
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000737")]
	[Address(RVA = "0x2ED580", Offset = "0x2EBF80", VA = "0x1802ED580")]
	public void OpenStage()
	{
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x2ED4C0", Offset = "0x2EBEC0", VA = "0x1802ED4C0")]
	public void CloseStage()
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public StageController()
	{
	}

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x18")]
	public BustlingButtonInteract[] buttons;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x20")]
	public Material forceFieldGreen;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x28")]
	public Material forceFieldRed;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] forceFieldVisuals;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x38")]
	public GameObject forceFieldCollider;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x40")]
	public ButtonTimer[] buttonTimer;

	// Token: 0x040006B2 RID: 1714
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x48")]
	public AudioSource green;

	// Token: 0x040006B3 RID: 1715
	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource red;

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x58")]
	public AudioSource clock;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x60")]
	public AudioSource next;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x0")]
	public static StageController Instance;
}
