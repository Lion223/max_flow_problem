namespace FormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.startVertexTb = new MetroFramework.Controls.MetroTextBox();
            this.endVertexTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.graphViewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.graphrbMp = new MetroFramework.Controls.MetroPanel();
            this.graph_maxRb = new MetroFramework.Controls.MetroRadioButton();
            this.graphRb = new MetroFramework.Controls.MetroRadioButton();
            this.fileLbl = new MetroFramework.Controls.MetroLabel();
            this.maxFlowBtn = new MetroFramework.Controls.MetroButton();
            this.fileTb = new System.Windows.Forms.RichTextBox();
            this.readfileBtn = new MetroFramework.Controls.MetroButton();
            this.resTb = new System.Windows.Forms.RichTextBox();
            this.routeCb = new MetroFramework.Controls.MetroComboBox();
            this.graphrbMp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // startVertexTb
            // 
            // 
            // 
            // 
            this.startVertexTb.CustomButton.Image = null;
            this.startVertexTb.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.startVertexTb.CustomButton.Name = "";
            this.startVertexTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.startVertexTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.startVertexTb.CustomButton.TabIndex = 1;
            this.startVertexTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startVertexTb.CustomButton.UseSelectable = true;
            this.startVertexTb.CustomButton.Visible = false;
            this.startVertexTb.Lines = new string[] {
        "0"};
            this.startVertexTb.Location = new System.Drawing.Point(528, 28);
            this.startVertexTb.MaxLength = 32767;
            this.startVertexTb.Name = "startVertexTb";
            this.startVertexTb.PasswordChar = '\0';
            this.startVertexTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.startVertexTb.SelectedText = "";
            this.startVertexTb.SelectionLength = 0;
            this.startVertexTb.SelectionStart = 0;
            this.startVertexTb.ShortcutsEnabled = true;
            this.startVertexTb.Size = new System.Drawing.Size(35, 23);
            this.startVertexTb.TabIndex = 18;
            this.startVertexTb.Text = "0";
            this.startVertexTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startVertexTb.UseSelectable = true;
            this.startVertexTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.startVertexTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // endVertexTb
            // 
            // 
            // 
            // 
            this.endVertexTb.CustomButton.Image = null;
            this.endVertexTb.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.endVertexTb.CustomButton.Name = "";
            this.endVertexTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.endVertexTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.endVertexTb.CustomButton.TabIndex = 1;
            this.endVertexTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.endVertexTb.CustomButton.UseSelectable = true;
            this.endVertexTb.CustomButton.Visible = false;
            this.endVertexTb.Lines = new string[] {
        "0"};
            this.endVertexTb.Location = new System.Drawing.Point(603, 28);
            this.endVertexTb.MaxLength = 32767;
            this.endVertexTb.Name = "endVertexTb";
            this.endVertexTb.PasswordChar = '\0';
            this.endVertexTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.endVertexTb.SelectedText = "";
            this.endVertexTb.SelectionLength = 0;
            this.endVertexTb.SelectionStart = 0;
            this.endVertexTb.ShortcutsEnabled = true;
            this.endVertexTb.Size = new System.Drawing.Size(35, 23);
            this.endVertexTb.TabIndex = 19;
            this.endVertexTb.Text = "0";
            this.endVertexTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endVertexTb.UseSelectable = true;
            this.endVertexTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.endVertexTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(569, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "→";
            // 
            // graphViewer
            // 
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(22, 272);
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.Size = new System.Drawing.Size(910, 318);
            this.graphViewer.TabIndex = 27;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomFraction = 0.5D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // graphrbMp
            // 
            this.graphrbMp.Controls.Add(this.graph_maxRb);
            this.graphrbMp.Controls.Add(this.graphRb);
            this.graphrbMp.Enabled = false;
            this.graphrbMp.HorizontalScrollbarBarColor = true;
            this.graphrbMp.HorizontalScrollbarHighlightOnWheel = false;
            this.graphrbMp.HorizontalScrollbarSize = 10;
            this.graphrbMp.Location = new System.Drawing.Point(23, 596);
            this.graphrbMp.Name = "graphrbMp";
            this.graphrbMp.Size = new System.Drawing.Size(909, 35);
            this.graphrbMp.TabIndex = 26;
            this.graphrbMp.VerticalScrollbarBarColor = true;
            this.graphrbMp.VerticalScrollbarHighlightOnWheel = false;
            this.graphrbMp.VerticalScrollbarSize = 10;
            // 
            // graph_maxRb
            // 
            this.graph_maxRb.AutoSize = true;
            this.graph_maxRb.Location = new System.Drawing.Point(81, 8);
            this.graph_maxRb.Name = "graph_maxRb";
            this.graph_maxRb.Size = new System.Drawing.Size(102, 15);
            this.graph_maxRb.TabIndex = 3;
            this.graph_maxRb.Text = "Max. flow path";
            this.graph_maxRb.UseSelectable = true;
            this.graph_maxRb.CheckedChanged += new System.EventHandler(this.graph_maxRb_CheckedChanged);
            // 
            // graphRb
            // 
            this.graphRb.AutoSize = true;
            this.graphRb.Checked = true;
            this.graphRb.Location = new System.Drawing.Point(12, 8);
            this.graphRb.Name = "graphRb";
            this.graphRb.Size = new System.Drawing.Size(55, 15);
            this.graphRb.TabIndex = 2;
            this.graphRb.TabStop = true;
            this.graphRb.Text = "Graph";
            this.graphRb.UseSelectable = true;
            this.graphRb.CheckedChanged += new System.EventHandler(this.graphRb_CheckedChanged);
            // 
            // fileLbl
            // 
            this.fileLbl.Location = new System.Drawing.Point(644, 247);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(289, 19);
            this.fileLbl.TabIndex = 25;
            this.fileLbl.Text = "No file opened";
            this.fileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxFlowBtn
            // 
            this.maxFlowBtn.Location = new System.Drawing.Point(388, 22);
            this.maxFlowBtn.Name = "maxFlowBtn";
            this.maxFlowBtn.Size = new System.Drawing.Size(122, 34);
            this.maxFlowBtn.TabIndex = 24;
            this.maxFlowBtn.Text = "Execute";
            this.maxFlowBtn.UseSelectable = true;
            this.maxFlowBtn.Click += new System.EventHandler(this.maxFlowBtn_Click);
            // 
            // fileTb
            // 
            this.fileTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTb.Location = new System.Drawing.Point(644, 77);
            this.fileTb.Name = "fileTb";
            this.fileTb.ReadOnly = true;
            this.fileTb.Size = new System.Drawing.Size(288, 189);
            this.fileTb.TabIndex = 23;
            this.fileTb.Text = "";
            // 
            // readfileBtn
            // 
            this.readfileBtn.Location = new System.Drawing.Point(222, 22);
            this.readfileBtn.Name = "readfileBtn";
            this.readfileBtn.Size = new System.Drawing.Size(160, 34);
            this.readfileBtn.TabIndex = 22;
            this.readfileBtn.Text = "Read data from a text file";
            this.readfileBtn.UseSelectable = true;
            this.readfileBtn.Click += new System.EventHandler(this.readfileBtn_Click);
            // 
            // resTb
            // 
            this.resTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resTb.Location = new System.Drawing.Point(23, 77);
            this.resTb.Name = "resTb";
            this.resTb.Size = new System.Drawing.Size(615, 189);
            this.resTb.TabIndex = 21;
            this.resTb.Text = "";
            // 
            // routeCb
            // 
            this.routeCb.FormattingEnabled = true;
            this.routeCb.ItemHeight = 23;
            this.routeCb.Location = new System.Drawing.Point(800, 319);
            this.routeCb.Name = "routeCb";
            this.routeCb.PromptText = "Max. flow path";
            this.routeCb.Size = new System.Drawing.Size(132, 29);
            this.routeCb.TabIndex = 28;
            this.routeCb.UseSelectable = true;
            this.routeCb.Visible = false;
            this.routeCb.SelectedIndexChanged += new System.EventHandler(this.routeCb_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 642);
            this.Controls.Add(this.routeCb);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.graphrbMp);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.maxFlowBtn);
            this.Controls.Add(this.fileTb);
            this.Controls.Add(this.readfileBtn);
            this.Controls.Add(this.resTb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.endVertexTb);
            this.Controls.Add(this.startVertexTb);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Max. flow problem";
            this.graphrbMp.ResumeLayout(false);
            this.graphrbMp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroTextBox startVertexTb;
        private MetroFramework.Controls.MetroTextBox endVertexTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer;
        private MetroFramework.Controls.MetroPanel graphrbMp;
        private MetroFramework.Controls.MetroRadioButton graph_maxRb;
        private MetroFramework.Controls.MetroRadioButton graphRb;
        private MetroFramework.Controls.MetroLabel fileLbl;
        private MetroFramework.Controls.MetroButton maxFlowBtn;
        public System.Windows.Forms.RichTextBox fileTb;
        private MetroFramework.Controls.MetroButton readfileBtn;
        public System.Windows.Forms.RichTextBox resTb;
        private MetroFramework.Controls.MetroComboBox routeCb;
    }
}

