using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
public class RewardUI : MonoBehaviour
{
	// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x3D3060", Offset = "0x3D1A60", VA = "0x1803D3060")]
	private void Awake()
	{
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x3D3200", Offset = "0x3D1C00", VA = "0x1803D3200")]
	public void NewReward(string header, string footer, float timeToFade = 3f)
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x3D3340", Offset = "0x3D1D40", VA = "0x1803D3340")]
	private void Update()
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x3D3690", Offset = "0x3D2090", VA = "0x1803D3690")]
	public RewardUI()
	{
	}

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x18")]
	public RawImage line;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI header;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI rewardText;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x30")]
	public Transform top;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x38")]
	public Transform bot;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x40")]
	public float topOffset;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x44")]
	public float botOffset;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 topStart;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 topDesired;

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 botStart;

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 botDesired;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x78")]
	public CanvasGroup group;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x80")]
	public AudioSource sfx;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x0")]
	public static RewardUI Instance;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x88")]
	private float timer;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x8C")]
	private float timeToFade;
}
