using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000D6")]
public class CombatUtility : MonoBehaviour
{
	// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x30DFB0", Offset = "0x30C9B0", VA = "0x18030DFB0")]
	private void Awake()
	{
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x30E000", Offset = "0x30CA00", VA = "0x18030E000")]
	public void DamageNumbers(Vector3 position, int dmg, Vector3 shooterPos)
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x30E170", Offset = "0x30CB70", VA = "0x18030E170")]
	public static float HurtboxTagToDamageMultiplier(string tag)
	{
		return 0f;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public CombatUtility()
	{
	}

	// Token: 0x04000485 RID: 1157
	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x18")]
	public GameObject damageNumbers;

	// Token: 0x04000486 RID: 1158
	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x20")]
	public GameObject hitMarker;

	// Token: 0x04000487 RID: 1159
	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x0")]
	public static CombatUtility Instance;
}
