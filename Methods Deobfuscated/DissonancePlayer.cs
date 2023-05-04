using System;
using Dissonance;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
public class DissonancePlayer : MonoBehaviour, IDissonancePlayer
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000065 RID: 101 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x17000002")]
	public string PlayerId
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2B1250", Offset = "0x2AFC50", VA = "0x1802B1250", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000066 RID: 102 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000003")]
	public Vector3 Position
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x316570", Offset = "0x314F70", VA = "0x180316570", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000067 RID: 103 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x17000004")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x316630", Offset = "0x315030", VA = "0x180316630", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000068 RID: 104 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x17000005")]
	public NetworkPlayerType Type
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3166E0", Offset = "0x3150E0", VA = "0x1803166E0", Slot = "7")]
		get
		{
			return default(NetworkPlayerType);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000069 RID: 105 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x17000006")]
	public bool IsTracking
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x316560", Offset = "0x314F60", VA = "0x180316560", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	public void OnEnable()
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x316170", Offset = "0x314B70", VA = "0x180316170")]
	public void OnDisable()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x316360", Offset = "0x314D60", VA = "0x180316360")]
	public void Setup(bool isLocal, [Attribute(Name = "NotNullAttribute", RVA = "0xDC390", Offset = "0xDB790")] string newPlayerId)
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x316200", Offset = "0x314C00", VA = "0x180316200")]
	private void SetSphereRadius()
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x316530", Offset = "0x314F30", VA = "0x180316530")]
	public DissonancePlayer()
	{
	}

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x18")]
	public bool local;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x19")]
	private bool isTracking;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x1A")]
	private bool isLocal;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x20")]
	private string playerId;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x28")]
	public Transform orientation;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x30")]
	public PlayerManager pm;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x38")]
	public SphereCollider sphereCollider;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x40")]
	private DissonanceComms comms;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x48")]
	private float maxRadius;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x4C")]
	private float minRadius;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x50")]
	private int maxPlayers;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x54")]
	private int minPlayers;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x58")]
	private int currentPlayers;
}
