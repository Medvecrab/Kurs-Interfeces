
namespace Kurs_Interfeces
{
    partial class AddTraficLight
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
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelRed = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.labelYellow = new System.Windows.Forms.Label();
            this.numericUpDownYellow = new System.Windows.Forms.NumericUpDown();
            this.labelGreen = new System.Windows.Forms.Label();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(13, 13);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(16, 30);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX.TabIndex = 1;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(13, 53);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(16, 69);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY.TabIndex = 3;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(13, 92);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(61, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "Состояние";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Красный",
            "Жёлтый",
            "Зелёный",
            "Режим ожидания",
            "Выключен"});
            this.comboBoxState.Location = new System.Drawing.Point(16, 109);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 5;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(13, 133);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(186, 13);
            this.labelRed.TabIndex = 6;
            this.labelRed.Text = "Длительность красного света, сек";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(16, 149);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRed.TabIndex = 7;
            this.numericUpDownRed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelYellow
            // 
            this.labelYellow.AutoSize = true;
            this.labelYellow.Location = new System.Drawing.Point(13, 172);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(181, 13);
            this.labelYellow.TabIndex = 8;
            this.labelYellow.Text = "Длительность жёлтого света, сек";
            // 
            // numericUpDownYellow
            // 
            this.numericUpDownYellow.Location = new System.Drawing.Point(16, 188);
            this.numericUpDownYellow.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownYellow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYellow.Name = "numericUpDownYellow";
            this.numericUpDownYellow.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYellow.TabIndex = 9;
            this.numericUpDownYellow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(13, 211);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(186, 13);
            this.labelGreen.TabIndex = 10;
            this.labelGreen.Text = "Длительность зелёного света, сек";
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(16, 227);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGreen.TabIndex = 11;
            this.numericUpDownGreen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(13, 254);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(166, 13);
            this.labelComment.TabIndex = 12;
            this.labelComment.Text = "Комментарий (не обязятельно)";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(16, 270);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(100, 20);
            this.textBoxComment.TabIndex = 13;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(50, 297);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(121, 23);
            this.buttonConfirm.TabIndex = 14;
            this.buttonConfirm.Text = "Добавить светофор";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // AddTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 332);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.numericUpDownYellow);
            this.Controls.Add(this.labelYellow);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.labelX);
            this.Name = "AddTraficLight";
            this.Text = "Добавить светофор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTraficLight_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.Label labelYellow;
        private System.Windows.Forms.NumericUpDown numericUpDownYellow;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonConfirm;
    }
}