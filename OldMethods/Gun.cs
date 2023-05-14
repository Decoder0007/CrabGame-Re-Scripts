using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E1 RID: 225
[Token(Token = "0x20000E1")]
public class Gun : MonoBehaviour
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600057E RID: 1406 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000025")]
	public static Gun Instance
	{
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE376E0", Offset = "0xE360E0", VA = "0x180E376E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE37720", Offset = "0xE36120", VA = "0x180E37720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000580")]
	[Address(RVA = "0xE36D10", Offset = "0xE35710", VA = "0x180E36D10")]
	private void Start()
	{
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000581")]
	[Address(RVA = "0xE36FA0", Offset = "0xE359A0", VA = "0x180E36FA0")]
	private void Update()
	{
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000582")]
	[Address(RVA = "0xE36770", Offset = "0xE35170", VA = "0x180E36770")]
	private void Rotation(Vector2 offset)
	{
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000583")]
	[Address(RVA = "0xE36230", Offset = "0xE34C30", VA = "0x180E36230")]
	private void MovementBob()
	{
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000584")]
	[Address(RVA = "0xE36AB0", Offset = "0xE354B0", VA = "0x180E36AB0")]
	private void SpeedBob()
	{
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000585")]
	[Address(RVA = "0xE36490", Offset = "0xE34E90", VA = "0x180E36490")]
	private void RecoilGun()
	{
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000586")]
	[Address(RVA = "0xE36980", Offset = "0xE35380", VA = "0x180E36980")]
	public void ShootGun(Vector2 recoilMultiplier)
	{
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000587")]
	[Address(RVA = "0xE361A0", Offset = "0xE34BA0", VA = "0x180E361A0")]
	public void Equip()
	{
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000588")]
	[Address(RVA = "0xE36CF0", Offset = "0xE356F0", VA = "0x180E36CF0")]
	public void StartReload(float reloadTime)
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000589")]
	[Address(RVA = "0xE365A0", Offset = "0xE34FA0", VA = "0x180E365A0")]
	private void ReloadGun()
	{
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x600058A")]
	[Address(RVA = "0xE36100", Offset = "0xE34B00", VA = "0x180E36100")]
	private float EaseInOutBack(float x)
	{
		return 0f;
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058B")]
	[Address(RVA = "0xE376A0", Offset = "0xE360A0", VA = "0x180E376A0")]
	public Gun()
	{
	}

	// Token: 0x04000496 RID: 1174
	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	// Token: 0x04000497 RID: 1175
	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x20")]
	private Transform playerCam;

	// Token: 0x04000498 RID: 1176
	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 startPos;

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x38")]
	private List<Vector3> velHistory;

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 desiredBob;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x4C")]
	private float xBob;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x50")]
	private float yBob;

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x54")]
	private float zBob;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x58")]
	private float bobSpeed;

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 recoilOffset;

	// Token: 0x040004A0 RID: 1184
	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 recoilRotation;

	// Token: 0x040004A1 RID: 1185
	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 recoilOffsetVel;

	// Token: 0x040004A2 RID: 1186
	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 recoilRotVel;

	// Token: 0x040004A3 RID: 1187
	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x8C")]
	private float reloadRotation;

	// Token: 0x040004A4 RID: 1188
	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x90")]
	private float desiredReloadRotation;

	// Token: 0x040004A5 RID: 1189
	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x94")]
	private float reloadTime;

	// Token: 0x040004A6 RID: 1190
	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x98")]
	private float rVel;

	// Token: 0x040004A7 RID: 1191
	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x9C")]
	private float reloadPosOffset;

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0xA0")]
	private float rPVel;

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0xA8")]
	public Transform weaponParent;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0xB0")]
	private float gunDrag;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0xB4")]
	public float currentGunDragMultiplier;

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private static Gun <Instance>k__BackingField;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0xB8")]
	private float desX;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0xBC")]
	private float desY;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 speedBob;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0xCC")]
	private float currentReloadTime;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0xD0")]
	private float totalReloadTime;
}
