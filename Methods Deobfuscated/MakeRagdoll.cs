using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public class MakeRagdoll : MonoBehaviour
{
	// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x325D50", Offset = "0x324750", VA = "0x180325D50")]
	public void CreateRagdoll(Vector3 dir)
	{
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x325EF0", Offset = "0x3248F0", VA = "0x180325EF0")]
	private void Ragdoll(Transform part, Vector3 dir)
	{
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x325A70", Offset = "0x324470", VA = "0x180325A70")]
	private void AddComponents(Transform p, Rigidbody parent, Vector3 dir)
	{
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MakeRagdoll()
	{
	}

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x18")]
	public Transform armature;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x20")]
	public PhysicMaterial mat;
}
