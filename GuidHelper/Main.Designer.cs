
namespace GuidHelper
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblPoweredBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "reload-48.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRaw);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.txtGuid);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 305);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guid Helper";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.Brown;
            this.lblType.Location = new System.Drawing.Point(319, 141);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(277, 30);
            this.lblType.TabIndex = 14;
            this.lblType.Text = " ...";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oracle Raw-16 Or Standard Guid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Standard Guid Or Oracle Raw-16:";
            // 
            // txtRaw
            // 
            this.txtRaw.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtRaw.Font = new System.Drawing.Font("Segoe UI Semibold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRaw.Location = new System.Drawing.Point(26, 235);
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.ReadOnly = true;
            this.txtRaw.Size = new System.Drawing.Size(570, 42);
            this.txtRaw.TabIndex = 4;
            this.txtRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.ImageIndex = 0;
            this.btnConvert.ImageList = this.imageList1;
            this.btnConvert.Location = new System.Drawing.Point(629, 50);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(187, 227);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtGuid
            // 
            this.txtGuid.BackColor = System.Drawing.SystemColors.Info;
            this.txtGuid.Font = new System.Drawing.Font("Segoe UI Semibold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGuid.Location = new System.Drawing.Point(26, 96);
            this.txtGuid.MaxLength = 50;
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.PlaceholderText = "Type Here";
            this.txtGuid.Size = new System.Drawing.Size(570, 42);
            this.txtGuid.TabIndex = 1;
            this.txtGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuid.WordWrap = false;
            this.txtGuid.TextChanged += new System.EventHandler(this.txtGuid_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPoweredBy});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 39);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblPoweredBy
            // 
            this.tslblPoweredBy.Image = global::GuidHelper.Properties.Resources._033;
            this.tslblPoweredBy.Name = "tslblPoweredBy";
            this.tslblPoweredBy.Size = new System.Drawing.Size(246, 30);
            this.tslblPoweredBy.Text = "Powered by XAMT.Pro";
            this.tslblPoweredBy.ToolTipText = "Powered by XAMT.Pro";
            this.tslblPoweredBy.Click += new System.EventHandler(this.tslblPoweredBy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.ImageIndex = 0;
            this.btnCancel.ImageList = this.imageList3;
            this.btnCancel.Location = new System.Drawing.Point(677, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 60);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Exit";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "018.png");
            this.imageList3.Images.SetKeyName(1, "029.png");
            this.imageList3.Images.SetKeyName(2, "103.png");
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.ImageIndex = 1;
            this.btnReload.ImageList = this.imageList3;
            this.btnReload.Location = new System.Drawing.Point(20, 351);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(185, 60);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.ImageIndex = 2;
            this.btnGenerate.ImageList = this.imageList3;
            this.btnGenerate.Location = new System.Drawing.Point(235, 351);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(185, 60);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReload;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Guid Helper";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaw;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblPoweredBy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblType;
    }
}

