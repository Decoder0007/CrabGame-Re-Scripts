using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
public class GameManager : MonoBehaviour
{
	// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x31B0F0", Offset = "0x319AF0", VA = "0x18031B0F0")]
	private void Awake()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x31BEF0", Offset = "0x31A8F0", VA = "0x18031BEF0")]
	private void RequestSpawn()
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x31C930", Offset = "0x31B330", VA = "0x18031C930")]
	private void Start()
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x31C530", Offset = "0x31AF30", VA = "0x18031C530")]
	public void SpawnPlayer(ulong steamId, Vector3 position, int numberId, bool streamerMode)
	{
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x31C740", Offset = "0x31B140", VA = "0x18031C740")]
	public void SpawnSpectator(ulong steamId)
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Update()
	{
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x31BDA0", Offset = "0x31A7A0", VA = "0x18031BDA0")]
	public void RemovePlayer(ulong steamId)
	{
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x31B570", Offset = "0x319F70", VA = "0x18031B570")]
	private void OnPlayerSpawnOrDespawn(ulong playerId)
	{
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x31C350", Offset = "0x31AD50", VA = "0x18031C350")]
	public void SetPlayerPosition(Packet packet)
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x31C430", Offset = "0x31AE30", VA = "0x18031C430")]
	public void SetPlayerRotation(Packet packet)
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x31C250", Offset = "0x31AC50", VA = "0x18031C250")]
	public void SetPlayerAnimation(Packet packet)
	{
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x31B270", Offset = "0x319C70", VA = "0x18031B270")]
	public void DamagePlayer(Packet packet)
	{
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x31B670", Offset = "0x31A070", VA = "0x18031B670")]
	public void PlayerDied(ulong playerDiedId, ulong damageDoerId, Vector3 dir)
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x31C070", Offset = "0x31AA70", VA = "0x18031C070")]
	public void RespawnPlayer(ulong playerId, Vector3 pos)
	{
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x31B5A0", Offset = "0x319FA0", VA = "0x18031B5A0")]
	public void PhysicsObjectSnapshot(Packet packet)
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x31CAB0", Offset = "0x31B4B0", VA = "0x18031CAB0")]
	public void SyncObject(Packet packet)
	{
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x31BB60", Offset = "0x31A560", VA = "0x18031BB60")]
	public void PunchPlayer(ulong puncher, ulong punched, Vector3 dir)
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x31B3F0", Offset = "0x319DF0", VA = "0x18031B3F0")]
	public int GetPlayersAlive()
	{
		return 0;
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x31CA30", Offset = "0x31B430", VA = "0x18031CA30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x101B80", Offset = "0x100F80")]
	private IEnumerator StopPlayerVoip(PlayerManager pm, float stopTime)
	{
		return null;
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x31CB60", Offset = "0x31B560", VA = "0x18031CB60")]
	public GameManager()
	{
	}

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<ulong, PlayerManager> activePlayers;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<ulong, PlayerManager> spectators;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject onlinePlayer;

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject localPlayer;

	// Token: 0x040002EB RID: 747
	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject playerRagdoll;

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x40")]
	public GameObject explodedPlayer;

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x48")]
	public GameObject spectatorCamera;

	// Token: 0x040002EE RID: 750
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x50")]
	public GameObject spectatorPrefab;

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x58")]
	public bool hasReceivedPlayers;

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x59")]
	public bool hasSpawnedSelf;

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x5C")]
	public LayerMask whatIsGround;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x60")]
	public LayerMask whatIsHittableBullet;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x64")]
	public LayerMask whatIsHurtbox;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x68")]
	public LayerMask whatIsPlayer;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x70")]
	public GameMode gameMode;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x78")]
	public GameAudio gameAudio;

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x0")]
	public static GameManager Instance;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x80")]
	private GameObject spectatorObject;

	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private sealed class <StopPlayerVoip>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2FC860", Offset = "0x2FB260", VA = "0x1802FC860")]
		[DebuggerHidden]
		public <StopPlayerVoip>d__36(int <>1__state)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2FD870", Offset = "0x2FC270", VA = "0x1802FD870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000013")]
		private object Current
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2FD9B0", Offset = "0x2FC3B0", VA = "0x1802FD9B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000014")]
		private object Current
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x20")]
		public PlayerManager pm;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x28")]
		public float stopTime;
	}
}
