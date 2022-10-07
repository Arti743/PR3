
namespace PR3
{
    partial class FormBan
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
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bantypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bantimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentfromadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR3DataSet = new PR3.PR3DataSet();
            this.ban_listTableAdapter = new PR3.PR3DataSetTableAdapters.Ban_listTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banlistBindingSource)).BeginInit();
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
            this.playeridDataGridViewTextBoxColumn,
            this.administratorsidDataGridViewTextBoxColumn,
            this.bantypeidDataGridViewTextBoxColumn,
            this.bantimeDataGridViewTextBoxColumn,
            this.commentfromadminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.banlistBindingSource;
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
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "Player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "Player_id";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.Width = 80;
            // 
            // administratorsidDataGridViewTextBoxColumn
            // 
            this.administratorsidDataGridViewTextBoxColumn.DataPropertyName = "Administrators_id";
            this.administratorsidDataGridViewTextBoxColumn.HeaderText = "Administrators_id";
            this.administratorsidDataGridViewTextBoxColumn.Name = "administratorsidDataGridViewTextBoxColumn";
            this.administratorsidDataGridViewTextBoxColumn.Width = 90;
            // 
            // bantypeidDataGridViewTextBoxColumn
            // 
            this.bantypeidDataGridViewTextBoxColumn.DataPropertyName = "Ban_type_id";
            this.bantypeidDataGridViewTextBoxColumn.HeaderText = "Ban_type_id";
            this.bantypeidDataGridViewTextBoxColumn.Name = "bantypeidDataGridViewTextBoxColumn";
            this.bantypeidDataGridViewTextBoxColumn.Width = 80;
            // 
            // bantimeDataGridViewTextBoxColumn
            // 
            this.bantimeDataGridViewTextBoxColumn.DataPropertyName = "Ban_time";
            this.bantimeDataGridViewTextBoxColumn.HeaderText = "Ban_time";
            this.bantimeDataGridViewTextBoxColumn.Name = "bantimeDataGridViewTextBoxColumn";
            this.bantimeDataGridViewTextBoxColumn.Width = 60;
            // 
            // commentfromadminDataGridViewTextBoxColumn
            // 
            this.commentfromadminDataGridViewTextBoxColumn.DataPropertyName = "Comment_from_admin";
            this.commentfromadminDataGridViewTextBoxColumn.HeaderText = "Comment_from_admin";
            this.commentfromadminDataGridViewTextBoxColumn.Name = "commentfromadminDataGridViewTextBoxColumn";
            this.commentfromadminDataGridViewTextBoxColumn.Width = 160;
            // 
            // banlistBindingSource
            // 
            this.banlistBindingSource.DataMember = "Ban_list";
            this.banlistBindingSource.DataSource = this.pR3DataSet;
            // 
            // pR3DataSet
            // 
            this.pR3DataSet.DataSetName = "PR3DataSet";
            this.pR3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ban_listTableAdapter
            // 
            this.ban_listTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 450);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBan";
            this.Text = "Ban list";
            this.Load += new System.EventHandler(this.FormBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR3DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PR3DataSet pR3DataSet;
        private System.Windows.Forms.BindingSource banlistBindingSource;
        private PR3DataSetTableAdapters.Ban_listTableAdapter ban_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administratorsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bantypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bantimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentfromadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}