// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BenchmarkService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Benchmark.Grpc.Common {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class BenchmarkService {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static BenchmarkService() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChZCZW5jaG1hcmtTZXJ2aWNlLnByb3RvIhwKDlNlcnZpY2VSZXF1ZXN0EgoK", 
              "AmlkGAEgASgFIh0KD1NlcnZpY2VSZXNwb25zZRIKCgJpZBgBIAEoBTKAAQoQ", 
              "QmVuY2htYXJrU2VydmljZRIwCglPcGVyYXRpb24SDy5TZXJ2aWNlUmVxdWVz", 
              "dBoQLlNlcnZpY2VSZXNwb25zZSIAEjoKD09wZXJhdGlvblN0cmVhbRIPLlNl", 
              "cnZpY2VSZXF1ZXN0GhAuU2VydmljZVJlc3BvbnNlIgAoATABQhiqAhVCZW5j", 
              "aG1hcmsuR3JwYy5Db21tb25iBnByb3RvMw=="));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { },
            new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
              new pbr::GeneratedCodeInfo(typeof(global::Benchmark.Grpc.Common.ServiceRequest), new[]{ "Id" }, null, null, null),
              new pbr::GeneratedCodeInfo(typeof(global::Benchmark.Grpc.Common.ServiceResponse), new[]{ "Id" }, null, null, null)
            }));
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ServiceRequest : pb::IMessage<ServiceRequest> {
    private static readonly pb::MessageParser<ServiceRequest> _parser = new pb::MessageParser<ServiceRequest>(() => new ServiceRequest());
    public static pb::MessageParser<ServiceRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Benchmark.Grpc.Common.Proto.BenchmarkService.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ServiceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ServiceRequest(ServiceRequest other) : this() {
      id_ = other.id_;
    }

    public ServiceRequest Clone() {
      return new ServiceRequest(this);
    }

    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ServiceRequest);
    }

    public bool Equals(ServiceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      return size;
    }

    public void MergeFrom(ServiceRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ServiceResponse : pb::IMessage<ServiceResponse> {
    private static readonly pb::MessageParser<ServiceResponse> _parser = new pb::MessageParser<ServiceResponse>(() => new ServiceResponse());
    public static pb::MessageParser<ServiceResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Benchmark.Grpc.Common.Proto.BenchmarkService.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ServiceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ServiceResponse(ServiceResponse other) : this() {
      id_ = other.id_;
    }

    public ServiceResponse Clone() {
      return new ServiceResponse(this);
    }

    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ServiceResponse);
    }

    public bool Equals(ServiceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      return size;
    }

    public void MergeFrom(ServiceResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code