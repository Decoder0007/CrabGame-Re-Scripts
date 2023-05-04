using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
public class Timer : MonoBehaviour
{
	// Token: 0x060007DB RID: 2011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x2FB000", Offset = "0x2F9A00", VA = "0x1802FB000")]
	private void Awake()
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x2FB0D0", Offset = "0x2F9AD0", VA = "0x1802FB0D0")]
	private void Update()
	{
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x2FB060", Offset = "0x2F9A60", VA = "0x1802FB060")]
	public void SetTimer(float time)
	{
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x2FB070", Offset = "0x2F9A70", VA = "0x1802FB070")]
	public void StopTimer()
	{
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x2FB050", Offset = "0x2F9A50", VA = "0x1802FB050")]
	public bool IsRunning()
	{
		return default(bool);
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public Timer()
	{
	}

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI timerText;

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x20")]
	private float currentTime;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x24")]
	private bool running;
}
