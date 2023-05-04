using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010D RID: 269
[Token(Token = "0x200010D")]
[Attribute(Name = "RequireComponent", RVA = "0x101E50", Offset = "0x101250")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x101E50", Offset = "0x101250")]
[Attribute(Name = "RequireComponent", RVA = "0x101E50", Offset = "0x101250")]
public class GeometryGrassPainter : MonoBehaviour
{
	// Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0xE358C0", Offset = "0xE342C0", VA = "0x180E358C0")]
	public GeometryGrassPainter()
	{
	}

	// Token: 0x0400064B RID: 1611
	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x18")]
	private Mesh mesh;

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x20")]
	private MeshFilter filter;

	// Token: 0x0400064D RID: 1613
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x28")]
	public Color AdjustedColor;

	// Token: 0x0400064E RID: 1614
	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x101EF0", Offset = "0x1012F0")]
	public int grassLimit;

	// Token: 0x0400064F RID: 1615
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 lastPosition;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x48")]
	public int toolbarInt;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Vector3> positions;

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<Color> colors;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<int> indicies;

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Vector3> normals;

	// Token: 0x04000655 RID: 1621
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<Vector2> length;

	// Token: 0x04000656 RID: 1622
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x78")]
	public bool painting;

	// Token: 0x04000657 RID: 1623
	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x79")]
	public bool removing;

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x7A")]
	public bool editing;

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x7C")]
	public int i;

	// Token: 0x0400065A RID: 1626
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x80")]
	public float sizeWidth;

	// Token: 0x0400065B RID: 1627
	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x84")]
	public float sizeLength;

	// Token: 0x0400065C RID: 1628
	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x88")]
	public float density;

	// Token: 0x0400065D RID: 1629
	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x8C")]
	public float normalLimit;

	// Token: 0x0400065E RID: 1630
	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x90")]
	public float rangeR;

	// Token: 0x0400065F RID: 1631
	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x94")]
	public float rangeG;

	// Token: 0x04000660 RID: 1632
	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x98")]
	public float rangeB;

	// Token: 0x04000661 RID: 1633
	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x9C")]
	public LayerMask hitMask;

	// Token: 0x04000662 RID: 1634
	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0xA0")]
	public LayerMask paintMask;

	// Token: 0x04000663 RID: 1635
	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0xA4")]
	public float brushSize;

	// Token: 0x04000664 RID: 1636
	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 mousePos;

	// Token: 0x04000665 RID: 1637
	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "HideInInspector", RVA = "0xDC390", Offset = "0xDB790")]
	public Vector3 hitPosGizmo;

	// Token: 0x04000666 RID: 1638
	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 hitPos;

	// Token: 0x04000667 RID: 1639
	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0xCC")]
	[Attribute(Name = "HideInInspector", RVA = "0xDC390", Offset = "0xDB790")]
	public Vector3 hitNormal;

	// Token: 0x04000668 RID: 1640
	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0xD8")]
	private int[] indi;
}
