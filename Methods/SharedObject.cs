using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C0 RID: 192
[Token(Token = "0x20000C0")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0xDC390", Offset = "0xDB790")]
public class SharedObject : MonoBehaviour
{
	// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x2EBD00", Offset = "0x2EA700", VA = "0x1802EBD00")]
	protected void Start()
	{
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x225FE0", Offset = "0x2249E0", VA = "0x180225FE0")]
	public int GetId()
	{
		return 0;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x226030", Offset = "0x224A30", VA = "0x180226030")]
	public void SetId(int id)
	{
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x2EBED0", Offset = "0x2EA8D0", VA = "0x1802EBED0")]
	public SharedObject()
	{
	}

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x18")]
	public int id;
}
