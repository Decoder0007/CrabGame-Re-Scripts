using System;
using Il2CppDummyDll;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
public enum ServerPackets
{
	// Token: 0x04000405 RID: 1029
	[Token(Token = "0x4000405")]
	welcome = 1,
	// Token: 0x04000406 RID: 1030
	[Token(Token = "0x4000406")]
	sendMessage,
	// Token: 0x04000407 RID: 1031
	[Token(Token = "0x4000407")]
	pingPong,
	// Token: 0x04000408 RID: 1032
	[Token(Token = "0x4000408")]
	lobbyVisualsChangeColor,
	// Token: 0x04000409 RID: 1033
	[Token(Token = "0x4000409")]
	lobbyMapUpdate,
	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x400040A")]
	lobbySettingsUpdate,
	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x400040B")]
	lobbyStart,
	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	lobbyClosed,
	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	loadMap,
	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	loadingState,
	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	loadingSendIntoGame,
	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x4000410")]
	gameStart,
	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x4000411")]
	sendToLobby,
	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	gameSpawnPlayer,
	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000413")]
	spectatorSpawn,
	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x4000414")]
	allReadyPlayers,
	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000415")]
	gameStartedCooldown,
	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000416")]
	freezePlayers,
	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000417")]
	playerPosition,
	// Token: 0x04000418 RID: 1048
	[Token(Token = "0x4000418")]
	playerRotation,
	// Token: 0x04000419 RID: 1049
	[Token(Token = "0x4000419")]
	voiceData,
	// Token: 0x0400041A RID: 1050
	[Token(Token = "0x400041A")]
	playerAnimation,
	// Token: 0x0400041B RID: 1051
	[Token(Token = "0x400041B")]
	physicsObjectSnapshot,
	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x400041C")]
	syncObject,
	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	interact,
	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	dropItem,
	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	forceGiveItem,
	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	forceRemoveItem,
	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	dropMoney,
	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	playerActiveItem,
	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x4000423")]
	useItem,
	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x4000424")]
	moneyUpdate,
	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	damagePlayer,
	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	playerDied,
	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	respawnPlayer,
	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	playerReload,
	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	punchPlayer,
	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	ping,
	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	waitingReady,
	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	gameModeTimer,
	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	gameOver,
	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	playerPings,
	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	syncClock,
	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	redLight,
	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	glassPieces,
	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	tagPlayer,
	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	makeSeeker,
	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	makeBomberman,
	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	toggleLights,
	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	strobeLights,
	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	sendWinner,
	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	gameModeAlert,
	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000439")]
	spectatingWho,
	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x400043A")]
	gameModeState,
	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x400043B")]
	sendPieces,
	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x400043C")]
	pieceFall,
	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	kingScores,
	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	tileTeams,
	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	tileUpdates,
	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	giveHat,
	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	hatScores,
	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	spawnBoulder,
	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	buttonModeState,
	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	buttonPressed,
	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	buttonSetNextPlayer
}
