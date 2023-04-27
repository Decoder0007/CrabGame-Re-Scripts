using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000122 RID: 290
[Token(Token = "0x2000122")]
public class SteamManager : MonoBehaviour
{
	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000748 RID: 1864 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003D")]
	public string PlayerName
	{
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2B43B0", Offset = "0x2B2DB0", VA = "0x1802B43B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x0600074A RID: 1866 RVA: 0x00002E38 File Offset: 0x00001038
	// (set) Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003E")]
	public CSteamID PlayerSteamId
	{
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2B1250", Offset = "0x2AFC50", VA = "0x1802B1250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2F14C0", Offset = "0x2EFEC0", VA = "0x1802F14C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600074C RID: 1868 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x1700003F")]
	public string PlayerSteamIdString
	{
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2B1230", Offset = "0x2AFC30", VA = "0x1802B1230")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600074D RID: 1869 RVA: 0x00002E50 File Offset: 0x00001050
	// (set) Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000040")]
	public CSteamID lobbyOwnerSteamId
	{
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2F14A0", Offset = "0x2EFEA0", VA = "0x1802F14A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2F14D0", Offset = "0x2EFED0", VA = "0x1802F14D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600074F RID: 1871 RVA: 0x00002E68 File Offset: 0x00001068
	// (set) Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000041")]
	public bool LobbyPartnerDisconnected
	{
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2F1490", Offset = "0x2EFE90", VA = "0x1802F1490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2F14B0", Offset = "0x2EFEB0", VA = "0x1802F14B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000751")]
	[Address(RVA = "0x2EECB0", Offset = "0x2ED6B0", VA = "0x1802EECB0")]
	public void Awake()
	{
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x6000752")]
	[Address(RVA = "0x2F1240", Offset = "0x2EFC40", VA = "0x1802F1240")]
	public bool TryToReconnectToSteam()
	{
		return default(bool);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x6000753")]
	[Address(RVA = "0x2EF2E0", Offset = "0x2EDCE0", VA = "0x1802EF2E0")]
	public bool IsLobbyOwner()
	{
		return default(bool);
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x6000754")]
	[Address(RVA = "0x2EF1B0", Offset = "0x2EDBB0", VA = "0x1802EF1B0")]
	public bool ConnectedToSteam()
	{
		return default(bool);
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000755")]
	[Address(RVA = "0x2F1430", Offset = "0x2EFE30", VA = "0x1802F1430")]
	private void Update()
	{
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x2F0DD0", Offset = "0x2EF7D0", VA = "0x1802F0DD0")]
	private void Start()
	{
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x2EF9C0", Offset = "0x2EE3C0", VA = "0x1802EF9C0")]
	private void LobbyCreated(LobbyCreated_t lobbyCreatedT)
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x2F0250", Offset = "0x2EEC50", VA = "0x1802F0250")]
	private void LobbyGameCreated(LobbyGameCreated_t lobbyCreatedT)
	{
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x2EFB70", Offset = "0x2EE570", VA = "0x1802EFB70")]
	private void LobbyEnter(LobbyEnter_t lobbyEnterT)
	{
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075A")]
	[Address(RVA = "0x2F0CE0", Offset = "0x2EF6E0", VA = "0x1802F0CE0")]
	private void PlayerJoinOrLeave(LobbyChatUpdate_t lobbyChatUpdateT)
	{
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075B")]
	[Address(RVA = "0x2F0420", Offset = "0x2EEE20", VA = "0x1802F0420")]
	private void OnAcceptP2P(SteamNetworkingMessagesSessionRequest_t request)
	{
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x2F0490", Offset = "0x2EEE90", VA = "0x1802F0490")]
	private void OnFailedP2P(SteamNetworkingMessagesSessionFailed_t steamNetworkingMessagesSessionFailedT)
	{
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x2F02B0", Offset = "0x2EECB0", VA = "0x1802F02B0")]
	public void NewAcceptP2P(SteamNetworkingIdentity identity)
	{
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x2F0330", Offset = "0x2EED30", VA = "0x1802F0330")]
	public void NewAcceptP2P(CSteamID steamID)
	{
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x2F11B0", Offset = "0x2EFBB0", VA = "0x1802F11B0")]
	public void StopP2P(CSteamID steamID)
	{
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x2F0670", Offset = "0x2EF070", VA = "0x1802F0670")]
	private void OnJoinRequest(GameLobbyJoinRequested_t gameLobbyJoinRequestedT)
	{
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x2F0440", Offset = "0x2EEE40", VA = "0x1802F0440")]
	private void OnEnable()
	{
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x2EEFE0", Offset = "0x2ED9E0", VA = "0x1802EEFE0")]
	private void CheckConnections()
	{
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x2F0D60", Offset = "0x2EF760", VA = "0x1802F0D60")]
	public void StartLobby()
	{
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x2EF350", Offset = "0x2EDD50", VA = "0x1802EF350")]
	public void JoinLobby(CSteamID lobbyId)
	{
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x2F0790", Offset = "0x2EF190", VA = "0x1802F0790")]
	public void OtherLobbyMemberJoined(CSteamID lobbyId, CSteamID steamId)
	{
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000766")]
	[Address(RVA = "0x2F09B0", Offset = "0x2EF3B0", VA = "0x1802F09B0")]
	public void OtherLobbyMemberLeft(CSteamID steamId)
	{
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000767")]
	[Address(RVA = "0x2EF540", Offset = "0x2EDF40", VA = "0x1802EF540")]
	public void LeaveLobby()
	{
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x2EF1C0", Offset = "0x2EDBC0", VA = "0x1802EF1C0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x101FE0", Offset = "0x1013E0")]
	public Task<bool> CreateLobby(int lobbyParameters)
	{
		return null;
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x2F0780", Offset = "0x2EF180", VA = "0x1802F0780")]
	public void OpenFriendOverlayForGameInvite()
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076A")]
	[Address(RVA = "0x2F0750", Offset = "0x2EF150", VA = "0x1802F0750")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
	{
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076B")]
	[Address(RVA = "0x2F1350", Offset = "0x2EFD50", VA = "0x1802F1350")]
	public void UpdateRichPresenceStatus(string SceneName)
	{
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x2F1480", Offset = "0x2EFE80", VA = "0x1802F1480")]
	public SteamManager()
	{
	}

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x0")]
	public static SteamManager Instance;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x8")]
	public static uint gameAppId;

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private string <PlayerName>k__BackingField;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private CSteamID <PlayerSteamId>k__BackingField;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x28")]
	private string playerSteamIdString;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x30")]
	private bool connectedToSteam;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private CSteamID <lobbyOwnerSteamId>k__BackingField;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <LobbyPartnerDisconnected>k__BackingField;

	// Token: 0x040006CE RID: 1742
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x40")]
	public CSteamID currentLobby;

	// Token: 0x040006CF RID: 1743
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x48")]
	public CSteamID originalLobbyOwnerId;

	// Token: 0x040006D0 RID: 1744
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x50")]
	private bool applicationHasQuit;

	// Token: 0x040006D1 RID: 1745
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x51")]
	private bool daRealOne;

	// Token: 0x040006D2 RID: 1746
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x54")]
	private int nAccepted;

	// Token: 0x040006D3 RID: 1747
	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x58")]
	private float updateConnectionsRate;
}
