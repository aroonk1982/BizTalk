namespace Theta.BizTalk.Common.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Theta.BizTalk.Common.Schemas.InputSchema",@"Customers")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customers"})]
    public sealed class InputSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Theta.BizTalk.Common.Schemas.InputSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Theta.BizTalk.Common.Schemas.InputSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Customers"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerNo"" type=""xs:string"" />
        <xs:element name=""CustomerFirstName"" type=""xs:string"" />
        <xs:element name=""Address"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""AddressLine1"" type=""xs:string"" />
              <xs:element name=""AddressLine2"" type=""xs:string"" />
              <xs:element name=""AddressLine3"" type=""xs:string"" />
              <xs:element name=""Suburb"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
              <xs:element name=""State"" type=""xs:string"" />
              <xs:element name=""Country"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""CustomerLastName"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InputSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Customers";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
