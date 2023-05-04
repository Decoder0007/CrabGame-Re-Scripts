using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public class LavaPiece : MonoBehaviour
{
	// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x321100", Offset = "0x31FB00", VA = "0x180321100")]
	public void Break()
	{
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x321310", Offset = "0x31FD10", VA = "0x180321310")]
	private void Update()
	{
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x321200", Offset = "0x31FC00", VA = "0x180321200")]
	private void FinalBreak()
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x321570", Offset = "0x31FF70", VA = "0x180321570")]
	public LavaPiece()
	{
	}

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x18")]
	private bool breaking;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject soundPrefab;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject breakPrefab;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x30")]
	private float currentTime;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x34")]
	private float breakTime;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x38")]
	private float fallSpeed;
}
