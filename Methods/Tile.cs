using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000139 RID: 313
[Token(Token = "0x2000139")]
public class Tile : MonoBehaviour
{
	// Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x2FAB60", Offset = "0x2F9560", VA = "0x1802FAB60")]
	public void SetTileId(int id)
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x2FAB70", Offset = "0x2F9570", VA = "0x1802FAB70")]
	private void Start()
	{
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00002FA0 File Offset: 0x000011A0
	// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000049")]
	public int teamId
	{
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2FAFE0", Offset = "0x2F99E0", VA = "0x1802FAFE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2FAFF0", Offset = "0x2F99F0", VA = "0x1802FAFF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x2FA2C0", Offset = "0x2F8CC0", VA = "0x1802FA2C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x2FA740", Offset = "0x2F9140", VA = "0x1802FA740")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x2FA9A0", Offset = "0x2F93A0", VA = "0x1802FA9A0")]
	public void SetTileColor(int team)
	{
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x2FA280", Offset = "0x2F8C80", VA = "0x1802FA280")]
	private void EnterTile()
	{
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x2FA2A0", Offset = "0x2F8CA0", VA = "0x1802FA2A0")]
	private void ExitTile()
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x2FAD20", Offset = "0x2F9720", VA = "0x1802FAD20")]
	private void Update()
	{
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x2FAFC0", Offset = "0x2F99C0", VA = "0x1802FAFC0")]
	public Tile()
	{
	}

	// Token: 0x04000703 RID: 1795
	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 downPosition;

	// Token: 0x04000704 RID: 1796
	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 topPosition;

	// Token: 0x04000705 RID: 1797
	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 desiredPos;

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x40")]
	public MeshRenderer mesh;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x48")]
	private Material mat;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x50")]
	public Transform movePart;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x58")]
	private int tileId;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x60")]
	private List<Transform> onTile;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x68")]
	private int playersOnTile;

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private int <teamId>k__BackingField;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x70")]
	private bool activated;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x74")]
	private float speed;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x78")]
	private float movedDistance;
}
