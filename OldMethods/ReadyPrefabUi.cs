using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
public class ReadyPrefabUi : MonoBehaviour
{
	// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x3D1D40", Offset = "0x3D0740", VA = "0x1803D1D40")]
	public void SetPlayer(PlayerManager pm)
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x3D1D70", Offset = "0x3D0770", VA = "0x1803D1D70")]
	public void UpdateUi()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x3D1CF0", Offset = "0x3D06F0", VA = "0x1803D1CF0")]
	private string GetReadyText(bool ready)
	{
		return null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ReadyPrefabUi()
	{
	}

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI username;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x20")]
	public RawImage overlay;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x28")]
	private PlayerManager pm;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x30")]
	public Color ready;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x40")]
	public Color notReady;
}
