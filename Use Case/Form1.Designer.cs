namespace Use_Case
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btActor = new System.Windows.Forms.Button();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbUseCase = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.RichTextBox();
            this.Actor1 = new System.Windows.Forms.PictureBox();
            this.Actor2 = new System.Windows.Forms.PictureBox();
            this.Actor3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbActor2 = new System.Windows.Forms.RadioButton();
            this.rbActor1 = new System.Windows.Forms.RadioButton();
            this.rbActor3 = new System.Windows.Forms.RadioButton();
            this.btRemoveActor = new System.Windows.Forms.Button();
            this.lbActor1 = new System.Windows.Forms.Label();
            this.lbActor2 = new System.Windows.Forms.Label();
            this.lbActor3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btActor);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Controls.Add(this.rbUseCase);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            // 
            // btActor
            // 
            this.btActor.Location = new System.Drawing.Point(7, 17);
            this.btActor.Name = "btActor";
            this.btActor.Size = new System.Drawing.Size(75, 23);
            this.btActor.TabIndex = 2;
            this.btActor.Text = "Actor";
            this.btActor.UseVisualStyleBackColor = true;
            this.btActor.Click += new System.EventHandler(this.btActor_Click);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(7, 66);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbUseCase
            // 
            this.rbUseCase.AutoSize = true;
            this.rbUseCase.Location = new System.Drawing.Point(7, 43);
            this.rbUseCase.Name = "rbUseCase";
            this.rbUseCase.Size = new System.Drawing.Size(71, 17);
            this.rbUseCase.TabIndex = 1;
            this.rbUseCase.TabStop = true;
            this.rbUseCase.Text = "Use Case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSelect);
            this.groupBox2.Controls.Add(this.rbCreate);
            this.groupBox2.Location = new System.Drawing.Point(221, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modes";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(7, 43);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(55, 17);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Checked = true;
            this.rbCreate.Location = new System.Drawing.Point(7, 20);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(56, 17);
            this.rbCreate.TabIndex = 0;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 111);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(804, 559);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(741, 14);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear All";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(741, 43);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tekst:";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(115, 31);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 53);
            this.txtInsert.TabIndex = 7;
            this.txtInsert.Text = "";
            // 
            // Actor1
            // 
            this.Actor1.BackColor = System.Drawing.Color.White;
            this.Actor1.BackgroundImage = global::Use_Case.Properties.Resources.Actor;
            this.Actor1.Location = new System.Drawing.Point(20, 120);
            this.Actor1.Name = "Actor1";
            this.Actor1.Size = new System.Drawing.Size(112, 125);
            this.Actor1.TabIndex = 8;
            this.Actor1.TabStop = false;
            this.Actor1.Visible = false;
            // 
            // Actor2
            // 
            this.Actor2.BackColor = System.Drawing.Color.White;
            this.Actor2.BackgroundImage = global::Use_Case.Properties.Resources.Actor;
            this.Actor2.Location = new System.Drawing.Point(20, 305);
            this.Actor2.Name = "Actor2";
            this.Actor2.Size = new System.Drawing.Size(112, 125);
            this.Actor2.TabIndex = 9;
            this.Actor2.TabStop = false;
            this.Actor2.Visible = false;
            // 
            // Actor3
            // 
            this.Actor3.BackColor = System.Drawing.Color.White;
            this.Actor3.BackgroundImage = global::Use_Case.Properties.Resources.Actor;
            this.Actor3.Location = new System.Drawing.Point(20, 488);
            this.Actor3.Name = "Actor3";
            this.Actor3.Size = new System.Drawing.Size(112, 125);
            this.Actor3.TabIndex = 10;
            this.Actor3.TabStop = false;
            this.Actor3.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btRemoveActor);
            this.groupBox3.Controls.Add(this.rbActor3);
            this.groupBox3.Controls.Add(this.rbActor2);
            this.groupBox3.Controls.Add(this.rbActor1);
            this.groupBox3.Location = new System.Drawing.Point(320, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 91);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actoren";
            // 
            // rbActor2
            // 
            this.rbActor2.AutoSize = true;
            this.rbActor2.Location = new System.Drawing.Point(7, 43);
            this.rbActor2.Name = "rbActor2";
            this.rbActor2.Size = new System.Drawing.Size(59, 17);
            this.rbActor2.TabIndex = 1;
            this.rbActor2.TabStop = true;
            this.rbActor2.Text = "Actor 2";
            this.rbActor2.UseVisualStyleBackColor = true;
            // 
            // rbActor1
            // 
            this.rbActor1.AutoSize = true;
            this.rbActor1.Checked = true;
            this.rbActor1.Location = new System.Drawing.Point(7, 20);
            this.rbActor1.Name = "rbActor1";
            this.rbActor1.Size = new System.Drawing.Size(59, 17);
            this.rbActor1.TabIndex = 0;
            this.rbActor1.TabStop = true;
            this.rbActor1.Text = "Actor 1";
            this.rbActor1.UseVisualStyleBackColor = true;
            // 
            // rbActor3
            // 
            this.rbActor3.AutoSize = true;
            this.rbActor3.Location = new System.Drawing.Point(7, 65);
            this.rbActor3.Name = "rbActor3";
            this.rbActor3.Size = new System.Drawing.Size(59, 17);
            this.rbActor3.TabIndex = 12;
            this.rbActor3.TabStop = true;
            this.rbActor3.Text = "Actor 3";
            this.rbActor3.UseVisualStyleBackColor = true;
            // 
            // btRemoveActor
            // 
            this.btRemoveActor.Location = new System.Drawing.Point(79, 47);
            this.btRemoveActor.Name = "btRemoveActor";
            this.btRemoveActor.Size = new System.Drawing.Size(75, 35);
            this.btRemoveActor.TabIndex = 12;
            this.btRemoveActor.Text = "Remove Actor";
            this.btRemoveActor.UseVisualStyleBackColor = true;
            this.btRemoveActor.Click += new System.EventHandler(this.btRemoveActor_Click);
            // 
            // lbActor1
            // 
            this.lbActor1.AutoSize = true;
            this.lbActor1.BackColor = System.Drawing.Color.White;
            this.lbActor1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbActor1.Location = new System.Drawing.Point(20, 248);
            this.lbActor1.Name = "lbActor1";
            this.lbActor1.Size = new System.Drawing.Size(66, 22);
            this.lbActor1.TabIndex = 12;
            this.lbActor1.Text = "Actor1";
            this.lbActor1.Visible = false;
            // 
            // lbActor2
            // 
            this.lbActor2.AutoSize = true;
            this.lbActor2.BackColor = System.Drawing.Color.White;
            this.lbActor2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbActor2.Location = new System.Drawing.Point(20, 433);
            this.lbActor2.Name = "lbActor2";
            this.lbActor2.Size = new System.Drawing.Size(66, 22);
            this.lbActor2.TabIndex = 13;
            this.lbActor2.Text = "Actor2";
            this.lbActor2.Visible = false;
            // 
            // lbActor3
            // 
            this.lbActor3.AutoSize = true;
            this.lbActor3.BackColor = System.Drawing.Color.White;
            this.lbActor3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbActor3.Location = new System.Drawing.Point(20, 616);
            this.lbActor3.Name = "lbActor3";
            this.lbActor3.Size = new System.Drawing.Size(66, 22);
            this.lbActor3.TabIndex = 14;
            this.lbActor3.Text = "Actor3";
            this.lbActor3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 682);
            this.Controls.Add(this.lbActor3);
            this.Controls.Add(this.lbActor2);
            this.Controls.Add(this.lbActor1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Actor3);
            this.Controls.Add(this.Actor2);
            this.Controls.Add(this.Actor1);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Use Case";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbUseCase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInsert;
        private System.Windows.Forms.Button btActor;
        private System.Windows.Forms.PictureBox Actor1;
        private System.Windows.Forms.PictureBox Actor2;
        private System.Windows.Forms.PictureBox Actor3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbActor3;
        private System.Windows.Forms.RadioButton rbActor2;
        private System.Windows.Forms.RadioButton rbActor1;
        private System.Windows.Forms.Button btRemoveActor;
        private System.Windows.Forms.Label lbActor1;
        private System.Windows.Forms.Label lbActor2;
        private System.Windows.Forms.Label lbActor3;
    }
}

