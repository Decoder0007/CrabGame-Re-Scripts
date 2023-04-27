using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class zzTransparencyCapture
{
	// Token: 0x060007BC RID: 1980 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x2FF940", Offset = "0x2FE340", VA = "0x1802FF940")]
	public static Texture2D capture(Rect pRect)
	{
		return null;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x2FF600", Offset = "0x2FE000", VA = "0x1802FF600")]
	public static Texture2D captureScreenshot()
	{
		return null;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x2FF670", Offset = "0x2FE070", VA = "0x1802FF670")]
	public static void captureScreenshot(string pFileName)
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x2FFC70", Offset = "0x2FE670", VA = "0x1802FFC70")]
	private static Color getColor(Color pColorWhenBlack, Color pColorWhenWhite)
	{
		return default(Color);
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x2FFC60", Offset = "0x2FE660", VA = "0x1802FFC60")]
	private static float getAlpha(float pColorWhenZero, float pColorWhenOne)
	{
		return 0f;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x2FF870", Offset = "0x2FE270", VA = "0x1802FF870")]
	private static Texture2D captureView(Rect pRect)
	{
		return null;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
	public zzTransparencyCapture()
	{
	}
}
