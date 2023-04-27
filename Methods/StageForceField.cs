using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
public class StageForceField : MonoBehaviour
{
	// Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x2ED820", Offset = "0x2EC220", VA = "0x1802ED820")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x2EC7C0", Offset = "0x2EB1C0", VA = "0x1802EC7C0")]
	private void GetReady()
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x2EC960", Offset = "0x2EB360", VA = "0x1802EC960")]
	public StageForceField()
	{
	}

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 pushDir;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x24")]
	private bool ready;
}
