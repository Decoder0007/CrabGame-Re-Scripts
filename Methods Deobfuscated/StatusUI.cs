using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000121 RID: 289
[Token(Token = "0x2000121")]
public class StatusUI : MonoBehaviour
{
	// Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x2EDCC0", Offset = "0x2EC6C0", VA = "0x1802EDCC0")]
	private void Awake()
	{
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x2EDD70", Offset = "0x2EC770", VA = "0x1802EDD70")]
	public void SetReadyStatus(int spawnedPlayers, int readyPlayers, int maxPlayers, int minPlayers, bool ready, int time)
	{
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x2EE100", Offset = "0x2ECB00", VA = "0x1802EE100")]
	public void SetStartedStatus(float time)
	{
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x2EE240", Offset = "0x2ECC40", VA = "0x1802EE240")]
	public void ToggleUI(bool visible)
	{
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x2EDD10", Offset = "0x2EC710", VA = "0x1802EDD10")]
	private void HideUI()
	{
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public StatusUI()
	{
	}

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x18")]
	public CircleRatioUI hpCircle;

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x20")]
	public CircleRatioUI ammoCircle;

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI playerCount;

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI countdown;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI lobbyStatus;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI readyText;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x48")]
	public Timer timer;

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI moneyText;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI taskDescription;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x0")]
	public static StatusUI Instance;
}
