using System;
using System.IO;
using System.Text;

namespace FlatBuffers
{
	public class ByteBuffer
	{
		protected byte[] _buffer;

		private int _pos;

		private float[] floathelper = new float[1];

		private int[] inthelper = new int[1];

		private double[] doublehelper = new double[1];

		private ulong[] ulonghelper = new ulong[1];

		public int Length => _buffer.Length;

		public int Position
		{
			get
			{
				return _pos;
			}
			set
			{
				_pos = value;
			}
		}

		public ByteBuffer(int size)
			: this(new byte[size])
		{
		}

		public ByteBuffer(byte[] buffer)
			: this(buffer, 0)
		{
		}

		public ByteBuffer(byte[] buffer, int pos)
		{
			_buffer = buffer;
			_pos = pos;
		}

		public void Reset()
		{
			_pos = 0;
		}

		public ByteBuffer Duplicate()
		{
			return new ByteBuffer(_buffer, Position);
		}

		public void GrowFront(int newSize)
		{
			if ((Length & 0xC0000000u) != 0L)
			{
				throw new Exception("ByteBuffer: cannot grow buffer beyond 2 gigabytes.");
			}
			if (newSize < Length)
			{
				throw new Exception("ByteBuffer: cannot truncate buffer.");
			}
			byte[] array = new byte[newSize];
			Buffer.BlockCopy(_buffer, 0, array, newSize - Length, Length);
			_buffer = array;
		}

		public byte[] ToArray(int pos, int len)
		{
			byte[] array = new byte[len];
			Buffer.BlockCopy(_buffer, pos, array, 0, len);
			return array;
		}

		public byte[] ToSizedArray()
		{
			return ToArray(Position, Length - Position);
		}

		public byte[] ToFullArray()
		{
			return ToArray(0, Length);
		}

		public ArraySegment<byte> ToArraySegment(int pos, int len)
		{
			return new ArraySegment<byte>(_buffer, pos, len);
		}

		public MemoryStream ToMemoryStream(int pos, int len)
		{
			return new MemoryStream(_buffer, pos, len);
		}

		public static ushort ReverseBytes(ushort input)
		{
			return (ushort)((uint)((input & 0xFF) << 8) | ((uint)(input & 0xFF00) >> 8));
		}

		public static uint ReverseBytes(uint input)
		{
			return ((input & 0xFF) << 24) | ((input & 0xFF00) << 8) | ((input & 0xFF0000) >> 8) | ((input & 0xFF000000u) >> 24);
		}

		public static ulong ReverseBytes(ulong input)
		{
			return ((input & 0xFF) << 56) | ((input & 0xFF00) << 40) | ((input & 0xFF0000) << 24) | ((input & 0xFF000000u) << 8) | ((input & 0xFF00000000L) >> 8) | ((input & 0xFF0000000000L) >> 24) | ((input & 0xFF000000000000L) >> 40) | ((input & 0xFF00000000000000uL) >> 56);
		}

		protected void WriteLittleEndian(int offset, int count, ulong data)
		{
			if (BitConverter.IsLittleEndian)
			{
				for (int i = 0; i < count; i++)
				{
					_buffer[offset + i] = (byte)(data >> i * 8);
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					_buffer[offset + count - 1 - j] = (byte)(data >> j * 8);
				}
			}
		}

		protected ulong ReadLittleEndian(int offset, int count)
		{
			AssertOffsetAndLength(offset, count);
			ulong num = 0uL;
			if (BitConverter.IsLittleEndian)
			{
				for (int i = 0; i < count; i++)
				{
					num |= (ulong)_buffer[offset + i] << i * 8;
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					num |= (ulong)_buffer[offset + count - 1 - j] << j * 8;
				}
			}
			return num;
		}

		private void AssertOffsetAndLength(int offset, int length)
		{
			if (offset < 0 || offset > _buffer.Length - length)
			{
				throw new ArgumentOutOfRangeException();
			}
		}

		public void PutSbyte(int offset, sbyte value)
		{
			AssertOffsetAndLength(offset, 1);
			_buffer[offset] = (byte)value;
		}

		public void PutByte(int offset, byte value)
		{
			AssertOffsetAndLength(offset, 1);
			_buffer[offset] = value;
		}

		public void PutByte(int offset, byte value, int count)
		{
			AssertOffsetAndLength(offset, count);
			for (int i = 0; i < count; i++)
			{
				_buffer[offset + i] = value;
			}
		}

		public void Put(int offset, byte value)
		{
			PutByte(offset, value);
		}

		public void PutStringUTF8(int offset, string value)
		{
			AssertOffsetAndLength(offset, value.Length);
			Encoding.UTF8.GetBytes(value, 0, value.Length, _buffer, offset);
		}

		public void PutShort(int offset, short value)
		{
			AssertOffsetAndLength(offset, 2);
			WriteLittleEndian(offset, 2, (ulong)value);
		}

		public void PutUshort(int offset, ushort value)
		{
			AssertOffsetAndLength(offset, 2);
			WriteLittleEndian(offset, 2, value);
		}

		public void PutInt(int offset, int value)
		{
			AssertOffsetAndLength(offset, 4);
			WriteLittleEndian(offset, 4, (ulong)value);
		}

		public void PutUint(int offset, uint value)
		{
			AssertOffsetAndLength(offset, 4);
			WriteLittleEndian(offset, 4, value);
		}

		public void PutLong(int offset, long value)
		{
			AssertOffsetAndLength(offset, 8);
			WriteLittleEndian(offset, 8, (ulong)value);
		}

		public void PutUlong(int offset, ulong value)
		{
			AssertOffsetAndLength(offset, 8);
			WriteLittleEndian(offset, 8, value);
		}

		public void PutFloat(int offset, float value)
		{
			AssertOffsetAndLength(offset, 4);
			floathelper[0] = value;
			Buffer.BlockCopy(floathelper, 0, inthelper, 0, 4);
			WriteLittleEndian(offset, 4, (ulong)inthelper[0]);
		}

		public void PutDouble(int offset, double value)
		{
			AssertOffsetAndLength(offset, 8);
			doublehelper[0] = value;
			Buffer.BlockCopy(doublehelper, 0, ulonghelper, 0, 8);
			WriteLittleEndian(offset, 8, ulonghelper[0]);
		}

		public sbyte GetSbyte(int index)
		{
			AssertOffsetAndLength(index, 1);
			return (sbyte)_buffer[index];
		}

		public byte Get(int index)
		{
			AssertOffsetAndLength(index, 1);
			return _buffer[index];
		}

		public string GetStringUTF8(int startPos, int len)
		{
			return Encoding.UTF8.GetString(_buffer, startPos, len);
		}

		public short GetShort(int index)
		{
			return (short)ReadLittleEndian(index, 2);
		}

		public ushort GetUshort(int index)
		{
			return (ushort)ReadLittleEndian(index, 2);
		}

		public int GetInt(int index)
		{
			return (int)ReadLittleEndian(index, 4);
		}

		public uint GetUint(int index)
		{
			return (uint)ReadLittleEndian(index, 4);
		}

		public long GetLong(int index)
		{
			return (long)ReadLittleEndian(index, 8);
		}

		public ulong GetUlong(int index)
		{
			return ReadLittleEndian(index, 8);
		}

		public float GetFloat(int index)
		{
			int num = (int)ReadLittleEndian(index, 4);
			inthelper[0] = num;
			Buffer.BlockCopy(inthelper, 0, floathelper, 0, 4);
			return floathelper[0];
		}

		public double GetDouble(int index)
		{
			ulong num = ReadLittleEndian(index, 8);
			ulonghelper[0] = num;
			Buffer.BlockCopy(ulonghelper, 0, doublehelper, 0, 8);
			return doublehelper[0];
		}
	}
}
