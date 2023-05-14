using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x20000C5")]
public class PlayerServerCommunication : MonoBehaviour
{
	// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x3CDFA0", Offset = "0x3CC9A0", VA = "0x1803CDFA0")]
	private void Awake()
	{
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x3CEB10", Offset = "0x3CD510", VA = "0x1803CEB10")]
	private void Start()
	{
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x3CE1D0", Offset = "0x3CCBD0", VA = "0x1803CE1D0")]
	private void CrouchUpdate()
	{
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600049A")]
	[Address(RVA = "0x3CE5A0", Offset = "0x3CCFA0", VA = "0x1803CE5A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x101CC0", Offset = "0x1010C0")]
	private IEnumerator PositionUpdate(float repeatRate, PlayerServerCommunication.RenderDistance distance)
	{
		return null;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600049B")]
	[Address(RVA = "0x3CE630", Offset = "0x3CD030", VA = "0x1803CE630")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x101D10", Offset = "0x101110")]
	private IEnumerator RotationUpdate(float repeatRate, PlayerServerCommunication.RenderDistance distance)
	{
		return null;
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049C")]
	[Address(RVA = "0x3CE390", Offset = "0x3CCD90", VA = "0x1803CE390")]
	public void ForceMovementUpdate()
	{
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x3CEB60", Offset = "0x3CD560", VA = "0x1803CEB60")]
	private void UpdateDistanceLists()
	{
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x3CE6C0", Offset = "0x3CD0C0", VA = "0x1803CE6C0")]
	private void SendPositionToAll(Vector3 pos, PlayerServerCommunication.RenderDistance distance)
	{
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049F")]
	[Address(RVA = "0x3CE8C0", Offset = "0x3CD2C0", VA = "0x1803CE8C0")]
	private void SendRotationToAll(float rotX, float rotY, PlayerServerCommunication.RenderDistance distance)
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x3CF180", Offset = "0x3CDB80", VA = "0x1803CF180")]
	public PlayerServerCommunication()
	{
	}

	// Token: 0x040003D7 RID: 983
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x18")]
	public Transform root;

	// Token: 0x040003D8 RID: 984
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x20")]
	public Transform cam;

	// Token: 0x040003D9 RID: 985
	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x28")]
	private int lastSentHp;

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x2C")]
	private float hpThreshold;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x30")]
	private float posThreshold;

	// Token: 0x040003DC RID: 988
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x34")]
	private float rotThreshold;

	// Token: 0x040003DD RID: 989
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastSentPosition;

	// Token: 0x040003DE RID: 990
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x44")]
	private float lastSentRotationY;

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x48")]
	private float lastSentRotationX;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x4C")]
	private float lastSentXZ;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x50")]
	private float lastSentBlendX;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x54")]
	private float lastSentBlendY;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float posUpdatesPerSecondClose;

	// Token: 0x040003E4 RID: 996
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x4")]
	public static readonly float posUpdatesPerSecondMedium;

	// Token: 0x040003E5 RID: 997
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x8")]
	public static readonly float posUpdatesPerSecondFar;

	// Token: 0x040003E6 RID: 998
	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0xC")]
	public static readonly float rotUpdatesPerSecondClose;

	// Token: 0x040003E7 RID: 999
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x10")]
	public static readonly float rotUpdatesPerSecondMedium;

	// Token: 0x040003E8 RID: 1000
	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x14")]
	public static readonly float rotUpdatesPerSecondFar;

	// Token: 0x040003E9 RID: 1001
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x18")]
	public static float posUpdateFrequencyClose;

	// Token: 0x040003EA RID: 1002
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x1C")]
	public static float posUpdateFrequencyMedium;

	// Token: 0x040003EB RID: 1003
	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x20")]
	public static float posUpdateFrequencyFar;

	// Token: 0x040003EC RID: 1004
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x24")]
	public static float rotUpdateFrequencyClose;

	// Token: 0x040003ED RID: 1005
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x28")]
	public static float rotUpdateFrequencyMedium;

	// Token: 0x040003EE RID: 1006
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x2C")]
	public static float rotUpdateFrequencyFar;

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x58")]
	private float closeDistance;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x5C")]
	private float mediumDistance;

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x60")]
	private float farDistance;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x64")]
	private float updateDistRate;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x30")]
	public static PlayerServerCommunication Instance;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x68")]
	private bool lastSentCrouching;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x70")]
	public Dictionary<ulong, PlayerServerCommunication.RenderDistance> idToDistance;

	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	public enum RenderDistance
	{
		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		Close,
		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		Medium,
		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		Far
	}

	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <PositionUpdate>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <PositionUpdate>d__33(int <>1__state)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2FCFF0", Offset = "0x2FB9F0", VA = "0x1802FCFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001F")]
		private object Current
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2FD1C0", Offset = "0x2FBBC0", VA = "0x1802FD1C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000020")]
		private object Current
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x20")]
		public float repeatRate;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x28")]
		public PlayerServerCommunication <>4__this;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x30")]
		public PlayerServerCommunication.RenderDistance distance;
	}

	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <RotationUpdate>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <RotationUpdate>d__34(int <>1__state)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2FD520", Offset = "0x2FBF20", VA = "0x1802FD520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000021")]
		private object Current
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2FD6F0", Offset = "0x2FC0F0", VA = "0x1802FD6F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000022")]
		private object Current
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x20")]
		public float repeatRate;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x28")]
		public PlayerServerCommunication <>4__this;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x30")]
		public PlayerServerCommunication.RenderDistance distance;
	}
}
