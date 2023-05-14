using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class Decals : MonoBehaviour
{
	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x314830", Offset = "0x313230", VA = "0x180314830")]
	private void Awake()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x3146E0", Offset = "0x3130E0", VA = "0x1803146E0")]
	public void AddDecal(Decals.Decal newDecal, Vector3 position, Quaternion rotation, [Optional] Transform parent)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x3148D0", Offset = "0x3132D0", VA = "0x1803148D0")]
	public void UpdateDecal(Decals.Decal decal, Vector3 position, Quaternion rotation, Transform parent)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x314BB0", Offset = "0x3135B0", VA = "0x180314BB0")]
	public Decals()
	{
	}

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject decalPrefab;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<MeshRenderer> decalPool;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int index;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int maxSize;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Decals Instance;

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Serializable]
	public class Decal
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public Decal()
		{
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material material;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float size;
	}
}
