
namespace pract1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLotID = new System.Windows.Forms.TextBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.tbCarNum = new System.Windows.Forms.TextBox();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.rbBin = new System.Windows.Forms.RadioButton();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currLang = new System.Windows.Forms.ToolStripSplitButton();
            this.engLang = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrLang = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // tbLotID
            // 
            resources.ApplyResources(this.tbLotID, "tbLotID");
            this.tbLotID.Name = "tbLotID";
            this.tbLotID.TextChanged += new System.EventHandler(this.tbLotID_TextChanged);
            // 
            // tbCarName
            // 
            resources.ApplyResources(this.tbCarName, "tbCarName");
            this.tbCarName.Name = "tbCarName";
            // 
            // tbCarNum
            // 
            resources.ApplyResources(this.tbCarNum, "tbCarNum");
            this.tbCarNum.Name = "tbCarNum";
            // 
            // tbOwner
            // 
            resources.ApplyResources(this.tbOwner, "tbOwner");
            this.tbOwner.Name = "tbOwner";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            resources.GetString("cbLevel.Items"),
            resources.GetString("cbLevel.Items1"),
            resources.GetString("cbLevel.Items2"),
            resources.GetString("cbLevel.Items3"),
            resources.GetString("cbLevel.Items4"),
            resources.GetString("cbLevel.Items5"),
            resources.GetString("cbLevel.Items6")});
            resources.ApplyResources(this.cbLevel, "cbLevel");
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.SelectedValueChanged += new System.EventHandler(this.cbLevel_SelectedValueChanged);
            // 
            // rbBin
            // 
            resources.ApplyResources(this.rbBin, "rbBin");
            this.rbBin.Name = "rbBin";
            this.rbBin.TabStop = true;
            this.rbBin.UseVisualStyleBackColor = true;
            this.rbBin.CheckedChanged += new System.EventHandler(this.rbBin_CheckedChanged);
            // 
            // rbXml
            // 
            resources.ApplyResources(this.rbXml, "rbXml");
            this.rbXml.Name = "rbXml";
            this.rbXml.TabStop = true;
            this.rbXml.UseVisualStyleBackColor = true;
            this.rbXml.CheckedChanged += new System.EventHandler(this.rbXml_CheckedChanged);
            // 
            // rbJson
            // 
            resources.ApplyResources(this.rbJson, "rbJson");
            this.rbJson.Name = "rbJson";
            this.rbJson.TabStop = true;
            this.rbJson.UseVisualStyleBackColor = true;
            this.rbJson.CheckedChanged += new System.EventHandler(this.rbJson_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.currLang});
            resources.ApplyResources(this.statusStrip2, "statusStrip2");
            this.statusStrip2.Name = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // currLang
            // 
            this.currLang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engLang,
            this.ukrLang});
            resources.ApplyResources(this.currLang, "currLang");
            this.currLang.Name = "currLang";
            // 
            // engLang
            // 
            this.engLang.Name = "engLang";
            resources.ApplyResources(this.engLang, "engLang");
            this.engLang.Click += new System.EventHandler(this.engLang_Click);
            // 
            // ukrLang
            // 
            this.ukrLang.Name = "ukrLang";
            resources.ApplyResources(this.ukrLang, "ukrLang");
            this.ukrLang.Click += new System.EventHandler(this.ukrLang_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbLotID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbBin);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbXml);
            this.Controls.Add(this.tbCarNum);
            this.Controls.Add(this.rbJson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbLotID;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.TextBox tbCarNum;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.RadioButton rbBin;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton currLang;
        private System.Windows.Forms.ToolStripMenuItem engLang;
        private System.Windows.Forms.ToolStripMenuItem ukrLang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

