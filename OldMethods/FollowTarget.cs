using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
public class FollowTarget : MonoBehaviour
{
	// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3195C0", Offset = "0x317FC0", VA = "0x1803195C0")]
	public void SetTarget(Transform target)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x319690", Offset = "0x318090", VA = "0x180319690")]
	private void Update()
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public FollowTarget()
	{
	}

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	public bool keepOffset;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 offset;
}
