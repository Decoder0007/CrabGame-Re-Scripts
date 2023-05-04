using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
public class GameLoop : MonoBehaviour
{
	// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x319D30", Offset = "0x318730", VA = "0x180319D30")]
	private void Awake()
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x31ACE0", Offset = "0x3196E0", VA = "0x18031ACE0")]
	public void Reset()
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x31A6F0", Offset = "0x3190F0", VA = "0x18031A6F0")]
	public void NextGame()
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x31AF40", Offset = "0x319940", VA = "0x18031AF40")]
	public void StartGames()
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x31AB30", Offset = "0x319530", VA = "0x18031AB30")]
	private void ResetGameModesList()
	{
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x31A9A0", Offset = "0x3193A0", VA = "0x18031A9A0")]
	private void ResetAllInventories()
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x319F50", Offset = "0x318950", VA = "0x180319F50")]
	private void CheckDeadPlayers()
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x31A190", Offset = "0x318B90", VA = "0x18031A190")]
	public void CheckGameOver()
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x31AEE0", Offset = "0x3198E0", VA = "0x18031AEE0")]
	public void SetWinner(ulong winnerId)
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x31AD10", Offset = "0x319710", VA = "0x18031AD10")]
	public void RestartLobby()
	{
	}

	// Token: 0x0600035B RID: 859 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x31A4D0", Offset = "0x318ED0", VA = "0x18031A4D0")]
	private ulong FindWinnerId()
	{
		return 0UL;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x319EE0", Offset = "0x3188E0", VA = "0x180319EE0")]
	public bool CanClientInteract(ulong id)
	{
		return default(bool);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x31AC30", Offset = "0x319630", VA = "0x18031AC30")]
	private void ResetReadyToJoin()
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public GameLoop()
	{
	}

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x0")]
	public static GameLoop Instance;

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x18")]
	public List<GameModeData> gameModesAvailable;

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x20")]
	public List<GameModeData> smallModes;

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x28")]
	private System.Random random;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x30")]
	public ulong winner;
}
