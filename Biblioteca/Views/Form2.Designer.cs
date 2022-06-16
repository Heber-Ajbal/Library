
namespace Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonGender = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonBook = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.simpleAuthor);
            this.tablePanel1.Controls.Add(this.ButtonGender);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.pictureBox3);
            this.tablePanel1.Controls.Add(this.pictureBox2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.ButtonBook);
            this.tablePanel1.Controls.Add(this.pictureBox1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel1.Location = new System.Drawing.Point(0, 56);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 179F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(579, 238);
            this.tablePanel1.TabIndex = 0;
            // 
            // simpleAuthor
            // 
            this.tablePanel1.SetColumn(this.simpleAuthor, 2);
            this.simpleAuthor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleAuthor.ImageOptions.SvgImage")));
            this.simpleAuthor.Location = new System.Drawing.Point(389, 215);
            this.simpleAuthor.Name = "simpleAuthor";
            this.tablePanel1.SetRow(this.simpleAuthor, 2);
            this.simpleAuthor.Size = new System.Drawing.Size(187, 20);
            this.simpleAuthor.TabIndex = 8;
            this.simpleAuthor.Text = "Ver Autores";
            this.simpleAuthor.Click += new System.EventHandler(this.simpleAuthor_Click);
            // 
            // ButtonGender
            // 
            this.tablePanel1.SetColumn(this.ButtonGender, 1);
            this.ButtonGender.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonGender.ImageOptions.SvgImage")));
            this.ButtonGender.Location = new System.Drawing.Point(196, 215);
            this.ButtonGender.Name = "ButtonGender";
            this.tablePanel1.SetRow(this.ButtonGender, 2);
            this.ButtonGender.Size = new System.Drawing.Size(187, 20);
            this.ButtonGender.TabIndex = 7;
            this.ButtonGender.Text = "Ver Generos";
            this.ButtonGender.Click += new System.EventHandler(this.ButtonGender_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(389, 182);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 1);
            this.labelControl3.Size = new System.Drawing.Size(187, 26);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Podrá visualizar todos los autores y administrarlos";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(196, 182);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(187, 26);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Podrá visualizar todos los generos y administrarlos";
            // 
            // pictureBox3
            // 
            this.tablePanel1.SetColumn(this.pictureBox3, 1);
            this.pictureBox3.Image = global::Biblioteca.Properties.Resources.generos;
            this.pictureBox3.Location = new System.Drawing.Point(196, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.tablePanel1.SetRow(this.pictureBox3, 0);
            this.pictureBox3.Size = new System.Drawing.Size(187, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.tablePanel1.SetColumn(this.pictureBox2, 2);
            this.pictureBox2.Image = global::Biblioteca.Properties.Resources.autor;
            this.pictureBox2.Location = new System.Drawing.Point(389, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.tablePanel1.SetRow(this.pictureBox2, 0);
            this.pictureBox2.Size = new System.Drawing.Size(187, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 182);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(187, 26);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Podrá visualizar todos los libros y administrarlos";
            // 
            // ButtonBook
            // 
            this.ButtonBook.AutoSize = true;
            this.tablePanel1.SetColumn(this.ButtonBook, 0);
            this.ButtonBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonBook.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonBook.ImageOptions.SvgImage")));
            this.ButtonBook.Location = new System.Drawing.Point(3, 215);
            this.ButtonBook.Name = "ButtonBook";
            this.tablePanel1.SetRow(this.ButtonBook, 2);
            this.ButtonBook.Size = new System.Drawing.Size(187, 20);
            this.ButtonBook.TabIndex = 1;
            this.ButtonBook.Text = "Ver Libros";
            this.ButtonBook.Click += new System.EventHandler(this.ButtonBook_Click);
            // 
            // pictureBox1
            // 
            this.tablePanel1.SetColumn(this.pictureBox1, 0);
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.ff;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel1.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(187, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(169, -7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(250, 57);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Bienvenido";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(425, 18);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(5, 0);
            this.separatorControl1.TabIndex = 2;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineColor = System.Drawing.Color.Black;
            this.separatorControl2.LineThickness = 2;
            this.separatorControl2.Location = new System.Drawing.Point(21, 18);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(142, 23);
            this.separatorControl2.TabIndex = 5;
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineColor = System.Drawing.Color.Black;
            this.separatorControl3.LineThickness = 2;
            this.separatorControl3.Location = new System.Drawing.Point(425, 18);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(142, 23);
            this.separatorControl3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 294);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleAuthor;
        private DevExpress.XtraEditors.SimpleButton ButtonGender;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
    }
}

