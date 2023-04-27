using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class ReadyDisplay : MonoBehaviour
{
	// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x3D1630", Offset = "0x3D0030", VA = "0x1803D1630")]
	private void Awake()
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x3D16D0", Offset = "0x3D00D0", VA = "0x1803D16D0")]
	private void SlowUpdate()
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ReadyDisplay()
	{
	}

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x20")]
	public Transform content;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, ReadyPrefabUi> idToPrefab;
}
