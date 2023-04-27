using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002C RID: 44
[Token(Token = "0x200002C")]
public class GameUI : MonoBehaviour
{
	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE356E0", Offset = "0xE340E0", VA = "0x180E356E0")]
	private void Awake()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE357A0", Offset = "0xE341A0", VA = "0x180E357A0")]
	private void Start()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE35730", Offset = "0xE34130", VA = "0x180E35730")]
	private void FixUI()
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE35830", Offset = "0xE34230", VA = "0x180E35830")]
	private void Update()
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE35810", Offset = "0xE34210", VA = "0x180E35810")]
	public void UpdateChat(bool enabled)
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public GameUI()
	{
	}

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject roleUI;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject lobbyStatusUI;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x0")]
	public static GameUI Instance;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x28")]
	public CanvasGroup canvasGroup;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject chatBox;
}
