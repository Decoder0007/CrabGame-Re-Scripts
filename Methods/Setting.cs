using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000FD RID: 253
[Token(Token = "0x20000FD")]
public class Setting : MonoBehaviour
{
	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000039")]
	public Setting.ButtonClickedEvent onClick
	{
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2B1250", Offset = "0x2AFC50", VA = "0x1802B1250")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2B4490", Offset = "0x2B2E90", VA = "0x1802B4490")]
		set
		{
		}
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D15D0", VA = "0x1803D2BD0")]
	public Setting()
	{
	}

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x18")]
	public int currentSetting;

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xF5230", Offset = "0xF4630")]
	[SerializeField]
	public Setting.ButtonClickedEvent m_OnClick;

	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public class ButtonClickedEvent : UnityEvent
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2E8B20", Offset = "0x2E7520", VA = "0x1802E8B20")]
		public ButtonClickedEvent()
		{
		}
	}
}
