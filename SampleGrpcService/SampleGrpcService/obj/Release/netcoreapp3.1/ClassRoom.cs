// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/classRoom.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SampleGrpcService.Protos {

  /// <summary>Holder for reflection information generated from Protos/classRoom.proto</summary>
  public static partial class ClassRoomReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/classRoom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClassRoomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90b3MvY2xhc3NSb29tLnByb3RvEgljbGFzc3Jvb20iOAoHU3R1ZGVu",
            "dBIOCgZSb2xsTm8YASABKAUSDAoETmFtZRgCIAEoCRIPCgdFbWFpbElkGAMg",
            "ASgJIi0KBUNsYXNzEiQKCFN0dWRlbnRzGAEgAygLMhIuY2xhc3Nyb29tLlN0",
            "dWRlbnQiIAoOU3R1ZGVudFJlcXVlc3QSDgoGUm9sbE5vGAEgASgFMlMKCUNs",
            "YXNzUm9vbRJGChVHZXRTdHVkZW50SW5mb3JtYXRpb24SGS5jbGFzc3Jvb20u",
            "U3R1ZGVudFJlcXVlc3QaEi5jbGFzc3Jvb20uU3R1ZGVudEIbqgIYU2FtcGxl",
            "R3JwY1NlcnZpY2UuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SampleGrpcService.Protos.Student), global::SampleGrpcService.Protos.Student.Parser, new[]{ "RollNo", "Name", "EmailId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SampleGrpcService.Protos.Class), global::SampleGrpcService.Protos.Class.Parser, new[]{ "Students" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SampleGrpcService.Protos.StudentRequest), global::SampleGrpcService.Protos.StudentRequest.Parser, new[]{ "RollNo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Student : pb::IMessage<Student> {
    private static readonly pb::MessageParser<Student> _parser = new pb::MessageParser<Student>(() => new Student());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Student> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SampleGrpcService.Protos.ClassRoomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Student() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Student(Student other) : this() {
      rollNo_ = other.rollNo_;
      name_ = other.name_;
      emailId_ = other.emailId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Student Clone() {
      return new Student(this);
    }

    /// <summary>Field number for the "RollNo" field.</summary>
    public const int RollNoFieldNumber = 1;
    private int rollNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RollNo {
      get { return rollNo_; }
      set {
        rollNo_ = value;
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "EmailId" field.</summary>
    public const int EmailIdFieldNumber = 3;
    private string emailId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EmailId {
      get { return emailId_; }
      set {
        emailId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Student);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Student other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RollNo != other.RollNo) return false;
      if (Name != other.Name) return false;
      if (EmailId != other.EmailId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RollNo != 0) hash ^= RollNo.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (EmailId.Length != 0) hash ^= EmailId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RollNo != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RollNo);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (EmailId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EmailId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RollNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RollNo);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (EmailId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EmailId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Student other) {
      if (other == null) {
        return;
      }
      if (other.RollNo != 0) {
        RollNo = other.RollNo;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.EmailId.Length != 0) {
        EmailId = other.EmailId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RollNo = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            EmailId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Class : pb::IMessage<Class> {
    private static readonly pb::MessageParser<Class> _parser = new pb::MessageParser<Class>(() => new Class());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Class> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SampleGrpcService.Protos.ClassRoomReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Class() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Class(Class other) : this() {
      students_ = other.students_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Class Clone() {
      return new Class(this);
    }

    /// <summary>Field number for the "Students" field.</summary>
    public const int StudentsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::SampleGrpcService.Protos.Student> _repeated_students_codec
        = pb::FieldCodec.ForMessage(10, global::SampleGrpcService.Protos.Student.Parser);
    private readonly pbc::RepeatedField<global::SampleGrpcService.Protos.Student> students_ = new pbc::RepeatedField<global::SampleGrpcService.Protos.Student>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SampleGrpcService.Protos.Student> Students {
      get { return students_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Class);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Class other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!students_.Equals(other.students_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= students_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      students_.WriteTo(output, _repeated_students_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += students_.CalculateSize(_repeated_students_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Class other) {
      if (other == null) {
        return;
      }
      students_.Add(other.students_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            students_.AddEntriesFrom(input, _repeated_students_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class StudentRequest : pb::IMessage<StudentRequest> {
    private static readonly pb::MessageParser<StudentRequest> _parser = new pb::MessageParser<StudentRequest>(() => new StudentRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StudentRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SampleGrpcService.Protos.ClassRoomReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StudentRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StudentRequest(StudentRequest other) : this() {
      rollNo_ = other.rollNo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StudentRequest Clone() {
      return new StudentRequest(this);
    }

    /// <summary>Field number for the "RollNo" field.</summary>
    public const int RollNoFieldNumber = 1;
    private int rollNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RollNo {
      get { return rollNo_; }
      set {
        rollNo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StudentRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StudentRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RollNo != other.RollNo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RollNo != 0) hash ^= RollNo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RollNo != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RollNo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RollNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RollNo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StudentRequest other) {
      if (other == null) {
        return;
      }
      if (other.RollNo != 0) {
        RollNo = other.RollNo;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RollNo = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code