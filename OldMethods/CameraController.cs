using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class CameraController : MonoBehaviour
{
	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3033E0", Offset = "0x301DE0", VA = "0x1803033E0")]
	private void Start()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3031F0", Offset = "0x301BF0", VA = "0x1803031F0")]
	private void NextCamera()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x303390", Offset = "0x301D90", VA = "0x180303390")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x303490", Offset = "0x301E90", VA = "0x180303490")]
	public CameraController()
	{
	}

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] cameras;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	private int currentCamera;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x24")]
	public float cameraSwitchTime;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource music;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource clapping;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x38")]
	public GameObject money;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x40")]
	public Animator animator;
}
