namespace CHA.Componentes
{
    partial class Dialogos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialogos));
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panelOk = new System.Windows.Forms.Panel();
            this.panelQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.icon_delad = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.icon = new System.Windows.Forms.PictureBox();
            this.bunifuCards1.SuspendLayout();
            this.panelOk.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.BunifuFormFadeTransition1_TransitionEnd);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCards1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.panelOk);
            this.bunifuCards1.Controls.Add(this.panelQuestion);
            this.bunifuCards1.Controls.Add(this.btncerrar);
            this.bunifuCards1.Controls.Add(this.lbltitulo);
            this.bunifuCards1.Controls.Add(this.lblmensaje);
            this.bunifuCards1.Controls.Add(this.icon);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(582, 451);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.BunifuCards1_Paint);
            // 
            // panelOk
            // 
            this.panelOk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOk.AutoSize = true;
            this.panelOk.Controls.Add(this.btnok);
            this.panelOk.Location = new System.Drawing.Point(220, 361);
            this.panelOk.Name = "panelOk";
            this.panelOk.Size = new System.Drawing.Size(245, 69);
            this.panelOk.TabIndex = 1;
            this.panelOk.Visible = false;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestion.AutoScroll = true;
            this.panelQuestion.AutoSize = true;
            this.panelQuestion.Controls.Add(this.btnsi);
            this.panelQuestion.Controls.Add(this.btnno);
            this.panelQuestion.Location = new System.Drawing.Point(179, 363);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(288, 73);
            this.panelQuestion.TabIndex = 0;
            this.panelQuestion.Visible = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(500, 17);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(70, 37);
            this.btncerrar.TabIndex = 4;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Visible = false;
            this.btncerrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(136, 14);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(304, 60);
            this.lbltitulo.TabIndex = 13;
            this.lbltitulo.Text = "Titulo";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmensaje.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(111, 255);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(354, 108);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "Mensaje";
            this.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_delad
            // 
            this.icon_delad.Enabled = true;
            this.icon_delad.Interval = 1300;
            this.icon_delad.Tick += new System.EventHandler(this.Icon_delad_Tick);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbltitulo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnok
            // 
            this.btnok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnok.AutoSize = true;
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnok.BorderRadius = 7;
            this.btnok.ButtonText = "Ok";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.DisabledColor = System.Drawing.Color.Gray;
            this.btnok.Iconcolor = System.Drawing.Color.Transparent;
            this.btnok.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnok.Iconimage")));
            this.btnok.Iconimage_right = null;
            this.btnok.Iconimage_right_Selected = null;
            this.btnok.Iconimage_Selected = null;
            this.btnok.IconMarginLeft = 0;
            this.btnok.IconMarginRight = 0;
            this.btnok.IconRightVisible = true;
            this.btnok.IconRightZoom = 0D;
            this.btnok.IconVisible = false;
            this.btnok.IconZoom = 90D;
            this.btnok.IsTab = false;
            this.btnok.Location = new System.Drawing.Point(14, 4);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnok.Name = "btnok";
            this.btnok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnok.OnHoverTextColor = System.Drawing.Color.White;
            this.btnok.selected = false;
            this.btnok.Size = new System.Drawing.Size(102, 61);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "Ok";
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Textcolor = System.Drawing.Color.White;
            this.btnok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // btnsi
            // 
            this.btnsi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnsi.AutoSize = true;
            this.btnsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsi.BorderRadius = 7;
            this.btnsi.ButtonText = "Sí";
            this.btnsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsi.DisabledColor = System.Drawing.Color.Gray;
            this.btnsi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsi.Iconimage")));
            this.btnsi.Iconimage_right = null;
            this.btnsi.Iconimage_right_Selected = null;
            this.btnsi.Iconimage_Selected = null;
            this.btnsi.IconMarginLeft = 0;
            this.btnsi.IconMarginRight = 0;
            this.btnsi.IconRightVisible = true;
            this.btnsi.IconRightZoom = 0D;
            this.btnsi.IconVisible = false;
            this.btnsi.IconZoom = 90D;
            this.btnsi.IsTab = false;
            this.btnsi.Location = new System.Drawing.Point(4, 4);
            this.btnsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsi.Name = "btnsi";
            this.btnsi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnsi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnsi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsi.selected = false;
            this.btnsi.Size = new System.Drawing.Size(102, 61);
            this.btnsi.TabIndex = 0;
            this.btnsi.Text = "Sí";
            this.btnsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsi.Textcolor = System.Drawing.Color.White;
            this.btnsi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnno
            // 
            this.btnno.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnno.AutoSize = true;
            this.btnno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnno.BorderRadius = 7;
            this.btnno.ButtonText = "No";
            this.btnno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnno.DisabledColor = System.Drawing.Color.Gray;
            this.btnno.Iconcolor = System.Drawing.Color.Transparent;
            this.btnno.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnno.Iconimage")));
            this.btnno.Iconimage_right = null;
            this.btnno.Iconimage_right_Selected = null;
            this.btnno.Iconimage_Selected = null;
            this.btnno.IconMarginLeft = 0;
            this.btnno.IconMarginRight = 0;
            this.btnno.IconRightVisible = true;
            this.btnno.IconRightZoom = 0D;
            this.btnno.IconVisible = false;
            this.btnno.IconZoom = 90D;
            this.btnno.IsTab = false;
            this.btnno.Location = new System.Drawing.Point(114, 4);
            this.btnno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnno.Name = "btnno";
            this.btnno.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.btnno.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnno.OnHoverTextColor = System.Drawing.Color.White;
            this.btnno.selected = false;
            this.btnno.Size = new System.Drawing.Size(102, 61);
            this.btnno.TabIndex = 0;
            this.btnno.Text = "No";
            this.btnno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnno.Textcolor = System.Drawing.Color.White;
            this.btnno.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // icon
            // 
            this.icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Location = new System.Drawing.Point(111, 17);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(354, 331);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 12;
            this.icon.TabStop = false;
            // 
            // Dialogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 451);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogos";
            this.Load += new System.EventHandler(this.Dialogos_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panelOk.ResumeLayout(false);
            this.panelOk.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        public System.Windows.Forms.Timer icon_delad;
        public System.Windows.Forms.Panel panelOk;
        public Bunifu.Framework.UI.BunifuFlatButton btnok;
        public System.Windows.Forms.FlowLayoutPanel panelQuestion;
        public System.Windows.Forms.Label lbltitulo;
        public System.Windows.Forms.Label lblmensaje;
        public System.Windows.Forms.PictureBox icon;
        public Bunifu.Framework.UI.BunifuCards bunifuCards1;
        public Bunifu.Framework.UI.BunifuFlatButton btnsi;
        public Bunifu.Framework.UI.BunifuFlatButton btnno;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        public System.Windows.Forms.Button btncerrar;
    }
}