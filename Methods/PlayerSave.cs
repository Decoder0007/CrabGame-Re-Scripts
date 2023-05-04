using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class PlayerSave
{
	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06004F0E RID: 20238 RVA: 0x00002070 File Offset: 0x00000270
	// (set) Token: 0x06004F0F RID: 20239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004B")]
	public int volume
	{
		[Token(Token = "0x6004F0E")]
		[Address(RVA = "0x668FD0", Offset = "0x667DD0", VA = "0x180668FD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6004F0F")]
		[Address(RVA = "0x105F810", Offset = "0x105E610", VA = "0x18105F810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		set
		{
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06004F10 RID: 20240 RVA: 0x00002070 File Offset: 0x00000270
	// (set) Token: 0x06004F11 RID: 20241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004C")]
	public int music
	{
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x668F40", Offset = "0x667D40", VA = "0x180668F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6004F11")]
		[Address(RVA = "0x105F7F0", Offset = "0x105E5F0", VA = "0x18105F7F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		set
		{
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06004F12 RID: 20242 RVA: 0x00002070 File Offset: 0x00000270
	// (set) Token: 0x06004F13 RID: 20243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004D")]
	public int voip
	{
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x105F7E0", Offset = "0x105E5E0", VA = "0x18105F7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6004F13")]
		[Address(RVA = "0x105F800", Offset = "0x105E600", VA = "0x18105F800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
		set
		{
		}
	}

	// Token: 0x06004F14 RID: 20244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004F14")]
	[Address(RVA = "0x105F2F0", Offset = "0x105E0F0", VA = "0x18105F2F0")]
	public void OpenCrate(ႤႥ႙Ⴃ႙\u109FႡႥႢႨႠ.\u109A\u109AႤ\u109FႠ႙\u109D\u109E\u109EႡ\u109E item)
	{
	}

	// Token: 0x06004F15 RID: 20245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004F15")]
	[Address(RVA = "0x105F2B0", Offset = "0x105E0B0", VA = "0x18105F2B0")]
	public void AddQuestProgress(float p)
	{
	}

	// Token: 0x06004F16 RID: 20246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004F16")]
	[Address(RVA = "0x105F670", Offset = "0x105E470", VA = "0x18105F670")]
	public PlayerSave()
	{
	}

	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x10")]
	public bool cameraShake;

	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x14")]
	public int fov;

	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x18")]
	public float sensMultiplier;

	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x1C")]
	public int inputDelay;

	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x20")]
	public bool invertedMouseHor;

	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x21")]
	public bool invertedMouseVert;

	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x22")]
	public bool grass;

	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x23")]
	public bool tutorial;

	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x24")]
	public bool holdCrouch;

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x25")]
	public bool firstTimeOpeningGame;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x26")]
	public bool updateShown;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x27")]
	public bool chatEnabled;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x28")]
	public bool streamerMode;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x2C")]
	public int forward;

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x30")]
	public int backwards;

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x34")]
	public int left;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x38")]
	public int right;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x3C")]
	public int jump;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x40")]
	public int crouch;

	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x44")]
	public int sprint;

	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x48")]
	public int interact;

	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x4C")]
	public int inventory;

	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x50")]
	public int drop;

	// Token: 0x040008F8 RID: 2296
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x54")]
	public int map;

	// Token: 0x040008F9 RID: 2297
	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x58")]
	public int leftClick;

	// Token: 0x040008FA RID: 2298
	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x5C")]
	public int rightClick;

	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x60")]
	public int inventory1;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x64")]
	public int inventory2;

	// Token: 0x040008FD RID: 2301
	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x68")]
	public int inventory3;

	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x6C")]
	public int inventory4;

	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x70")]
	public int inventory5;

	// Token: 0x04000900 RID: 2304
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x74")]
	public int inventory6;

	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x78")]
	public int inventory7;

	// Token: 0x04000902 RID: 2306
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x7C")]
	public int inventory8;

	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x80")]
	public int voipKey;

	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x84")]
	public int shadowQuality;

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x88")]
	public int shadowResolution;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x8C")]
	public int shadowDistance;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x90")]
	public int shadowCascade;

	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x94")]
	public int textureQuality;

	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x98")]
	public int antiAliasing;

	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x9C")]
	public bool softParticles;

	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0xA0")]
	public int bloom;

	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0xA4")]
	public bool motionBlur;

	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0xA5")]
	public bool ambientOcclusion;

	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0xA8")]
	public Vector2 resolution;

	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0xB0")]
	public int refreshRate;

	// Token: 0x04000910 RID: 2320
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0xB4")]
	public bool fullscreen;

	// Token: 0x04000911 RID: 2321
	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0xB8")]
	public int fullscreenMode;

	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0xBC")]
	public int vSync;

	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0xC0")]
	public int fpsLimit;

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private int <volume>k__BackingField;

	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private int <music>k__BackingField;

	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0xCC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C0", Offset = "0x376C0")]
	private int <voip>k__BackingField;

	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0xD0")]
	public int micSetting;

	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0xD4")]
	public int deaf;

	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0xD8")]
	public int hairDefId;

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0xDC")]
	public int faceDefId;

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0xE0")]
	public int hatDefId;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0xE4")]
	public int shoesDefId;

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0xE8")]
	public int topDefId;

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0xEC")]
	public int backpackDefId;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0xF0")]
	public ulong hair;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0xF8")]
	public ulong face;

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x100")]
	public ulong hat;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x108")]
	public ulong shoes;

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x110")]
	public ulong top;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x118")]
	public ulong backpack;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0x120")]
	public ulong cratesOpened;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x128")]
	public ulong commons;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x130")]
	public ulong uncommons;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x138")]
	public ulong rares;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x140")]
	public ulong extraordinarys;

	// Token: 0x0400092A RID: 2346
	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x148")]
	public ulong legendarys;

	// Token: 0x0400092B RID: 2347
	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x150")]
	public ulong commonsC;

	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0x158")]
	public ulong uncommonsC;

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	[FieldOffset(Offset = "0x160")]
	public ulong raresC;

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0x168")]
	public ulong legendarysC;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0x170")]
	public ulong shinys;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0x178")]
	public int questsComplete;

	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0x17C")]
	public int currentQuest;

	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0x180")]
	public float questProgress;

	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000933")]
	[FieldOffset(Offset = "0x188")]
	public DateTime nextQuestAvailableTime;

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x190")]
	public bool isQuestComplete;
}
