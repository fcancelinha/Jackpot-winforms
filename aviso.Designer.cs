namespace SLOT_MACHINE_FINAL
{
    partial class aviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aviso));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.avisoelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.avisopanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avisonaobotao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.avisosimbutton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.avisopaneltop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closebutton = new MetroSet_UI.Controls.MetroSetButton();
            this.avisodrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.avisopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.avisopaneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // avisoelipse
            // 
            this.avisoelipse.ElipseRadius = 20;
            this.avisoelipse.TargetControl = this;
            // 
            // avisopanel
            // 
            this.avisopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avisopanel.BackgroundImage")));
            this.avisopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avisopanel.Controls.Add(this.pictureBox1);
            this.avisopanel.Controls.Add(this.label1);
            this.avisopanel.Controls.Add(this.avisonaobotao);
            this.avisopanel.Controls.Add(this.avisosimbutton);
            this.avisopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avisopanel.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.avisopanel.GradientBottomRight = System.Drawing.Color.Cyan;
            this.avisopanel.GradientTopLeft = System.Drawing.Color.Aqua;
            this.avisopanel.GradientTopRight = System.Drawing.Color.Teal;
            this.avisopanel.Location = new System.Drawing.Point(0, 25);
            this.avisopanel.Name = "avisopanel";
            this.avisopanel.Quality = 10;
            this.avisopanel.Size = new System.Drawing.Size(421, 169);
            this.avisopanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SLOT_MACHINE_FINAL.Properties.Resources.avisoimage;
            this.pictureBox1.Location = new System.Drawing.Point(150, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Do you wish to start a new game ?";
            // 
            // avisonaobotao
            // 
            this.avisonaobotao.AllowToggling = true;
            this.avisonaobotao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avisonaobotao.AnimationSpeed = 200;
            this.avisonaobotao.AutoGenerateColors = false;
            this.avisonaobotao.BackColor = System.Drawing.Color.Transparent;
            this.avisonaobotao.BackColor1 = System.Drawing.Color.Transparent;
            this.avisonaobotao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avisonaobotao.BackgroundImage")));
            this.avisonaobotao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisonaobotao.ButtonText = "No";
            this.avisonaobotao.ButtonTextMarginLeft = 0;
            this.avisonaobotao.ColorContrastOnClick = 45;
            this.avisonaobotao.ColorContrastOnHover = 45;
            this.avisonaobotao.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.avisonaobotao.CustomizableEdges = borderEdges1;
            this.avisonaobotao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.avisonaobotao.DisabledBorderColor = System.Drawing.Color.Empty;
            this.avisonaobotao.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.avisonaobotao.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.avisonaobotao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.avisonaobotao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisonaobotao.ForeColor = System.Drawing.Color.White;
            this.avisonaobotao.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.avisonaobotao.IconMarginLeft = 11;
            this.avisonaobotao.IconPadding = 10;
            this.avisonaobotao.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.avisonaobotao.IdleBorderColor = System.Drawing.Color.White;
            this.avisonaobotao.IdleBorderRadius = 25;
            this.avisonaobotao.IdleBorderThickness = 1;
            this.avisonaobotao.IdleFillColor = System.Drawing.Color.Transparent;
            this.avisonaobotao.IdleIconLeftImage = null;
            this.avisonaobotao.IdleIconRightImage = null;
            this.avisonaobotao.IndicateFocus = true;
            this.avisonaobotao.Location = new System.Drawing.Point(233, 129);
            this.avisonaobotao.Name = "avisonaobotao";
            this.avisonaobotao.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.avisonaobotao.onHoverState.BorderRadius = 25;
            this.avisonaobotao.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisonaobotao.onHoverState.BorderThickness = 1;
            this.avisonaobotao.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.avisonaobotao.onHoverState.ForeColor = System.Drawing.Color.White;
            this.avisonaobotao.onHoverState.IconLeftImage = null;
            this.avisonaobotao.onHoverState.IconRightImage = null;
            this.avisonaobotao.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.avisonaobotao.OnIdleState.BorderRadius = 25;
            this.avisonaobotao.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisonaobotao.OnIdleState.BorderThickness = 1;
            this.avisonaobotao.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.avisonaobotao.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.avisonaobotao.OnIdleState.IconLeftImage = null;
            this.avisonaobotao.OnIdleState.IconRightImage = null;
            this.avisonaobotao.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.avisonaobotao.OnPressedState.BorderRadius = 25;
            this.avisonaobotao.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisonaobotao.OnPressedState.BorderThickness = 1;
            this.avisonaobotao.OnPressedState.FillColor = System.Drawing.Color.White;
            this.avisonaobotao.OnPressedState.ForeColor = System.Drawing.Color.Aqua;
            this.avisonaobotao.OnPressedState.IconLeftImage = null;
            this.avisonaobotao.OnPressedState.IconRightImage = null;
            this.avisonaobotao.Size = new System.Drawing.Size(83, 25);
            this.avisonaobotao.TabIndex = 71;
            this.avisonaobotao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avisonaobotao.TextMarginLeft = 0;
            this.avisonaobotao.UseDefaultRadiusAndThickness = true;
            this.avisonaobotao.Click += new System.EventHandler(this.avisonaobotao_Click);
            // 
            // avisosimbutton
            // 
            this.avisosimbutton.AllowToggling = true;
            this.avisosimbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avisosimbutton.AnimationSpeed = 200;
            this.avisosimbutton.AutoGenerateColors = false;
            this.avisosimbutton.BackColor = System.Drawing.Color.Transparent;
            this.avisosimbutton.BackColor1 = System.Drawing.Color.Transparent;
            this.avisosimbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avisosimbutton.BackgroundImage")));
            this.avisosimbutton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisosimbutton.ButtonText = "Yes";
            this.avisosimbutton.ButtonTextMarginLeft = 0;
            this.avisosimbutton.ColorContrastOnClick = 45;
            this.avisosimbutton.ColorContrastOnHover = 45;
            this.avisosimbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.avisosimbutton.CustomizableEdges = borderEdges2;
            this.avisosimbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.avisosimbutton.DisabledBorderColor = System.Drawing.Color.Empty;
            this.avisosimbutton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.avisosimbutton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.avisosimbutton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.avisosimbutton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisosimbutton.ForeColor = System.Drawing.Color.White;
            this.avisosimbutton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.avisosimbutton.IconMarginLeft = 11;
            this.avisosimbutton.IconPadding = 10;
            this.avisosimbutton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.avisosimbutton.IdleBorderColor = System.Drawing.Color.White;
            this.avisosimbutton.IdleBorderRadius = 25;
            this.avisosimbutton.IdleBorderThickness = 1;
            this.avisosimbutton.IdleFillColor = System.Drawing.Color.Transparent;
            this.avisosimbutton.IdleIconLeftImage = null;
            this.avisosimbutton.IdleIconRightImage = null;
            this.avisosimbutton.IndicateFocus = true;
            this.avisosimbutton.Location = new System.Drawing.Point(92, 129);
            this.avisosimbutton.Name = "avisosimbutton";
            this.avisosimbutton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.avisosimbutton.onHoverState.BorderRadius = 25;
            this.avisosimbutton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisosimbutton.onHoverState.BorderThickness = 1;
            this.avisosimbutton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.avisosimbutton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.avisosimbutton.onHoverState.IconLeftImage = null;
            this.avisosimbutton.onHoverState.IconRightImage = null;
            this.avisosimbutton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.avisosimbutton.OnIdleState.BorderRadius = 25;
            this.avisosimbutton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisosimbutton.OnIdleState.BorderThickness = 1;
            this.avisosimbutton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.avisosimbutton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.avisosimbutton.OnIdleState.IconLeftImage = null;
            this.avisosimbutton.OnIdleState.IconRightImage = null;
            this.avisosimbutton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.avisosimbutton.OnPressedState.BorderRadius = 25;
            this.avisosimbutton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.avisosimbutton.OnPressedState.BorderThickness = 1;
            this.avisosimbutton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.avisosimbutton.OnPressedState.ForeColor = System.Drawing.Color.Aqua;
            this.avisosimbutton.OnPressedState.IconLeftImage = null;
            this.avisosimbutton.OnPressedState.IconRightImage = null;
            this.avisosimbutton.Size = new System.Drawing.Size(83, 25);
            this.avisosimbutton.TabIndex = 70;
            this.avisosimbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avisosimbutton.TextMarginLeft = 0;
            this.avisosimbutton.UseDefaultRadiusAndThickness = true;
            this.avisosimbutton.Click += new System.EventHandler(this.avisosimbutton_Click);
            // 
            // avisopaneltop
            // 
            this.avisopaneltop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avisopaneltop.BackgroundImage")));
            this.avisopaneltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avisopaneltop.Controls.Add(this.closebutton);
            this.avisopaneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.avisopaneltop.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.avisopaneltop.GradientBottomRight = System.Drawing.Color.Cyan;
            this.avisopaneltop.GradientTopLeft = System.Drawing.Color.Aqua;
            this.avisopaneltop.GradientTopRight = System.Drawing.Color.Teal;
            this.avisopaneltop.Location = new System.Drawing.Point(0, 0);
            this.avisopaneltop.Name = "avisopaneltop";
            this.avisopaneltop.Quality = 10;
            this.avisopaneltop.Size = new System.Drawing.Size(421, 25);
            this.avisopaneltop.TabIndex = 74;
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.closebutton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.closebutton.DisabledForeColor = System.Drawing.Color.Gray;
            this.closebutton.Font = new System.Drawing.Font("Corbel", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.HoverBorderColor = System.Drawing.Color.Transparent;
            this.closebutton.HoverColor = System.Drawing.Color.Transparent;
            this.closebutton.HoverTextColor = System.Drawing.Color.Firebrick;
            this.closebutton.Location = new System.Drawing.Point(394, 7);
            this.closebutton.Name = "closebutton";
            this.closebutton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.closebutton.NormalColor = System.Drawing.Color.Transparent;
            this.closebutton.NormalTextColor = System.Drawing.Color.White;
            this.closebutton.PressBorderColor = System.Drawing.Color.Transparent;
            this.closebutton.PressColor = System.Drawing.Color.Transparent;
            this.closebutton.PressTextColor = System.Drawing.Color.Firebrick;
            this.closebutton.Size = new System.Drawing.Size(15, 15);
            this.closebutton.Style = MetroSet_UI.Design.Style.Custom;
            this.closebutton.StyleManager = null;
            this.closebutton.TabIndex = 7;
            this.closebutton.Text = "•";
            this.closebutton.ThemeAuthor = "Narwin";
            this.closebutton.ThemeName = "MetroLite";
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // avisodrag
            // 
            this.avisodrag.Fixed = true;
            this.avisodrag.Horizontal = true;
            this.avisodrag.TargetControl = this.avisopaneltop;
            this.avisodrag.Vertical = true;
            // 
            // aviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 194);
            this.Controls.Add(this.avisopanel);
            this.Controls.Add(this.avisopaneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aviso";
            this.avisopanel.ResumeLayout(false);
            this.avisopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.avisopaneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse avisoelipse;
        private Bunifu.Framework.UI.BunifuGradientPanel avisopanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton avisonaobotao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton avisosimbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel avisopaneltop;
        private MetroSet_UI.Controls.MetroSetButton closebutton;
        private Bunifu.Framework.UI.BunifuDragControl avisodrag;
    }
}