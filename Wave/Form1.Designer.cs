namespace Wave
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeHardView = new System.Windows.Forms.TreeView();
            this.listHardView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comLocHard = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeHardView
            // 
            this.treeHardView.Location = new System.Drawing.Point(394, 119);
            this.treeHardView.Name = "treeHardView";
            this.treeHardView.Size = new System.Drawing.Size(326, 401);
            this.treeHardView.TabIndex = 0;
            this.treeHardView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeHardView_MouseDoubleClick);
            // 
            // listHardView
            // 
            this.listHardView.CheckBoxes = true;
            this.listHardView.LabelWrap = false;
            this.listHardView.Location = new System.Drawing.Point(59, 119);
            this.listHardView.Name = "listHardView";
            this.listHardView.ShowGroups = false;
            this.listHardView.Size = new System.Drawing.Size(184, 401);
            this.listHardView.TabIndex = 1;
            this.listHardView.UseCompatibleStateImageBehavior = false;
            this.listHardView.View = System.Windows.Forms.View.SmallIcon;
            this.listHardView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listHardView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据文件目录：";
            // 
            // comLocHard
            // 
            this.comLocHard.FormattingEnabled = true;
            this.comLocHard.Location = new System.Drawing.Point(59, 80);
            this.comLocHard.Name = "comLocHard";
            this.comLocHard.Size = new System.Drawing.Size(184, 20);
            this.comLocHard.TabIndex = 3;
            this.comLocHard.SelectedIndexChanged += new System.EventHandler(this.comLocHard_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(278, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加=>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(278, 310);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 42);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导入";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 532);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comLocHard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHardView);
            this.Controls.Add(this.treeHardView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeHardView;
        private System.Windows.Forms.ListView listHardView;
        private System.Windows.Forms.ComboBox comLocHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
    }
}

