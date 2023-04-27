using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000032")]
public class IntroUI : MonoBehaviour
{
	// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xE39170", Offset = "0xE37B70", VA = "0x180E39170")]
	private void Awake()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xE392C0", Offset = "0xE37CC0", VA = "0x180E392C0")]
	private void Start()
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xE39290", Offset = "0xE37C90", VA = "0x180E39290")]
	public void Hide()
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE39460", Offset = "0xE37E60", VA = "0x180E39460")]
	public void StopCinematic()
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public IntroUI()
	{
	}

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject parent;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x20")]
	public new TextMeshProUGUI name;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI gamemode;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI description;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x0")]
	public static IntroUI Instance;
}
