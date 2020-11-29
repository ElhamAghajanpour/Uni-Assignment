

#pragma warning disable 1591

namespace WindowsFormsApplication6
{

    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("BookStoreDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class BookStoreDataSet : global::System.Data.DataSet
    {


        private BookDataTable tableBook;

        private BookTypeDataTable tableBookType;

        private CustomerDataTable tableCustomer;

        private FactorDataTable tableFactor;

        private OrderListDataTable tableOrderList;

        private Good_BookDataTable tableGood_Book;

        private Good_CustomerDataTable tableGood_Customer;

        private Good_FactorDataTable tableGood_Factor;

        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookStoreDataSet()
        {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected BookStoreDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context, false)
        {
            if ((this.IsBinarySerialized(info, context) == true))
            {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema))
            {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Book"] != null))
                {
                    base.Tables.Add(new BookDataTable(ds.Tables["Book"]));
                }
                if ((ds.Tables["BookType"] != null))
                {
                    base.Tables.Add(new BookTypeDataTable(ds.Tables["BookType"]));
                }
                if ((ds.Tables["Customer"] != null))
                {
                    base.Tables.Add(new CustomerDataTable(ds.Tables["depot"]));
                }
                if ((ds.Tables["Factor"] != null))
                {
                    base.Tables.Add(new FactorDataTable(ds.Tables["Factor"]));
                }
                if ((ds.Tables["OrderList"] != null))
                {
                    base.Tables.Add(new OrderListDataTable(ds.Tables["OrderList"]));
                }
                if ((ds.Tables["Good_Book"] != null))
                {
                    base.Tables.Add(new Good_BookDataTable(ds.Tables["Good_Book"]));
                }
                if ((ds.Tables["Good_Customer"] != null))
                {
                    base.Tables.Add(new Good_CustomerDataTable(ds.Tables["Good_Customer"]));
                }
                if ((ds.Tables["Good_Factor"] != null))
                {
                    base.Tables.Add(new Good_FactorDataTable(ds.Tables["Good_Factor"]));
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
            else
            {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public BookDataTable Book
        {
            get
            {
                return this.tableBook;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public BookTypeDataTable BookType
        {
            get
            {
                return this.tableBookType;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CustomerDataTable Customer
        {
            get
            {
                return this.tableCustomer;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public FactorDataTable Factor
        {
            get
            {
                return this.tableFactor;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public OrderListDataTable OrderList
        {
            get
            {
                return this.tableOrderList;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Good_BookDataTable Good_Book
        {
            get
            {
                return this.tableGood_Book;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Good_CustomerDataTable Good_Customer
        {
            get
            {
                return this.tableGood_Customer;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Good_FactorDataTable Good_Factor
        {
            get
            {
                return this.tableGood_Factor;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this._schemaSerializationMode;
            }
            set
            {
                this._schemaSerializationMode = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone()
        {
            BookStoreDataSet cln = ((BookStoreDataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader)
        {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema))
            {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Book"] != null))
                {
                    base.Tables.Add(new BookDataTable(ds.Tables["Book"]));
                }
                if ((ds.Tables["BookType"] != null))
                {
                    base.Tables.Add(new BookTypeDataTable(ds.Tables["BookType"]));
                }
                if ((ds.Tables["Customer"] != null))
                {
                    base.Tables.Add(new CustomerDataTable(ds.Tables["Customer"]));
                }
                if ((ds.Tables["Factor"] != null))
                {
                    base.Tables.Add(new FactorDataTable(ds.Tables["Factor"]));
                }
                if ((ds.Tables["OrderList"] != null))
                {
                    base.Tables.Add(new OrderListDataTable(ds.Tables["OrderList"]));
                }
                if ((ds.Tables["Good_Book"] != null))
                {
                    base.Tables.Add(new Good_BookDataTable(ds.Tables["Good_Book"]));
                }
                if ((ds.Tables["Good_Customer"] != null))
                {
                    base.Tables.Add(new Good_CustomerDataTable(ds.Tables["Good_Customer"]));
                }
                if ((ds.Tables["Good_Factor"] != null))
                {
                    base.Tables.Add(new Good_FactorDataTable(ds.Tables["Good_Factor"]));
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
            else
            {
                this.ReadXml(reader);
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable()
        {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.InitVars(true);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable)
        {
            this.tableBook = ((BookDataTable)(base.Tables["Book"]));
            if ((initTable == true))
            {
                if ((this.tableBook != null))
                {
                    this.tableBook.InitVars();
                }
            }
            this.tableBookType = ((BookTypeDataTable)(base.Tables["BookType"]));
            if ((initTable == true))
            {
                if ((this.tableBookType != null))
                {
                    this.tableBookType.InitVars();
                }
            }
            this.tableCustomer = ((CustomerDataTable)(base.Tables["Customer"]));
            if ((initTable == true))
            {
                if ((this.tableCustomer != null))
                {
                    this.tableCustomer.InitVars();
                }
            }
            this.tableFactor = ((FactorDataTable)(base.Tables["Factor"]));
            if ((initTable == true))
            {
                if ((this.tableFactor != null))
                {
                    this.tableFactor.InitVars();
                }
            }
            this.tableOrderList = ((OrderListDataTable)(base.Tables["OrderList"]));
            if ((initTable == true))
            {
                if ((this.tableOrderList != null))
                {
                    this.tableOrderList.InitVars();
                }
            }
            this.tableGood_book = ((Good_bookDataTable)(base.Tables["Good_book"]));
            if ((initTable == true))
            {
                if ((this.tableGood_book != null))
                {
                    this.tableGood_book.InitVars();
                }
            }
            this.tableGood_Customer = ((Good_CustomerDataTable)(base.Tables["Good_Customer"]));
            if ((initTable == true))
            {
                if ((this.tableGood_Customer != null))
                {
                    this.tableGood_Customer.InitVars();
                }
            }
            this.tableGood_Factor = ((Good_FactorDataTable)(base.Tables["Good_Factor"]));
            if ((initTable == true))
            {
                if ((this.tableGood_Factor != null))
                {
                    this.tableGood_Factor.InitVars();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.DataSetName = "BookStoreDataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/BookStoreDataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableBook = new BookDataTable();
            base.Tables.Add(this.tableBook);
            this.tableBookType = new BookTypeDataTable();
            base.Tables.Add(this.tableBookType);
            this.tableCustomer = new CustomerDataTable();
            base.Tables.Add(this.tableCustomer);
            this.tableFactor = new FactorDataTable();
            base.Tables.Add(this.tableFactor);
            this.tableOrderList = new OrderListDataTable();
            base.Tables.Add(this.tableOrderList);
            this.tableGood_Book = new Good_BookDataTable();
            base.Tables.Add(this.tableGood_Book);
            this.tableGood_Customer = new Good_CustomerDataTable();
            base.Tables.Add(this.tableGood_Customer);
            this.tableGood_Factor = new Good_FactorDataTable();
            base.Tables.Add(this.tableGood_Factor);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeBook()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeBookType()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeCustomer()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeFactor()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeOrderList()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeGood_Book()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeGood_Customer()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeGood_Factor()
        {
            return false;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs)
    {
        BookStoreDataSet ds = new BookStoreDataSet();
        global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
        global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
        global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
        any.Namespace = ds.Namespace;
        sequence.Items.Add(any);
        type.Particle = sequence;
        global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
        if (xs.Contains(dsSchema.TargetNamespace))
        {
            global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
            global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
            try
            {
                global::System.Xml.Schema.XmlSchema schema = null;
                dsSchema.Write(s1);
                for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                {
                    schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                    s2.SetLength(0);
                    schema.Write(s2);
                    if ((s1.Length == s2.Length))
                    {
                        s1.Position = 0;
                        s2.Position = 0;
                        for (; ((s1.Position != s1.Length)
                                    && (s1.ReadByte() == s2.ReadByte()));)
                        {
                            ;
                        }
                        if ((s1.Position == s1.Length))
                        {
                            return type;
                        }
                    }
                }
            }
            finally
            {
                if ((s1 != null))
                {
                    s1.Close();
                }
                if ((s2 != null))
                {
                    s2.Close();
                }
            }
        }
        xs.Add(dsSchema);
        return type;
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void BookRowChangeEventHandler(object sender, BookRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void BookTypeRowChangeEventHandler(object sender, BookTypeRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void CustomerRowChangeEventHandler(object sender, CustomerRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void FactorRowChangeEventHandler(object sender, FactorRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void OrderListRowChangeEventHandler(object sender, OrderListRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void Good_BookRowChangeEventHandler(object sender, Good_BookRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void Good_CustomerRowChangeEventHandler(object sender, Good_CustomerRowChangeEvent e);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void Good_FactorRowChangeEventHandler(object sender, Good_FactorRowChangeEvent e);

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class BookDataTable : global::System.Data.TypedTableBase<BookRow>
    {

        private global::System.Data.DataColumn columnageid;

        private global::System.Data.DataColumn columnstartrange;

        private global::System.Data.DataColumn columnendrange;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookDataTable()
        {
            this.TableName = "Book";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal BookDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected BookDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn booknameColumn
        {
            get
            {
                return this.columnbookname;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_idColumn
        {
            get
            {
                return this.columnbook_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn booktype_idColumn
        {
            get
            {
                return this.columnbooktype_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn priceColumn
        {
            get
            {
                return this.columnprice;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_languageColumn
        {
            get
            {
                return this.columnbook_language;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn publisherColumn
        {
            get
            {
                return this.columnpublisher;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn agecategoryColumn
        {
            get
            {
                return this.columnagecategory;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn QtyColumn
        {
            get
            {
                return this.columnQty;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookRow this[int index]
        {
            get
            {
                return ((BookRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowDeleted;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowDeleted;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowDeleted;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowDeleted;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookRowChangeEventHandler BookRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddBookRow(BookRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookRow AddBookRow(string bookname, int book_id, int booktype_id, float price, string book_language, string publisher, string agecategory, int Qty)
        {
            BookRow rowBookRow = ((BookRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                bookname,
                book_id,
                booktype_id,
                price,
                book_language,
                publisher,
                agecategory,
                Qty};
            rowBookRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowBookRow);
            return rowBookRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookRow FindByageid(int book_id)
        {
            return ((BookRow)(this.Rows.Find(new object[] {
                            bookname})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            BookDataTable cln = ((BookDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new BookDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columnbookname = base.Columns["bookname"];
            this.columnbook_id = base.Columns["book_id"];
            this.columnbooktype_id = base.Columns["booktype_id"];
            this.columnprice = base.Columns["price"];
            this.columnbook_language = base.Columns["book_language"];
            this.columnpublisher = base.Columns["publisher"];
            this.columnagecategory = base.Columns["agecategory"];
            this.columnQty = base.Columns["Qty"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columnbookname = new global::System.Data.DataColumn("bookname", typeof(string), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbookname);
            this.columnbook_id = new global::System.Data.DataColumn("book_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_id);
            this.columnbooktype_id = new global::System.Data.DataColumn("booktype_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbooktype_id);
            this.columnprice = new global::System.Data.DataColumn("price", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnprice);
            this.columnbook_language = new global::System.Data.DataColumn("book_language", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_language);
            this.columnpublisher = new global::System.Data.DataColumn("publisher", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnpublisher);
            this.columnagecategory = new global::System.Data.DataColumn("agecategory", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnagecategory);
            this.columnQty = new global::System.Data.DataColumn("Qty", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnQty);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columbook_id}, true));
            this.columnbook_id.AllowDBNull = false;
            this.columnbook_id.Unique = true;
            this.columnbook_id.MaxLength = 1000000;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookRow NewBookRow()
        {
            return ((BookRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new BookRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(BookRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.BookRowChanged != null))
            {
                this.BookRowChanged(this, new BookRowChangeEvent(((BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.BookRowChanging != null))
            {
                this.BookRowChanging(this, new BookRowChangeEvent(((BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.BookRowDeleted != null))
            {
                this.BookRowDeleted(this, new BookRowChangeEvent(((BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.BookRowDeleting != null))
            {
                this.BookRowDeleting(this, new BookChangeEvent(((BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveBookRow(BookRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "BookDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class BookTypeDataTable : global::System.Data.TypedTableBase<BookTypeRow>
    {

        private global::System.Data.DataColumn columnbooktype_id;

        private global::System.Data.DataColumn columnbooktype;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookTypeDataTable()
        {
            this.TableName = "BookType";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal BookTypeDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected BookTypeDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn booktype_idColumn
        {
            get
            {
                return this.columnbooktype_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn booktypeColumn
        {
            get
            {
                return this.columnbooktype;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookTypeRow this[int index]
        {
            get
            {
                return ((BookTypeRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookTypeRowChangeEventHandler BookTypeRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookTypeRowChangeEventHandler BookTypeRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookTypeRowChangeEventHandler BookTypeRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event BookTypeRowChangeEventHandler BookTypeRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddBookTypeRow(BookTypeRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookTypeRow AddBookTypeRow(int booktype_id, string booktype)
        {
            BookTypeRow rowBookTypeRow = ((BookTypeRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                        booktype_id,
                        booktype};
            rowBookTypeRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowBookTypeRow);
            return rowBookTypeRow;
        }
        //????????????????????
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookTypeRow FindBybooktype_id(int booktype_id)
        {
            return ((BookTypeRow)(this.Rows.Find(new object[] {
                            booktype_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            BookTypeDataTable cln = ((BookTypeDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new BookTypeDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columnbooktype_id = base.Columns["booktype_id"];
            this.columnbooktype = base.Columns["booktype"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columnbooktype_id = new global::System.Data.DataColumn("booktype_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbooktype_id);
            this.columnbooktype = new global::System.Data.DataColumn("booktype", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbooktype);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnbooktype_id}, true));
            this.columnbooktype_id.AllowDBNull = false;
            this.columnbooktype_id.Unique = true;
            this.columnbooktype.AllowDBNull = false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BookTypeRow NewBookTypeRow()
        {
            return ((BookTypeRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new BookTypeRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(BookTypeRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.BookTypeRowChanged != null))
            {
                this.BookTypeRowChanged(this, new BookTypeRowChangeEvent(((BookTypeRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.BookTypeRowChanging != null))
            {
                this.BookTypeRowChanging(this, new BookTypeRowChangeEvent(((BookTypeRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.BookTypeRowDeleted != null))
            {
                this.BookTypeRowDeleted(this, new BookTypeRowChangeEvent(((BookTypeRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.BookTypeRowDeleting != null))
            {
                this.BookTypeRowDeleting(this, new BookTypeRowChangeEvent(((BookTypeRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveBookTypeRow(BookTypeRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "BookTypeDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class CustomerDataTable : global::System.Data.TypedTableBase<CustomerRow>
    {

        private global::System.Data.DataColumn columncustomername;

        private global::System.Data.DataColumn columncustomer_id;

        private global::System.Data.DataColumn columnphone_number;

        private global::System.Data.DataColumn columnage;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CustomerDataTable()
        {
            this.TableName = "Customer";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal CustomerDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected CustomerDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn customernameColumn
        {
            get
            {
                return this.columncustomername;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn customer_idColumn
        {
            get
            {
                return this.columncustomer_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn phone_numberColumn
        {
            get
            {
                return this.columnphone_number;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn ageColumn
        {
            get
            {
                return this.columnage;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CustomerRow this[int index]
        {
            get
            {
                return ((CustomerRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event CustomerRowChangeEventHandler CustomerRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event CustomerRowChangeEventHandler CustomerRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event CustomerRowChangeEventHandler CustomerRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event CustomerRowChangeEventHandler CustomerRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddCustomerRow(CustomerRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CustomerRow AddCustomerRow(string customername, int customer_id, string phone_number, string age)
        {
            CustomerRow rowCustomerRow = ((CustomerRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                customername,
                customer_id,
                phone_number,
                age};
            rowCustomerRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowCustomerRow);
            return rowCustomerRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CustomerRow FindBycustomer_id(int customer_id)
        {
            return ((CustomerRow)(this.Rows.Find(new object[] {
                           customer_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            CustomerDataTable cln = ((CustomerDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new CustomerDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columncustomername = base.Columns["customername"];
            this.columncustomer_id = base.Columns["customer_id"];
            this.columnphone_number = base.Columns["phone_number"];
            this.columnage = base.Columns["age"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columncustomername = new global::System.Data.DataColumn("customername", typeof(string), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columncustomername);
            this.columncustomer_id = new global::System.Data.DataColumn("customer_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columncustomer_id);
            this.columnphone_number = new global::System.Data.DataColumn("phone_number", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnphone_number);
            this.columnage = new global::System.Data.DataColumn("age", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnage);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columncustomer_id}, true));
            this.columncustomer_id.AllowDBNull = false;
            this.columncustomer_id.Unique = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CustomerRow NewCustomerRow()
        {
            return ((CustomerRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new CustomerRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(CustomerRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.CustomerRowChanged != null))
            {
                this.CustomerRowChanged(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.CustomerRowChanging != null))
            {
                this.CustomerRowChanging(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.CustomerRowDeleted != null))
            {
                this.CustomerRowDeleted(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.CustomerRowDeleting != null))
            {
                this.CustomerRowDeleting(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveCustomerRow(CustomerRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "CustomerDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class FactorDataTable : global::System.Data.TypedTableBase<FactorRow>
    {

        private global::System.Data.DataColumn columnfactor_id;

        private global::System.Data.DataColumn columnubook_id;

        private global::System.Data.DataColumn columncustomer_id;

        private global::System.Data.DataColumn columntotal_price;

        private global::System.Data.DataColumn columnpyment_price;

        private global::System.Data.DataColumn columndiscountpercent;

        private global::System.Data.DataColumn columnfactor_data;

        private global::System.Data.DataColumn columnfactor_time;

        private global::System.Data.DataColumn columnbook_number;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FactorDataTable()
        {
            this.TableName = "Factor";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal FactorDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected FactorDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn factor_idColumn
        {
            get
            {
                return this.columnfactor_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_idColumn
        {
            get
            {
                return this.columnbook_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn customer_idColumn
        {
            get
            {
                return this.columncustomer_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn total_priceColumn
        {
            get
            {
                return this.columntotal_price;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn pyment_priceColumn
        {
            get
            {
                return this.columnpyment_price;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn discountpercentColumn
        {
            get
            {
                return this.columndiscountpercent;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn factor_dataColumn
        {
            get
            {
                return this.columnfactor_data;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn factor_timeColumn
        {
            get
            {
                return this.columnfactor_time;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_numberColumn
        {
            get
            {
                return this.columnbook_number;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FactorRow this[int index]
        {
            get
            {
                return ((FactorRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event FactorRowChangeEventHandler FactorRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event FactorRowChangeEventHandler FactorRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event FactorRowChangeEventHandler FactorRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event FactorRowChangeEventHandler FactorRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddFactorRow(FactorRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FactorRow AddFactorRow(int factor_id, int book_id, int customer_id, float total_price, float pyment_price, int discountpercent, System.DateTime factor_data, System.TimeSpan factor_time, int book_number)
        {
            FactorRow rowFactorRow = ((FactorRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                factor_id,
                book_id,
                customer_id,
                total_price,
                pyment_price,
                discountpercent,
                factor_data,
                factor_time,
                book_number};
            rowFactorRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowFactorRow);
            return rowFactorRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FactorRow FindByfactor_id(int factor_id)
        {
            return ((FactorRow)(this.Rows.Find(new object[] {
                            factor_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            FactorDataTable cln = ((FactorDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new FactorDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columnfactor_id = base.Columns["factor_id"];
            this.columnubook_id = base.Columns["book_id"];
            this.columncustomer_id = base.Columns["customer_id"];
            this.columntotal_price = base.Columns["total_price"];
            this.columnpyment_price = base.Columns["pyment_price"];
            this.columndiscountpercent = base.Columns["discountpercent"];
            this.columnfactor_data = base.Columns["factor_data"];
            this.columnfactor_time = base.Columns["factor_time"];
            this.columnbook_number = base.Columns["book_number"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columnfactor_id = new global::System.Data.DataColumn("factor_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnfactor_id);
            this.columnbook_id = new global::System.Data.DataColumn("book_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_id);
            this.columncustomer_id = new global::System.Data.DataColumn("customer_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columncustomer_id);
            this.columntotal_price = new global::System.Data.DataColumn("total_price", typeof(float), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columntotal_price);
            this.columnpyment_price = new global::System.Data.DataColumn("pyment_price", typeof(float), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnpyment_price);
            this.columndiscountpercent = new global::System.Data.DataColumn("discountpercent", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columndiscountpercent);
            this.columnfactor_data = new global::System.Data.DataColumn("factor_data", typeof(global::System.DateTime), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnfactor_data);
            this.columnfactor_time = new global::System.Data.DataColumn("factor_time", typeof(global::System.TimeSpan), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnfactor_time);
            this.columnbook_number = new global::System.Data.DataColumn("book_number", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_number);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnfactor_id}, true));
            this.columnfactor_id.AllowDBNull = false;
            this.columnfactor_id.Unique = true;
            this.columnbook_id.AllowDBNull = false;
            this.columncustomer_id.AllowDBNull = false;
            this.columntotal_price.AllowDBNull = false;
            this.columnpyment_price.AllowDBNull = false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FactorRow NewFactorRow()
        {
            return ((FactorRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new FactorRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(FactorRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.FactorRowChanged != null))
            {
                this.FactorRowChanged(this, new FactorRowChangeEvent(((FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.FactorRowChanging != null))
            {
                this.FactorRowChanging(this, new FactorRowChangeEvent(((FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.FactorRowDeleted != null))
            {
                this.FactorRowDeleted(this, new FactorRowChangeEvent(((FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.FactorRowDeleting != null))
            {
                this.FactorRowDeleting(this, new FactorRowChangeEvent(((FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveFactorRow(FactorRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "FactorDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class OrderListDataTable : global::System.Data.TypedTableBase<OrderListRow>
    {

        private global::System.Data.DataColumn columnfactor_id;

        private global::System.Data.DataColumn columnbook_id;

        private global::System.Data.DataColumn columnbook_number;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrderListDataTable()
        {
            this.TableName = "OrderList";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal OrderListDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected OrderListDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn factor_idColumn
        {
            get
            {
                return this.columnfactor_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_idColumn
        {
            get
            {
                return this.columnbook_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_numberColumn
        {
            get
            {
                return this.columnbook_number;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrderListRow this[int index]
        {
            get
            {
                return ((OrderListRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event OrderListRowChangeEventHandler OrderListRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event OrderListRowChangeEventHandler OrderListRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event OrderListRowChangeEventHandler OrderListRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event OrderListRowChangeEventHandler OrderListRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddOrderListRow(OrderListRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrderListRow AddOrderListRow(int factor_id, int book_id, int book_number)
        {
            OrderListRow rowOrderListRow = ((OrderListRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                factor_id,
                book_id,
                book_number};
            rowOrderListRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowOrderListRow);
            return rowOrderListRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrderListRow FindByfactor_id(int factor_id)
        {
            return ((OrderListRow)(this.Rows.Find(new object[] {
                            factor_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrderListRow FindBybook_id(int book_id)
        {
            return ((OrderListRow)(this.Rows.Find(new object[] {
                            book_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            OrderListDataTable cln = ((OrderListDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new OrderListDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columnfactor_id = base.Columns["factor_id"];
            this.columnbook_id = base.Columns["book_id"];
            this.columnbook_number = base.Columns["book_number"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columnfactor_id = new global::System.Data.DataColumn("factor_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnfactor_id);
            this.columnbook_id = new global::System.Data.DataColumn("book_id", typeof(int), global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_id);
            this.columnbook_number = new global::System.Data.DataColumn("book_number", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_number);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnfactor_id , this.columnbook_id}, true));
            this.columnfactor_id.AllowDBNull = false;
            this.columnfactor_id.Unique = true;
            this.columnbook_id.AllowDBNull = false;
            this.columnbook_id.Unique = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrderListRow NewOrderListRow()
        {
            return ((OrderListRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new OrderListRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(OrderListRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.OrderListRowChanged != null))
            {
                this.OrderListRowChanged(this, new OrderListRowChangeEvent(((OrderListRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.OrderListRowChanging != null))
            {
                this.OrderListRowChanging(this, new OrderListRowChangeEvent(((OrderListRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.OrderListRowDeleted != null))
            {
                this.OrderListRowDeleted(this, new OrderListRowChangeEvent(((OrderListRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.OrderListRowDeleting != null))
            {
                this.OrderListRowDeleting(this, new OrderListRowChangeEvent(((OrderListRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveOrderListRow(OrderListRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "OrderListDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class Good_BookDataTable : global::System.Data.TypedTableBase<Good_BookRow>
    {


        private global::System.Data.DataColumn columnbookname;

        private global::System.Data.DataColumn columnbook_id;

        private global::System.Data.DataColumn columnprice;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_BookDataTable()
        {
            this.TableName = "Good_Book";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal Good_BookDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected Good_BookDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn booknameColumn
        {
            get
            {
                return this.columnbookname;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn book_idColumn
        {
            get
            {
                return this.columnbook_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn priceColumn
        {
            get
            {
                return this.columnprice;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_BookRow this[int index]
        {
            get
            {
                return ((Good_BookRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_BookRowChangeEventHandler Good_BookRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_BookRowChangeEventHandler Good_BookRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_BookRowChangeEventHandler Good_BookRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_BookRowChangeEventHandler Good_BookRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddGood_BookeRow(Good_BookRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_BookRow AddGood_BookRow(int book_id, string bookname, float price)
        {
            Good_BookRow rowGood_BookRow = ((Good_BookRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                        book_id,
                        bookname,
                        price};
            rowGood_BookRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowGood_BookRow);
            return rowGood_BookRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_BookRow FindBybook_id(int book_id)
        {
            return ((Good_BookRow)(this.Rows.Find(new object[] {
                            book_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            Good_BookDataTable cln = ((Good_BookDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new Good_BookDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columnbook_id = base.Columns["book_id"];
            this.columnbookname = base.Columns["bookname"];
            this.columnprice = base.Columns["price"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columnbook_id = new global::System.Data.DataColumn("book_id", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbook_id);
            this.columnbookname = new global::System.Data.DataColumn("bookname", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnbookname);
            this.columnprice = new global::System.Data.DataColumn("price", typeof(float), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnprice);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnbook_id}, true));
            this.columnbook_id.AllowDBNull = false;
            this.columnbook_id.Unique = true;
            this.columnprice.AllowDBNull = false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_BookRow NewGood_BookRow()
        {
            return ((Good_BookRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new Good_BookRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(Good_BookRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.Good_BookRowChanged != null))
            {
                this.Good_BookRowChanged(this, new Good_BookRowChangeEvent(((Good_BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.Good_BookRowChanging != null))
            {
                this.Good_BookRowChanging(this, new Good_BookRowChangeEvent(((Good_BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.Good_BookRowDeleted != null))
            {
                this.Good_BookRowDeleted(this, new Good_BookRowChangeEvent(((Good_BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.Good_BookRowDeleting != null))
            {
                this.Good_BookRowDeleting(this, new Good_BookRowChangeEvent(((Good_BookRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveGood_BookRow(Good_BookRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "Good_BookDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class Good_CustomerDataTable : global::System.Data.TypedTableBase<Good_CustomerRow>
    {

        private global::System.Data.DataColumn columncustomername;

        private global::System.Data.DataColumn columncustomer_id;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_CustomerDataTable()
        {
            this.TableName = "Good_Customer";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal Good_CustomerDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected Good_CustomerDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn customernameColumn
        {
            get
            {
                return this.columncustomername;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn customer_idColumn
        {
            get
            {
                return this.columncustomer_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_CustomerRow this[int index]
        {
            get
            {
                return ((Good_CustomerRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_CustomerRowChangeEventHandler Good_CustomerRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_CustomerRowChangeEventHandler Good_CustomerRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_CustomerRowChangeEventHandler Good_CustomerRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_CustomerRowChangeEventHandler Good_CustomerRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddGood_CustomerRow(Good_CustomerRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_CustomerRow AddGood_CustomerRow(string customername, int customer_id)
        {
            Good_CustomerRow rowGood_CustomerRow = ((Good_CustomerRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                customername,
                customer_id};
            rowGood_CustomerRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowGood_CustomerRow);
            return rowGood_CustomerRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_CustomerRow FindBycustomer_id(int customer_id)
        {
            return ((Good_CustomerRow)(this.Rows.Find(new object[] {
                            customer_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            Good_CustomerDataTable cln = ((Good_CustomerDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new Good_CustomerDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.customernameColumn = base.Columns["customername"];
            this.columncustomer_id = base.Columns["customer_id"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.customernameColumn = new global::System.Data.DataColumn("customername", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.customernameColumn);
            this.columncustomer_id = new global::System.Data.DataColumn("customer_id", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columncustomer_id);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columncustomer_id}, true));
            this.columncustomer_id.AllowDBNull = false;
            this.columncustomer_id.Unique = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_CustomerRow NewGood_CustomerRow()
        {
            return ((Good_CustomerRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new Good_CustomerRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(Good_CustomerRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.Good_CustomerRowChanged != null))
            {
                this.Good_CustomerRowChanged(this, new Good_CustomerRowChangeEvent(((Good_CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.Good_CustomerRowChanging != null))
            {
                this.Good_CustomerRowChanging(this, new Good_CustomerRowChangeEvent(((Good_CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.Good_CustomerRowDeleted != null))
            {
                this.Good_CustomerRowDeleted(this, new Good_CustomerRowChangeEvent(((Good_CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.Good_CustomerRowDeleting != null))
            {
                this.Good_CustomerRowDeleting(this, new Good_CustomerRowChangeEvent(((Good_CustomerRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveGood_CustomerRow(Good_CustomerRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "Good_CustomerDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }

    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class Good_FactorDataTable : global::System.Data.TypedTableBase<Good_FactorRow>
    {

        private global::System.Data.DataColumn columnfactor_id;

        private global::System.Data.DataColumn columntotal_price;

        private global::System.Data.DataColumn columnpyment_price;

        private global::System.Data.DataColumn columndiscountpercent;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_FactorDataTable()
        {
            this.TableName = "Good_Factor";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal Good_FactorDataTable(global::System.Data.DataTable table)
        {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive))
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace))
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected Good_FactorDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
        {
            this.InitVars();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn factor_idColumn
        {
            get
            {
                return this.columnfactor_id;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn total_priceColumn
        {
            get
            {
                return this.columntotal_price;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn pyment_priceColumn
        {
            get
            {
                return this.columnpyment_price;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn discountpercentColumn
        {
            get
            {
                return this.columndiscountpercent;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count
        {
            get
            {
                return this.Rows.Count;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_FactorRow this[int index]
        {
            get
            {
                return ((Good_FactorRow)(this.Rows[index]));
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_FactorRowChangeEventHandler Good_FactorRowChanging;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_FactorRowChangeEventHandler Good_FactorRowChanged;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_FactorRowChangeEventHandler Good_FactorRowDeleting;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event Good_FactorRowChangeEventHandler Good_FactorRowDeleted;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddGood_FactorRow(Good_FactorRow row)
        {
            this.Rows.Add(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_FactorRow AddGood_FactorRow(int factor_id, float total_price, float pyment_price, int discountpercent)
        {
            Good_FactorRow rowGood_FactorRow = ((Good_FactorRow)(this.NewRow()));
            object[] columnValuesArray = new object[] { };
            rowGood_FactorRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowGood_FactorRow);
            return rowGood_FactorRow;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_FactorRow FindByfactor_id(int factor_id)
        {
            return ((Good_FactorRow)(this.Rows.Find(new object[] {
                            factor_id})));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone()
        {
            Good_FactorDataTable cln = ((Good_FactorDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance()
        {
            return new Good_FactorDataTable();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.columnfactor_id = base.Columns["factor_id"];
            this.columntotal_price = base.Columns["total_price"];
            this.columnpyment_price = base.Columns["pyment_price"];
            this.columndiscountpercent = base.Columns["discountpercent"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.columnfactor_id = new global::System.Data.DataColumn("factor_id", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnfactor_id);
            this.columntotal_price = new global::System.Data.DataColumn("total_price", typeof(float), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columntotal_price);
            this.columnpyment_price = new global::System.Data.DataColumn("pyment_price", typeof(float), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnpyment_price);
            this.columndiscountpercent = new global::System.Data.DataColumn("discountpercent", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columndiscountpercent);
            this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnfactor_id}, true));
            this.columnfactor_id.AllowDBNull = false;
            this.columnfactor_id.Unique = true;
            this.columntotal_price.AllowDBNull = false;
            this.columnpyment_price.AllowDBNull = false;
            this.ExtendedProperties.Add("Generator_TableVarName", "tableGood_Factor");
            this.ExtendedProperties.Add("Generator_UserTableName", "Good_Factor");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public Good_FactorRow NewGood_FactorRow()
        {
            return ((Good_FactorRow)(this.NewRow()));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
        {
            return new Good_FactorRow(builder);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType()
        {
            return typeof(Good_FactorRow);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((this.Good_FactorRowChanged != null))
            {
                this.Good_FactorRowChanged(this, new Good_FactorRowChangeEvent(((Good_FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((this.Good_FactorRowChanging != null))
            {
                this.Good_FactorRowChanging(this, new Good_FactorRowChangeEvent(((Good_FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((this.Good_FactorRowDeleted != null))
            {
                this.Good_FactorRowDeleted(this, new Good_FactorRowChangeEvent(((Good_FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((this.Good_FactorRowDeleting != null))
            {
                this.Good_FactorRowDeleting(this, new Good_FactorRowChangeEvent(((Good_FactorRow)(e.Row)), e.Action));
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveGood_FactorRow(Good_FactorRow row)
        {
            this.Rows.Remove(row);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            BookStoreDataSet ds = new BookStoreDataSet();
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
            attribute2.FixedValue = "Good_FactorDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext();)
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte()));)
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
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
    public partial class BookRow : global::System.Data.DataRow
    {

        private BookDataTable tableBook;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal BookRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
        {
            this.tableBook = ((BookDataTable)(this.Table));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int book_id
        {
            get
            {
                return ((int)(this[this.tableBook.book_idColumn]));
            }
            set
            {
                this[this.tableBook.book_idColumn] = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string bookname
        {
            get
            {
                try
                {
                    return ((string)(this[this.tableBook.booknameColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'bookname\' in table \'Book\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBook.booknameColumn] = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int booktype_id
        {
            get
            {
                try
                {
                    return ((int)(this[this.tableBook.booktype_idColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'booktype_id\' in table \'Book\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBook.booktype_idColumn] = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public float price
        {
            get
            {
                return ((float)(this[this.tableBook.priceColumn]));
            }
            set
            {
                this[this.tableBook.priceColumn] = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string book_language
        {
            get
            {
                try
                {
                    return ((string)(this[this.tableBook.book_languageColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'book_language\' in table \'Book\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBook.book_languageColumn] = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string publisher
        {
            get
            {
                try
                {
                    return ((string)(this[this.tableBook.publisherColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'publisher\' in table \'Book\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBook.publisherColumn] = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string agecategory
        {
            get
            {
                try
                {
                    return ((string)(this[this.tableBook.agecategoryColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'agacategory\' in table \'Book\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBook.agecategoryColumn] = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int Qty
        {
            get
            {
                try
                {
                    return ((int)(this[this.tableBook.QtyColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'Qty\' in table \'Book\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBook.QtyColumn] = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool IsbooknameNull()
        {
            return this.IsNull(this.tableBook.booknameColumn);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void SetbooknameNull()
        {
            this[this.tableBook.booknameColumn] = global::System.Convert.DBNull;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool Isbook_languageNull()
        {
            return this.IsNull(this.tableBook.book_languageColumn);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void Setbook_languageNull()
        {
            this[this.tableBook.book_languageColumn] = global::System.Convert.DBNull;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool IspublisherNull()
        {
            return this.IsNull(this.tableBook.publisherColumn);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void SetpublisherNull()
        {
            this[this.tableBook.publisherColumn] = global::System.Convert.DBNull;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool IsagecategoryNull()
        {
            return this.IsNull(this.tableBook.agecategoryColumn);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void SetagecategoryNull()
        {
            this[this.tableBook.agecategoryColumn] = global::System.Convert.DBNull;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool IsQtyNull()
        {
            return this.IsNull(this.tableBook.QtyColumn);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void SetQtyNull()
        {
            this[this.tableBook.QtyColumn] = global::System.Convert.DBNull;
        }
    }

    /// <summary>
    ///Represents strongly named DataRow class.
    ///</summary>
    public partial class BookTypeRow : global::System.Data.DataRow
    {

        private BookTypeDataTable tableBookType;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal BookTypeRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
        {
            this.tableBookType = ((BookTypeDataTable)(this.Table));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int booktype_id
        {
            get
            {
                return ((int)(this[this.tableBookType.booktype_idColumn]));
            }
            set
            {
                this[this.tablebook.booktype_idColumn] = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string booktype
        {
            get
            {
                try
                {
                    return ((string)(this[this.tableBookType.booktypeColumn]));
                }
                catch (global::System.InvalidCastException e)
                {
                    throw new global::System.Data.StrongTypingException("The value for column \'booktype\' in table \'BookType\' is DBNull.", e);
                }
            }
            set
            {
                this[this.tableBookType.booktypeColumn] = value;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class CustomerRow : global::System.Data.DataRow
        {

            private CustomerDataTable tableCustomer;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CustomerRow(global::System.Data.DataRowBuilder rb) :
                    base(rb)
            {
                this.tableCustomer = ((CustomerDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string customername
            {
                get
                {
                    return ((string)(this[this.tableCustomer.customernameColumn]));
                }
                set
                {
                    this[this.tableCustomer.customernameColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int customer_id
            {
                get
                {
                    return ((int)(this[this.tableCustomer.customer_idColumn]));
                }
                set
                {
                    this[this.tableCustomer.customer_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string phone_number
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableCustomer.phone_numberColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'phone_number\' in table \'Customer\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableCustomer.phone_numberColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string age
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableCustomer.ageColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'age\' in table \'Customer\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableCustomer.ageColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isphone_numberNull()
            {
                return this.IsNull(this.tableCustomer.phone_numberColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setphone_numbereNull()
            {
                this[this.tableCustomer.phone_numberColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsageNull()
            {
                return this.IsNull(this.tableCustomer.ageColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetageNull()
            {
                this[this.tableCustomer.ageColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class FactorRow : global::System.Data.DataRow
        {

            private FactorDataTable tableFactor;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal FactorRow(global::System.Data.DataRowBuilder rb) :
                    base(rb)
            {
                this.tableFactor = ((FactorDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int factor_id
            {
                get
                {
                    return ((int)(this[this.tableFactor.factor_idColumn]));
                }
                set
                {
                    this[this.tableFactor.factor_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int book_id
            {
                get
                {
                    return ((int)(this[this.tableFactor.book_idColumn]));
                }
                set
                {
                    this[this.tableFactor.book_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int customer_id
            {
                get
                {
                    return ((int)(this[this.tableFactor.customer_idColumn]));
                }
                set
                {
                    this[this.tableFactor.customer_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public float total_price
            {
                get
                {
                    return ((float)(this[this.tableFactor.total_priceColumn]));
                }
                set
                {
                    this[this.tableFactor.total_priceColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public float pyment_price
            {
                get
                {
                    return ((float)(this[this.tableFactor.pyment_priceColumn]));
                }
                set
                {
                    this[this.tableFactor.pyment_priceColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int discountpercent
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableFactor.discountpercentColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'discountpercent\' in table \'Factor\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableFactor.discountpercentColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime factor_data
            {
                get
                {
                    try
                    {
                        return ((global::System.DateTime)(this[this.tableFactor.factor_dataColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'factor_data\' in table \'Factor\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableFactor.factor_dataColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.TimeSpan factor_time
            {
                get
                {
                    try
                    {
                        return ((global::System.TimeSpan)(this[this.tableFactor.factor_timeColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'factor_time\' in table \'Factor\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableFactor.factor_timeColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int book_number
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableFactor.book_numberColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'book_number\' in table \'Factor\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableFactor.book_numberColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdiscountpercentNull()
            {
                return this.IsNull(this.tableFactor.discountpercentColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdiscountpercentNull()
            {
                this[this.tableFactor.discountpercentColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isfactor_dataNull()
            {
                return this.IsNull(this.tableFactor.factor_dataColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setfactor_dataNull()
            {
                this[this.tableFactor.factor_dataColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isfactor_timeNull()
            {
                return this.IsNull(this.tableFactor.factor_timeColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setfactor_timeNull()
            {
                this[this.tableFactor.factor_timeColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isbook_numberNull()
            {
                return this.IsNull(this.tableFactor.book_numberColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setbook_numberNull()
            {
                this[this.tableFactor.book_numberColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class OrderListRow : global::System.Data.DataRow
        {

            private OrderListDataTable tableOrderList;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal OrderListRow(global::System.Data.DataRowBuilder rb) :
                    base(rb)
            {
                this.tableOrderList = ((OrderListDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int factor_id
            {
                get
                {
                    return ((int)(this[this.tableOrderList.factor_idColumn]));
                }
                set
                {
                    this[this.tableOrderList.factor_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int book_id
            {
                get
                {
                    return ((int)(this[this.tableOrderList.book_idColumn]));
                }
                set
                {
                    this[this.tableOrderList.book_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int book_number
            {
                get
                {
                    return ((int)(this[this.tableOrderList.book_numberColumn]));
                }
                set
                {
                    this[this.tableOrderList.book_numberColumn] = value;
                }
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Good_BookRow : global::System.Data.DataRow
        {

            private Good_BookDataTable tableGood_Book;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Good_BookRow(global::System.Data.DataRowBuilder rb) :
                    base(rb)
            {
                this.tableGood_Book = ((Good_BookDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int book_id
            {
                get
                {
                    return ((int)(this[this.tableGood_Book.book_idColumn]));
                }
                set
                {
                    this[this.tableGood_Book.book_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string bookname
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableGood_Book.booknameColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'bookname\' in table \'Good_Book\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableGood_Book.booknameColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public float price
            {
                get
                {
                    return ((float)(this[this.tableGood_Book.priceColumn]));
                }
                set
                {
                    this[this.tableGood_Book.priceColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsbooknameNull()
            {
                return this.IsNull(this.tableGood_Book.booknameColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetbooknameNull()
            {
                this[this.tableGood_Book.booknameColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Good_CustomerRow : global::System.Data.DataRow
        {

            private Good_CustomerDataTable tableGood_Customer;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Good_CustomerRow(global::System.Data.DataRowBuilder rb) :
                    base(rb)
            {
                this.tableGood_Customer = ((Good_CustomerDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int customer_id
            {
                get
                {
                    return ((int)(this[this.tableGood_Customer.customer_idColumn]));
                }
                set
                {
                    this[this.tableGood_Customer.customer_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string customername
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableGood_Customer.customernameColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'customername\' in table \'Good_Customer\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableGood_Customer.customernameColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscustomernameNull()
            {
                return this.IsNull(this.tableGood_Customer.customernameColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetcustomernameNull()
            {
                this[this.tableGood_Customer.customernameColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Good_FactorRow : global::System.Data.DataRow
        {

            private Good_FactorDataTable tableGood_Factor;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Good_FactorRow(global::System.Data.DataRowBuilder rb) :
                    base(rb)
            {
                this.tableGood_Factor = ((Good_FactorDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int factor_id
            {
                get
                {
                    return ((int)(this[this.tableGood_Factor.factor_idColumn]));
                }
                set
                {
                    this[this.tableGood_Factor.factor_idColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public float total_price
            {
                get
                {
                    return ((float)(this[this.tableGood_Factor.total_priceColumn]));
                }
                set
                {
                    this[this.tableGood_Factor.total_priceColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public float pyment_price
            {
                get
                {
                    return ((float)(this[this.tableGood_Factor.pyment_priceColumn]));
                }
                set
                {
                    this[this.tableGood_Factor.pyment_priceColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int discountpercent
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableGood_Factor.discountpercentColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'discountpercent\' in table \'Good_Factor\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableGood_Factor.discountpercentColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdiscountpercentNull()
            {
                return this.IsNull(this.tableGood_Factor.discountpercentColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdiscountpercentNull()
            {
                this[this.tableGood_Factor.discountpercentColumn] = global::System.Convert.DBNull;
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class BookRowChangeEvent : global::System.EventArgs
            {

                private BookRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public BookRowChangeEvent(BookRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public BookRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class BookTypeRowChangeEvent : global::System.EventArgs
            {

                private BookTypeRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public BookTypeRowChangeEvent(BookTypeRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public BookTypeRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class CustomerRowChangeEvent : global::System.EventArgs
            {

                private CustomerRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public CustomerRowChangeEvent(CustomerRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public CustomerRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class FactorRowChangeEvent : global::System.EventArgs
            {

                private FactorRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public FactorRowChangeEvent(FactorRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public FactorRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class OrderListRowChangeEvent : global::System.EventArgs
            {

                private OrderListtableRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public OrderListRowChangeEvent(OrderListRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public OrderListRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class Good_BookRowChangeEvent : global::System.EventArgs
            {

                private Good_BookRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public Good_BookRowChangeEvent(Good_BookRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public Good_BookRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class Good_CustomerRowChangeEvent : global::System.EventArgs
            {

                private Good_CustomerRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public Good_CustomerRowChangeEvent(Good_CustomerRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public Good_CustomerRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }

            /// <summary>
            ///Row event argument class
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public class Good_FactorRowChangeEvent : global::System.EventArgs
            {

                private Good_FactorRow eventRow;

                private global::System.Data.DataRowAction eventAction;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public Good_FactorRowChangeEvent(Good_FactorRow row, global::System.Data.DataRowAction action)
                {
                    this.eventRow = row;
                    this.eventAction = action;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public Good_FactorRow Row
                {
                    get
                    {
                        return this.eventRow;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public global::System.Data.DataRowAction Action
                {
                    get
                    {
                        return this.eventAction;
                    }
                }
            }
        }
    }
    namespace WindowsFormsApplication6.BookStoreDataSetTableAdapters
    {


        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class BookTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BookTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "Book";
                tableMapping.ColumnMappings.Add("bookname", "bookname");
                tableMapping.ColumnMappings.Add("book_id", "book_id");
                tableMapping.ColumnMappings.Add("booktype_id", "booktype_id");
                tableMapping.ColumnMappings.Add("price", "price");
                tableMapping.ColumnMappings.Add("discountpercent", "discountpercent");
                tableMapping.ColumnMappings.Add("book_language", "book_language");
                tableMapping.ColumnMappings.Add("publisher", "publisher");
                tableMapping.ColumnMappings.Add("agecategory", "agecategory");
                tableMapping.ColumnMappings.Add("Qty", "Qty");
                this._adapter.TableMappings.Add(tableMapping);
                this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.DeleteCommand.Connection = this.Connection;
                this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Book] WHERE (([bookid] = @Original_bookid) AND ([booktype_id] = @" +
                    "Original_booktype_id) AND ([price] = @Original_price) AND AND ((@IsNull_discountpercent = " +
                "1 AND [discountpercent] IS NULL) OR ([discountpercent] = @Original_discountpercent)))";
                this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.InsertCommand.Connection = this.Connection;
                this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Book] ([bookname], [book_id], [booktype_id], [price], [discountpercent], [book_language], [publisher], [agecategory], [Qty]) VALUES (@bookname" +
                    "@book_id, @booktype_id, @price, @discountpercent, @book_language, @publisher, @agecategory, @Qty);\r\nSELECT  bookname, book_id, booktype_id, price, discountpercent, book_language, publisher, agecategory FROM Book" +
                    " WHERE (book_id = @book_id)";
                this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@bookname", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "bookname", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_language", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_language", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@publisher", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "publisher", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@agecategory", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "agecategory", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Qty", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Qty", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.UpdateCommand.Connection = this.Connection;
                this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Book] SET [bookname] = @bookname, [book_id] = @book_id, [booktype_id] = @booktype_id, [price] = @price, [book_language] = @book_language, [publisher] = @publisher, [agecategory] = @agecategory, [Qty] = @Qty WHERE (([book_id] = @Original_book_id) AND ([booktype_id] = @Original_booktype_id) AND ([price] = @Original_price));
SELECT bookname, book_id, booktype_id, price, discountpercent, book_language, publisher, agecategory FROM Book WHERE (book_id = @book_id)";
                this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@bookname", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "bookname", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_language", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_language", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@publisher", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "publisher", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@agecategory", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "agecategory", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Qty", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Qty", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT  bookname, book_id, booktype_id, price, book_language, publisher, agecategory FROM dbo.Book";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.BookDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.BookDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.BookDataTable dataTable = new BookStoreDataSet.BookDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet.BookDataTable dataTable)
            {
                return this.Adapter.Update(dataTable);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet dataSet)
            {
                return this.Adapter.Update(dataSet, "Book");
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow dataRow)
            {
                return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow[] dataRows)
            {
                return this.Adapter.Update(dataRows);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
            public virtual int Delete(int Original_book_id, int Original_booktype_id, float Original_price, global::System.Nullable<int> Original_discountpercent)
            {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_book_id));
                this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_booktype_id));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((float)(Original_price));
                if ((Original_discountpercent.HasValue == true))
                {
                    this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                    this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_discountpercent.Value));
                }
                else
                {
                    this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                    this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
                if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.DeleteCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.DeleteCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
            public virtual int Insert(string bookname, int book_id, int booktype_id, float price, global::System.Nullable<int> discountpercent, string book_language, string publisher, string agecategory, int Qty)
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(book_id));
                if ((bookname == null))
                {
                    this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[0].Value = ((string)(bookname));
                }
                this.Adapter.InsertCommand.Parameters[2].Value = ((int)(booktype_id));
                this.Adapter.InsertCommand.Parameters[3].Value = ((float)(price));
                if ((discountpercent.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[4].Value = ((int)(discountpercent.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
                }
                if ((book_language == null))
                {
                    this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[5].Value = ((string)(book_language));
                }
                if ((publisher == null))
                {
                    this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[6].Value = ((string)(publisher));
                }
                if ((agecategory == null))
                {
                    this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[7].Value = ((string)(agecategory));
                }
                if ((Qty == null))
                {
                    this.Adapter.InsertCommand.Parameters[8].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[8].Value = ((int)(Qty));
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
                if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.InsertCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.InsertCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(string bookname, int book_id, int booktype_id, float price, global::System.Nullable<int> discountpercent, string book_language, string publisher, string agecategory, int Qty, int Original_book_id, int Original_booktype_id, float Original_price, global::System.Nullable<int> Original_discountpercent)
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(book_id));
                if ((bookname == null))
                {
                    this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(bookname));
                }
                this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(booktype));
                this.Adapter.UpdateCommand.Parameters[3].Value = ((float)(price));
                if ((discountpercent.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(discountpercent.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
                }
                if ((book_language == null))
                {
                    this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(book_language));
                }
                if ((publisher == null))
                {
                    this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[6].Value = ((string)(publisher));
                }
                if ((agecategory == null))
                {
                    this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[7].Value = ((string)(agecategory));
                }
                if ((Qty == null))
                {
                    this.Adapter.InsertCommand.Parameters[8].Value = global::System.DBNull.Value;
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[8].Value = ((int)(Qty));
                }
                this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_book_id));
                this.Adapter.UpdateCommand.Parameters[10].Value = ((int)(Original_booktype_id));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((float)(Original_price));
                if ((Original_discountpercent.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                    this.Adapter.UpdateCommand.Parameters[13].Value = ((int)(Original_discountpercent.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                    this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
                if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.UpdateCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.UpdateCommand.Connection.Close();
                    }
                }
            }


            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(string bookname, int booktype_id, float price, global::System.Nullable<int> discountpercent, string book_language, string publisher, string agecategory, int Qty, int Original_book_id, int Original_booktype_id, float Original_price, global::System.Nullable<int> Original_discountpercent)
            {
                return this.Update(bookname, book_id, booktype_id, price, discountpercent, book_language, publisher, agecategory, Qty, Original_book_id, Original_booktype_id, Original_price, Original_discountpercent);
            }
        }

        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class BookTypeTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BookTypeTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "BookType";
                tableMapping.ColumnMappings.Add("booktype_id", "booktype_id");
                tableMapping.ColumnMappings.Add("booktype", "booktype");
                this._adapter.TableMappings.Add(tableMapping);
                this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.DeleteCommand.Connection = this.Connection;
                this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[BookType] WHERE (([booktype_id] = @Original_booktype_id))";
                this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.InsertCommand.Connection = this.Connection;
                this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[BookType] ([booktype_id], [booktype]) VALUES (@booktype_id, @booktype);\r\nSELECT booktype_id, booktype" +
                    "FROM BookType WHERE (booktype_id = @booktype_id)";
                this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@booktype", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.UpdateCommand.Connection = this.Connection;
                this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[BookType] SET [booktype_id] = @booktype_id, [booktype] = @booktype WHERE (([booktype_id] = @Original_" +
                    "booktype_id));\r\nSELECT booktype_id, booktype FROM BookType WHERE (booktype_id = @booktype_id)";
                this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@booktype_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@booktype", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "booktype_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT booktype_id, booktype FROM dbo.BookType";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.BookTypeDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.BookTypeDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.BookTypeDataTable dataTable = new BookStoreDataSet.BookTypeDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet.BookTypeDataTable dataTable)
            {
                return this.Adapter.Update(dataTable);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet dataSet)
            {
                return this.Adapter.Update(dataSet, "BookType");
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow dataRow)
            {
                return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow[] dataRows)
            {
                return this.Adapter.Update(dataRows);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
            public virtual int Delete(int Original_booktype_id)
            {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_booktype_id));
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
                if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.DeleteCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.DeleteCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
            public virtual int Insert(int booktype_id, string booktype)
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(booktype_id));
                if ((booktype == null))
                {
                    throw new global::System.ArgumentNullException("booktype");
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[1].Value = ((string)(booktype));
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
                if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.InsertCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.InsertCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(int booktype_id, string booktype, int Original_booktype_id)
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(booktype_id));
                if ((booktype == null))
                {
                    throw new global::System.ArgumentNullException("booktype");
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(booktype));
                }
                this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(Original_booktype_id));
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
                if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.UpdateCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.UpdateCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(string booktype, int Original_booktype_id)
            {
                return this.Update(Original_booktype_id, booktype, Original_booktype_id);
            }
        }


        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class CustomerTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CustomerTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "Customer";
                tableMapping.ColumnMappings.Add("customername", "customername");
                tableMapping.ColumnMappings.Add("customer_id", "customer_id");
                tableMapping.ColumnMappings.Add("phone_number", "phone_number");
                tableMapping.ColumnMappings.Add("age", "age");
                this._adapter.TableMappings.Add(tableMapping);
                this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.DeleteCommand.Connection = this.Connection;
                this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Customer] WHERE (([customer_id] = @Original_customer_id)" +
                    "AND ((@IsNull_phone_number = 1 AND [phone_number] IS NULL) OR ([phone_number] = @Original_phone_number))" +
                    "AND ((@IsNull_age = 1 AND [age] IS NULL) OR ([age] = @Original_age)))";
                this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_phone_number", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone_number", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_phone_number", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone_number", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_age", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "age", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_age", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "age", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.InsertCommand.Connection = this.Connection;
                this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Customer] ([customername], [customer_id], [phone_number], [age])" +
                    " VALUES (@customername, @customer_id, @phone_number, @age);\r\nSELECT customername, customer_id," +
                    " phone_number, age FROM Customer WHERE (customer_id = @customer_id)";
                this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@customername", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customername", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@phone_number", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone_number", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@age", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "age", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.UpdateCommand.Connection = this.Connection;
                this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Customer] SET [customername] = @customername, [customer_id] = @customer_id, [phone_number] = @phone_number, [age] = @age WHERE (([customer_id] = @Original_customer_id) AND ((@IsNull_phone_number = 1 AND [phone_number] IS NULL) OR ([phone_number] = @Original_phone_number)) AND ((@IsNull_age = 1 AND [age] IS NULL) OR ([age] = @Original_age)));
SELECT customername, customer_id, phone_number, age FROM Customer WHERE (customer_id = @customer_id)";
                this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@customername", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customername", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@phone_number", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone_number", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@age", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "age", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_phone_number", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone_number", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_phone_number", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone_number", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_age", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "age", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_age", global::System.Data.SqlDbType.Char, 0, global::System.Data.ParameterDirection.Input, 0, 0, "age", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT customername, customer_id, phone_number, age FROM dbo.Customer";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.CustomerDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStpreDataSet.CustomerDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.CustomerDataTable dataTable = new BookStoreDataSet.CustomerDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet.CustomerDataTable dataTable)
            {
                return this.Adapter.Update(dataTable);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet dataSet)
            {
                return this.Adapter.Update(dataSet, "Customer");
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow dataRow)
            {
                return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow[] dataRows)
            {
                return this.Adapter.Update(dataRows);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
            public virtual int Delete(int Original_customer_id, global::System.Nullable<string> Original_phone_number, global::System.Nullable<string> Original_age)
            {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_customer_id));
                if ((Original_phone_number.HasValue == true))
                {
                    this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                    this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_phone_number.Value));
                }
                else
                {
                    this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                    this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
                }
                if ((Original_age.HasValue == true))
                {
                    this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                    this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_age.Value));
                }
                else
                {
                    this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                    this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
                if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.DeleteCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.DeleteCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
            public virtual int Insert(string customername, int customer_id, global::System.Nullable<string> phone_number, global::System.Nullable<string> age)
            {
                if ((customername == null))
                {
                    throw new global::System.ArgumentNullException("customername");
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[0].Value = ((string)(customername));
                }
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(customer_id));
                if ((phone_number.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[2].Value = ((string)(phone_number.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
                }
                if ((age.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[3].Value = ((string)(age.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
                if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.InsertCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.InsertCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(string customername, int customer_id, global::System.Nullable<string> phone_number, global::System.Nullable<string> age, int Original_customer_id, global::System.Nullable<string> Original_userphone, global::System.Nullable<string> Original_age)
            {
                if ((customername == null))
                {
                    throw new global::System.ArgumentNullException("customername");
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(customername));
                }
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(customer_id));
                if ((phone_number.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(phone_number.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
                }
                if ((age.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(age.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
                }
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_customer_id));
                if ((Original_phone_number.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(0));
                    this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Original_phone_number.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(1));
                    this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
                }
                if ((Original_age.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[7].Value = ((object)(0));
                    this.Adapter.UpdateCommand.Parameters[8].Value = ((string)(Original_age.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[7].Value = ((object)(1));
                    this.Adapter.UpdateCommand.Parameters[8].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
                if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.UpdateCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.UpdateCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(string customername, global::System.Nullable<string> phone_number, global::System.Nullable<string> age, int Original_customer_id, global::System.Nullable<string> Original_phone_number, global::System.Nullable<string> Original_age)
            {
                return this.Update(customername, customer_id, phone_number, age, Original_customer_id, Original_phone_number, Original_age);
            }
        }


        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class FactorTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public FactorTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "Factor";
                tableMapping.ColumnMappings.Add("factor_id", "factor_id");
                tableMapping.ColumnMappings.Add("book_id", "book_id");
                tableMapping.ColumnMappings.Add("customer_id", "customer_id");
                tableMapping.ColumnMappings.Add("total_price", "total_price");
                tableMapping.ColumnMappings.Add("pyment_price", "pyment_price");
                tableMapping.ColumnMappings.Add("discountpercent", "discountpercent");
                tableMapping.ColumnMappings.Add("factor_data", "factor_data");
                tableMapping.ColumnMappings.Add("factor_time", "factor_time");
                tableMapping.ColumnMappings.Add("book_number", "book_number");
                this._adapter.TableMappings.Add(tableMapping);
                this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.DeleteCommand.Connection = this.Connection;
                this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[Factor] WHERE (([factor_id] = @Original_factor_id) AND ([book_id] = @Original_book_id) AND ([customer_id] = @Original_customer_id) AND ([total_price] = @Original_total_price) AND ([pyment_price] = @Original_pyment_price) AND ((@IsNull_discountpercent = 1 AND [discountpercent] IS NULL) OR ([discountpercent] = @Original_discountpercent)) AND ((@IsNull_factor_data = 1 AND [factor_data] IS NULL) OR ([factor_data] = @Original_factor_data)) AND ((@IsNull_factor_time = 1 AND [factor_time] IS NULL) OR ([factor_time] = @Original_factor_time)))";
                this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_total_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "total_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_pyment_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "pyment_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_factor_data", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_data", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_data", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_data", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_factor_time", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_time", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_time", global::System.Data.SqlDbType.Time, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_time", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.InsertCommand.Connection = this.Connection;
                this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[Factor] ([factor_id], [book_id], [customer_id], [total_price], [pyment_price], [discountpercent], [factor_data], [factor_time], [book_number]) VALUES (@factor_id, @book_id, @customer_id, @total_price, @pyment_price, @discountpercent, @factor_data, @factor_time, @book_number);
SELECT factor_id, book_id, customer_id, total_price, pyment_price,discountpercent , factor_data, factor_time, book_number FROM Factor WHERE (factor_id = @factor_id)";
                this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@total_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "total_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@pyment_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "pyment_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_data", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_data", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_time", global::System.Data.SqlDbType.Time, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_time", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.UpdateCommand.Connection = this.Connection;
                this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Factor] SET [factor_id] = @factor_id, [book_id] = @book_id, [customer_id] = @customer_id, [total_price] = @total_price, [pyment_price] = @pyment_price, [discountpercent] = @discountpercent, [factor_data] = @factor_data, [factor_time] = @factor_time, [book_number] = @book_number WHERE (([factor_id] = @Original_factor_id) AND ([book_id] = @Original_book_id) AND ([customer_id] = @customer_id) AND ([total_price] = @Original_total_price) AND ([pyment_price] = @Original_pyment_price) AND ((@IsNull_discountpercent = 1 AND [discountpercent] IS NULL) OR ([discountpercent] = @Original_discountpercent)) AND ((@IsNull_factor_data = 1 AND [factor_data] IS NULL) OR ([factor_data] = @Original_factor_data)) AND ((@IsNull_factor_time = 1 AND [factor_time] IS NULL) OR ([factor_time] = @Original_factor_time)));
SELECT factor_id, book_id, customer_id, total_price, pyment_price, discountpercent, factor_data, factor_time, book_number FROM Factor WHERE (factor_id = @factor_id)";
                this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@total_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "total_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@pyment_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "pyment_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_data", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_data", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_time", global::System.Data.SqlDbType.Time, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_time", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_customer_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "customer_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_total_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "total_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_pyment_price", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "pyment_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_discountpercent", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "discountpercent", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_factor_data", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_data", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_data", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_data", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_factor_time", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_time", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_time", global::System.Data.SqlDbType.Time, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_time", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT factor_id, book_id, customer_id, total_price, pyment_price, discountpercent, factor_data, factor_time, book_number FROM dbo.Factor";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.FactorDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.FactorDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.FactorDataTable dataTable = new BookStoreDataSet.FactorDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet.FactorDataTable dataTable)
            {
                return this.Adapter.Update(dataTable);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet dataSet)
            {
                return this.Adapter.Update(dataSet, "Factor");
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow dataRow)
            {
                return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow[] dataRows)
            {
                return this.Adapter.Update(dataRows);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
            public virtual int Delete(int Original_factor_id, int Original_book_id, int Original_customer_id, float Original_total_price, float Original_pyment_price, global::System.Nullable<int> Original_discountpercent, global::System.Nullable<global::System.DateTime> Original_factor_data, global::System.Nullable<global::System.TimeSpan> Original_factor_time)
            {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_factor_id));
                this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_book_id));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_customer_id));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((float)(Original_total_price));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((float)(Original_pyment_price));
                if ((Original_discountpercent.HasValue == true))
                {
                    this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                    this.Adapter.DeleteCommand.Parameters[6].Value = ((int)(Original_discountpercent.Value));
                }
                else
                {
                    this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                    this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
                }
                if ((Original_factor_data.HasValue == true))
                {
                    this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                    this.Adapter.DeleteCommand.Parameters[8].Value = ((System.DateTime)(Original_factor_data.Value));
                }
                else
                {
                    this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                    this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
                }
                if ((Original_factor_time.HasValue == true))
                {
                    this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                    this.Adapter.DeleteCommand.Parameters[10].Value = ((System.TimeSpan)(Original_factor_time.Value));
                }
                else
                {
                    this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                    this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
                if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.DeleteCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.DeleteCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
            public virtual int Insert(int factor_id, int book_id, int customer_id, float total_price, float pyment_price, global::System.Nullable<int> discountpercent, global::System.Nullable<global::System.DateTime> factor_data, global::System.Nullable<global::System.TimeSpan> factor_time, int book_number)
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(factor_id));
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(book_id));
                this.Adapter.InsertCommand.Parameters[2].Value = ((int)(customer_id));
                this.Adapter.InsertCommand.Parameters[3].Value = ((float)(total_price));
                this.Adapter.InsertCommand.Parameters[4].Value = ((float)(pyment_price));
                if ((discountpercent.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[5].Value = ((int)(discountpercent.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
                }
                if ((factor_data.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[6].Value = ((System.DateTime)(factor_data.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
                }
                if ((factor_time.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[7].Value = ((System.TimeSpan)(factor_time.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
                }
                if ((book_number.HasValue == true))
                {
                    this.Adapter.InsertCommand.Parameters[8].Value = ((int)(book_number.Value));
                }
                else
                {
                    this.Adapter.InsertCommand.Parameters[8].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
                if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.InsertCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.InsertCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(int factor_id, int book_id, int customer_id, float total_price, float pyment_price, global::System.Nullable<int> discountpercent, global::System.Nullable<global::System.DateTime> factor_data, global::System.Nullable<global::System.TimeSpan> factor_time, int Original_factor_id, int Original_book_id, int Original_customer_id, float Original_total_price, float Original_pyment_price, global::System.Nullable<int> Original_discountpercent, global::System.Nullable<global::System.DateTime> Original_factor_data, global::System.Nullable<global::System.TimeSpan> Original_factor_time)
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(factor_id));
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(book_id));
                this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(customer_id));
                this.Adapter.UpdateCommand.Parameters[3].Value = ((float)(total_price));
                this.Adapter.UpdateCommand.Parameters[4].Value = ((float)(pyment_price));
                if ((discountpercent.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(discountpercent.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
                }
                if ((factor_data.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[6].Value = ((System.DateTime)(factor_data.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
                }
                if ((factor_time.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[7].Value = ((System.TimeSpan)(factor_time.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
                }
                this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Original_factor_id));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_book_id));
                this.Adapter.UpdateCommand.Parameters[10].Value = ((int)(Original_customer_id));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((float)(Original_total_price));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((float)(Original_pyment_price));
                if ((Original_discountpercent.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                    this.Adapter.UpdateCommand.Parameters[14].Value = ((int)(Original_discountpercent.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                    this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
                }
                if ((Original_factor_data.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                    this.Adapter.UpdateCommand.Parameters[16].Value = ((System.DateTime)(Original_factor_data.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                    this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
                }
                if ((Original_time.HasValue == true))
                {
                    this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                    this.Adapter.UpdateCommand.Parameters[18].Value = ((System.TimeSpan)(Original_time.Value));
                }
                else
                {
                    this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                    this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
                }
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
                if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.UpdateCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.UpdateCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(int book_id, int customer_id, float total_price, float pyment_price, global::System.Nullable<int> discountpercent, global::System.Nullable<global::System.DateTime> factor_data, global::System.Nullable<global::System.TimeSpan> factor_time, int Original_factor_id, int Original_book_id, int Original_customer_id, float Original_total_price, float Original_pyment_price, global::System.Nullable<int> Original_discountpercent, global::System.Nullable<global::System.DateTime> Original_factor_data, global::System.Nullable<global::System.TimeSpan> Original_factor_time, int book_number)
            {
                return this.Update(factor_id, book_id, customer_id, total_price, pyment_price, discountpercent, factor_data, factor_time, Original_factor_id, Original_book_id, Original_customer_id, Original_total_price, Original_pyment_price, Original_discountpercent, Original_factor_data, Original_factor_time, book_number);
            }
        }

        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class OrderListTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrderListTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "OrderList";
                tableMapping.ColumnMappings.Add("factor_id", "factor_id");
                tableMapping.ColumnMappings.Add("book_id", "book_id");
                tableMapping.ColumnMappings.Add("book_number", "book_number");
                this._adapter.TableMappings.Add(tableMapping);
                this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.DeleteCommand.Connection = this.Connection;
                this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[OrderList] WHERE (([factor_id] = @Original_factor_id) AND ([book_id] = @Original_book_id) AND ([book_number] = @Original_book_number))";
                this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_number", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_number", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.InsertCommand.Connection = this.Connection;
                this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[OrderList] ([factor_id], [book_id], [book_number]) VALUES (@factor_id," +
                    " @book_id, @book_number);\r\nSELECT factor_id, book_id, book_number FROM OrderList WHERE (factor_id = @factor_id)";
                this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_number", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_number", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
                this._adapter.UpdateCommand.Connection = this.Connection;
                this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[OrderList] SET [factor_id] = @factor_id, [book_id] = @book_id, [book_number] = @book_number WHERE (([factor_id] = @Original_factor_id) AND ([book_id] = @Original_book_id) AND ([book_number] = @Original_book_number));
SELECT factor_id, book_id, book_number FROM OrderList WHERE (factor_id = @factor_id)";
                this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@book_number", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_number", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_factor_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "factor_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
                this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_book_number", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "book_number", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT factor_id, book_id, book_number FROM dbo.OrderList";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.OrderListDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.OrderListDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.OrderListDataTable dataTable = new BookStoreDataSet.OrderListDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet.OrderListDataTable dataTable)
            {
                return this.Adapter.Update(dataTable);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(BookStoreDataSet dataSet)
            {
                return this.Adapter.Update(dataSet, "OrderList");
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow dataRow)
            {
                return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            public virtual int Update(global::System.Data.DataRow[] dataRows)
            {
                return this.Adapter.Update(dataRows);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
            public virtual int Delete(int Original_factor_id, int Original_book_id, int Original_book_number)
            {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_factor_id));
                this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_book_id));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_book_number));
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
                if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.DeleteCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.DeleteCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
            public virtual int Insert(int factor_id, int book_id, int book_number)
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(factor_id));
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(book_id));
                this.Adapter.InsertCommand.Parameters[2].Value = ((int)(book_number));
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
                if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.InsertCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.InsertCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(int factor_id, int book_id, int book_number, int Original_factor_id, int Original_book_id, int Original_book_number)
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(factor_id));
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(book_id));
                this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(book_number));
                this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Original_factor_id));
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_book_id));
                this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(Original_book_number));
                global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
                if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                            != global::System.Data.ConnectionState.Open))
                {
                    this.Adapter.UpdateCommand.Connection.Open();
                }
                try
                {
                    int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                    return returnValue;
                }
                finally
                {
                    if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                    {
                        this.Adapter.UpdateCommand.Connection.Close();
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
            public virtual int Update(int book_number, int Original_factor_id, int Original_book_id, int Original_book_number)
            {
                return this.Update(factor_id, book_id, book_number, Original_factor_id, Original_book_id, Original_book_number);
            }
        }



        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class Good_BookTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Good_BookTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "Good_Book";
                tableMapping.ColumnMappings.Add("book_id", "book_id");
                tableMapping.ColumnMappings.Add("bookname", "bookname");
                tableMapping.ColumnMappings.Add("price", "price");
                this._adapter.TableMappings.Add(tableMapping);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT book_id, bookname, price, FROM dbo.Good_Book";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.Good_BookDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.Good_DataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.Good_BookDataTable dataTable = new BookStoreDataSet.Good_BookDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }
        }

        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class Good_CustomerTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Good_CustomerTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "Good_Customer";
                tableMapping.ColumnMappings.Add("customer_id", "customer_id");
                tableMapping.ColumnMappings.Add("customername", "customername");
                this._adapter.TableMappings.Add(tableMapping);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT customer_id, customername FROM dbo.Good_Customer";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.Good_CustomerDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.Good_CustomerDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.Good_CustomerDataTable dataTable = new BookStoreDataSet.Good_CustomerDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }
        }

        /// <summary>
        ///Represents the connection and commands used to retrieve and save data.
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DataObjectAttribute(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
            ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public partial class Good_FactorTableAdapter : global::System.ComponentModel.Component
        {

            private global::System.Data.SqlClient.SqlDataAdapter _adapter;

            private global::System.Data.SqlClient.SqlConnection _connection;

            private global::System.Data.SqlClient.SqlTransaction _transaction;

            private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

            private bool _clearBeforeFill;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Good_FactorTableAdapter()
            {
                this.ClearBeforeFill = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter
            {
                get
                {
                    if ((this._adapter == null))
                    {
                        this.InitAdapter();
                    }
                    return this._adapter;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlConnection Connection
            {
                get
                {
                    if ((this._connection == null))
                    {
                        this.InitConnection();
                    }
                    return this._connection;
                }
                set
                {
                    this._connection = value;
                    if ((this.Adapter.InsertCommand != null))
                    {
                        this.Adapter.InsertCommand.Connection = value;
                    }
                    if ((this.Adapter.DeleteCommand != null))
                    {
                        this.Adapter.DeleteCommand.Connection = value;
                    }
                    if ((this.Adapter.UpdateCommand != null))
                    {
                        this.Adapter.UpdateCommand.Connection = value;
                    }
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        if ((this.CommandCollection[i] != null))
                        {
                            ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                        }
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal global::System.Data.SqlClient.SqlTransaction Transaction
            {
                get
                {
                    return this._transaction;
                }
                set
                {
                    this._transaction = value;
                    for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                    {
                        this.CommandCollection[i].Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.DeleteCommand != null)))
                    {
                        this.Adapter.DeleteCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.InsertCommand != null)))
                    {
                        this.Adapter.InsertCommand.Transaction = this._transaction;
                    }
                    if (((this.Adapter != null)
                                && (this.Adapter.UpdateCommand != null)))
                    {
                        this.Adapter.UpdateCommand.Transaction = this._transaction;
                    }
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected global::System.Data.SqlClient.SqlCommand[] CommandCollection
            {
                get
                {
                    if ((this._commandCollection == null))
                    {
                        this.InitCommandCollection();
                    }
                    return this._commandCollection;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool ClearBeforeFill
            {
                get
                {
                    return this._clearBeforeFill;
                }
                set
                {
                    this._clearBeforeFill = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitAdapter()
            {
                this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
                tableMapping.SourceTable = "Table";
                tableMapping.DataSetTable = "Good_Factor";
                tableMapping.ColumnMappings.Add("factor_id", "factor_id");
                tableMapping.ColumnMappings.Add("total_price", "total_price");
                tableMapping.ColumnMappings.Add("pyment_price", "pyment_price");
                tableMapping.ColumnMappings.Add("discountpercent", "discountpercent");
                this._adapter.TableMappings.Add(tableMapping);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitConnection()
            {
                this._connection = new global::System.Data.SqlClient.SqlConnection();
                this._connection.ConnectionString = global::WindowsFormsApplication6.Properties.Settings.Default.BookStoreConnectionString;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitCommandCollection()
            {
                this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
                this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
                this._commandCollection[0].Connection = this.Connection;
                this._commandCollection[0].CommandText = "SELECT factor_id, discountpercent, pyment_price, total_price FROM dbo.[Good_Factor]";
                this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
            public virtual int Fill(BookStoreDataSet.Good_FactorDataTable dataTable)
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                if ((this.ClearBeforeFill == true))
                {
                    dataTable.Clear();
                }
                int returnValue = this.Adapter.Fill(dataTable);
                return returnValue;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
            [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
            public virtual BookStoreDataSet.Good_FactorDataTable GetData()
            {
                this.Adapter.SelectCommand = this.CommandCollection[0];
                BookStoreDataSet.Good_FactorDataTable dataTable = new BookStoreDataSet.Good_FactorDataTable();
                this.Adapter.Fill(dataTable);
                return dataTable;
            }
        }

        /// <summary>
        ///TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
        ///</summary>
        [global::System.ComponentModel.DesignerCategoryAttribute("code")]
        [global::System.ComponentModel.ToolboxItem(true)]
        [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
            "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
        public partial class TableAdapterManager : global::System.ComponentModel.Component
        {

            private UpdateOrderOption _updateOrder;

            private BookTableAdapter _BookTableAdapter;

            private BookTypeTableAdapter _BookTypeTableAdapter;

            private CustomerTableAdapter _CustomerTableAdapter;

            private FactorTableAdapter _FactorTableAdapter;

            private OrderListTableAdapter _OrderListTableAdapter;

            private bool _backupDataSetBeforeUpdate;

            private global::System.Data.IDbConnection _connection;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public UpdateOrderOption UpdateOrder
            {
                get
                {
                    return this._updateOrder;
                }
                set
                {
                    this._updateOrder = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public BookTableAdapter BookTableAdapter
            {
                get
                {
                    return this._BookTableAdapter;
                }
                set
                {
                    this._BookTableAdapter = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public BookTypeTableAdapter BookTypeTableAdapter
            {
                get
                {
                    return this._BookTypeTableAdapter;
                }
                set
                {
                    this._BookTypeTableAdapter = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public CustomerTableAdapter CustomerTableAdapter
            {
                get
                {
                    return this._CustomerTableAdapter;
                }
                set
                {
                    this._CustomerTableAdapter = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public FactorTableAdapter FactorTableAdapter
            {
                get
                {
                    return this._FactorTableAdapter;
                }
                set
                {
                    this._FactorTableAdapter = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public OrderListTableAdapter OrderListTableAdapter
            {
                get
                {
                    return this._OrderListTableAdapter;
                }
                set
                {
                    this._OrderListTableAdapter = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool BackupDataSetBeforeUpdate
            {
                get
                {
                    return this._backupDataSetBeforeUpdate;
                }
                set
                {
                    this._backupDataSetBeforeUpdate = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public global::System.Data.IDbConnection Connection
            {
                get
                {
                    if ((this._connection != null))
                    {
                        return this._connection;
                    }
                    if (((this._BookTableAdapter != null)
                                && (this._BookTableAdapter.Connection != null)))
                    {
                        return this._BookTableAdapter.Connection;
                    }
                    if (((this._BookTypeTableAdapter != null)
                                && (this._BookTypeTableAdapter.Connection != null)))
                    {
                        return this._BookTypeTableAdapter.Connection;
                    }
                    if (((this._CustomerTableAdapter != null)
                                && (this._CustomerTableAdapter.Connection != null)))
                    {
                        return this._CustomerTableAdapter.Connection;
                    }
                    if (((this._FactorTableAdapter != null)
                                && (this._FactorTableAdapter.Connection != null)))
                    {
                        return this._FactorTableAdapter.Connection;
                    }
                    if (((this._OrderListTableAdapter != null)
                                && (this._OrderListTableAdapter.Connection != null)))
                    {
                        return this._OrderListTableAdapter.Connection;
                    }
                    return null;
                }
                set
                {
                    this._connection = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int TableAdapterInstanceCount
            {
                get
                {
                    int count = 0;
                    if ((this._BookTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._BookTypeTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._CustomerTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._FactorTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._OrderListTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }

            /// <summary>
            ///Update rows in top-down order.
            ///</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private int UpdateUpdatedRows(BookStoreDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
            {
                int result = 0;
                if ((this._BookTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Book.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._BookTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._FactorTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Factor.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._FactorTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._OrderListTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.OrderList.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._OrderListTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._BookTypeTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.BookType.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._BookTypeTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._CustomerTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Customer.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._CustomerTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                return result;
            }

            /// <summary>
            ///Insert rows in top-down order.
            ///</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private int UpdateInsertedRows(BookStoreDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
            {
                int result = 0;
                if ((this._BookTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Book.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._BookTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._FactorTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Factor.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._FactorTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._BookTypeTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.BookType.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._BookTypeTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._CustomerTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Customer.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._CustomerTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._OrderListTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.OrderList.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._OrderListTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                return result;
            }

            /// <summary>
            ///Delete rows in bottom-up order.
            ///</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private int UpdateDeletedRows(BookStoreDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows)
            {
                int result = 0;
                if ((this._OrderListTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.OrderList.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._OrderListTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._CustomerTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Customer.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._CustomerTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._BookTypeTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.BookType.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._BookTypeTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._BookTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Book.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._BookTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._FactorTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Factor.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._FactorTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                return result;
            }

            /// <summary>
            ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
            ///</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
            {
                if (((updatedRows == null)
                            || (updatedRows.Length < 1)))
                {
                    return updatedRows;
                }
                if (((allAddedRows == null)
                            || (allAddedRows.Count < 1)))
                {
                    return updatedRows;
                }
                global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
                for (int i = 0; (i < updatedRows.Length); i = (i + 1))
                {
                    global::System.Data.DataRow row = updatedRows[i];
                    if ((allAddedRows.Contains(row) == false))
                    {
                        realUpdatedRows.Add(row);
                    }
                }
                return realUpdatedRows.ToArray();
            }

            /// <summary>
            ///Update all changes to the dataset.
            ///</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public virtual int UpdateAll(BookStoreDataSet dataSet)
            {
                if ((dataSet == null))
                {
                    throw new global::System.ArgumentNullException("dataSet");
                }
                if ((dataSet.HasChanges() == false))
                {
                    return 0;
                }
                if (((this._BookTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._BookTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                            "tring.");
                }
                if (((this._BookTypeTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._BookTypeTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                            "tring.");
                }
                if (((this._CustomerTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._CustomerTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                            "tring.");
                }
                if (((this._FactorTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._FactorTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                            "tring.");
                }
                if (((this._OrderListTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._OrderListTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                            "tring.");
                }
                global::System.Data.IDbConnection workConnection = this.Connection;
                if ((workConnection == null))
                {
                    throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                            "ger TableAdapter property to a valid TableAdapter instance.");
                }
                bool workConnOpened = false;
                if (((workConnection.State & global::System.Data.ConnectionState.Broken)
                            == global::System.Data.ConnectionState.Broken))
                {
                    workConnection.Close();
                }
                if ((workConnection.State == global::System.Data.ConnectionState.Closed))
                {
                    workConnection.Open();
                    workConnOpened = true;
                }
                global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
                if ((workTransaction == null))
                {
                    throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                            "ctions or the current state is not allowing the transaction to begin.");
                }
                global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
                global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
                global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
                global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
                int result = 0;
                global::System.Data.DataSet backupDataSet = null;
                if (this.BackupDataSetBeforeUpdate)
                {
                    backupDataSet = new global::System.Data.DataSet();
                    backupDataSet.Merge(dataSet);
                }
                try
                {
                    // ---- Prepare for update -----------
                    //
                    if ((this._BookTableAdapter != null))
                    {
                        revertConnections.Add(this._BookTableAdapter, this._BookTableAdapter.Connection);
                        this._BookTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                        this._BookTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                        if (this._BookTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._BookTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._BookTableAdapter.Adapter);
                        }
                    }
                    if ((this._BookTypeTableAdapter != null))
                    {
                        revertConnections.Add(this._BookTypeTableAdapter, this._BookTypeTableAdapter.Connection);
                        this._BookTypeTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                        this._BookTypeTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                        if (this._BookTypeTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._BookTypeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._BookTypeTableAdapter.Adapter);
                        }
                    }
                    if ((this._CustomerTableAdapter != null))
                    {
                        revertConnections.Add(this._CustomerTableAdapter, this._CustomerTableAdapter.Connection);
                        this._CustomerTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                        this._CustomerTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                        if (this._CustomerTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._CustomerTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._CustomerTableAdapter.Adapter);
                        }
                    }
                    if ((this._FactorTableAdapter != null))
                    {
                        revertConnections.Add(this._FactorTableAdapter, this._FactorTableAdapter.Connection);
                        this._FactorTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                        this._FactorTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                        if (this._FactorTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._FactorTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._FactorTableAdapter.Adapter);
                        }
                    }
                    if ((this._OrderListTableAdapter != null))
                    {
                        revertConnections.Add(this._OrderListTableAdapter, this._OrderListTableAdapter.Connection);
                        this._OrderListTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                        this._OrderListTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                        if (this._OrderListTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._OrderListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._OrderListTableAdapter.Adapter);
                        }
                    }
                    // 
                    //---- Perform updates -----------
                    //
                    if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete))
                    {
                        result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                        result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    }
                    else
                    {
                        result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                        result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    }
                    result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                    // 
                    //---- Commit updates -----------
                    //
                    workTransaction.Commit();
                    if ((0 < allAddedRows.Count))
                    {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1))
                        {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                        }
                    }
                    if ((0 < allChangedRows.Count))
                    {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                        allChangedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1))
                        {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                        }
                    }
                }
                catch (global::System.Exception ex)
                {
                    workTransaction.Rollback();
                    // ---- Restore the dataset -----------
                    if (this.BackupDataSetBeforeUpdate)
                    {
                        global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                        dataSet.Clear();
                        dataSet.Merge(backupDataSet);
                    }
                    else
                    {
                        if ((0 < allAddedRows.Count))
                        {
                            global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                            allAddedRows.CopyTo(rows);
                            for (int i = 0; (i < rows.Length); i = (i + 1))
                            {
                                global::System.Data.DataRow row = rows[i];
                                row.AcceptChanges();
                                row.SetAdded();
                            }
                        }
                    }
                    throw ex;
                }
                finally
                {
                    if (workConnOpened)
                    {
                        workConnection.Close();
                    }
                    if ((this._BookTableAdapter != null))
                    {
                        this._BookTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._BookTableAdapter]));
                        this._BookTableAdapter.Transaction = null;
                    }
                    if ((this._BookTypeTableAdapter != null))
                    {
                        this._BookTypeTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._BookTypeTableAdapter]));
                        this._BookTypeTableAdapter.Transaction = null;
                    }
                    if ((this._CustomerTableAdapter != null))
                    {
                        this._CustomerTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._CustomerTableAdapter]));
                        this._CustomerTableAdapter.Transaction = null;
                    }
                    if ((this._FactorTableAdapter != null))
                    {
                        this._FactorTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._FactorTableAdapter]));
                        this._FactorTableAdapter.Transaction = null;
                    }
                    if ((this._OrderListTableAdapter != null))
                    {
                        this._OrderListTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._OrderListTableAdapter]));
                        this._OrderListTableAdapter.Transaction = null;
                    }
                    if ((0 < adaptersWithAcceptChangesDuringUpdate.Count))
                    {
                        global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                        adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                        for (int i = 0; (i < adapters.Length); i = (i + 1))
                        {
                            global::System.Data.Common.DataAdapter adapter = adapters[i];
                            adapter.AcceptChangesDuringUpdate = true;
                        }
                    }
                }
                return result;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst)
            {
                global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection)
            {
                if ((this._connection != null))
                {
                    return true;
                }
                if (((this.Connection == null)
                            || (inputConnection == null)))
                {
                    return true;
                }
                if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal))
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            ///Update Order Option
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public enum UpdateOrderOption
            {

                InsertUpdateDelete = 0,

                UpdateInsertDelete = 1,
            }

            /// <summary>
            ///Used to sort self-referenced table's rows
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow>
            {

                private global::System.Data.DataRelation _relation;

                private int _childFirst;

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst)
                {
                    this._relation = relation;
                    if (childFirst)
                    {
                        this._childFirst = -1;
                    }
                    else
                    {
                        this._childFirst = 1;
                    }
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance)
                {
                    global::System.Diagnostics.Debug.Assert((row != null));
                    global::System.Data.DataRow root = row;
                    distance = 0;

                    global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                    traversedRows[row] = row;

                    global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                    for (
                    ; ((parent != null)
                                && (traversedRows.ContainsKey(parent) == false));
                    )
                    {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                    }

                    if ((distance == 0))
                    {
                        traversedRows.Clear();
                        traversedRows[row] = row;
                        parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                        for (
                        ; ((parent != null)
                                    && (traversedRows.ContainsKey(parent) == false));
                        )
                        {
                            distance = (distance + 1);
                            root = parent;
                            traversedRows[parent] = parent;
                            parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                        }
                    }

                    return root;
                }

                [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
                public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2)
                {
                    if (object.ReferenceEquals(row1, row2))
                    {
                        return 0;
                    }
                    if ((row1 == null))
                    {
                        return -1;
                    }
                    if ((row2 == null))
                    {
                        return 1;
                    }

                    int distance1 = 0;
                    global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                    int distance2 = 0;
                    global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                    if (object.ReferenceEquals(root1, root2))
                    {
                        return (this._childFirst * distance1.CompareTo(distance2));
                    }
                    else
                    {
                        global::System.Diagnostics.Debug.Assert(((root1.Table != null)
                                        && (root2.Table != null)));
                        if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2)))
                        {
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591