using System;
using System.Text;
using Il2CppDummyDll;
using SteamworksNative;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0xDC390", Offset = "0xDB790")]
public class SteamManagerNative : MonoBehaviour
{
	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000770 RID: 1904 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x17000042")]
	protected static SteamManagerNative Instance
	{
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2EEB80", Offset = "0x2ED580", VA = "0x1802EEB80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000771 RID: 1905 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x17000043")]
	public static bool Initialized
	{
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2EEA00", Offset = "0x2ED400", VA = "0x1802EEA00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x2EE990", Offset = "0x2ED390", VA = "0x1802EE990")]
	[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x102030", Offset = "0x101430")]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x2EE6C0", Offset = "0x2ED0C0", VA = "0x1802EE6C0")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x102080", Offset = "0x101480")]
	private static void InitOnPlayMode()
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x2EE2A0", Offset = "0x2ECCA0", VA = "0x1802EE2A0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x2EE840", Offset = "0x2ED240", VA = "0x1802EE840", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x2EE740", Offset = "0x2ED140", VA = "0x1802EE740", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x2EE9F0", Offset = "0x2ED3F0", VA = "0x1802EE9F0", Slot = "7")]
	protected virtual void Update()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public SteamManagerNative()
	{
	}

	// Token: 0x040006D7 RID: 1751
	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x0")]
	protected static bool s_EverInitialized;

	// Token: 0x040006D8 RID: 1752
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x8")]
	protected static SteamManagerNative s_instance;

	// Token: 0x040006D9 RID: 1753
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x18")]
	protected bool m_bInitialized;

	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x20")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;
}
