using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000AB RID: 171
[Token(Token = "0x20000AB")]
public class LoadingScreen : MonoBehaviour
{
	// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x321A90", Offset = "0x320490", VA = "0x180321A90")]
	private void Start()
	{
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x3218D0", Offset = "0x3202D0", VA = "0x1803218D0")]
	public void MainMenu()
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x321840", Offset = "0x320240", VA = "0x180321840")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x101BD0", Offset = "0x100FD0")]
	private IEnumerator LoadSceneAsync(string sceneName)
	{
		return null;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x321810", Offset = "0x320210", VA = "0x180321810")]
	private void AllowSceneActivation()
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x321EA0", Offset = "0x3208A0", VA = "0x180321EA0")]
	private void Update()
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x321D30", Offset = "0x320730", VA = "0x180321D30")]
	private void UpdateProgressText(AsyncOperation AO)
	{
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x321980", Offset = "0x320380", VA = "0x180321980")]
	private void RequestEnterGame()
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public LoadingScreen()
	{
	}

	// Token: 0x0400030E RID: 782
	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI progressText;

	// Token: 0x0400030F RID: 783
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x20")]
	private ulong[] assets;

	// Token: 0x04000310 RID: 784
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x28")]
	private ulong mapId;

	// Token: 0x04000311 RID: 785
	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x30")]
	private MyTimer timer;

	// Token: 0x04000312 RID: 786
	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x0")]
	public static bool timerDone;

	// Token: 0x04000313 RID: 787
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x38")]
	public RawImage backgroundImage;

	// Token: 0x04000314 RID: 788
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI mapName;

	// Token: 0x04000315 RID: 789
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI gameMode;

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI gameModeDescription;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x58")]
	private AsyncOperation AO;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x60")]
	private int joinAttempts;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x1")]
	public static bool waitingForServer;

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x4")]
	public static LoadingScreen.LoadingScreenState loadingState;

	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public enum LoadingScreenState
	{
		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		Loading,
		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		WaitingForHost,
		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		WaitingForPlayers,
		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		Joining
	}

	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <LoadSceneAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <LoadSceneAsync>d__12(int <>1__state)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2FCBF0", Offset = "0x2FB5F0", VA = "0x1802FCBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000015")]
		private object Current
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2FCFB0", Offset = "0x2FB9B0", VA = "0x1802FCFB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000016")]
		private object Current
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x20")]
		public LoadingScreen <>4__this;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x28")]
		public string sceneName;
	}
}
