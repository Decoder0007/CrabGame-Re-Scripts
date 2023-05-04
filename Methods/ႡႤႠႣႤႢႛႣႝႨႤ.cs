using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000170 RID: 368
[Token(Token = "0x2000170")]
[Attribute(Name = "RequireComponent", RVA = "0x1E77C0", Offset = "0x1E6BC0")]
[Attribute(Name = "RequireComponent", RVA = "0x1E77C0", Offset = "0x1E6BC0")]
[ExecuteInEditMode]
public class ႡႤႠႣႤႢ\u109BႣ\u109DႨႤ : MonoBehaviour
{
	// Token: 0x06005156 RID: 20822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6005156")]
	[Address(RVA = "0xFF42B0", Offset = "0xFF30B0", VA = "0x180FF42B0")]
	public ႡႤႠႣႤႢ\u109BႣ\u109DႨႤ()
	{
	}

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x18")]
	private Mesh \u109C\u109B\u109A\u109FႥႤႥ႙Ⴅ\u109D\u109D;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x20")]
	private MeshFilter ႢႨ\u109FႥ\u109B\u109AႨႧႦႡ\u109C;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x28")]
	public Color AdjustedColor;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1E7860", Offset = "0x1E6C60")]
	public int grassLimit;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 ႣႢႥႤႧႦ႙Ⴂ\u109F\u109D\u109D;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x48")]
	public int toolbarInt;

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Vector3> positions;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<Color> colors;

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<int> indicies;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Vector3> normals;

	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<Vector2> length;

	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x78")]
	public bool painting;

	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x79")]
	public bool removing;

	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x7A")]
	public bool editing;

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x7C")]
	public int i;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x80")]
	public float sizeWidth;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x84")]
	public float sizeLength;

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x88")]
	public float density;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x8C")]
	public float normalLimit;

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x90")]
	public float rangeR;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x94")]
	public float rangeG;

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x98")]
	public float rangeB;

	// Token: 0x040009BA RID: 2490
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x9C")]
	public LayerMask hitMask;

	// Token: 0x040009BB RID: 2491
	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0xA0")]
	public LayerMask paintMask;

	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0xA4")]
	public float brushSize;

	// Token: 0x040009BD RID: 2493
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 ႙ႠႣ\u109AႧႣႡႡ႙\u109DႥ;

	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0xB4")]
	[HideInInspector]
	public Vector3 hitPosGizmo;

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 Ⴈ\u109FႦ\u109C\u109C\u109EႨ\u109DႥ\u109AႢ;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0xCC")]
	[HideInInspector]
	public Vector3 hitNormal;

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0xD8")]
	private int[] \u109BႤ\u109FႢႥ\u109EႢႠ\u109DႧ\u109D;
}
