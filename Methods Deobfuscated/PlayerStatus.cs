using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class PlayerStatus : MonoBehaviour
{
	// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x3CF1C0", Offset = "0x3CDBC0", VA = "0x1803CF1C0")]
	private void Awake()
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x3CF830", Offset = "0x3CE230", VA = "0x1803CF830")]
	private void Start()
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Update()
	{
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x3CF830", Offset = "0x3CE230", VA = "0x1803CF830")]
	public void ResetStatus()
	{
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x3CF220", Offset = "0x3CDC20", VA = "0x1803CF220")]
	public void DamagePlayer(int dmg, Vector3 damageDir, ulong damageDoerId, int itemId)
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x3CF8F0", Offset = "0x3CE2F0", VA = "0x1803CF8F0")]
	private void UpdateStatusUI()
	{
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x3CF700", Offset = "0x3CE100", VA = "0x1803CF700")]
	private void PlayerDied(ulong damageDoerId, Vector3 damageDir)
	{
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x3CF690", Offset = "0x3CE090", VA = "0x1803CF690")]
	public float GetHpRatio()
	{
		return 0f;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x3CF850", Offset = "0x3CE250", VA = "0x1803CF850")]
	public void UpdateMoney(int money)
	{
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x3CF9B0", Offset = "0x3CE3B0", VA = "0x1803CF9B0")]
	public PlayerStatus()
	{
	}

	// Token: 0x04000583 RID: 1411
	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x18")]
	public ObscuredInt currentHp;

	// Token: 0x04000584 RID: 1412
	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x2C")]
	public ObscuredInt maxHp;

	// Token: 0x04000585 RID: 1413
	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerStatus Instance;

	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public enum DamageType
	{
		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		FallDamage = -2
	}
}
