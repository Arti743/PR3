
namespace PR3
{
    partial class FormAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR3DataSet = new PR3.PR3DataSet();
            this.administratorsTableAdapter = new PR3.PR3DataSetTableAdapters.AdministratorsTableAdapter();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR3DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.servernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.administratorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // servernameDataGridViewTextBoxColumn
            // 
            this.servernameDataGridViewTextBoxColumn.DataPropertyName = "Server_name";
            this.servernameDataGridViewTextBoxColumn.HeaderText = "Server_name";
            this.servernameDataGridViewTextBoxColumn.Name = "servernameDataGridViewTextBoxColumn";
            // 
            // administratorsBindingSource
            // 
            this.administratorsBindingSource.DataMember = "Administrators";
            this.administratorsBindingSource.DataSource = this.pR3DataSet;
            // 
            // pR3DataSet
            // 
            this.pR3DataSet.DataSetName = "PR3DataSet";
            this.pR3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administratorsTableAdapter
            // 
            this.administratorsTableAdapter.ClearBeforeFill = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(274, 264);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(86, 37);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(366, 264);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(86, 37);
            this.button_Del.TabIndex = 2;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(458, 264);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(86, 37);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(458, 307);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(86, 37);
            this.button_Refresh.TabIndex = 4;
            this.button_Refresh.Text = "Обновить";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.button_Del);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 450);
            this.panel1.TabIndex = 5;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR3DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PR3DataSet pR3DataSet;
        private System.Windows.Forms.BindingSource administratorsBindingSource;
        private PR3DataSetTableAdapters.AdministratorsTableAdapter administratorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Panel panel1;
    }
}