using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200005D")]
public class Prompt : MonoBehaviour
{
	// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x3D04B0", Offset = "0x3CEEB0", VA = "0x1803D04B0")]
	private void Awake()
	{
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x3D0650", Offset = "0x3CF050", VA = "0x1803D0650")]
	public void NewPrompt(string header, string content)
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x3D07B0", Offset = "0x3CF1B0", VA = "0x1803D07B0")]
	private void Update()
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public Prompt()
	{
	}

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prompt;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> prompts;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x0")]
	public static Prompt Instance;
}
