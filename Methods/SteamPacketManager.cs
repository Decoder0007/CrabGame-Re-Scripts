using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class SteamPacketManager : MonoBehaviour
{
	// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x2F14E0", Offset = "0x2EFEE0", VA = "0x1802F14E0")]
	private void Awake()
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x2F1550", Offset = "0x2EFF50", VA = "0x1802F1550")]
	private void Update()
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x2F1550", Offset = "0x2EFF50", VA = "0x1802F1550")]
	public static void CheckForPackets()
	{
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x2F19E0", Offset = "0x2F03E0", VA = "0x1802F19E0")]
	private static void HandlePacket(SteamNetworkingMessage_t messageT, int channel)
	{
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000547")]
	[Address(RVA = "0x2F3E80", Offset = "0x2F2880", VA = "0x1802F3E80")]
	public static void SendPacket(CSteamID steamId, Packet p, int p2pSend, SteamPacketManager.NetworkChannel channel)
	{
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x2F3E70", Offset = "0x2F2870", VA = "0x1802F3E70")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x2F16D0", Offset = "0x2F00D0", VA = "0x1802F16D0")]
	public static void CloseConnections()
	{
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x2F33C0", Offset = "0x2F1DC0", VA = "0x1802F33C0")]
	public static void InitializeServerPackets()
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x2F1EC0", Offset = "0x2F08C0", VA = "0x1802F1EC0")]
	public static void InitializeClientData()
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public SteamPacketManager()
	{
	}

	// Token: 0x0400047B RID: 1147
	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0x0")]
	public static int packetsUp;

	// Token: 0x0400047C RID: 1148
	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x4")]
	public static int bytesUp;

	// Token: 0x0400047D RID: 1149
	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x8")]
	public static int packetsDown;

	// Token: 0x0400047E RID: 1150
	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0xC")]
	public static int bytesDown;

	// Token: 0x0400047F RID: 1151
	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x10")]
	public static Dictionary<int, SteamPacketManager.ServerPacketHandler> ServerPacketHandlers;

	// Token: 0x04000480 RID: 1152
	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x18")]
	public static Dictionary<int, SteamPacketManager.ClientPacketHandler> ClientPacketHandlers;

	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public enum NetworkChannel
	{
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		ToClient,
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		ToServer
	}

	// Token: 0x020000D3 RID: 211
	// (Invoke) Token: 0x0600054E RID: 1358
	[Token(Token = "0x20000D3")]
	public delegate void ServerPacketHandler(ulong fromSteamId, Packet packet);

	// Token: 0x020000D4 RID: 212
	// (Invoke) Token: 0x06000552 RID: 1362
	[Token(Token = "0x20000D4")]
	public delegate void ClientPacketHandler(Packet packet);
}
