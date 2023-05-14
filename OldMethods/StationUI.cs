using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000120 RID: 288
[Token(Token = "0x2000120")]
public class StationUI : MonoBehaviour
{
	// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x2EDB80", Offset = "0x2EC580", VA = "0x1802EDB80")]
	private void Awake()
	{
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x2EDCA0", Offset = "0x2EC6A0", VA = "0x1802EDCA0")]
	private void Start()
	{
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x2EDC20", Offset = "0x2EC620", VA = "0x1802EDC20")]
	public void OpenStation(StationInteract.StationType type)
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x2EDBD0", Offset = "0x2EC5D0", VA = "0x1802EDBD0")]
	public void CloseStation()
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public StationUI()
	{
	}

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x18")]
	public ShopWindow shopWindow;

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject currentWindow;

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x0")]
	public static StationUI Instance;
}
