using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
public class ClientSend : MonoBehaviour
{
	// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042E")]
	[Address(RVA = "0x30C600", Offset = "0x30B000", VA = "0x18030C600")]
	private static void SendTCPData(Packet packet)
	{
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042F")]
	[Address(RVA = "0x30C720", Offset = "0x30B120", VA = "0x18030C720")]
	private static void SendTCPData(Packet packet, ulong id)
	{
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000430")]
	[Address(RVA = "0x30C810", Offset = "0x30B210", VA = "0x18030C810")]
	private static void SendUDPData(Packet packet)
	{
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000431")]
	[Address(RVA = "0x30C930", Offset = "0x30B330", VA = "0x18030C930")]
	private static void SendUDPData(Packet packet, ulong id)
	{
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x30C070", Offset = "0x30AA70", VA = "0x18030C070")]
	public static void SendChatMessage(string msg)
	{
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000433")]
	[Address(RVA = "0x30AFB0", Offset = "0x3099B0", VA = "0x18030AFB0")]
	public static void PingPong()
	{
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000434")]
	[Address(RVA = "0x30AAB0", Offset = "0x3094B0", VA = "0x18030AAB0")]
	public static void HandShake(ulong id)
	{
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000435")]
	[Address(RVA = "0x30B0D0", Offset = "0x309AD0", VA = "0x18030B0D0")]
	public static void PingServer(string t1)
	{
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x30C1B0", Offset = "0x30ABB0", VA = "0x18030C1B0")]
	public static void SendClientPing(int ping)
	{
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000437")]
	[Address(RVA = "0x30BBB0", Offset = "0x30A5B0", VA = "0x18030BBB0")]
	public static void RequestColor(int colorIndex)
	{
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000438")]
	[Address(RVA = "0x30ACA0", Offset = "0x3096A0", VA = "0x18030ACA0")]
	public static void LoadingRequestEnterGame()
	{
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x30CA20", Offset = "0x30B420", VA = "0x18030CA20")]
	public static void StartedLoading()
	{
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x30A850", Offset = "0x309250", VA = "0x18030A850")]
	public static void GameRequestAllPlayers()
	{
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x30A970", Offset = "0x309370", VA = "0x18030A970")]
	public static void GameRequestToSpawn(bool streamerMode)
	{
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043C")]
	[Address(RVA = "0x30BE10", Offset = "0x30A810", VA = "0x18030BE10")]
	public static void RequestGameStartedCooldown()
	{
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x30B4E0", Offset = "0x309EE0", VA = "0x18030B4E0")]
	public static void PlayerPosition(Vector3 position, ulong toId)
	{
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x30B790", Offset = "0x30A190", VA = "0x18030B790")]
	public static void PlayerRotation(float x, float y, ulong toId)
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x30B210", Offset = "0x309C10", VA = "0x18030B210")]
	public static void PlayerAnimation(int animationType, bool state)
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x30A580", Offset = "0x308F80", VA = "0x18030A580")]
	public static void DamagePlayer(ulong hurtPlayerId, int damage, Vector3 damageDir, int itemID, int objectID)
	{
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x30B370", Offset = "0x309D70", VA = "0x18030B370")]
	public static void PlayerDied(ulong damageDoerId, Vector3 damageDir)
	{
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x30B650", Offset = "0x30A050", VA = "0x18030B650")]
	public static void PlayerReload(float reloadTime)
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x30ADC0", Offset = "0x3097C0", VA = "0x18030ADC0")]
	public static void PhysicsObjectSnapshot(int objectId, Vector3 position, Vector3 velocity, Vector3 angVelocity, Quaternion rotation)
	{
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x30CB40", Offset = "0x30B540", VA = "0x18030CB40")]
	public static void SyncObject(int objectId)
	{
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000445")]
	[Address(RVA = "0x30BA40", Offset = "0x30A440", VA = "0x18030BA40")]
	public static void PunchPlayer(ulong playerId, Vector3 dir)
	{
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000446")]
	[Address(RVA = "0x30CF40", Offset = "0x30B940", VA = "0x18030CF40")]
	public static void TryInteract(int objectId)
	{
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000447")]
	[Address(RVA = "0x30CDC0", Offset = "0x30B7C0", VA = "0x18030CDC0")]
	public static void TryDropItem(int itemId, int objectId, int ammo)
	{
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000448")]
	[Address(RVA = "0x30BF30", Offset = "0x30A930", VA = "0x18030BF30")]
	public static void SendActiveItem(int itemId)
	{
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000449")]
	[Address(RVA = "0x30D080", Offset = "0x30BA80", VA = "0x18030D080")]
	public static void UseItem(int itemId, Vector3 dir)
	{
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044A")]
	[Address(RVA = "0x30CC80", Offset = "0x30B680", VA = "0x18030CC80")]
	public static void TryBuyItem(int itemId)
	{
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044B")]
	[Address(RVA = "0x30C2F0", Offset = "0x30ACF0", VA = "0x18030C2F0")]
	public static void SendProximityVoice(int compressedWritten, byte[] data)
	{
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044C")]
	[Address(RVA = "0x30D1F0", Offset = "0x30BBF0", VA = "0x18030D1F0")]
	public static void VoiceChatOnOrOff(bool on)
	{
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044D")]
	[Address(RVA = "0x30C450", Offset = "0x30AE50", VA = "0x18030C450")]
	public static void SendSpectating(ulong watchingId)
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044E")]
	[Address(RVA = "0x30BCF0", Offset = "0x30A6F0", VA = "0x18030BCF0")]
	public static void RequestFreezeTime()
	{
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044F")]
	[Address(RVA = "0x30A730", Offset = "0x309130", VA = "0x18030A730")]
	public static void GameModeLoaded()
	{
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000450")]
	[Address(RVA = "0x30B900", Offset = "0x30A300", VA = "0x18030B900")]
	public static void PressButton(int buttonId)
	{
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000451")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ClientSend()
	{
	}

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x0")]
	public static int packetsSent;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x4")]
	public static int bytesSent;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x8")]
	private static int TCPvariant;

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0xC")]
	private static int UDPVariant;
}
