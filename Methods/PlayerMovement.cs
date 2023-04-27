using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EB RID: 235
[Token(Token = "0x20000EB")]
public class PlayerMovement : MonoBehaviour
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00002AC0 File Offset: 0x00000CC0
	// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002F")]
	public float playerHeight
	{
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x3CDC10", Offset = "0x3CC610", VA = "0x1803CDC10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x3CDCC0", Offset = "0x3CC6C0", VA = "0x1803CDCC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00002AD8 File Offset: 0x00000CD8
	// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000030")]
	public bool jumping
	{
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x3CDC00", Offset = "0x3CC600", VA = "0x1803CDC00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x3CDCB0", Offset = "0x3CC6B0", VA = "0x1803CDCB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00002AF0 File Offset: 0x00000CF0
	// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000031")]
	public bool crouching
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x3CDBF0", Offset = "0x3CC5F0", VA = "0x1803CDBF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x3CDCA0", Offset = "0x3CC6A0", VA = "0x1803CDCA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060005FA RID: 1530 RVA: 0x00002B08 File Offset: 0x00000D08
	// (set) Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000032")]
	public bool sprinting
	{
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x3CDC20", Offset = "0x3CC620", VA = "0x1803CDC20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x3CDCD0", Offset = "0x3CC6D0", VA = "0x1803CDCD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060005FC RID: 1532 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000033")]
	public static PlayerMovement Instance
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x3CDB90", Offset = "0x3CC590", VA = "0x1803CDB90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x3CDC30", Offset = "0x3CC630", VA = "0x1803CDC30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		private set
		{
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x3C7350", Offset = "0x3C5D50", VA = "0x1803C7350")]
	private void Awake()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x3CCF10", Offset = "0x3CB910", VA = "0x1803CCF10")]
	private void Start()
	{
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x3CD5E0", Offset = "0x3CBFE0", VA = "0x1803CD5E0")]
	private void Update()
	{
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x3CC810", Offset = "0x3CB210", VA = "0x1803CC810")]
	public void SetInput(Vector2 dir, bool crouching, bool jumping, bool sprinting)
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x3C7CF0", Offset = "0x3C66F0", VA = "0x1803C7CF0")]
	private void CheckInput()
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x3CC960", Offset = "0x3CB360", VA = "0x1803CC960")]
	public void StartCrouch()
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x3CC4F0", Offset = "0x3CAEF0", VA = "0x1803CC4F0")]
	private void ReadyToCrouch()
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x3CD1D0", Offset = "0x3CBBD0", VA = "0x1803CD1D0")]
	public void StopCrouch()
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x3C79B0", Offset = "0x3C63B0", VA = "0x1803C79B0")]
	private bool CanStopCrouching()
	{
		return default(bool);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x3CCC00", Offset = "0x3CB600", VA = "0x1803CCC00")]
	private void StartSlide()
	{
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x3CD3C0", Offset = "0x3CBDC0", VA = "0x1803CD3C0")]
	private void StopSlide()
	{
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x3CC950", Offset = "0x3CB350", VA = "0x1803CC950")]
	private void SlideCooldown()
	{
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x3C8D30", Offset = "0x3C7730", VA = "0x1803C8D30")]
	private void FootSteps()
	{
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x3CD670", Offset = "0x3CC070", VA = "0x1803CD670")]
	private void WaterMovement()
	{
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x3C9D80", Offset = "0x3C8780", VA = "0x1803C9D80")]
	public bool IsUnderWater()
	{
		return default(bool);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x3CA7F0", Offset = "0x3C91F0", VA = "0x1803CA7F0")]
	public void Movement(float x, float y)
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x3CC8E0", Offset = "0x3CB2E0", VA = "0x1803CC8E0")]
	public void SetLadder(bool b, Transform ladder)
	{
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x3CC500", Offset = "0x3CAF00", VA = "0x1803CC500")]
	public void RefreshLadder(Transform ladder)
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000610")]
	[Address(RVA = "0x3CD3B0", Offset = "0x3CBDB0", VA = "0x1803CD3B0")]
	private void StopLadder()
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x3CA3F0", Offset = "0x3C8DF0", VA = "0x1803CA3F0")]
	private void LadderMovement(float x, float y, Vector2 mag)
	{
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x3CCF80", Offset = "0x3CB980", VA = "0x1803CCF80")]
	private void StickToLadder()
	{
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x6000613")]
	[Address(RVA = "0x3C9960", Offset = "0x3C8360", VA = "0x1803C9960")]
	private bool IsTouchingGround()
	{
		return default(bool);
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x6000614")]
	[Address(RVA = "0x3C98E0", Offset = "0x3C82E0", VA = "0x1803C98E0")]
	public bool IsSliding()
	{
		return default(bool);
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000615")]
	[Address(RVA = "0x3CD4A0", Offset = "0x3CBEA0", VA = "0x1803CD4A0")]
	private void UpdateCrouchState()
	{
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000616")]
	[Address(RVA = "0x3CC080", Offset = "0x3CAA80", VA = "0x1803CC080")]
	public void PushPlayer(Vector3 pushForce)
	{
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x3C77F0", Offset = "0x3C61F0", VA = "0x1803C77F0")]
	public void BouncePlayer(Vector3 pushForce)
	{
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x3CD580", Offset = "0x3CBF80", VA = "0x1803CD580")]
	private void UpdatePushMultiplier()
	{
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x3CC800", Offset = "0x3CB200", VA = "0x1803CC800")]
	private void ResetPush()
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x3CC200", Offset = "0x3CAC00", VA = "0x1803CC200")]
	private void RampMovement(Vector2 mag)
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x3C9130", Offset = "0x3C7B30", VA = "0x1803C9130")]
	private bool HasFooting()
	{
		return default(bool);
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x3CC7A0", Offset = "0x3CB1A0", VA = "0x1803CC7A0")]
	private void ResetJump()
	{
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x3C9E90", Offset = "0x3C8890", VA = "0x1803C9E90")]
	public void Jump()
	{
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x3C9E50", Offset = "0x3C8850", VA = "0x1803C9E50")]
	private void JumpCooldown()
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x3CC860", Offset = "0x3CB260", VA = "0x1803CC860")]
	private void SetKinematic(bool b)
	{
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x3C7F70", Offset = "0x3C6970", VA = "0x1803C7F70")]
	private void CounterMovement(float x, float y, Vector2 mag)
	{
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00002B98 File Offset: 0x00000D98
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x3C9760", Offset = "0x3C8160", VA = "0x1803C9760")]
	private bool IsHoldingAgainstHorizontalVel(Vector2 vel)
	{
		return default(bool);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x3C97B0", Offset = "0x3C81B0", VA = "0x1803C97B0")]
	private bool IsHoldingAgainstVerticalVel(Vector2 vel)
	{
		return default(bool);
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x6000623")]
	[Address(RVA = "0x3C8B90", Offset = "0x3C7590", VA = "0x1803C8B90")]
	public Vector2 FindVelRelativeToLook()
	{
		return default(Vector2);
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x3C9700", Offset = "0x3C8100", VA = "0x1803C9700")]
	private bool IsFloor(Vector3 v)
	{
		return default(bool);
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x3C9880", Offset = "0x3C8280", VA = "0x1803C9880")]
	private bool IsSlideable(Vector3 v)
	{
		return default(bool);
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00002C10 File Offset: 0x00000E10
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x3C98F0", Offset = "0x3C82F0", VA = "0x1803C98F0")]
	private bool IsSurf(Vector3 v)
	{
		return default(bool);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00002C28 File Offset: 0x00000E28
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x3C9D90", Offset = "0x3C8790", VA = "0x1803C9D90")]
	private bool IsWall(Vector3 v)
	{
		return default(bool);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x3C9800", Offset = "0x3C8200", VA = "0x1803C9800")]
	private bool IsRoof(Vector3 v)
	{
		return default(bool);
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x3CB540", Offset = "0x3C9F40", VA = "0x1803CB540")]
	private void OnCollisionEnter(Collision other)
	{
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x3CD3A0", Offset = "0x3CBDA0", VA = "0x1803CD3A0")]
	private void StopJustLanded()
	{
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x3C95F0", Offset = "0x3C7FF0", VA = "0x1803C95F0")]
	private bool IsBreakingFall(Vector3 normal, Collision other)
	{
		return default(bool);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062C")]
	[Address(RVA = "0x3CBC60", Offset = "0x3CA660", VA = "0x1803CBC60")]
	private void OnCollisionStay(Collision other)
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062D")]
	[Address(RVA = "0x3CD430", Offset = "0x3CBE30", VA = "0x1803CD430")]
	private void UpdateCollisionChecks()
	{
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x3CD390", Offset = "0x3CBD90", VA = "0x1803CD390")]
	private void StopGrounded()
	{
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x3CD420", Offset = "0x3CBE20", VA = "0x1803CD420")]
	private void StopSurf()
	{
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x3C90F0", Offset = "0x3C7AF0", VA = "0x1803C90F0")]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x3C9070", Offset = "0x3C7A70", VA = "0x1803C9070")]
	public float GetSpeedHorizontal()
	{
		return 0f;
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00002CA0 File Offset: 0x00000EA0
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x3C9010", Offset = "0x3C7A10", VA = "0x1803C9010")]
	public float GetFallSpeed()
	{
		return 0f;
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x3C9060", Offset = "0x3C7A60", VA = "0x1803C9060")]
	public Collider GetPlayerCollider()
	{
		return null;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x3C9040", Offset = "0x3C7A40", VA = "0x1803C9040")]
	public Transform GetPlayerCamTransform()
	{
		return null;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x3C9220", Offset = "0x3C7C20", VA = "0x1803C9220")]
	public Vector3 HitPoint()
	{
		return default(Vector3);
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x3C96F0", Offset = "0x3C80F0", VA = "0x1803C96F0")]
	public bool IsCrouching()
	{
		return default(bool);
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x3A6E50", Offset = "0x3A5850", VA = "0x1803A6E50")]
	public bool IsDead()
	{
		return default(bool);
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x2B1240", Offset = "0x2AFC40", VA = "0x1802B1240")]
	public Rigidbody GetRb()
	{
		return null;
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x3CD950", Offset = "0x3CC350", VA = "0x1803CD950")]
	public PlayerMovement()
	{
	}

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x18")]
	public GameObject playerJumpSmokeFx;

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x20")]
	public GameObject footstepFx;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x28")]
	public Transform playerCam;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x30")]
	public Transform orientation;

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x40")]
	public bool dead;

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x44")]
	private ObscuredFloat moveSpeed;

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x5C")]
	private ObscuredFloat defaultMoveSpeed;

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x74")]
	private ObscuredFloat iceMoveSpeed;

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x8C")]
	private ObscuredFloat iceMoveSpeedFaster;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0xA4")]
	private ObscuredFloat maxWalkSpeed;

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0xBC")]
	private ObscuredFloat maxRunSpeed;

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0xD4")]
	private ObscuredFloat maxSpeed;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0xEC")]
	private ObscuredFloat slideForce;

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x104")]
	public bool grounded;

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x108")]
	public LayerMask whatIsGround;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x10C")]
	public LayerMask whatIsGroundOnly;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x110")]
	public float extraGravity;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x114")]
	private Vector3 playerScale;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 crouchScale;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x12C")]
	private float slideCounterMovement;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x0")]
	public static float crouchRatio;

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private float <playerHeight>k__BackingField;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x138")]
	public AudioSource slideStartSfx;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x140")]
	public AudioSource slideSfx;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x148")]
	private ObscuredBool readyToJump;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x154")]
	private float jumpCooldown;

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x158")]
	private float jumpForce;

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x15C")]
	private int jumps;

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x160")]
	private float x;

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x164")]
	private float y;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x168")]
	private float mouseDeltaX;

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x16C")]
	private float mouseDeltaY;

	// Token: 0x04000534 RID: 1332
	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x170")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <jumping>k__BackingField;

	// Token: 0x04000535 RID: 1333
	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0x171")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <crouching>k__BackingField;

	// Token: 0x04000536 RID: 1334
	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0x172")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <sprinting>k__BackingField;

	// Token: 0x04000537 RID: 1335
	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0x174")]
	private PlayerMovement.CrouchState crouchState;

	// Token: 0x04000538 RID: 1336
	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x4")]
	public static float slideThresholdSpeed;

	// Token: 0x04000539 RID: 1337
	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x178")]
	private Vector3 normalVector;

	// Token: 0x0400053A RID: 1338
	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x188")]
	public ParticleSystem ps;

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x190")]
	private ParticleSystem.EmissionModule psEmission;

	// Token: 0x0400053C RID: 1340
	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x198")]
	private Collider playerCollider;

	// Token: 0x0400053D RID: 1341
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x1A0")]
	private float fallSpeed;

	// Token: 0x0400053E RID: 1342
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject playerSmokeFx;

	// Token: 0x0400053F RID: 1343
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x1B0")]
	public PunchPlayers punchPlayers;

	// Token: 0x04000540 RID: 1344
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private static PlayerMovement <Instance>k__BackingField;

	// Token: 0x04000541 RID: 1345
	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x1B8")]
	private float crouchCooldown;

	// Token: 0x04000542 RID: 1346
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x1BC")]
	private bool readyToCrouch;

	// Token: 0x04000543 RID: 1347
	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x1C0")]
	public Transform feet;

	// Token: 0x04000544 RID: 1348
	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x1C8")]
	private float slideCooldown;

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x1CC")]
	private bool readyToSlide;

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x1CD")]
	private bool justLanded;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x1D0")]
	private float distance;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x1D4")]
	private float swimSpeed;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x1D8")]
	public bool underWater;

	// Token: 0x0400054A RID: 1354
	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x1D9")]
	private bool onLadder;

	// Token: 0x0400054B RID: 1355
	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x1DC")]
	private Vector3 ladderNormal;

	// Token: 0x0400054C RID: 1356
	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x1E8")]
	private Transform ladder;

	// Token: 0x0400054D RID: 1357
	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x1F0")]
	private float ladderSpeed;

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x1F4")]
	private bool onLadderLastFrame;

	// Token: 0x0400054F RID: 1359
	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x1F8")]
	private float ladderRefreshTime;

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x1FC")]
	private float playerRadius;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x200")]
	private bool pushed;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x204")]
	private float pushMultiplier;

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x208")]
	private float pushResetSpeed;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x20C")]
	private bool onRamp;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x210")]
	private int extraJumps;

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x214")]
	private int resetJumpCounter;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x218")]
	private int jumpCounterResetTime;

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x21C")]
	private float iceMultiplier;

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x220")]
	private float iceMultiplierFaster;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x224")]
	private float counterMovement;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x228")]
	private float defaultCounterMovement;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x22C")]
	private float threshold;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x230")]
	private int readyToCounterX;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x234")]
	private int readyToCounterY;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x238")]
	private float slowDownSpeed;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x23C")]
	private bool cancelling;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x240")]
	private float maxSlopeAngle;

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x244")]
	private float slideAngle;

	// Token: 0x04000563 RID: 1379
	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x248")]
	private bool airborne;

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x24C")]
	private PlayerMovement.Surface surfaceType;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x250")]
	private float minBreakFallAngle;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x254")]
	private float maxBreakFallAngle;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x258")]
	private bool onGround;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x259")]
	private bool surfing;

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x25A")]
	private bool cancellingGrounded;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x25B")]
	private bool cancellingSurf;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x25C")]
	private float delay;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x260")]
	private int groundCancel;

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x264")]
	private int wallCancel;

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x268")]
	private int surfCancel;

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x26C")]
	public LayerMask whatIsHittable;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x270")]
	private float vel;

	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	private enum CrouchState
	{
		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		None,
		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		Crouching,
		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		Sliding
	}

	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	private enum Surface
	{
		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		Generic,
		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		Ice,
		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		Ice2x
	}
}
