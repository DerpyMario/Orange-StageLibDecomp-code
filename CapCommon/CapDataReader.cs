using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Better;

public class CapDataReader
{
	public System.Collections.Generic.Dictionary<string, DataTable> tablesByName = new Better.Dictionary<string, DataTable>();

	public System.Collections.Generic.Dictionary<string, string> dicConstData = new Better.Dictionary<string, string>();

	public string createTime = string.Empty;

	public static string CONST_CONVERT_VERSION_KEY = "CONST_CONVERT_VERSION_KEY";

	public string sourceFile { get; set; }

	public int this[string key]
	{
		get
		{
			if (dicConstData.ContainsKey(key))
			{
				return Convert.ToInt32(dicConstData[key]);
			}
			return 0;
		}
	}

	public CapDataReader(string path = "")
	{
		sourceFile = path;
	}

	public void ReadStream(byte[] encryptedData, List<string> allowTables = null, bool forceReplaceData = true)
	{
		byte[] buffer = CapDatagram.Decrypt(encryptedData);
		using BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream());
		binaryWriter.Write(buffer);
		using BinaryReader binaryReader = new BinaryReader(binaryWriter.BaseStream);
		binaryReader.BaseStream.Position = 0L;
		int num = binaryReader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			if (binaryReader.ReadInt32() != 2)
			{
				continue;
			}
			DataTable dataTable = new DataTable
			{
				TableName = binaryReader.ReadExString()
			};
			int num2 = binaryReader.ReadInt32();
			for (int j = 0; j < num2; j++)
			{
				DataColumn dataColumn = new DataColumn
				{
					ColumnName = binaryReader.ReadExString()
				};
				switch ((CapDataType)binaryReader.ReadInt32())
				{
				case CapDataType.Int:
					dataColumn.DataType = typeof(int);
					break;
				case CapDataType.BigInt:
					dataColumn.DataType = typeof(long);
					break;
				case CapDataType.Float:
					dataColumn.DataType = typeof(float);
					break;
				case CapDataType.String:
					dataColumn.DataType = typeof(string);
					break;
				case CapDataType.WString:
					dataColumn.DataType = typeof(string);
					break;
				case CapDataType.Error:
					dataColumn.DataType = typeof(byte);
					break;
				}
				dataTable.Columns.Add(dataColumn);
			}
			if (!forceReplaceData)
			{
				DataTable table = GetTable(dataTable.TableName);
				if (table != null)
				{
					if (dataTable.Columns.Count != table.Columns.Count)
					{
						throw new Exception($"Table[{dataTable.TableName}]'s column doesn't match. New={dataTable.Columns.Count} vs Old={table.Columns.Count}");
					}
					if (allowTables == null || allowTables.Contains(dataTable.TableName))
					{
						dataTable = table;
					}
				}
			}
			int num3 = binaryReader.ReadInt32();
			for (int k = 0; k < num3; k++)
			{
				DataRow dataRow = dataTable.NewRow();
				foreach (DataColumn column in dataTable.Columns)
				{
					if ((object)column.DataType == typeof(int))
					{
						dataRow[column] = binaryReader.ReadInt32();
					}
					else if ((object)column.DataType == typeof(long))
					{
						dataRow[column] = binaryReader.ReadInt64();
					}
					else if ((object)column.DataType == typeof(float))
					{
						dataRow[column] = binaryReader.ReadDouble();
					}
					else if ((object)column.DataType == typeof(string))
					{
						dataRow[column] = binaryReader.ReadExString();
					}
					else if ((object)column.DataType == typeof(byte))
					{
						dataRow[column] = binaryReader.ReadByte();
					}
				}
				dataTable.Rows.Add(dataRow);
			}
			if (allowTables == null || allowTables.Contains(dataTable.TableName))
			{
				tablesByName[dataTable.TableName] = dataTable;
			}
		}
		int num4 = binaryReader.ReadInt32();
		for (int l = 0; l < num4; l++)
		{
			string text = binaryReader.ReadExString();
			string value = binaryReader.ReadExString();
			if (text == CONST_CONVERT_VERSION_KEY)
			{
				if (!dicConstData.ContainsKey(text))
				{
					dicConstData.Add(text, value);
					continue;
				}
				int num5 = Convert.ToInt32(value);
				int num6 = Convert.ToInt32(dicConstData[text]);
				if (num5 != 99999999 && num5 > num6)
				{
					dicConstData[text] = value;
				}
			}
			else if (forceReplaceData)
			{
				dicConstData[text] = value;
			}
			else if (!dicConstData.ContainsKey(text))
			{
				dicConstData.Add(text, value);
			}
		}
		createTime = binaryReader.ReadExString();
	}

	public virtual void ReadData(string srcPath = "", string srcFile = "")
	{
		if (!string.IsNullOrEmpty(srcPath))
		{
			sourceFile = srcPath;
			FileStream fileStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			ReadStream(array);
		}
	}

	public object GetValue(string tableName, int id, string columnName)
	{
		DataRow row = GetRow(tableName, id);
		if (row == null)
		{
			return null;
		}
		if (columnName[0] == 'n')
		{
			return (int)row[columnName];
		}
		if (columnName[0] == 'f')
		{
			return (float)row[columnName];
		}
		if (columnName[0] == 's')
		{
			return (string)row[columnName];
		}
		if (columnName[0] == 'l')
		{
			return (long)row[columnName];
		}
		return null;
	}

	public DataTable GetTable(string tableName)
	{
		if (string.IsNullOrEmpty(tableName) || !tablesByName.ContainsKey(tableName))
		{
			return null;
		}
		return tablesByName[tableName];
	}

	public DataRow GetRow(string tableName, string idColumnName, object id)
	{
		DataTable table = GetTable(tableName);
		if (table == null)
		{
			return null;
		}
		if (idColumnName[0] == 'n')
		{
			foreach (DataRow row in table.Rows)
			{
				if ((int)row[idColumnName] == (int)id)
				{
					return row;
				}
			}
		}
		else if (idColumnName[0] == 'f')
		{
			foreach (DataRow row2 in table.Rows)
			{
				if ((float)row2[idColumnName] == (float)id)
				{
					return row2;
				}
			}
		}
		else if (idColumnName[0] == 's')
		{
			foreach (DataRow row3 in table.Rows)
			{
				if ((string)row3[idColumnName] == (string)id)
				{
					return row3;
				}
			}
		}
		else if (idColumnName[0] == 'l')
		{
			foreach (DataRow row4 in table.Rows)
			{
				if ((long)row4[idColumnName] == (long)id)
				{
					return row4;
				}
			}
		}
		return null;
	}

	public DataRow GetRow(string tableName, int id)
	{
		return GetRow(tableName, "n_ID", id);
	}

	public System.Collections.Generic.Dictionary<int, T> DeserializeTableToClass<T>(string tableName, RowDataConverter converter = null) where T : new()
	{
		SortedDictionary<int, T> sortedDictionary = new SortedDictionary<int, T>();
		DataTable table = GetTable(tableName);
		if (table != null)
		{
			foreach (DataRow row in table.Rows)
			{
				int key = (int)row["n_ID"];
				try
				{
					if (!sortedDictionary.ContainsKey(key))
					{
						T value = CapUtility.CreateItemFromRow<T>(row, converter);
						sortedDictionary.Add(key, value);
					}
				}
				catch (Exception ex)
				{
					throw new Exception(string.Format("tableName={0}, rowID={1} message={2}", tableName, row["n_ID"], ex.Message));
				}
			}
		}
		return new System.Collections.Generic.Dictionary<int, T>(sortedDictionary);
	}

	public System.Collections.Generic.Dictionary<string, T> DeserializeTableToClass<T>(string keyName, string tableName, RowDataConverter converter = null) where T : new()
	{
		SortedDictionary<string, T> sortedDictionary = new SortedDictionary<string, T>();
		DataTable table = GetTable(tableName);
		if (table != null)
		{
			foreach (DataRow row in table.Rows)
			{
				try
				{
					if (!sortedDictionary.ContainsKey((string)row[keyName]))
					{
						T value = CapUtility.CreateItemFromRow<T>(row, converter);
						sortedDictionary.Add((string)row[keyName], value);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"tableName={tableName}, rowID={row[keyName]} message={ex.Message}");
				}
			}
		}
		return new System.Collections.Generic.Dictionary<string, T>(sortedDictionary);
	}

	public System.Collections.Generic.Dictionary<T, U> DeserializeTableToClass<T, U>(string keyName, string tableName, RowDataConverter converter = null) where U : new()
	{
		SortedDictionary<T, U> sortedDictionary = new SortedDictionary<T, U>();
		DataTable table = GetTable(tableName);
		if (table != null)
		{
			foreach (DataRow row in table.Rows)
			{
				try
				{
					if (!sortedDictionary.ContainsKey((T)row[keyName]))
					{
						U value = CapUtility.CreateItemFromRow<U>(row, converter);
						sortedDictionary.Add((T)row[keyName], value);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"tableName={tableName}, rowID={row[keyName]} message={ex.Message}");
				}
			}
		}
		return new System.Collections.Generic.Dictionary<T, U>(sortedDictionary);
	}
}
