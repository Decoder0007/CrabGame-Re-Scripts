using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
public class AssignSharedObjectID : MonoBehaviour
{
	// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x2FFE60", Offset = "0x2FE860", VA = "0x1802FFE60")]
	public static void AddObject(SharedObject sharedObject)
	{
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x2FFEF0", Offset = "0x2FE8F0", VA = "0x1802FFEF0")]
	public void AssignIDs()
	{
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x3000A0", Offset = "0x2FEAA0", VA = "0x1803000A0")]
	public static bool Contains(SharedObject sharedObject)
	{
		return default(bool);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000457")]
	[Address(RVA = "0x300190", Offset = "0x2FEB90", VA = "0x180300190")]
	public static void RemoveObject(SharedObject sharedObject)
	{
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x300130", Offset = "0x2FEB30", VA = "0x180300130")]
	public static List<SharedObject> GetDictionary()
	{
		return null;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public AssignSharedObjectID()
	{
	}

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x14E0")]
	private static List<SharedObject> sharedObjects;
}
