using System;
using Dissonance;
using Dissonance.Integrations.SteamworksP2P;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public class DissonanceManager : MonoBehaviour
{
	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x315CE0", Offset = "0x3146E0", VA = "0x180315CE0")]
	private void Awake()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x316020", Offset = "0x314A20", VA = "0x180316020")]
	private void Start()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x315F90", Offset = "0x314990", VA = "0x180315F90")]
	public void ResetDissonance()
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x315F00", Offset = "0x314900", VA = "0x180315F00")]
	public void PlayerDied(ulong playerId)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x315E60", Offset = "0x314860", VA = "0x180315E60")]
	public void JoinedLobby(CSteamID lobbyId)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x315DE0", Offset = "0x3147E0", VA = "0x180315DE0")]
	public void CreatedLobby(CSteamID lobbyId)
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x315EA0", Offset = "0x3148A0", VA = "0x180315EA0")]
	public void PeerJoinedLobby(CSteamID lobbyId, CSteamID friendId)
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x315EE0", Offset = "0x3148E0", VA = "0x180315EE0")]
	public void PeerLeftLobby(CSteamID friendId)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void OnPlayerJoined([Attribute(Name = "NotNullAttribute", RVA = "0xDC390", Offset = "0xDB790")] VoicePlayerState player)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public DissonanceManager()
	{
	}

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x18")]
	public SteamworksP2PCommsNetwork dissonanceP2p;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x20")]
	public DissonanceComms comms;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x0")]
	public static DissonanceManager Instance;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject dissonanceManager;
}
