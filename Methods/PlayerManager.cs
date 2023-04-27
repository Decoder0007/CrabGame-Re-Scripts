using System;
using Dissonance;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;

// Token: 0x020000C4 RID: 196
[Token(Token = "0x20000C4")]
public class PlayerManager : MonoBehaviour
{
	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000486 RID: 1158 RVA: 0x000026B8 File Offset: 0x000008B8
	// (set) Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001C")]
	public int ping
	{
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x339F30", Offset = "0x338930", VA = "0x180339F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x339F60", Offset = "0x338960", VA = "0x180339F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000488 RID: 1160 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001D")]
	public OnlinePlayerMovement onlinePlayerMovement
	{
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x339F20", Offset = "0x338920", VA = "0x180339F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x339F50", Offset = "0x338950", VA = "0x180339F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x338D60", Offset = "0x337760", VA = "0x180338D60")]
	private void Awake()
	{
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x339420", Offset = "0x337E20", VA = "0x180339420")]
	public void SetPlayer(ulong steamId, int numberId, bool streamerMode)
	{
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x3397A0", Offset = "0x3381A0", VA = "0x1803397A0")]
	public void SetSpectator(ulong steamId)
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x3392E0", Offset = "0x337CE0", VA = "0x1803392E0")]
	public void SetColor(int colorId)
	{
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x338E20", Offset = "0x337820", VA = "0x180338E20")]
	public Quaternion GetRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600048F RID: 1167 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001E")]
	public Texture profileTexture
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x339F40", Offset = "0x338940", VA = "0x180339F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x339F70", Offset = "0x338970", VA = "0x180339F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x338F80", Offset = "0x337980", VA = "0x180338F80")]
	private void LoadAvatar()
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x339970", Offset = "0x338370", VA = "0x180339970")]
	public void SetVolume(float v)
	{
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x339120", Offset = "0x337B20", VA = "0x180339120")]
	public void Mute(bool b)
	{
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x3399B0", Offset = "0x3383B0", VA = "0x1803399B0")]
	public void UpdateForceMute()
	{
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x339C60", Offset = "0x338660", VA = "0x180339C60")]
	public void UpdateVcSettings()
	{
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public PlayerManager()
	{
	}

	// Token: 0x040003C1 RID: 961
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x18")]
	public CSteamID steamProfile;

	// Token: 0x040003C2 RID: 962
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x20")]
	public Renderer shirt;

	// Token: 0x040003C3 RID: 963
	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x28")]
	public Transform head;

	// Token: 0x040003C4 RID: 964
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x30")]
	public DisplayNameUI playerName;

	// Token: 0x040003C5 RID: 965
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x38")]
	public bool justDied;

	// Token: 0x040003C6 RID: 966
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x39")]
	public bool dead;

	// Token: 0x040003C7 RID: 967
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x3A")]
	public bool waitingReady;

	// Token: 0x040003C8 RID: 968
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x40")]
	public string username;

	// Token: 0x040003C9 RID: 969
	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x48")]
	public int colorId;

	// Token: 0x040003CA RID: 970
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <ping>k__BackingField;

	// Token: 0x040003CB RID: 971
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private OnlinePlayerMovement <onlinePlayerMovement>k__BackingField;

	// Token: 0x040003CC RID: 972
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x58")]
	public ItemHandle itemHandle;

	// Token: 0x040003CD RID: 973
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x60")]
	public PlayerCustomization playerCustomization;

	// Token: 0x040003CE RID: 974
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x68")]
	public GameObject pants;

	// Token: 0x040003CF RID: 975
	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x70")]
	public GameObject sweater;

	// Token: 0x040003D0 RID: 976
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x78")]
	public VoiceChatTransform vcTransform;

	// Token: 0x040003D1 RID: 977
	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x80")]
	public DissonancePlayer dissonancePlayer;

	// Token: 0x040003D2 RID: 978
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x88")]
	public VoiceBroadcastTrigger dissonanceConfig;

	// Token: 0x040003D3 RID: 979
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x90")]
	public bool streamerMode;

	// Token: 0x040003D4 RID: 980
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x94")]
	public int playerNumber;

	// Token: 0x040003D5 RID: 981
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private Texture <profileTexture>k__BackingField;

	// Token: 0x040003D6 RID: 982
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0xA0")]
	private bool forceMute;
}
