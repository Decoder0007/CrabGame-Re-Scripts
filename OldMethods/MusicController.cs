using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006D RID: 109
[Token(Token = "0x200006D")]
public class MusicController : MonoBehaviour
{
	// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x32BA30", Offset = "0x32A430", VA = "0x18032BA30")]
	private void Awake()
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x32BFA0", Offset = "0x32A9A0", VA = "0x18032BFA0")]
	private void Start()
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x32BF50", Offset = "0x32A950", VA = "0x18032BF50")]
	public void SetVolume(float f)
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x32BF30", Offset = "0x32A930", VA = "0x18032BF30")]
	public void SetPitch(float f)
	{
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x32BC30", Offset = "0x32A630", VA = "0x18032BC30")]
	public void PlaySong(MusicController.SongType s, float newFadeTime = 4f)
	{
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x32BBC0", Offset = "0x32A5C0", VA = "0x18032BBC0")]
	private void NextSong()
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x32BB50", Offset = "0x32A550", VA = "0x18032BB50")]
	private void NextSong(AudioClip song)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x32C020", Offset = "0x32AA20", VA = "0x18032C020")]
	public void StopSong(float fade = -1f)
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x32C070", Offset = "0x32AA70", VA = "0x18032C070")]
	private void Update()
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x32BF60", Offset = "0x32A960", VA = "0x18032BF60")]
	private void StartFade(AudioSource audioSource, float duration, float targetVolume)
	{
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x32BB30", Offset = "0x32A530", VA = "0x18032BB30")]
	public void ImmediateStop()
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x32C0F0", Offset = "0x32AAF0", VA = "0x18032C0F0")]
	public MusicController()
	{
	}

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] Intense;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] Menu;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] funky;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip[] scary;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip[] winMusic;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x40")]
	private AudioSource audio;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x0")]
	public static MusicController Instance;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x48")]
	private AudioClip queuedSong;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x50")]
	private float fadeTime;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x54")]
	private float defaultFadeTime;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x58")]
	private float targetVolume;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x5C")]
	private MusicController.SongType currentSong;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x60")]
	private float currentTime;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x64")]
	private float newFadeTime;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x68")]
	private float desiredVolume;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x6C")]
	private float startVolume;

	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public enum SongType
	{
		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		None,
		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		Intense,
		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		Menu,
		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		Funky,
		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		Scary,
		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		WinMusic
	}
}
