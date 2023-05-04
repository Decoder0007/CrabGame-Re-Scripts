using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000070 RID: 112
[Token(Token = "0x2000070")]
public class RandomSfx : MonoBehaviour
{
	// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3D1340", Offset = "0x3CFD40", VA = "0x1803D1340")]
	private void Awake()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x3D13D0", Offset = "0x3CFDD0", VA = "0x1803D13D0")]
	public void Randomize(float delay = 0f, float volumeMultiplier = 1f)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x3D14C0", Offset = "0x3CFEC0", VA = "0x1803D14C0")]
	public void Stop()
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x3D14E0", Offset = "0x3CFEE0", VA = "0x1803D14E0")]
	public RandomSfx()
	{
	}

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] sounds;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1017E0", Offset = "0x100BE0")]
	public float maxPitch;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1017E0", Offset = "0x100BE0")]
	public float minPitch;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x28")]
	private AudioSource s;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x30")]
	public bool playOnAwake;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x34")]
	private float defaultVolume;
}
