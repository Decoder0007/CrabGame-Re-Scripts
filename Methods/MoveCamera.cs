using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E7 RID: 231
[Token(Token = "0x20000E7")]
public class MoveCamera : MonoBehaviour
{
	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000026")]
	public static MoveCamera Instance
	{
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x32B0C0", Offset = "0x329AC0", VA = "0x18032B0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x32B110", Offset = "0x329B10", VA = "0x18032B110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x328B90", Offset = "0x327590", VA = "0x180328B90")]
	private void Awake()
	{
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x32AC50", Offset = "0x329650", VA = "0x18032AC50")]
	private void Start()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x328EA0", Offset = "0x3278A0", VA = "0x180328EA0")]
	private void LateUpdate()
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00002970 File Offset: 0x00000B70
	// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000027")]
	public MoveCamera.CameraState state
	{
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x32B100", Offset = "0x329B00", VA = "0x18032B100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return MoveCamera.CameraState.Player;
		}
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x32B160", Offset = "0x329B60", VA = "0x18032B160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x329B60", Offset = "0x328560", VA = "0x180329B60")]
	public void PlayerRespawn(Vector3 pos)
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x3299B0", Offset = "0x3283B0", VA = "0x1803299B0")]
	public void PlayerDied(Transform ragdoll)
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x32A9F0", Offset = "0x3293F0", VA = "0x18032A9F0")]
	public void StartSpectating()
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x329C10", Offset = "0x328610", VA = "0x180329C10")]
	private void SpectateCamera()
	{
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void FreeCam()
	{
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void FreeCamRotation()
	{
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x32A670", Offset = "0x329070", VA = "0x18032A670")]
	private void SpectateToggle(int dir)
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x329700", Offset = "0x328100", VA = "0x180329700")]
	private void PlayerDeathCamera()
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x329000", Offset = "0x327A00", VA = "0x180329000")]
	private void PlayerCamera()
	{
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x328ED0", Offset = "0x3278D0", VA = "0x180328ED0")]
	private void MoveGun()
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x32B070", Offset = "0x329A70", VA = "0x18032B070")]
	public void UpdateFov(float f)
	{
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x328CE0", Offset = "0x3276E0", VA = "0x180328CE0")]
	public void BobOnce(Vector3 bobDirection)
	{
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x32AEF0", Offset = "0x3298F0", VA = "0x18032AEF0")]
	private void UpdateBob()
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x328DE0", Offset = "0x3277E0", VA = "0x180328DE0")]
	private Vector3 ClampVector(Vector3 vec, float min, float max)
	{
		return default(Vector3);
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x32B0A0", Offset = "0x329AA0", VA = "0x18032B0A0")]
	public MoveCamera()
	{
	}

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x18")]
	public Transform player;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 offset;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 desyncOffset;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 vaultOffset;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x48")]
	private Camera cam;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rb;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x58")]
	public PlayerInput playerInput;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x60")]
	public Transform raycastCamera;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private static MoveCamera <Instance>k__BackingField;

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x68")]
	public bool cinematic;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x6C")]
	private float desiredTilt;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x70")]
	private float tilt;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private MoveCamera.CameraState <state>k__BackingField;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 desiredDeathPos;

	// Token: 0x040004E6 RID: 1254
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x88")]
	private Transform target;

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 desiredSpectateRotation;

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0xA0")]
	private Transform playerTarget;

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0xA8")]
	public LayerMask whatIsGround;

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0xAC")]
	private int spectatingId;

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0xB0")]
	private float yRotation;

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0xB4")]
	private float desiredX;

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 cameraRot;

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0xC8")]
	private ulong lastSentSpectatingId;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 desiredBob;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 bobOffset;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0xE8")]
	private float bobSpeed;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0xEC")]
	private float bobMultiplier;

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0xF0")]
	public Camera mainCam;

	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public enum CameraState
	{
		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		Player,
		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		PlayerDeath,
		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		Spectate,
		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		Freecam
	}
}
