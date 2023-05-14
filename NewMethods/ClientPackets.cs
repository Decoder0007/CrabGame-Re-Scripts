using System;
using Il2CppDummyDll;

// Token: 0x02000123 RID: 291
[Token(Token = "0x2000123")]
public enum ClientPackets
{
	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	handShake,
	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	welcomeReceived,
	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	sendMessage,
	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	pingPong,
	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	ping,
	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	sendClientPing,
	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x4000726")]
	requestLoadMap,
	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x4000727")]
	lobbyVisualsChangeColor,
	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x4000728")]
	startedLoading,
	// Token: 0x04000729 RID: 1833
	[Token(Token = "0x4000729")]
	loadingRequestEnterGame,
	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	gameRequestAllPlayers,
	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	gameRequestToSpawn,
	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	gameStartedCooldown,
	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	playerPosition,
	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	playerRotation,
	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	voiceData,
	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	playerAnimation,
	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	physicsObjectSnapshot,
	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	syncObject,
	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	tryInteract,
	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	tryDropItem,
	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	sendActiveItem,
	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	useItem,
	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	buyItem,
	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x4000738")]
	damagePlayer,
	// Token: 0x04000739 RID: 1849
	[Token(Token = "0x4000739")]
	playerDied,
	// Token: 0x0400073A RID: 1850
	[Token(Token = "0x400073A")]
	playerReload,
	// Token: 0x0400073B RID: 1851
	[Token(Token = "0x400073B")]
	punchPlayer,
	// Token: 0x0400073C RID: 1852
	[Token(Token = "0x400073C")]
	getFreezeTime,
	// Token: 0x0400073D RID: 1853
	[Token(Token = "0x400073D")]
	voiceOnOrOff,
	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	spectatingWho,
	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	gameModeLoaded,
	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	buttonPressed,
	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	sendSerializedInventory,
	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	sendSerializedDrop,
	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	sendItemDrop,
	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	damageCrab
}
