using System;
using Il2CppDummyDll;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000CB")]
public enum ClientPackets
{
	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	handShake,
	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	welcomeReceived,
	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	sendMessage,
	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	pingPong,
	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	ping,
	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	sendClientPing,
	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	lobbyVisualsChangeColor,
	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	startedLoading,
	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	loadingRequestEnterGame,
	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000450")]
	gameRequestAllPlayers,
	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	gameRequestToSpawn,
	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	gameStartedCooldown,
	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	playerPosition,
	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	playerRotation,
	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	voiceData,
	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	playerAnimation,
	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	physicsObjectSnapshot,
	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	syncObject,
	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000459")]
	tryInteract,
	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x400045A")]
	tryDropItem,
	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	sendActiveItem,
	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	useItem,
	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x400045D")]
	buyItem,
	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	damagePlayer,
	// Token: 0x0400045F RID: 1119
	[Token(Token = "0x400045F")]
	playerDied,
	// Token: 0x04000460 RID: 1120
	[Token(Token = "0x4000460")]
	playerReload,
	// Token: 0x04000461 RID: 1121
	[Token(Token = "0x4000461")]
	punchPlayer,
	// Token: 0x04000462 RID: 1122
	[Token(Token = "0x4000462")]
	getFreezeTime,
	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x4000463")]
	voiceOnOrOff,
	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000464")]
	spectatingWho,
	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000465")]
	gameModeLoaded,
	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x4000466")]
	buttonPressed
}
