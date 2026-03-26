namespace Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbSorts = new System.Windows.Forms.GroupBox();
            this.rbVanilla = new System.Windows.Forms.RadioButton();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbPistachio = new System.Windows.Forms.RadioButton();
            this.rbFruit = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSorts
            // 
            this.gbSorts.Controls.Add(this.rbFruit);
            this.gbSorts.Controls.Add(this.rbVanilla);
            this.gbSorts.Controls.Add(this.rbPistachio);
            this.gbSorts.Controls.Add(this.rbChocolate);
            this.gbSorts.Location = new System.Drawing.Point(116, 84);
            this.gbSorts.Name = "gbSorts";
            this.gbSorts.Size = new System.Drawing.Size(212, 155);
            this.gbSorts.TabIndex = 0;
            this.gbSorts.TabStop = false;
            this.gbSorts.Text = "Виберіть сорт морозива:";
            // 
            // rbVanilla
            // 
            this.rbVanilla.AutoSize = true;
            this.rbVanilla.Location = new System.Drawing.Point(0, 25);
            this.rbVanilla.Name = "rbVanilla";
            this.rbVanilla.Size = new System.Drawing.Size(152, 24);
            this.rbVanilla.TabIndex = 1;
            this.rbVanilla.TabStop = true;
            this.rbVanilla.Text = "Пломбір 30 грн ";
            this.rbVanilla.UseVisualStyleBackColor = true;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(0, 55);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(176, 24);
            this.rbChocolate.TabIndex = 2;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Шоколадне 35 грн ";
            this.rbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbPistachio
            // 
            this.rbPistachio.AutoSize = true;
            this.rbPistachio.Location = new System.Drawing.Point(0, 85);
            this.rbPistachio.Name = "rbPistachio";
            this.rbPistachio.Size = new System.Drawing.Size(181, 24);
            this.rbPistachio.TabIndex = 3;
            this.rbPistachio.TabStop = true;
            this.rbPistachio.Text = "Фісташкове 45 грн ";
            this.rbPistachio.UseVisualStyleBackColor = true;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(0, 115);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(164, 24);
            this.rbFruit.TabIndex = 4;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "Фруктове 25 грн ";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(116, 258);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(134, 20);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Кількість порцій:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(256, 255);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(116, 294);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 52);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(506, 93);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(156, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "До сплати: 0.00 грн";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.gbSorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSorts.ResumeLayout(false);
            this.gbSorts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSorts;
        private System.Windows.Forms.RadioButton rbFruit;
        private System.Windows.Forms.RadioButton rbVanilla;
        private System.Windows.Forms.RadioButton rbPistachio;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

