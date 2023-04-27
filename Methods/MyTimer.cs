using System;
using Il2CppDummyDll;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class MyTimer
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600055F RID: 1375 RVA: 0x00002838 File Offset: 0x00000A38
	// (set) Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000023")]
	public float currentTime
	{
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x32C310", Offset = "0x32AD10", VA = "0x18032C310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x32C320", Offset = "0x32AD20", VA = "0x18032C320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000561 RID: 1377 RVA: 0x00002850 File Offset: 0x00000A50
	// (set) Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000024")]
	public float totalTime
	{
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x225F00", Offset = "0x224900", VA = "0x180225F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x225F60", Offset = "0x224960", VA = "0x180225F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x32C2A0", Offset = "0x32ACA0", VA = "0x18032C2A0")]
	public bool UpdateTimer()
	{
		return default(bool);
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x32C250", Offset = "0x32AC50", VA = "0x18032C250")]
	public int GetSeconds()
	{
		return 0;
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x32C260", Offset = "0x32AC60", VA = "0x18032C260")]
	public void SetTimer(float time)
	{
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x32C290", Offset = "0x32AC90", VA = "0x18032C290")]
	public void StopTimer()
	{
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x2F51B0", Offset = "0x2F3BB0", VA = "0x1802F51B0")]
	public bool IsRunning()
	{
		return default(bool);
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000568")]
	[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
	public MyTimer()
	{
	}

	// Token: 0x04000488 RID: 1160
	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <currentTime>k__BackingField;

	// Token: 0x04000489 RID: 1161
	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <totalTime>k__BackingField;

	// Token: 0x0400048A RID: 1162
	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x18")]
	private bool running;
}
