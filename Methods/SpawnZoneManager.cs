using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
public class SpawnZoneManager : MonoBehaviour
{
	// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2ECB20", Offset = "0x2EB520", VA = "0x1802ECB20")]
	private void Awake()
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void SpawnNewZone()
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x2ECC40", Offset = "0x2EB640", VA = "0x1802ECC40")]
	public Vector3 FindGroundedSpawnPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public SpawnZoneManager()
	{
	}

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x0")]
	public static SpawnZoneManager Instance;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject spawnZonePrefab;
}
