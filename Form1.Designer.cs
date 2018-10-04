namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label eNDERECOLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clientscadastralDataSet = new Crud.ClientscadastralDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Crud.ClientscadastralDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Crud.ClientscadastralDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuscaPorId = new System.Windows.Forms.ToolStripLabel();
            this.tstId = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.eNDERECOTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.bAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cIDADETextBox = new System.Windows.Forms.TextBox();
            this.uFTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            eNDERECOLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientscadastralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(6, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "ID:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(83, 25);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 4;
            nOMELabel.Text = "NOME:";
            nOMELabel.Click += new System.EventHandler(this.nOMELabel_Click);
            // 
            // eNDERECOLabel
            // 
            eNDERECOLabel.AutoSize = true;
            eNDERECOLabel.Location = new System.Drawing.Point(7, 70);
            eNDERECOLabel.Name = "eNDERECOLabel";
            eNDERECOLabel.Size = new System.Drawing.Size(70, 13);
            eNDERECOLabel.TabIndex = 6;
            eNDERECOLabel.Text = "ENDERECO:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(7, 109);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 8;
            cEPLabel.Text = "CEP:";
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Location = new System.Drawing.Point(112, 109);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(51, 13);
            bAIRROLabel.TabIndex = 10;
            bAIRROLabel.Text = "BAIRRO:";
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Location = new System.Drawing.Point(475, 109);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(50, 13);
            cIDADELabel.TabIndex = 12;
            cIDADELabel.Text = "CIDADE:";
            cIDADELabel.Click += new System.EventHandler(this.cIDADELabel_Click);
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(762, 109);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 14;
            uFLabel.Text = "UF:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(7, 147);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONELabel.TabIndex = 16;
            tELEFONELabel.Text = "TELEFONE:";
            tELEFONELabel.Click += new System.EventHandler(this.tELEFONELabel_Click);
            // 
            // clientscadastralDataSet
            // 
            this.clientscadastralDataSet.DataSetName = "ClientscadastralDataSet";
            this.clientscadastralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.clientscadastralDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Crud.ClientscadastralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = null;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.tableBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbBuscaPorId,
            this.tstId,
            this.tsbBuscar});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = null;
            this.tableBindingNavigator.MoveLastItem = null;
            this.tableBindingNavigator.MoveNextItem = null;
            this.tableBindingNavigator.MovePreviousItem = null;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = null;
            this.tableBindingNavigator.Size = new System.Drawing.Size(865, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Excluir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBuscaPorId
            // 
            this.tsbBuscaPorId.Name = "tsbBuscaPorId";
            this.tsbBuscaPorId.Size = new System.Drawing.Size(79, 22);
            this.tsbBuscaPorId.Text = "Buscar por Id:";
            // 
            // tstId
            // 
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(0, 189);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(845, 275);
            this.tableDataGridView.TabIndex = 1;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn3.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn4.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BAIRRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn6.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UF";
            this.dataGridViewTextBoxColumn7.HeaderText = "UF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn8.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(9, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(68, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(86, 47);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(726, 20);
            this.nOMETextBox.TabIndex = 5;
            // 
            // eNDERECOTextBox
            // 
            this.eNDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ENDERECO", true));
            this.eNDERECOTextBox.Location = new System.Drawing.Point(9, 86);
            this.eNDERECOTextBox.Name = "eNDERECOTextBox";
            this.eNDERECOTextBox.Size = new System.Drawing.Size(803, 20);
            this.eNDERECOTextBox.TabIndex = 7;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(9, 125);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEPTextBox.TabIndex = 9;
            // 
            // bAIRROTextBox
            // 
            this.bAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "BAIRRO", true));
            this.bAIRROTextBox.Location = new System.Drawing.Point(115, 125);
            this.bAIRROTextBox.Name = "bAIRROTextBox";
            this.bAIRROTextBox.Size = new System.Drawing.Size(357, 20);
            this.bAIRROTextBox.TabIndex = 11;
            // 
            // cIDADETextBox
            // 
            this.cIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CIDADE", true));
            this.cIDADETextBox.Location = new System.Drawing.Point(478, 125);
            this.cIDADETextBox.Name = "cIDADETextBox";
            this.cIDADETextBox.Size = new System.Drawing.Size(281, 20);
            this.cIDADETextBox.TabIndex = 13;
            this.cIDADETextBox.TextChanged += new System.EventHandler(this.cIDADETextBox_TextChanged);
            // 
            // uFTextBox
            // 
            this.uFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "UF", true));
            this.uFTextBox.Location = new System.Drawing.Point(765, 125);
            this.uFTextBox.Name = "uFTextBox";
            this.uFTextBox.Size = new System.Drawing.Size(47, 20);
            this.uFTextBox.TabIndex = 15;
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Location = new System.Drawing.Point(9, 163);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(93, 20);
            this.tELEFONETextBox.TabIndex = 17;
            this.tELEFONETextBox.TextChanged += new System.EventHandler(this.tELEFONETextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 476);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.uFTextBox);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.cIDADETextBox);
            this.Controls.Add(bAIRROLabel);
            this.Controls.Add(this.bAIRROTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(eNDERECOLabel);
            this.Controls.Add(this.eNDERECOTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientscadastralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientscadastralDataSet clientscadastralDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ClientscadastralDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ClientscadastralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsbBuscaPorId;
        private System.Windows.Forms.ToolStripTextBox tstId;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox eNDERECOTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox bAIRROTextBox;
        private System.Windows.Forms.TextBox cIDADETextBox;
        private System.Windows.Forms.TextBox uFTextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
    }
}

