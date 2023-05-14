using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200013F RID: 319
[Token(Token = "0x200013F")]
public class Transition : MonoBehaviour
{
	// Token: 0x060007EC RID: 2028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x2FC3B0", Offset = "0x2FADB0", VA = "0x1802FC3B0")]
	private void Awake()
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x2FC5C0", Offset = "0x2FAFC0", VA = "0x1802FC5C0")]
	public void StartTransition(float fadeTime = 1f, [Optional] Transition.TransitionCallback function)
	{
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x2FC540", Offset = "0x2FAF40", VA = "0x1802FC540")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1021D0", Offset = "0x1015D0")]
	private IEnumerator InvokeCallback(float time)
	{
		return null;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void TransitionDone()
	{
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public Transition()
	{
	}

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transition.TransitionCallback callbackFunction;

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage overlay;

	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Transition Instance;

	// Token: 0x04000739 RID: 1849
	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float currentTime;

	// Token: 0x0400073A RID: 1850
	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float transitionTime;

	// Token: 0x02000140 RID: 320
	// (Invoke) Token: 0x060007F2 RID: 2034
	[Token(Token = "0x2000140")]
	public delegate void TransitionCallback();

	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <InvokeCallback>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <InvokeCallback>d__8(int <>1__state)
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2FCAC0", Offset = "0x2FB4C0", VA = "0x1802FCAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700004A")]
		private object Current
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2FCBB0", Offset = "0x2FB5B0", VA = "0x1802FCBB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700004B")]
		private object Current
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transition <>4__this;
	}
}
