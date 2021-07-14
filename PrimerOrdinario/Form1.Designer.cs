namespace PrimerOrdinario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabDv = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSDV = new System.Windows.Forms.Button();
            this.btnLDV = new System.Windows.Forms.Button();
            this.nDividendo = new System.Windows.Forms.TextBox();
            this.nResultado = new System.Windows.Forms.TextBox();
            this.nDivisor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMT = new System.Windows.Forms.TabPage();
            this.dgMtx = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.nColumnas = new System.Windows.Forms.TextBox();
            this.nFilas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSPro = new System.Windows.Forms.Button();
            this.tabDv.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMtx)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDv
            // 
            this.tabDv.Controls.Add(this.tabPage1);
            this.tabDv.Controls.Add(this.tabMT);
            this.tabDv.Location = new System.Drawing.Point(12, 25);
            this.tabDv.Name = "tabDv";
            this.tabDv.SelectedIndex = 0;
            this.tabDv.Size = new System.Drawing.Size(757, 376);
            this.tabDv.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSDV);
            this.tabPage1.Controls.Add(this.btnLDV);
            this.tabPage1.Controls.Add(this.nDividendo);
            this.tabPage1.Controls.Add(this.nResultado);
            this.tabPage1.Controls.Add(this.nDivisor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "División";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSDV
            // 
            this.btnSDV.Location = new System.Drawing.Point(526, 174);
            this.btnSDV.Name = "btnSDV";
            this.btnSDV.Size = new System.Drawing.Size(162, 37);
            this.btnSDV.TabIndex = 7;
            this.btnSDV.Text = "Limpiar";
            this.btnSDV.UseVisualStyleBackColor = true;
            this.btnSDV.Click += new System.EventHandler(this.btnSDV_Click);
            // 
            // btnLDV
            // 
            this.btnLDV.Location = new System.Drawing.Point(526, 61);
            this.btnLDV.Name = "btnLDV";
            this.btnLDV.Size = new System.Drawing.Size(162, 37);
            this.btnLDV.TabIndex = 6;
            this.btnLDV.Text = "Dividir";
            this.btnLDV.UseVisualStyleBackColor = true;
            this.btnLDV.Click += new System.EventHandler(this.btnLDV_Click);
            // 
            // nDividendo
            // 
            this.nDividendo.Location = new System.Drawing.Point(105, 138);
            this.nDividendo.Name = "nDividendo";
            this.nDividendo.Size = new System.Drawing.Size(133, 20);
            this.nDividendo.TabIndex = 5;
            // 
            // nResultado
            // 
            this.nResultado.Location = new System.Drawing.Point(105, 220);
            this.nResultado.Name = "nResultado";
            this.nResultado.Size = new System.Drawing.Size(133, 20);
            this.nResultado.TabIndex = 4;
            // 
            // nDivisor
            // 
            this.nDivisor.Location = new System.Drawing.Point(105, 50);
            this.nDivisor.Name = "nDivisor";
            this.nDivisor.Size = new System.Drawing.Size(133, 20);
            this.nDivisor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dividendo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divisor";
            // 
            // tabMT
            // 
            this.tabMT.Controls.Add(this.dgMtx);
            this.tabMT.Controls.Add(this.btnLimpiar);
            this.tabMT.Controls.Add(this.btnImprimir);
            this.tabMT.Controls.Add(this.nColumnas);
            this.tabMT.Controls.Add(this.nFilas);
            this.tabMT.Controls.Add(this.label6);
            this.tabMT.Controls.Add(this.label5);
            this.tabMT.Location = new System.Drawing.Point(4, 22);
            this.tabMT.Name = "tabMT";
            this.tabMT.Padding = new System.Windows.Forms.Padding(3);
            this.tabMT.Size = new System.Drawing.Size(749, 350);
            this.tabMT.TabIndex = 1;
            this.tabMT.Text = "Matriz";
            this.tabMT.UseVisualStyleBackColor = true;
            // 
            // dgMtx
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMtx.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMtx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMtx.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMtx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMtx.Location = new System.Drawing.Point(197, 16);
            this.dgMtx.Name = "dgMtx";
            this.dgMtx.Size = new System.Drawing.Size(546, 328);
            this.dgMtx.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(30, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 41);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(30, 177);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 41);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // nColumnas
            // 
            this.nColumnas.Location = new System.Drawing.Point(25, 114);
            this.nColumnas.Name = "nColumnas";
            this.nColumnas.Size = new System.Drawing.Size(127, 20);
            this.nColumnas.TabIndex = 3;
            // 
            // nFilas
            // 
            this.nFilas.Location = new System.Drawing.Point(25, 54);
            this.nFilas.Name = "nFilas";
            this.nFilas.Size = new System.Drawing.Size(127, 20);
            this.nFilas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Columnas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(318, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Primer Odinario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSPro
            // 
            this.btnSPro.Location = new System.Drawing.Point(635, 407);
            this.btnSPro.Name = "btnSPro";
            this.btnSPro.Size = new System.Drawing.Size(130, 41);
            this.btnSPro.TabIndex = 6;
            this.btnSPro.Text = "Salir";
            this.btnSPro.UseVisualStyleBackColor = true;
            this.btnSPro.Click += new System.EventHandler(this.btnSPro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabDv);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.tabDv.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabMT.ResumeLayout(false);
            this.tabMT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMtx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDv;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabMT;
        private System.Windows.Forms.Button btnSDV;
        private System.Windows.Forms.Button btnLDV;
        private System.Windows.Forms.TextBox nDividendo;
        private System.Windows.Forms.TextBox nResultado;
        private System.Windows.Forms.TextBox nDivisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox nColumnas;
        private System.Windows.Forms.TextBox nFilas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSPro;
        private System.Windows.Forms.DataGridView dgMtx;
    }
}

