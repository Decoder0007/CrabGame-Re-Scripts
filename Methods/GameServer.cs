using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class GameServer : MonoBehaviour
{
	// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE33840", Offset = "0xE32240", VA = "0x180E33840")]
	private void Awake()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE35480", Offset = "0xE33E80", VA = "0x180E35480")]
	public void QueueRespawn(ulong playerId, float respawnTime)
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000098")]
	[Address(RVA = "0xE35510", Offset = "0xE33F10", VA = "0x180E35510")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1016C0", Offset = "0x100AC0")]
	private IEnumerator RespawnPlayer(ulong playerId, float respawnTime)
	{
		return null;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE34FF0", Offset = "0xE339F0", VA = "0x180E34FF0")]
	public static void PlayerSpawnRequest(ulong fromClient, bool streamerMode)
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009A")]
	[Address(RVA = "0xE34DB0", Offset = "0xE337B0", VA = "0x180E34DB0")]
	public static void PlayerDied(ulong fromClient, ulong damageDoerId, Vector3 damageDir)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0xE33F40", Offset = "0xE32940", VA = "0x180E33F40")]
	public static void ForceGiveAllWeapon(int itemId)
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0xE34230", Offset = "0xE32C30", VA = "0x180E34230")]
	public static void ForceGiveWeapon(ulong toClient, int itemId, int objectId)
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009D")]
	[Address(RVA = "0xE34CE0", Offset = "0xE336E0", VA = "0x180E34CE0")]
	public static void ForceRemoveItem(ulong toClient, int objectId)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009E")]
	[Address(RVA = "0xE34930", Offset = "0xE33330", VA = "0x180E34930")]
	public static void ForceRemoveItemItemId(ulong toClient, int itemId)
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009F")]
	[Address(RVA = "0xE34610", Offset = "0xE33010", VA = "0x180E34610")]
	public static void ForceRemoveAllWeapons()
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xE33990", Offset = "0xE32390", VA = "0x180E33990")]
	public static void CheckHit(ulong fromClient, ulong hitClient, int itemID)
	{
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xE33CB0", Offset = "0xE326B0", VA = "0x180E33CB0")]
	public static void CheckPush(PlayerManager pusher, PlayerManager pushed)
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE353E0", Offset = "0xE33DE0", VA = "0x180E353E0")]
	public void PunchCooldown(Client c, float t)
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE33EC0", Offset = "0xE328C0", VA = "0x180E33EC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x101710", Offset = "0x100B10")]
	public IEnumerator CooldownPunch(Client c, float t)
	{
		return null;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public GameServer()
	{
	}

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x14D6")]
	public static GameServer Instance;

	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <RespawnPlayer>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <RespawnPlayer>d__3(int <>1__state)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2FD200", Offset = "0x2FBC00", VA = "0x1802FD200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000007")]
		private object Current
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2FD300", Offset = "0x2FBD00", VA = "0x1802FD300", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000008")]
		private object Current
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x20")]
		public float respawnTime;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		public ulong playerId;
	}

	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <CooldownPunch>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <CooldownPunch>d__14(int <>1__state)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2FC770", Offset = "0x2FB170", VA = "0x1802FC770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000009")]
		private object Current
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2FC820", Offset = "0x2FB220", VA = "0x1802FC820", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000A")]
		private object Current
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		public float t;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		public Client c;
	}
}
