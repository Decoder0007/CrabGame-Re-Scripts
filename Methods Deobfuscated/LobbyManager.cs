using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public class LobbyManager : MonoBehaviour
{
	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000393 RID: 915 RVA: 0x00002580 File Offset: 0x00000780
	// (set) Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000017")]
	public CSteamID currentLobby
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x323CA0", Offset = "0x3226A0", VA = "0x180323CA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000395 RID: 917 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000018")]
	public bool[] colorsTaken
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x27E000", Offset = "0x27CA00", VA = "0x18027E000")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x324310", Offset = "0x322D10", VA = "0x180324310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x322690", Offset = "0x321090", VA = "0x180322690")]
	private void Awake()
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x323670", Offset = "0x322070", VA = "0x180323670")]
	public void NewLobbySettings()
	{
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x322ED0", Offset = "0x3218D0", VA = "0x180322ED0")]
	private void InitLobby(CSteamID lobbyId)
	{
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x323CA0", Offset = "0x3226A0", VA = "0x180323CA0")]
	public void SetLobby(CSteamID lobbyId)
	{
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x3240C0", Offset = "0x322AC0", VA = "0x1803240C0")]
	public void StartNewLobby(CSteamID hostSteamId, CSteamID lobbyId)
	{
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x322110", Offset = "0x320B10", VA = "0x180322110")]
	public void AddPlayerToLobby(CSteamID steamId)
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x323920", Offset = "0x322320", VA = "0x180323920")]
	public void RemovePlayerFromLobby(CSteamID steamId)
	{
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x322E10", Offset = "0x321810", VA = "0x180322E10")]
	public int GetPlayerColorId(ulong steamId)
	{
		return 0;
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x324100", Offset = "0x322B00", VA = "0x180324100")]
	private void UpdateColor(int colorId, bool taken)
	{
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x322A00", Offset = "0x321400", VA = "0x180322A00")]
	public void ChangeColor(ulong steamId, int colorId)
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x322C80", Offset = "0x321680", VA = "0x180322C80")]
	private int FindAvailableLobbyId()
	{
		return 0;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x322C50", Offset = "0x321650", VA = "0x180322C50")]
	private int FindAvailableColorId()
	{
		return 0;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x322BA0", Offset = "0x3215A0", VA = "0x180322BA0")]
	public void CloseLobby()
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x323E30", Offset = "0x322830", VA = "0x180323E30")]
	public void StartLobby()
	{
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x323B10", Offset = "0x322510", VA = "0x180323B10")]
	private void SetLobbyMetaData()
	{
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000019")]
	public string serverName
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x324300", Offset = "0x322D00", VA = "0x180324300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x324320", Offset = "0x322D20", VA = "0x180324320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x323CB0", Offset = "0x3226B0", VA = "0x180323CB0")]
	public void SetServerName()
	{
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void SetServerVersion()
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x323740", Offset = "0x322140", VA = "0x180323740")]
	public void OnPlayerJoinLeaveUpdate(CSteamID steamId, bool joined)
	{
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x322CD0", Offset = "0x3216D0", VA = "0x180322CD0")]
	public Client GetClient(ulong steamId)
	{
		return null;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x323310", Offset = "0x321D10", VA = "0x180323310")]
	public void LobbyLoop()
	{
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x2B1230", Offset = "0x2AFC30", VA = "0x1802B1230")]
	public Client[] GetClients()
	{
		return null;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x323C20", Offset = "0x322620", VA = "0x180323C20")]
	private void SetLobbyType()
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x323BF0", Offset = "0x3225F0", VA = "0x180323BF0")]
	private void SetLobbySize()
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x3236D0", Offset = "0x3220D0", VA = "0x1803236D0")]
	public void NewMuteList()
	{
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x3231E0", Offset = "0x321BE0", VA = "0x1803231E0")]
	public void KickPlayer(ulong id)
	{
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x322860", Offset = "0x321260", VA = "0x180322860")]
	public void BanPlayer(ulong id)
	{
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x324260", Offset = "0x322C60", VA = "0x180324260")]
	public LobbyManager()
	{
	}

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private CSteamID <currentLobby>k__BackingField;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<ulong, int> steamIdToUID;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x20")]
	private ulong[] UIDToSteamId;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x28")]
	private Client[] clients;

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<ulong, PlayerInfo> lobbyPlayers;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool[] <colorsTaken>k__BackingField;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x38")]
	public bool started;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x40")]
	public List<ulong> assets;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x48")]
	public Map map;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x50")]
	public GameModeData gameMode;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x58")]
	public int nextRoundPlayers;

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x60")]
	public GameSettings gameSettings;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x68")]
	public LobbyManager.LobbyState state;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x70")]
	public GameState gameState;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x78")]
	public bool queueLobby;

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x80")]
	public LobbyUtility lobbyUtility;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x10")]
	public static LobbyManager Instance;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private string <serverName>k__BackingField;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x90")]
	public Dictionary<ulong, bool> mutedPlayers;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x18")]
	public static List<ulong> bannedPlayers;

	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public enum LeaveCode
	{
		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		ServerClosed,
		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		Kicked,
		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		Banned,
		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		LostConnection
	}

	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public enum LobbyState
	{
		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		Menu,
		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		Loading,
		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		PreGame,
		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		Started,
		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		GameOver
	}
}
