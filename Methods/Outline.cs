using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0xDC390", Offset = "0xDB790")]
public class Outline : MonoBehaviour
{
	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600079C RID: 1948 RVA: 0x00002EE0 File Offset: 0x000010E0
	// (set) Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000044")]
	public Outline.Mode OutlineMode
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x225FE0", Offset = "0x2249E0", VA = "0x180225FE0")]
		get
		{
			return Outline.Mode.OutlineAll;
		}
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x32F150", Offset = "0x32DB50", VA = "0x18032F150")]
		set
		{
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x0600079E RID: 1950 RVA: 0x00002EF8 File Offset: 0x000010F8
	// (set) Token: 0x0600079F RID: 1951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000045")]
	public Color OutlineColor
	{
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x32F120", Offset = "0x32DB20", VA = "0x18032F120")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x32F140", Offset = "0x32DB40", VA = "0x18032F140")]
		set
		{
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00002F10 File Offset: 0x00001110
	// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000046")]
	public float OutlineWidth
	{
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x32F130", Offset = "0x32DB30", VA = "0x18032F130")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x32F160", Offset = "0x32DB60", VA = "0x18032F160")]
		set
		{
		}
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x32DD80", Offset = "0x32C780", VA = "0x18032DD80")]
	private void Awake()
	{
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x32E570", Offset = "0x32CF70", VA = "0x18032E570")]
	private void OnEnable()
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x32E6A0", Offset = "0x32D0A0", VA = "0x18032E6A0")]
	private void OnValidate()
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x32EFA0", Offset = "0x32D9A0", VA = "0x18032EFA0")]
	private void Update()
	{
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x32E440", Offset = "0x32CE40", VA = "0x18032E440")]
	private void OnDisable()
	{
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x32E3D0", Offset = "0x32CDD0", VA = "0x18032E3D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x32DF00", Offset = "0x32C900", VA = "0x18032DF00")]
	private void Bake()
	{
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x32E0E0", Offset = "0x32CAE0", VA = "0x18032E0E0")]
	private void LoadSmoothNormals()
	{
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x32E780", Offset = "0x32D180", VA = "0x18032E780")]
	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x32EDB0", Offset = "0x32D7B0", VA = "0x18032EDB0")]
	private void UpdateMaterialProperties()
	{
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x32F040", Offset = "0x32DA40", VA = "0x18032F040")]
	public Outline()
	{
	}

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<Mesh> registeredMeshes;

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Outline.Mode outlineMode;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color outlineColor;

	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1020A0", Offset = "0x1014A0")]
	[SerializeField]
	private float outlineWidth;

	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1020E0", Offset = "0x1014E0")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1020E0", Offset = "0x1014E0")]
	private bool precomputeOutline;

	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0xDD310", Offset = "0xDC710")]
	[SerializeField]
	private List<Mesh> bakeKeys;

	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0xDD310", Offset = "0xDC710")]
	[SerializeField]
	private List<Outline.ListVector3> bakeValues;

	// Token: 0x040006F3 RID: 1779
	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x48")]
	private Renderer[] renderers;

	// Token: 0x040006F4 RID: 1780
	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x50")]
	private Material outlineMaskMaterial;

	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x58")]
	private Material outlineFillMaterial;

	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x60")]
	private bool needsUpdate;

	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public enum Mode
	{
		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		OutlineAll,
		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		OutlineVisible,
		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		OutlineHidden,
		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		OutlineAndSilhouette,
		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		SilhouetteOnly
	}

	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	[Serializable]
	private class ListVector3
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public ListVector3()
		{
		}

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector3> data;
	}

	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1F5CB0", Offset = "0x1F46B0", VA = "0x1801F5CB0")]
		public <>c()
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2FDAB0", Offset = "0x2FC4B0", VA = "0x1802FDAB0")]
		internal KeyValuePair<Vector3, int> <SmoothNormals>b__30_0(Vector3 vertex, int index)
		{
			return default(KeyValuePair<Vector3, int>);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2FDB30", Offset = "0x2FC530", VA = "0x1802FDB30")]
		internal Vector3 <SmoothNormals>b__30_1(KeyValuePair<Vector3, int> pair)
		{
			return default(Vector3);
		}

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Outline.<>c <>9;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__30_0;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x10")]
		public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__30_1;
	}
}
