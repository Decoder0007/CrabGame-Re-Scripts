using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
public class ServerSend : MonoBehaviour
{
	// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x3DE8C0", Offset = "0x3DD2C0", VA = "0x1803DE8C0")]
	private static void SendTCPData(ulong toClient, Packet packet)
	{
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x3DF200", Offset = "0x3DDC00", VA = "0x1803DF200")]
	private static void SendUDPData(ulong toClient, Packet packet)
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x3DE6F0", Offset = "0x3DD0F0", VA = "0x1803DE6F0")]
	private static void SendTCPDataToAll(Packet packet)
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x3DE520", Offset = "0x3DCF20", VA = "0x1803DE520")]
	private static void SendTCPDataToAll(ulong exceptClient, Packet packet)
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x3DF030", Offset = "0x3DDA30", VA = "0x1803DF030")]
	private static void SendUDPDataToAll(Packet packet)
	{
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x3DEE60", Offset = "0x3DD860", VA = "0x1803DEE60")]
	private static void SendUDPDataToAll(ulong exceptClient, Packet packet)
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x3DC1F0", Offset = "0x3DABF0", VA = "0x1803DC1F0")]
	public static void PingPong(ulong steamId)
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x3DC2D0", Offset = "0x3DACD0", VA = "0x1803DC2D0")]
	public static void Ping(ulong steamId, string timeStamp)
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x3DB940", Offset = "0x3DA340", VA = "0x1803DB940")]
	public static void LobbyClosed(ulong id, LobbyManager.LeaveCode leaveCode)
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x3DBA40", Offset = "0x3DA440", VA = "0x1803DBA40")]
	public static void LobbyMapUpdate(ulong workshopId, ulong toPlayer = 69UL)
	{
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x3DBC40", Offset = "0x3DA640", VA = "0x1803DBC40")]
	public static void LobbySettingsUpdate(GameSettings settings, ulong toPlayer = 69UL)
	{
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x3DA690", Offset = "0x3D9090", VA = "0x1803DA690")]
	public static void ChangeColor(ulong steamId, int colorId)
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x3DFA20", Offset = "0x3DE420", VA = "0x1803DFA20")]
	public static void StartLobby(List<ulong> assets)
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x3DFB70", Offset = "0x3DE570", VA = "0x1803DFB70")]
	public static void StartLobby(List<ulong> assets, ulong newPlayer)
	{
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x3DB450", Offset = "0x3D9E50", VA = "0x1803DB450")]
	public static void LoadMap(int mapId, int gameModeId, ulong toPlayer)
	{
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x3DB570", Offset = "0x3D9F70", VA = "0x1803DB570")]
	public static void LoadMap(int mapId, int gameModeId)
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x3DF950", Offset = "0x3DE350", VA = "0x1803DF950")]
	public static void StartGame()
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x3DED90", Offset = "0x3DD790", VA = "0x1803DED90")]
	public static void SendToLobby()
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x3DB150", Offset = "0x3D9B50", VA = "0x1803DB150")]
	public static void GameStartedCooldown(ulong toClient, float time)
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x3DAC10", Offset = "0x3D9610", VA = "0x1803DAC10")]
	public static void FreezePlayers(bool freeze)
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x3DB760", Offset = "0x3DA160", VA = "0x1803DB760")]
	public static void LoadingSendIntoGame(ulong steamId)
	{
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x3DB680", Offset = "0x3DA080", VA = "0x1803DB680")]
	public static void LoadingSendAllIntoGame(ulong steamId)
	{
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x3DB840", Offset = "0x3DA240", VA = "0x1803DB840")]
	public static void LoadingState(ulong steamId, LoadingScreen.LoadingScreenState state)
	{
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x3DAF20", Offset = "0x3D9920", VA = "0x1803DAF20")]
	public static void GameSpawnPlayer(ulong toClient, ulong spawnedClient, Vector3 spawnPos, int numberId, bool streamerMode)
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x3DC890", Offset = "0x3DB290", VA = "0x1803DC890")]
	public static void PlayerPosition(ulong fromClient, Vector3 position)
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050F")]
	[Address(RVA = "0x3DCAD0", Offset = "0x3DB4D0", VA = "0x1803DCAD0")]
	public static void PlayerRotation(ulong fromClient, float y, float x)
	{
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000510")]
	[Address(RVA = "0x3DC4D0", Offset = "0x3DAED0", VA = "0x1803DC4D0")]
	public static void PlayerAnimation(ulong fromClient, int animationType, bool state)
	{
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000511")]
	[Address(RVA = "0x3DC600", Offset = "0x3DB000", VA = "0x1803DC600")]
	public static void PlayerDamage(ulong fromClient, ulong hurtPlayer, int damage, Vector3 damageDir, int itemId)
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000512")]
	[Address(RVA = "0x3DC760", Offset = "0x3DB160", VA = "0x1803DC760")]
	public static void PlayerDied(ulong deadClient, ulong damageDoerId, Vector3 damageDir)
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000513")]
	[Address(RVA = "0x3DCE60", Offset = "0x3DB860", VA = "0x1803DCE60")]
	public static void RespawnPlayer(ulong deadClient, Vector3 spawnPos)
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x3DC9B0", Offset = "0x3DB3B0", VA = "0x1803DC9B0")]
	public static void PlayerReload(ulong fromClient, float time)
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x3DBF60", Offset = "0x3DA960", VA = "0x1803DBF60")]
	public static void PhysicsObjectSnapshot(ulong fromClient, int objectId, Vector3 position, Vector3 velocity, Vector3 angVelocity, Quaternion rotation)
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x3DFDD0", Offset = "0x3DE7D0", VA = "0x1803DFDD0")]
	public static void SyncObject(ulong fromClient, int objectId, bool exists)
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x3DCC00", Offset = "0x3DB600", VA = "0x1803DCC00")]
	public static void PunchPlayer(ulong fromClient, ulong punchedPlayer, Vector3 dir)
	{
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x3DB350", Offset = "0x3D9D50", VA = "0x1803DB350")]
	public static void Interact(ulong fromClient, int objectId)
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x3DA790", Offset = "0x3D9190", VA = "0x1803DA790")]
	public static void DropItem(ulong fromClient, int itemId, int objectId, int ammo)
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x3DA9F0", Offset = "0x3D93F0", VA = "0x1803DA9F0")]
	public static void ForceGiveItem(ulong toClient, int itemId, int objectId)
	{
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x3DAB10", Offset = "0x3D9510", VA = "0x1803DAB10")]
	public static void ForceRemoveItem(ulong toClient, int objectId)
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x3DA8D0", Offset = "0x3D92D0", VA = "0x1803DA8D0")]
	public static void DropMoney(ulong fromClient, int amount, int oId)
	{
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x3DC3D0", Offset = "0x3DADD0", VA = "0x1803DC3D0")]
	public static void PlayerActiveItem(ulong fromClient, int itemId)
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x3E00F0", Offset = "0x3DEAF0", VA = "0x1803E00F0")]
	public static void UseItem(ulong fromClient, int itemId, Vector3 dir)
	{
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x3DBE60", Offset = "0x3DA860", VA = "0x1803DBE60")]
	public static void MoneyUpdate(ulong playerId, int moneyAmount)
	{
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x3DDD90", Offset = "0x3DC790", VA = "0x1803DDD90")]
	public static void SendProximityVoice(ulong fromClient, int compressedWritten, byte[] voiceData)
	{
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000521")]
	[Address(RVA = "0x3DD070", Offset = "0x3DBA70", VA = "0x1803DD070")]
	public static void SendChatMessage(ulong fromClient, string msg)
	{
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x3DDB00", Offset = "0x3DC500", VA = "0x1803DDB00")]
	public static void SendPlayerPings(List<ValueTuple<ulong, int>> playerPings)
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x3DDC90", Offset = "0x3DC690", VA = "0x1803DDC90")]
	public static void SendPlayerReady(ulong fromClient, bool ready)
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x3DD2B0", Offset = "0x3DBCB0", VA = "0x1803DD2B0")]
	public static void SendGameModeTimer(ulong toClient, float freezeTime, int modeState)
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x3DD1A0", Offset = "0x3DBBA0", VA = "0x1803DD1A0")]
	public static void SendGameModeTimer(float freezeTime, int modeState)
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x3DAE00", Offset = "0x3D9800", VA = "0x1803DAE00")]
	public static void GameOver(ulong winnerId)
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x3DF2F0", Offset = "0x3DDCF0", VA = "0x1803DF2F0")]
	public static void SendWinner(ulong winnerId, ulong pricePool)
	{
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x3DF5E0", Offset = "0x3DDFE0", VA = "0x1803DF5E0")]
	public static void SpectatorSpawn(ulong fromClient)
	{
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x3DE330", Offset = "0x3DCD30", VA = "0x1803DE330")]
	public static void SendSpectatingWho(ulong toClient, ulong fromClient, ulong spectatingWho)
	{
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x3DF850", Offset = "0x3DE250", VA = "0x1803DF850")]
	public static void SpectatorSpawn(ulong toClient, ulong fromClient)
	{
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x3DDF60", Offset = "0x3DC960", VA = "0x1803DDF60")]
	public static void SendReadyPlayers(ulong fromClient)
	{
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x3DFCD0", Offset = "0x3DE6D0", VA = "0x1803DFCD0")]
	public static void SyncClock(ulong toClient, float time)
	{
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x3DCD30", Offset = "0x3DB730", VA = "0x1803DCD30")]
	public static void RedLight(ulong toId, bool redLight, float reactionTime)
	{
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x3DD3D0", Offset = "0x3DBDD0", VA = "0x1803DD3D0")]
	public static void SendGlassPieces(ulong toClient, List<int> pieces)
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x3DFF00", Offset = "0x3DE900", VA = "0x1803DFF00")]
	public static void TagPlayer(ulong taggerClient, ulong taggedClient)
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x3DBD60", Offset = "0x3DA760", VA = "0x1803DBD60")]
	public static void MakeSeeker(ulong seekerId, bool isSeeker)
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x3DF3F0", Offset = "0x3DDDF0", VA = "0x1803DF3F0")]
	public static void SetBomber(ulong tagger, ulong tagged)
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x3DB250", Offset = "0x3D9C50", VA = "0x1803DB250")]
	public static void GiveHat(ulong stealer, ulong stolenFrom)
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x3E0000", Offset = "0x3DEA00", VA = "0x1803E0000")]
	public static void ToggleLights(bool b)
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x3DE450", Offset = "0x3DCE50", VA = "0x1803DE450")]
	public static void SendStrobe()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x3DAD00", Offset = "0x3D9700", VA = "0x1803DAD00")]
	public static void GameModeAlert(ulong toClient, int i)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x3DD910", Offset = "0x3DC310", VA = "0x1803DD910")]
	public static void SendModeState(int state)
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x3DDA00", Offset = "0x3DC400", VA = "0x1803DDA00")]
	public static void SendPieces(ulong toClient, int pieces)
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x3DC100", Offset = "0x3DAB00", VA = "0x1803DC100")]
	public static void PieceFall(int pieceIndex)
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x3DD720", Offset = "0x3DC120", VA = "0x1803DD720")]
	public static void SendKingScores(List<ValueTuple<ulong, int>> allPlayerScores)
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x3DE9B0", Offset = "0x3DD3B0", VA = "0x1803DE9B0")]
	public static void SendTeams(List<ValueTuple<ulong, int>> teams)
	{
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x3DEBA0", Offset = "0x3DD5A0", VA = "0x1803DEBA0")]
	public static void SendTileUpdates(List<ValueTuple<int, int>> tiles)
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x3DD530", Offset = "0x3DBF30", VA = "0x1803DD530")]
	public static void SendHatScores(List<ValueTuple<ulong, int>> allPlayerScores)
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x3DF4F0", Offset = "0x3DDEF0", VA = "0x1803DF4F0")]
	public static void SpawnBoulder(int spawnPoint)
	{
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x3DCF80", Offset = "0x3DB980", VA = "0x1803DCF80")]
	public static void SendButtonState(GameModeButtons.ButtonModeState buttonState)
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x3DA490", Offset = "0x3D8E90", VA = "0x1803DA490")]
	public static void ButtonPressed(ulong playerId, int buttonId)
	{
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x3DA590", Offset = "0x3D8F90", VA = "0x1803DA590")]
	public static void ButtonSetNextPlayer(ulong playerId, ulong nextPlayerId)
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public ServerSend()
	{
	}

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x0")]
	private static int TCPvariant;

	// Token: 0x0400047A RID: 1146
	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x4")]
	private static int UDPVariant;
}
