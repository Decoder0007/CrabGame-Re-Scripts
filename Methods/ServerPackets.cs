using System;
using Il2CppDummyDll;

// Token: 0x02000122 RID: 290
[Token(Token = "0x2000122")]
public enum ServerPackets
{
	// Token: 0x040006D1 RID: 1745
	[Token(Token = "0x40006D1")]
	welcome = 1,
	// Token: 0x040006D2 RID: 1746
	[Token(Token = "0x40006D2")]
	sendMessage,
	// Token: 0x040006D3 RID: 1747
	[Token(Token = "0x40006D3")]
	pingPong,
	// Token: 0x040006D4 RID: 1748
	[Token(Token = "0x40006D4")]
	lobbyVisualsChangeColor,
	// Token: 0x040006D5 RID: 1749
	[Token(Token = "0x40006D5")]
	lobbyMapUpdate,
	// Token: 0x040006D6 RID: 1750
	[Token(Token = "0x40006D6")]
	lobbySettingsUpdate,
	// Token: 0x040006D7 RID: 1751
	[Token(Token = "0x40006D7")]
	lobbyStart,
	// Token: 0x040006D8 RID: 1752
	[Token(Token = "0x40006D8")]
	lobbyClosed,
	// Token: 0x040006D9 RID: 1753
	[Token(Token = "0x40006D9")]
	loadMap,
	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x40006DA")]
	loadingState,
	// Token: 0x040006DB RID: 1755
	[Token(Token = "0x40006DB")]
	loadingSendIntoGame,
	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x40006DC")]
	requestCosmetics,
	// Token: 0x040006DD RID: 1757
	[Token(Token = "0x40006DD")]
	sendSerializedInventory,
	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x40006DE")]
	sendSerializedDrop,
	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x40006DF")]
	gameStart,
	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x40006E0")]
	sendToLobby,
	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x40006E1")]
	gameSpawnPlayer,
	// Token: 0x040006E2 RID: 1762
	[Token(Token = "0x40006E2")]
	spectatorSpawn,
	// Token: 0x040006E3 RID: 1763
	[Token(Token = "0x40006E3")]
	allReadyPlayers,
	// Token: 0x040006E4 RID: 1764
	[Token(Token = "0x40006E4")]
	gameStartedCooldown,
	// Token: 0x040006E5 RID: 1765
	[Token(Token = "0x40006E5")]
	freezePlayers,
	// Token: 0x040006E6 RID: 1766
	[Token(Token = "0x40006E6")]
	playerPosition,
	// Token: 0x040006E7 RID: 1767
	[Token(Token = "0x40006E7")]
	playerRotation,
	// Token: 0x040006E8 RID: 1768
	[Token(Token = "0x40006E8")]
	voiceData,
	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x40006E9")]
	playerAnimation,
	// Token: 0x040006EA RID: 1770
	[Token(Token = "0x40006EA")]
	physicsObjectSnapshot,
	// Token: 0x040006EB RID: 1771
	[Token(Token = "0x40006EB")]
	syncObject,
	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	interact,
	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	dropItem,
	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	forceGiveItem,
	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x40006EF")]
	forceRemoveItem,
	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x40006F0")]
	dropMoney,
	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x40006F1")]
	playerActiveItem,
	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x40006F2")]
	useItem,
	// Token: 0x040006F3 RID: 1779
	[Token(Token = "0x40006F3")]
	moneyUpdate,
	// Token: 0x040006F4 RID: 1780
	[Token(Token = "0x40006F4")]
	damagePlayer,
	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x40006F5")]
	playerDied,
	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x40006F6")]
	respawnPlayer,
	// Token: 0x040006F7 RID: 1783
	[Token(Token = "0x40006F7")]
	playerReload,
	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x40006F8")]
	punchPlayer,
	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	ping,
	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x40006FA")]
	waitingReady,
	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40006FB")]
	gameModeTimer,
	// Token: 0x040006FC RID: 1788
	[Token(Token = "0x40006FC")]
	gameOver,
	// Token: 0x040006FD RID: 1789
	[Token(Token = "0x40006FD")]
	playerPings,
	// Token: 0x040006FE RID: 1790
	[Token(Token = "0x40006FE")]
	syncClock,
	// Token: 0x040006FF RID: 1791
	[Token(Token = "0x40006FF")]
	redLight,
	// Token: 0x04000700 RID: 1792
	[Token(Token = "0x4000700")]
	glassPieces,
	// Token: 0x04000701 RID: 1793
	[Token(Token = "0x4000701")]
	tagPlayer,
	// Token: 0x04000702 RID: 1794
	[Token(Token = "0x4000702")]
	makeSeeker,
	// Token: 0x04000703 RID: 1795
	[Token(Token = "0x4000703")]
	makeBomberman,
	// Token: 0x04000704 RID: 1796
	[Token(Token = "0x4000704")]
	toggleLights,
	// Token: 0x04000705 RID: 1797
	[Token(Token = "0x4000705")]
	strobeLights,
	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	sendWinner,
	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	gameModeAlert,
	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	spectatingWho,
	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	gameModeState,
	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	sendPieces,
	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	pieceFall,
	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	kingScores,
	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	tileTeams,
	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	tileUpdates,
	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	giveHat,
	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	hatScores,
	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	spawnBoulder,
	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	buttonModeState,
	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x4000713")]
	buttonPressed,
	// Token: 0x04000714 RID: 1812
	[Token(Token = "0x4000714")]
	buttonSetNextPlayer,
	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	standoffUpdate,
	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x4000716")]
	standoffToggle,
	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x4000717")]
	fallingBlocks,
	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x4000718")]
	blockCrush,
	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x4000719")]
	playerReceievedDrop,
	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x400071A")]
	crabBall,
	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	crabDifficulty,
	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	crabHp,
	// Token: 0x0400071D RID: 1821
	[Token(Token = "0x400071D")]
	crabTarget,
	// Token: 0x0400071E RID: 1822
	[Token(Token = "0x400071E")]
	crabAnimation
}
