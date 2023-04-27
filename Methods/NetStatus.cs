using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
public class NetStatus : MonoBehaviour
{
	// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x32C430", Offset = "0x32AE30", VA = "0x18032C430")]
	private void Awake()
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x32C900", Offset = "0x32B300", VA = "0x18032C900")]
	private void SlowUpdate()
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x32CA10", Offset = "0x32B410", VA = "0x18032CA10")]
	private void SlowerUpdate()
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x32C330", Offset = "0x32AD30", VA = "0x18032C330")]
	public static void AddPing(int p)
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x32C4E0", Offset = "0x32AEE0", VA = "0x18032C4E0")]
	public static int GetPing()
	{
		return 0;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x32C590", Offset = "0x32AF90", VA = "0x18032C590")]
	private void SendPings()
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x32CC20", Offset = "0x32B620", VA = "0x18032CC20")]
	public NetStatus()
	{
	}

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x18")]
	private string dateFormat;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x0")]
	private static LinkedList<int> pings;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x8")]
	private static int pingBuffer;
}
