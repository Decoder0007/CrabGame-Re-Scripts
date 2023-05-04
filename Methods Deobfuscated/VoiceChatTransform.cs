using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000145 RID: 325
[Token(Token = "0x2000145")]
public class VoiceChatTransform : MonoBehaviour
{
	// Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x2FE980", Offset = "0x2FD380", VA = "0x1802FE980")]
	private void Start()
	{
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x2FE9E0", Offset = "0x2FD3E0", VA = "0x1802FE9E0")]
	private void Update()
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x2B43B0", Offset = "0x2B2DB0", VA = "0x1802B43B0")]
	public void SetNewTarget(Transform newTarget)
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x2FE8E0", Offset = "0x2FD2E0", VA = "0x1802FE8E0")]
	public void PlayerDied(Transform newTarget)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x2FE9B0", Offset = "0x2FD3B0", VA = "0x1802FE9B0")]
	public void StopAudio()
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public VoiceChatTransform()
	{
	}

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x20")]
	public PlayerManager pm;
}
