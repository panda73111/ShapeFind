namespace ShapeFind
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.numericUpDown_shapeCount = new System.Windows.Forms.NumericUpDown();
            this.label_shapeCount_label = new System.Windows.Forms.Label();
            this.checkBox_genRectangles = new System.Windows.Forms.CheckBox();
            this.checkBox_genTriangles = new System.Windows.Forms.CheckBox();
            this.checkBox_genEllipses = new System.Windows.Forms.CheckBox();
            this.groupBox_minSize = new System.Windows.Forms.GroupBox();
            this.label_minSize_y = new System.Windows.Forms.Label();
            this.label_minSize_x = new System.Windows.Forms.Label();
            this.numericUpDown_minSize_y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_minSize_x = new System.Windows.Forms.NumericUpDown();
            this.groupBox_maxSize = new System.Windows.Forms.GroupBox();
            this.label_maxSize_y = new System.Windows.Forms.Label();
            this.label_maxSize_x = new System.Windows.Forms.Label();
            this.numericUpDown_maxSize_y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_maxSize_x = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_spacer0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_x = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_coordSep = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_y = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_countOnClick = new System.Windows.Forms.CheckBox();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.label_countedShapes = new System.Windows.Forms.Label();
            this.radioButton_countMethod_calculate = new System.Windows.Forms.RadioButton();
            this.radioButton_countMethod_lookup = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shapeCount)).BeginInit();
            this.groupBox_minSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minSize_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minSize_x)).BeginInit();
            this.groupBox_maxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSize_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSize_x)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(660, 384);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(11, 270);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(110, 23);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "generieren";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // numericUpDown_shapeCount
            // 
            this.numericUpDown_shapeCount.Location = new System.Drawing.Point(13, 12);
            this.numericUpDown_shapeCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_shapeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_shapeCount.Name = "numericUpDown_shapeCount";
            this.numericUpDown_shapeCount.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_shapeCount.TabIndex = 2;
            this.numericUpDown_shapeCount.ThousandsSeparator = true;
            this.numericUpDown_shapeCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label_shapeCount_label
            // 
            this.label_shapeCount_label.AutoSize = true;
            this.label_shapeCount_label.Location = new System.Drawing.Point(79, 14);
            this.label_shapeCount_label.Name = "label_shapeCount_label";
            this.label_shapeCount_label.Size = new System.Drawing.Size(42, 13);
            this.label_shapeCount_label.TabIndex = 3;
            this.label_shapeCount_label.Text = "Formen";
            // 
            // checkBox_genRectangles
            // 
            this.checkBox_genRectangles.AutoSize = true;
            this.checkBox_genRectangles.Checked = true;
            this.checkBox_genRectangles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_genRectangles.Location = new System.Drawing.Point(23, 39);
            this.checkBox_genRectangles.Name = "checkBox_genRectangles";
            this.checkBox_genRectangles.Size = new System.Drawing.Size(79, 17);
            this.checkBox_genRectangles.TabIndex = 4;
            this.checkBox_genRectangles.Text = "Rechtecke";
            this.checkBox_genRectangles.UseVisualStyleBackColor = true;
            // 
            // checkBox_genTriangles
            // 
            this.checkBox_genTriangles.AutoSize = true;
            this.checkBox_genTriangles.Checked = true;
            this.checkBox_genTriangles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_genTriangles.Location = new System.Drawing.Point(23, 62);
            this.checkBox_genTriangles.Name = "checkBox_genTriangles";
            this.checkBox_genTriangles.Size = new System.Drawing.Size(69, 17);
            this.checkBox_genTriangles.TabIndex = 5;
            this.checkBox_genTriangles.Text = "Dreiecke";
            this.checkBox_genTriangles.UseVisualStyleBackColor = true;
            // 
            // checkBox_genEllipses
            // 
            this.checkBox_genEllipses.AutoSize = true;
            this.checkBox_genEllipses.Checked = true;
            this.checkBox_genEllipses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_genEllipses.Location = new System.Drawing.Point(23, 86);
            this.checkBox_genEllipses.Name = "checkBox_genEllipses";
            this.checkBox_genEllipses.Size = new System.Drawing.Size(62, 17);
            this.checkBox_genEllipses.TabIndex = 6;
            this.checkBox_genEllipses.Text = "Ellipsen";
            this.checkBox_genEllipses.UseVisualStyleBackColor = true;
            // 
            // groupBox_minSize
            // 
            this.groupBox_minSize.Controls.Add(this.label_minSize_y);
            this.groupBox_minSize.Controls.Add(this.label_minSize_x);
            this.groupBox_minSize.Controls.Add(this.numericUpDown_minSize_y);
            this.groupBox_minSize.Controls.Add(this.numericUpDown_minSize_x);
            this.groupBox_minSize.Location = new System.Drawing.Point(12, 110);
            this.groupBox_minSize.Name = "groupBox_minSize";
            this.groupBox_minSize.Size = new System.Drawing.Size(109, 74);
            this.groupBox_minSize.TabIndex = 7;
            this.groupBox_minSize.TabStop = false;
            this.groupBox_minSize.Text = "min. Größe";
            // 
            // label_minSize_y
            // 
            this.label_minSize_y.AutoSize = true;
            this.label_minSize_y.Location = new System.Drawing.Point(23, 47);
            this.label_minSize_y.Name = "label_minSize_y";
            this.label_minSize_y.Size = new System.Drawing.Size(12, 13);
            this.label_minSize_y.TabIndex = 3;
            this.label_minSize_y.Text = "y";
            // 
            // label_minSize_x
            // 
            this.label_minSize_x.AutoSize = true;
            this.label_minSize_x.Location = new System.Drawing.Point(23, 21);
            this.label_minSize_x.Name = "label_minSize_x";
            this.label_minSize_x.Size = new System.Drawing.Size(12, 13);
            this.label_minSize_x.TabIndex = 2;
            this.label_minSize_x.Text = "x";
            // 
            // numericUpDown_minSize_y
            // 
            this.numericUpDown_minSize_y.Location = new System.Drawing.Point(41, 45);
            this.numericUpDown_minSize_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_minSize_y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_minSize_y.Name = "numericUpDown_minSize_y";
            this.numericUpDown_minSize_y.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_minSize_y.TabIndex = 1;
            this.numericUpDown_minSize_y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_minSize_x
            // 
            this.numericUpDown_minSize_x.Location = new System.Drawing.Point(41, 19);
            this.numericUpDown_minSize_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_minSize_x.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_minSize_x.Name = "numericUpDown_minSize_x";
            this.numericUpDown_minSize_x.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_minSize_x.TabIndex = 0;
            this.numericUpDown_minSize_x.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox_maxSize
            // 
            this.groupBox_maxSize.Controls.Add(this.label_maxSize_y);
            this.groupBox_maxSize.Controls.Add(this.label_maxSize_x);
            this.groupBox_maxSize.Controls.Add(this.numericUpDown_maxSize_y);
            this.groupBox_maxSize.Controls.Add(this.numericUpDown_maxSize_x);
            this.groupBox_maxSize.Location = new System.Drawing.Point(12, 190);
            this.groupBox_maxSize.Name = "groupBox_maxSize";
            this.groupBox_maxSize.Size = new System.Drawing.Size(109, 74);
            this.groupBox_maxSize.TabIndex = 8;
            this.groupBox_maxSize.TabStop = false;
            this.groupBox_maxSize.Text = "min. Größe";
            // 
            // label_maxSize_y
            // 
            this.label_maxSize_y.AutoSize = true;
            this.label_maxSize_y.Location = new System.Drawing.Point(23, 47);
            this.label_maxSize_y.Name = "label_maxSize_y";
            this.label_maxSize_y.Size = new System.Drawing.Size(12, 13);
            this.label_maxSize_y.TabIndex = 3;
            this.label_maxSize_y.Text = "y";
            // 
            // label_maxSize_x
            // 
            this.label_maxSize_x.AutoSize = true;
            this.label_maxSize_x.Location = new System.Drawing.Point(23, 21);
            this.label_maxSize_x.Name = "label_maxSize_x";
            this.label_maxSize_x.Size = new System.Drawing.Size(12, 13);
            this.label_maxSize_x.TabIndex = 2;
            this.label_maxSize_x.Text = "x";
            // 
            // numericUpDown_maxSize_y
            // 
            this.numericUpDown_maxSize_y.Location = new System.Drawing.Point(41, 45);
            this.numericUpDown_maxSize_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_maxSize_y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_maxSize_y.Name = "numericUpDown_maxSize_y";
            this.numericUpDown_maxSize_y.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_maxSize_y.TabIndex = 1;
            this.numericUpDown_maxSize_y.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_maxSize_x
            // 
            this.numericUpDown_maxSize_x.Location = new System.Drawing.Point(41, 19);
            this.numericUpDown_maxSize_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_maxSize_x.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_maxSize_x.Name = "numericUpDown_maxSize_x";
            this.numericUpDown_maxSize_x.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_maxSize_x.TabIndex = 0;
            this.numericUpDown_maxSize_x.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_status,
            this.toolStripStatusLabel_spacer0,
            this.toolStripStatusLabel_x,
            this.toolStripStatusLabel_coordSep,
            this.toolStripStatusLabel_y});
            this.statusStrip.Location = new System.Drawing.Point(0, 399);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(810, 22);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel_status
            // 
            this.toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
            this.toolStripStatusLabel_status.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel_status.Text = "Bereit";
            // 
            // toolStripStatusLabel_spacer0
            // 
            this.toolStripStatusLabel_spacer0.Name = "toolStripStatusLabel_spacer0";
            this.toolStripStatusLabel_spacer0.Size = new System.Drawing.Size(324, 17);
            this.toolStripStatusLabel_spacer0.Spring = true;
            // 
            // toolStripStatusLabel_x
            // 
            this.toolStripStatusLabel_x.AutoSize = false;
            this.toolStripStatusLabel_x.Name = "toolStripStatusLabel_x";
            this.toolStripStatusLabel_x.Size = new System.Drawing.Size(50, 17);
            // 
            // toolStripStatusLabel_coordSep
            // 
            this.toolStripStatusLabel_coordSep.Name = "toolStripStatusLabel_coordSep";
            this.toolStripStatusLabel_coordSep.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel_coordSep.Text = "|";
            // 
            // toolStripStatusLabel_y
            // 
            this.toolStripStatusLabel_y.AutoSize = false;
            this.toolStripStatusLabel_y.Name = "toolStripStatusLabel_y";
            this.toolStripStatusLabel_y.Size = new System.Drawing.Size(50, 17);
            // 
            // checkBox_countOnClick
            // 
            this.checkBox_countOnClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_countOnClick.AutoSize = true;
            this.checkBox_countOnClick.Location = new System.Drawing.Point(3, 333);
            this.checkBox_countOnClick.Name = "checkBox_countOnClick";
            this.checkBox_countOnClick.Size = new System.Drawing.Size(102, 17);
            this.checkBox_countOnClick.TabIndex = 10;
            this.checkBox_countOnClick.Text = "Zählen bei Klick";
            this.checkBox_countOnClick.UseVisualStyleBackColor = true;
            this.checkBox_countOnClick.CheckedChanged += new System.EventHandler(this.checkBox_countOnClick_CheckedChanged);
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.label_countedShapes);
            this.panel_settings.Controls.Add(this.radioButton_countMethod_calculate);
            this.panel_settings.Controls.Add(this.radioButton_countMethod_lookup);
            this.panel_settings.Controls.Add(this.numericUpDown_shapeCount);
            this.panel_settings.Controls.Add(this.checkBox_countOnClick);
            this.panel_settings.Controls.Add(this.button_generate);
            this.panel_settings.Controls.Add(this.label_shapeCount_label);
            this.panel_settings.Controls.Add(this.groupBox_maxSize);
            this.panel_settings.Controls.Add(this.checkBox_genRectangles);
            this.panel_settings.Controls.Add(this.groupBox_minSize);
            this.panel_settings.Controls.Add(this.checkBox_genTriangles);
            this.panel_settings.Controls.Add(this.checkBox_genEllipses);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_settings.Location = new System.Drawing.Point(678, 0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(132, 399);
            this.panel_settings.TabIndex = 11;
            // 
            // label_countedShapes
            // 
            this.label_countedShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countedShapes.Location = new System.Drawing.Point(4, 296);
            this.label_countedShapes.Name = "label_countedShapes";
            this.label_countedShapes.Size = new System.Drawing.Size(116, 34);
            this.label_countedShapes.TabIndex = 13;
            this.label_countedShapes.Text = "0";
            this.label_countedShapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_countMethod_calculate
            // 
            this.radioButton_countMethod_calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_countMethod_calculate.AutoSize = true;
            this.radioButton_countMethod_calculate.Location = new System.Drawing.Point(3, 379);
            this.radioButton_countMethod_calculate.Name = "radioButton_countMethod_calculate";
            this.radioButton_countMethod_calculate.Size = new System.Drawing.Size(83, 17);
            this.radioButton_countMethod_calculate.TabIndex = 12;
            this.radioButton_countMethod_calculate.Text = "Berechnend";
            this.radioButton_countMethod_calculate.UseVisualStyleBackColor = true;
            // 
            // radioButton_countMethod_lookup
            // 
            this.radioButton_countMethod_lookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_countMethod_lookup.AutoSize = true;
            this.radioButton_countMethod_lookup.Checked = true;
            this.radioButton_countMethod_lookup.Location = new System.Drawing.Point(3, 356);
            this.radioButton_countMethod_lookup.Name = "radioButton_countMethod_lookup";
            this.radioButton_countMethod_lookup.Size = new System.Drawing.Size(86, 17);
            this.radioButton_countMethod_lookup.TabIndex = 11;
            this.radioButton_countMethod_lookup.TabStop = true;
            this.radioButton_countMethod_lookup.Text = "Nachsehend";
            this.radioButton_countMethod_lookup.UseVisualStyleBackColor = true;
            this.radioButton_countMethod_lookup.CheckedChanged += new System.EventHandler(this.radioButton_countMethod_lookup_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 421);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(700, 430);
            this.Name = "MainForm";
            this.Text = "ShapeFind";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shapeCount)).EndInit();
            this.groupBox_minSize.ResumeLayout(false);
            this.groupBox_minSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minSize_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minSize_x)).EndInit();
            this.groupBox_maxSize.ResumeLayout(false);
            this.groupBox_maxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSize_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSize_x)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.NumericUpDown numericUpDown_shapeCount;
        private System.Windows.Forms.Label label_shapeCount_label;
        private System.Windows.Forms.CheckBox checkBox_genRectangles;
        private System.Windows.Forms.CheckBox checkBox_genTriangles;
        private System.Windows.Forms.CheckBox checkBox_genEllipses;
        private System.Windows.Forms.GroupBox groupBox_minSize;
        private System.Windows.Forms.Label label_minSize_y;
        private System.Windows.Forms.Label label_minSize_x;
        private System.Windows.Forms.NumericUpDown numericUpDown_minSize_y;
        private System.Windows.Forms.NumericUpDown numericUpDown_minSize_x;
        private System.Windows.Forms.GroupBox groupBox_maxSize;
        private System.Windows.Forms.Label label_maxSize_y;
        private System.Windows.Forms.Label label_maxSize_x;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxSize_y;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxSize_x;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_status;
        private System.Windows.Forms.CheckBox checkBox_countOnClick;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_spacer0;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_x;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_y;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_coordSep;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.RadioButton radioButton_countMethod_calculate;
        private System.Windows.Forms.RadioButton radioButton_countMethod_lookup;
        private System.Windows.Forms.Label label_countedShapes;
    }
}

