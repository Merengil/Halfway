namespace Halfway
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upValue = new System.Windows.Forms.NumericUpDown();
            this.dnValue = new System.Windows.Forms.NumericUpDown();
            this.mid = new System.Windows.Forms.TextBox();
            this.isShort = new System.Windows.Forms.CheckBox();
            this.calc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnValue)).BeginInit();
            this.SuspendLayout();
            // 
            // upValue
            // 
            this.upValue.DecimalPlaces = 3;
            this.upValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.upValue.Location = new System.Drawing.Point(13, 13);
            this.upValue.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.upValue.Name = "upValue";
            this.upValue.Size = new System.Drawing.Size(120, 20);
            this.upValue.TabIndex = 0;
            this.upValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.upValue_KeyPress);
            // 
            // dnValue
            // 
            this.dnValue.DecimalPlaces = 3;
            this.dnValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.dnValue.Location = new System.Drawing.Point(12, 66);
            this.dnValue.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.dnValue.Name = "dnValue";
            this.dnValue.Size = new System.Drawing.Size(121, 20);
            this.dnValue.TabIndex = 1;
            this.dnValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dnValue_KeyPress);
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(13, 40);
            this.mid.Name = "mid";
            this.mid.ReadOnly = true;
            this.mid.Size = new System.Drawing.Size(120, 20);
            this.mid.TabIndex = 2;
            // 
            // isShort
            // 
            this.isShort.AutoSize = true;
            this.isShort.Location = new System.Drawing.Point(13, 93);
            this.isShort.Name = "isShort";
            this.isShort.Size = new System.Drawing.Size(51, 17);
            this.isShort.TabIndex = 3;
            this.isShort.Text = "Short";
            this.isShort.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(13, 117);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(120, 23);
            this.calc.TabIndex = 4;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 152);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.isShort);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.dnValue);
            this.Controls.Add(this.upValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Halfway";
            ((System.ComponentModel.ISupportInitialize)(this.upValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upValue;
        private System.Windows.Forms.NumericUpDown dnValue;
        private System.Windows.Forms.TextBox mid;
        private System.Windows.Forms.CheckBox isShort;
        private System.Windows.Forms.Button calc;
    }
}

