using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000CC RID: 204
[Token(Token = "0x20000CC")]
public class Packet : IDisposable
{
	// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x330C50", Offset = "0x32F650", VA = "0x180330C50")]
	public Packet()
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x330BB0", Offset = "0x32F5B0", VA = "0x180330BB0")]
	public Packet(int _id)
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x330AA0", Offset = "0x32F4A0", VA = "0x180330AA0")]
	public Packet(byte[] _data)
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x330350", Offset = "0x32ED50", VA = "0x180330350")]
	public void SetBytes(byte[] _data)
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x330490", Offset = "0x32EE90", VA = "0x180330490")]
	public void WriteLength()
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x32F7B0", Offset = "0x32E1B0", VA = "0x18032F7B0")]
	public void InsertInt(int _value)
	{
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x3303F0", Offset = "0x32EDF0", VA = "0x1803303F0")]
	public byte[] ToArray()
	{
		return null;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x32F840", Offset = "0x32E240", VA = "0x18032F840")]
	public int Length()
	{
		return 0;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x330450", Offset = "0x32EE50", VA = "0x180330450")]
	public int UnreadLength()
	{
		return 0;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x3302D0", Offset = "0x32ECD0", VA = "0x1803302D0")]
	public void Reset(bool _shouldReset = true)
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x330650", Offset = "0x32F050", VA = "0x180330650")]
	public void Write(byte _value)
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x3308C0", Offset = "0x32F2C0", VA = "0x1803308C0")]
	public void Write(byte[] _value)
	{
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x3306B0", Offset = "0x32F0B0", VA = "0x1803306B0")]
	public void Write(short _value)
	{
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x330980", Offset = "0x32F380", VA = "0x180330980")]
	public void Write(int _value)
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x330530", Offset = "0x32EF30", VA = "0x180330530")]
	public void Write(long _value)
	{
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x3305C0", Offset = "0x32EFC0", VA = "0x1803305C0")]
	public void Write(ulong _value)
	{
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x330A10", Offset = "0x32F410", VA = "0x180330A10")]
	public void Write(float _value)
	{
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x330740", Offset = "0x32F140", VA = "0x180330740")]
	public void Write(bool _value)
	{
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x330830", Offset = "0x32F230", VA = "0x180330830")]
	public void Write(string _value)
	{
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x330920", Offset = "0x32F320", VA = "0x180330920")]
	public void Write(Vector3 _value)
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x3307D0", Offset = "0x32F1D0", VA = "0x1803307D0")]
	public void Write(Quaternion _value)
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x32F970", Offset = "0x32E370", VA = "0x18032F970")]
	public byte ReadByte(bool _moveReadPos = true)
	{
		return 0;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x32FA40", Offset = "0x32E440", VA = "0x18032FA40")]
	public byte[] ReadBytes(int _length, bool _moveReadPos = true)
	{
		return null;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x32F6A0", Offset = "0x32E0A0", VA = "0x18032F6A0")]
	public byte[] CloneBytes()
	{
		return null;
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x32FEC0", Offset = "0x32E8C0", VA = "0x18032FEC0")]
	public short ReadShort(bool _moveReadPos = true)
	{
		return 0;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x32FC20", Offset = "0x32E620", VA = "0x18032FC20")]
	public int ReadInt(bool _moveReadPos = true)
	{
		return 0;
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x32FD10", Offset = "0x32E710", VA = "0x18032FD10")]
	public long ReadLong(bool _moveReadPos = true)
	{
		return 0L;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x330160", Offset = "0x32EB60", VA = "0x180330160")]
	public ulong ReadUlong(bool _moveReadPos = true)
	{
		return 0UL;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x32FB30", Offset = "0x32E530", VA = "0x18032FB30")]
	public float ReadFloat(bool _moveReadPos = true)
	{
		return 0f;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x32F880", Offset = "0x32E280", VA = "0x18032F880")]
	public bool ReadBool(bool _moveReadPos = true)
	{
		return default(bool);
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x32FFB0", Offset = "0x32E9B0", VA = "0x18032FFB0")]
	public string ReadString(bool _moveReadPos = true)
	{
		return null;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x330250", Offset = "0x32EC50", VA = "0x180330250")]
	public Vector3 ReadVector3(bool moveReadPos = true)
	{
		return default(Vector3);
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x32FE00", Offset = "0x32E800", VA = "0x18032FE00")]
	public Quaternion ReadQuaternion(bool moveReadPos = true)
	{
		return default(Quaternion);
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x32F6F0", Offset = "0x32E0F0", VA = "0x18032F6F0", Slot = "5")]
	protected virtual void Dispose(bool _disposing)
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x32F740", Offset = "0x32E140", VA = "0x18032F740", Slot = "4")]
	public void Dispose()
	{
	}

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x10")]
	private List<byte> buffer;

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x18")]
	private byte[] readableBuffer;

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x20")]
	private int readPos;

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x24")]
	private bool disposed;
}
