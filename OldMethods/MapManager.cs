using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
public class MapManager : MonoBehaviour
{
	// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x327060", Offset = "0x325A60", VA = "0x180327060")]
	private void Awake()
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x3271F0", Offset = "0x325BF0", VA = "0x1803271F0")]
	public Map GetMap(int index)
	{
		return null;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public MapManager()
	{
	}

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x0")]
	public static MapManager Instance;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x18")]
	public Map[] maps;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x20")]
	public Map defaultMap;
}
