using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EE RID: 238
[Token(Token = "0x20000EE")]
public class SmokeLeg : MonoBehaviour
{
	// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x2EC7D0", Offset = "0x2EB1D0", VA = "0x1802EC7D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x2EC7C0", Offset = "0x2EB1C0", VA = "0x1802EC7C0")]
	private void GetReady()
	{
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x2EC960", Offset = "0x2EB360", VA = "0x1802EC960")]
	public SmokeLeg()
	{
	}

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x18")]
	public GameObject smokeFx;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x20")]
	public float cooldown;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x24")]
	private bool ready;
}
