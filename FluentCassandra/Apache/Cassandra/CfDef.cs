/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Cassandra
{

  [Serializable]
  public partial class CfDef : TBase
  {
    private string keyspace;
    private string name;
    private string column_type;
    private string clock_type;
    private string comparator_type;
    private string subcomparator_type;
    private string reconciler;
    private string comment;
    private double row_cache_size;
    private bool preload_row_cache;
    private double key_cache_size;
    private double read_repair_chance;
    private List<ColumnDef> column_metadata;
    private int gc_grace_seconds;

    public string Keyspace
    {
      get
      {
        return keyspace;
      }
      set
      {
        __isset.keyspace = true;
        this.keyspace = value;
      }
    }

    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        __isset.name = true;
        this.name = value;
      }
    }

    public string Column_type
    {
      get
      {
        return column_type;
      }
      set
      {
        __isset.column_type = true;
        this.column_type = value;
      }
    }

    public string Clock_type
    {
      get
      {
        return clock_type;
      }
      set
      {
        __isset.clock_type = true;
        this.clock_type = value;
      }
    }

    public string Comparator_type
    {
      get
      {
        return comparator_type;
      }
      set
      {
        __isset.comparator_type = true;
        this.comparator_type = value;
      }
    }

    public string Subcomparator_type
    {
      get
      {
        return subcomparator_type;
      }
      set
      {
        __isset.subcomparator_type = true;
        this.subcomparator_type = value;
      }
    }

    public string Reconciler
    {
      get
      {
        return reconciler;
      }
      set
      {
        __isset.reconciler = true;
        this.reconciler = value;
      }
    }

    public string Comment
    {
      get
      {
        return comment;
      }
      set
      {
        __isset.comment = true;
        this.comment = value;
      }
    }

    public double Row_cache_size
    {
      get
      {
        return row_cache_size;
      }
      set
      {
        __isset.row_cache_size = true;
        this.row_cache_size = value;
      }
    }

    public bool Preload_row_cache
    {
      get
      {
        return preload_row_cache;
      }
      set
      {
        __isset.preload_row_cache = true;
        this.preload_row_cache = value;
      }
    }

    public double Key_cache_size
    {
      get
      {
        return key_cache_size;
      }
      set
      {
        __isset.key_cache_size = true;
        this.key_cache_size = value;
      }
    }

    public double Read_repair_chance
    {
      get
      {
        return read_repair_chance;
      }
      set
      {
        __isset.read_repair_chance = true;
        this.read_repair_chance = value;
      }
    }

    public List<ColumnDef> Column_metadata
    {
      get
      {
        return column_metadata;
      }
      set
      {
        __isset.column_metadata = true;
        this.column_metadata = value;
      }
    }

    public int Gc_grace_seconds
    {
      get
      {
        return gc_grace_seconds;
      }
      set
      {
        __isset.gc_grace_seconds = true;
        this.gc_grace_seconds = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool keyspace;
      public bool name;
      public bool column_type;
      public bool clock_type;
      public bool comparator_type;
      public bool subcomparator_type;
      public bool reconciler;
      public bool comment;
      public bool row_cache_size;
      public bool preload_row_cache;
      public bool key_cache_size;
      public bool read_repair_chance;
      public bool column_metadata;
      public bool gc_grace_seconds;
    }

    public CfDef() {
      this.column_type = "Standard";
      this.clock_type = "Timestamp";
      this.comparator_type = "BytesType";
      this.subcomparator_type = "";
      this.reconciler = "";
      this.comment = "";
      this.row_cache_size = 0;
      this.preload_row_cache = false;
      this.key_cache_size = 200000;
      this.read_repair_chance = 1;
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              this.keyspace = iprot.ReadString();
              this.__isset.keyspace = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              this.name = iprot.ReadString();
              this.__isset.name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              this.column_type = iprot.ReadString();
              this.__isset.column_type = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              this.clock_type = iprot.ReadString();
              this.__isset.clock_type = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              this.comparator_type = iprot.ReadString();
              this.__isset.comparator_type = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              this.subcomparator_type = iprot.ReadString();
              this.__isset.subcomparator_type = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              this.reconciler = iprot.ReadString();
              this.__isset.reconciler = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              this.comment = iprot.ReadString();
              this.__isset.comment = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Double) {
              this.row_cache_size = iprot.ReadDouble();
              this.__isset.row_cache_size = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Bool) {
              this.preload_row_cache = iprot.ReadBool();
              this.__isset.preload_row_cache = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Double) {
              this.key_cache_size = iprot.ReadDouble();
              this.__isset.key_cache_size = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Double) {
              this.read_repair_chance = iprot.ReadDouble();
              this.__isset.read_repair_chance = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.List) {
              {
                this.column_metadata = new List<ColumnDef>();
                TList _list25 = iprot.ReadListBegin();
                for( int _i26 = 0; _i26 < _list25.Count; ++_i26)
                {
                  ColumnDef _elem27 = new ColumnDef();
                  _elem27 = new ColumnDef();
                  _elem27.Read(iprot);
                  this.column_metadata.Add(_elem27);
                }
                iprot.ReadListEnd();
              }
              this.__isset.column_metadata = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.I32) {
              this.gc_grace_seconds = iprot.ReadI32();
              this.__isset.gc_grace_seconds = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("CfDef");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.keyspace != null && __isset.keyspace) {
        field.Name = "keyspace";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.keyspace);
        oprot.WriteFieldEnd();
      }
      if (this.name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.name);
        oprot.WriteFieldEnd();
      }
      if (this.column_type != null && __isset.column_type) {
        field.Name = "column_type";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.column_type);
        oprot.WriteFieldEnd();
      }
      if (this.clock_type != null && __isset.clock_type) {
        field.Name = "clock_type";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.clock_type);
        oprot.WriteFieldEnd();
      }
      if (this.comparator_type != null && __isset.comparator_type) {
        field.Name = "comparator_type";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.comparator_type);
        oprot.WriteFieldEnd();
      }
      if (this.subcomparator_type != null && __isset.subcomparator_type) {
        field.Name = "subcomparator_type";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.subcomparator_type);
        oprot.WriteFieldEnd();
      }
      if (this.reconciler != null && __isset.reconciler) {
        field.Name = "reconciler";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.reconciler);
        oprot.WriteFieldEnd();
      }
      if (this.comment != null && __isset.comment) {
        field.Name = "comment";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.comment);
        oprot.WriteFieldEnd();
      }
      if (__isset.row_cache_size) {
        field.Name = "row_cache_size";
        field.Type = TType.Double;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(this.row_cache_size);
        oprot.WriteFieldEnd();
      }
      if (__isset.preload_row_cache) {
        field.Name = "preload_row_cache";
        field.Type = TType.Bool;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.preload_row_cache);
        oprot.WriteFieldEnd();
      }
      if (__isset.key_cache_size) {
        field.Name = "key_cache_size";
        field.Type = TType.Double;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(this.key_cache_size);
        oprot.WriteFieldEnd();
      }
      if (__isset.read_repair_chance) {
        field.Name = "read_repair_chance";
        field.Type = TType.Double;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(this.read_repair_chance);
        oprot.WriteFieldEnd();
      }
      if (this.column_metadata != null && __isset.column_metadata) {
        field.Name = "column_metadata";
        field.Type = TType.List;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.column_metadata.Count));
          foreach (ColumnDef _iter28 in this.column_metadata)
          {
            _iter28.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.gc_grace_seconds) {
        field.Name = "gc_grace_seconds";
        field.Type = TType.I32;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.gc_grace_seconds);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CfDef(");
      sb.Append("keyspace: ");
      sb.Append(this.keyspace);
      sb.Append(",name: ");
      sb.Append(this.name);
      sb.Append(",column_type: ");
      sb.Append(this.column_type);
      sb.Append(",clock_type: ");
      sb.Append(this.clock_type);
      sb.Append(",comparator_type: ");
      sb.Append(this.comparator_type);
      sb.Append(",subcomparator_type: ");
      sb.Append(this.subcomparator_type);
      sb.Append(",reconciler: ");
      sb.Append(this.reconciler);
      sb.Append(",comment: ");
      sb.Append(this.comment);
      sb.Append(",row_cache_size: ");
      sb.Append(this.row_cache_size);
      sb.Append(",preload_row_cache: ");
      sb.Append(this.preload_row_cache);
      sb.Append(",key_cache_size: ");
      sb.Append(this.key_cache_size);
      sb.Append(",read_repair_chance: ");
      sb.Append(this.read_repair_chance);
      sb.Append(",column_metadata: ");
      sb.Append(this.column_metadata);
      sb.Append(",gc_grace_seconds: ");
      sb.Append(this.gc_grace_seconds);
      sb.Append(")");
      return sb.ToString();
    }

  }

}