﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.1433
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace GEXVOC.Core.Informes {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("ConsultaMortalidadDS")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class ConsultaMortalidadDS : global::System.Data.DataSet {
        
        private MortalidadDataTable tableMortalidad;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ConsultaMortalidadDS() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected ConsultaMortalidadDS(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Mortalidad"] != null)) {
                    base.Tables.Add(new MortalidadDataTable(ds.Tables["Mortalidad"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public MortalidadDataTable Mortalidad {
            get {
                return this.tableMortalidad;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override global::System.Data.DataSet Clone() {
            ConsultaMortalidadDS cln = ((ConsultaMortalidadDS)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Mortalidad"] != null)) {
                    base.Tables.Add(new MortalidadDataTable(ds.Tables["Mortalidad"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableMortalidad = ((MortalidadDataTable)(base.Tables["Mortalidad"]));
            if ((initTable == true)) {
                if ((this.tableMortalidad != null)) {
                    this.tableMortalidad.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "ConsultaMortalidadDS";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/ConsultaMortalidadDS.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableMortalidad = new MortalidadDataTable();
            base.Tables.Add(this.tableMortalidad);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeMortalidad() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            ConsultaMortalidadDS ds = new ConsultaMortalidadDS();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        public delegate void MortalidadRowChangeEventHandler(object sender, MortalidadRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class MortalidadDataTable : global::System.Data.TypedTableBase<MortalidadRow> {
            
            private global::System.Data.DataColumn columnTotal_Nacimientos;
            
            private global::System.Data.DataColumn columnMortalidad_Nacimiento;
            
            private global::System.Data.DataColumn columnMortalidad_Perinatal;
            
            private global::System.Data.DataColumn columnMortalidad_Destete;
            
            private global::System.Data.DataColumn columnMortalidad_PostDestete;
            
            private global::System.Data.DataColumn columnDescEspecie;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public MortalidadDataTable() {
                this.TableName = "Mortalidad";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal MortalidadDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected MortalidadDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn Total_NacimientosColumn {
                get {
                    return this.columnTotal_Nacimientos;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn Mortalidad_NacimientoColumn {
                get {
                    return this.columnMortalidad_Nacimiento;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn Mortalidad_PerinatalColumn {
                get {
                    return this.columnMortalidad_Perinatal;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn Mortalidad_DesteteColumn {
                get {
                    return this.columnMortalidad_Destete;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn Mortalidad_PostDesteteColumn {
                get {
                    return this.columnMortalidad_PostDestete;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn DescEspecieColumn {
                get {
                    return this.columnDescEspecie;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public MortalidadRow this[int index] {
                get {
                    return ((MortalidadRow)(this.Rows[index]));
                }
            }
            
            public event MortalidadRowChangeEventHandler MortalidadRowChanging;
            
            public event MortalidadRowChangeEventHandler MortalidadRowChanged;
            
            public event MortalidadRowChangeEventHandler MortalidadRowDeleting;
            
            public event MortalidadRowChangeEventHandler MortalidadRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddMortalidadRow(MortalidadRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public MortalidadRow AddMortalidadRow(int Total_Nacimientos, int Mortalidad_Nacimiento, int Mortalidad_Perinatal, int Mortalidad_Destete, int Mortalidad_PostDestete, string DescEspecie) {
                MortalidadRow rowMortalidadRow = ((MortalidadRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        Total_Nacimientos,
                        Mortalidad_Nacimiento,
                        Mortalidad_Perinatal,
                        Mortalidad_Destete,
                        Mortalidad_PostDestete,
                        DescEspecie};
                rowMortalidadRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowMortalidadRow);
                return rowMortalidadRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override global::System.Data.DataTable Clone() {
                MortalidadDataTable cln = ((MortalidadDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataTable CreateInstance() {
                return new MortalidadDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnTotal_Nacimientos = base.Columns["Total_Nacimientos"];
                this.columnMortalidad_Nacimiento = base.Columns["Mortalidad_Nacimiento"];
                this.columnMortalidad_Perinatal = base.Columns["Mortalidad_Perinatal"];
                this.columnMortalidad_Destete = base.Columns["Mortalidad_Destete"];
                this.columnMortalidad_PostDestete = base.Columns["Mortalidad_PostDestete"];
                this.columnDescEspecie = base.Columns["DescEspecie"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnTotal_Nacimientos = new global::System.Data.DataColumn("Total_Nacimientos", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTotal_Nacimientos);
                this.columnMortalidad_Nacimiento = new global::System.Data.DataColumn("Mortalidad_Nacimiento", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnMortalidad_Nacimiento);
                this.columnMortalidad_Perinatal = new global::System.Data.DataColumn("Mortalidad_Perinatal", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnMortalidad_Perinatal);
                this.columnMortalidad_Destete = new global::System.Data.DataColumn("Mortalidad_Destete", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnMortalidad_Destete);
                this.columnMortalidad_PostDestete = new global::System.Data.DataColumn("Mortalidad_PostDestete", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnMortalidad_PostDestete);
                this.columnDescEspecie = new global::System.Data.DataColumn("DescEspecie", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDescEspecie);
                this.columnTotal_Nacimientos.Caption = "Nacimientos";
                this.columnMortalidad_Nacimiento.Caption = "Nacimientos";
                this.columnMortalidad_Perinatal.Caption = "Nacimientos";
                this.columnMortalidad_Destete.Caption = "Nacimientos";
                this.columnMortalidad_PostDestete.Caption = "Nacimientos";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public MortalidadRow NewMortalidadRow() {
                return ((MortalidadRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new MortalidadRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Type GetRowType() {
                return typeof(MortalidadRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.MortalidadRowChanged != null)) {
                    this.MortalidadRowChanged(this, new MortalidadRowChangeEvent(((MortalidadRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.MortalidadRowChanging != null)) {
                    this.MortalidadRowChanging(this, new MortalidadRowChangeEvent(((MortalidadRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.MortalidadRowDeleted != null)) {
                    this.MortalidadRowDeleted(this, new MortalidadRowChangeEvent(((MortalidadRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.MortalidadRowDeleting != null)) {
                    this.MortalidadRowDeleting(this, new MortalidadRowChangeEvent(((MortalidadRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveMortalidadRow(MortalidadRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                ConsultaMortalidadDS ds = new ConsultaMortalidadDS();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "MortalidadDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class MortalidadRow : global::System.Data.DataRow {
            
            private MortalidadDataTable tableMortalidad;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal MortalidadRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableMortalidad = ((MortalidadDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Total_Nacimientos {
                get {
                    try {
                        return ((int)(this[this.tableMortalidad.Total_NacimientosColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("El valor de la columna \'Total_Nacimientos\' de la tabla \'Mortalidad\' es DBNull.", e);
                    }
                }
                set {
                    this[this.tableMortalidad.Total_NacimientosColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Mortalidad_Nacimiento {
                get {
                    try {
                        return ((int)(this[this.tableMortalidad.Mortalidad_NacimientoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("El valor de la columna \'Mortalidad_Nacimiento\' de la tabla \'Mortalidad\' es DBNull" +
                                ".", e);
                    }
                }
                set {
                    this[this.tableMortalidad.Mortalidad_NacimientoColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Mortalidad_Perinatal {
                get {
                    try {
                        return ((int)(this[this.tableMortalidad.Mortalidad_PerinatalColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("El valor de la columna \'Mortalidad_Perinatal\' de la tabla \'Mortalidad\' es DBNull." +
                                "", e);
                    }
                }
                set {
                    this[this.tableMortalidad.Mortalidad_PerinatalColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Mortalidad_Destete {
                get {
                    try {
                        return ((int)(this[this.tableMortalidad.Mortalidad_DesteteColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("El valor de la columna \'Mortalidad_Destete\' de la tabla \'Mortalidad\' es DBNull.", e);
                    }
                }
                set {
                    this[this.tableMortalidad.Mortalidad_DesteteColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Mortalidad_PostDestete {
                get {
                    try {
                        return ((int)(this[this.tableMortalidad.Mortalidad_PostDesteteColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("El valor de la columna \'Mortalidad_PostDestete\' de la tabla \'Mortalidad\' es DBNul" +
                                "l.", e);
                    }
                }
                set {
                    this[this.tableMortalidad.Mortalidad_PostDesteteColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string DescEspecie {
                get {
                    try {
                        return ((string)(this[this.tableMortalidad.DescEspecieColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("El valor de la columna \'DescEspecie\' de la tabla \'Mortalidad\' es DBNull.", e);
                    }
                }
                set {
                    this[this.tableMortalidad.DescEspecieColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsTotal_NacimientosNull() {
                return this.IsNull(this.tableMortalidad.Total_NacimientosColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetTotal_NacimientosNull() {
                this[this.tableMortalidad.Total_NacimientosColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsMortalidad_NacimientoNull() {
                return this.IsNull(this.tableMortalidad.Mortalidad_NacimientoColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetMortalidad_NacimientoNull() {
                this[this.tableMortalidad.Mortalidad_NacimientoColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsMortalidad_PerinatalNull() {
                return this.IsNull(this.tableMortalidad.Mortalidad_PerinatalColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetMortalidad_PerinatalNull() {
                this[this.tableMortalidad.Mortalidad_PerinatalColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsMortalidad_DesteteNull() {
                return this.IsNull(this.tableMortalidad.Mortalidad_DesteteColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetMortalidad_DesteteNull() {
                this[this.tableMortalidad.Mortalidad_DesteteColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsMortalidad_PostDesteteNull() {
                return this.IsNull(this.tableMortalidad.Mortalidad_PostDesteteColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetMortalidad_PostDesteteNull() {
                this[this.tableMortalidad.Mortalidad_PostDesteteColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsDescEspecieNull() {
                return this.IsNull(this.tableMortalidad.DescEspecieColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetDescEspecieNull() {
                this[this.tableMortalidad.DescEspecieColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class MortalidadRowChangeEvent : global::System.EventArgs {
            
            private MortalidadRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public MortalidadRowChangeEvent(MortalidadRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public MortalidadRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591