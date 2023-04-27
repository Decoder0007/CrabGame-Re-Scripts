using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BE RID: 190
[Token(Token = "0x20000BE")]
[Attribute(Name = "RequireComponent", RVA = "0x101C70", Offset = "0x101070")]
public class PhysicsObject : MonoBehaviour
{
	// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x331DF0", Offset = "0x3307F0", VA = "0x180331DF0")]
	private void Start()
	{
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x331FE0", Offset = "0x3309E0", VA = "0x180331FE0")]
	private void SyncObject()
	{
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x331620", Offset = "0x330020", VA = "0x180331620")]
	private void SendSnapshot()
	{
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x3317F0", Offset = "0x3301F0", VA = "0x1803317F0")]
	public void SetSnapshot(Packet packet)
	{
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045F")]
	[Address(RVA = "0x331BC0", Offset = "0x3305C0", VA = "0x180331BC0")]
	private void SnapShotUpdate()
	{
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x331620", Offset = "0x330020", VA = "0x180331620")]
	private void SendSnapshots()
	{
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x3311F0", Offset = "0x32FBF0", VA = "0x1803311F0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x3311E0", Offset = "0x32FBE0", VA = "0x1803311E0")]
	private void GetReady()
	{
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x332090", Offset = "0x330A90", VA = "0x180332090")]
	public PhysicsObject()
	{
	}

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x18")]
	private SharedObject sharedObject;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rb;

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float updatesPerSecond;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x28")]
	private float updateFrequency;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 desiredVelocity;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 correctionVelocity;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 desiredPosition;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 correctionPosition;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion desiredRotation;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion correctionRotation;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 lastSentPosition;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 lastSentVelocity;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x94")]
	private Quaternion lastSentRotation;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0xA4")]
	private float positionThreshold;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0xA8")]
	private float rotationThreshold;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0xAC")]
	private float timeSinceLastSnapshot;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0xB0")]
	private LinkedList<PhysicsObject.SnapShot> positionHistory;

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0xB8")]
	private int snapshotsPerSecond;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0xBC")]
	private float snapshotSendRate;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0xC0")]
	private float damageThreshold;

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0xC4")]
	private bool ready;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject collideFx;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0xD0")]
	public ObjectHitSfx.SfxHitType hitFxType;

	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	private class SnapShot
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2ECA10", Offset = "0x2EB410", VA = "0x1802ECA10")]
		public SnapShot(Vector3 position, Vector3 velocity, Quaternion rotation)
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2EC970", Offset = "0x2EB370", VA = "0x1802EC970")]
		public static PhysicsObject.SnapShot GetNth(LinkedListNode<PhysicsObject.SnapShot> head, int index)
		{
			return null;
		}

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 velocity;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion rotation;
	}
}
