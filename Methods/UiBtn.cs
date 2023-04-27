using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000142 RID: 322
[Token(Token = "0x2000142")]
public class UiBtn : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060007FB RID: 2043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x2FDE30", Offset = "0x2FC830", VA = "0x1802FDE30")]
	private void Awake()
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x2FDF50", Offset = "0x2FC950", VA = "0x1802FDF50")]
	private void SetScale(float scale)
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x2FDE80", Offset = "0x2FC880", VA = "0x1802FDE80")]
	private void OnEnable()
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x2FE000", Offset = "0x2FCA00", VA = "0x1802FE000")]
	private void Update()
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x2FDF30", Offset = "0x2FC930", VA = "0x1802FDF30", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x2FDF40", Offset = "0x2FC940", VA = "0x1802FDF40", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x2FE250", Offset = "0x2FCC50", VA = "0x1802FE250")]
	public UiBtn()
	{
	}

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x18")]
	public Transform text;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x20")]
	private float desiredScaleX;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x24")]
	private bool stopped;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x28")]
	private float textScaleMultiplier;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 defaultTextScale;
}
