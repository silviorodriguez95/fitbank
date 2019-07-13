namespace FitBank_TestePratico_SilvioRodriguez
{
    partial class frGerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGerenciador));
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.lbLogging = new System.Windows.Forms.ListBox();
            this.lbFooterDescription = new System.Windows.Forms.Label();
            this.lblFooterYear = new System.Windows.Forms.Label();
            this.lblFooterAuthor = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblSelectedItens = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnCleanOrder = new System.Windows.Forms.Button();
            this.lbOrderItens = new System.Windows.Forms.ListBox();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.gbQueue = new System.Windows.Forms.GroupBox();
            this.lbQueue = new System.Windows.Forms.ListBox();
            this.gbStartedOrders = new System.Windows.Forms.GroupBox();
            this.lbStartedOrders = new System.Windows.Forms.ListBox();
            this.gbFinishedOrders = new System.Windows.Forms.GroupBox();
            this.lbFinishedOrders = new System.Windows.Forms.ListBox();
            this.gbDeliveredOrders = new System.Windows.Forms.GroupBox();
            this.lbDeliveredOrders = new System.Windows.Forms.ListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbLog.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.gbQueue.SuspendLayout();
            this.gbStartedOrders.SuspendLayout();
            this.gbFinishedOrders.SuspendLayout();
            this.gbDeliveredOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.lbLogging);
            this.gbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbLog.Location = new System.Drawing.Point(12, 367);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(1018, 100);
            this.gbLog.TabIndex = 0;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            this.gbLog.MouseHover += new System.EventHandler(this.gbLog_MouseHover);
            // 
            // lbLogging
            // 
            this.lbLogging.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogging.FormattingEnabled = true;
            this.lbLogging.ItemHeight = 16;
            this.lbLogging.Location = new System.Drawing.Point(14, 25);
            this.lbLogging.Name = "lbLogging";
            this.lbLogging.Size = new System.Drawing.Size(986, 64);
            this.lbLogging.TabIndex = 0;
            // 
            // lbFooterDescription
            // 
            this.lbFooterDescription.AutoSize = true;
            this.lbFooterDescription.Location = new System.Drawing.Point(12, 475);
            this.lbFooterDescription.Name = "lbFooterDescription";
            this.lbFooterDescription.Size = new System.Drawing.Size(270, 13);
            this.lbFooterDescription.TabIndex = 1;
            this.lbFooterDescription.Text = "Exame Recrutamento Fitbank - Gerenciador de Pedidos";
            // 
            // lblFooterYear
            // 
            this.lblFooterYear.AutoSize = true;
            this.lblFooterYear.Location = new System.Drawing.Point(512, 475);
            this.lblFooterYear.Name = "lblFooterYear";
            this.lblFooterYear.Size = new System.Drawing.Size(31, 13);
            this.lblFooterYear.TabIndex = 2;
            this.lblFooterYear.Text = "2019";
            // 
            // lblFooterAuthor
            // 
            this.lblFooterAuthor.AutoSize = true;
            this.lblFooterAuthor.Location = new System.Drawing.Point(814, 475);
            this.lblFooterAuthor.Name = "lblFooterAuthor";
            this.lblFooterAuthor.Size = new System.Drawing.Size(216, 13);
            this.lblFooterAuthor.TabIndex = 3;
            this.lblFooterAuthor.Text = "Desenvolvidor por Silvio Rodriguez Monteiro";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.lblCustomerName);
            this.gbPedido.Controls.Add(this.txtCustomerName);
            this.gbPedido.Controls.Add(this.lblSelectedItens);
            this.gbPedido.Controls.Add(this.lblMenu);
            this.gbPedido.Controls.Add(this.btnConfirmOrder);
            this.gbPedido.Controls.Add(this.btnCleanOrder);
            this.gbPedido.Controls.Add(this.lbOrderItens);
            this.gbPedido.Controls.Add(this.lbMenu);
            this.gbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbPedido.Location = new System.Drawing.Point(12, 12);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(907, 209);
            this.gbPedido.TabIndex = 1;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Monte o Pedido";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(576, 57);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(141, 20);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Nome do Cliente";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(580, 89);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(283, 26);
            this.txtCustomerName.TabIndex = 7;
            // 
            // lblSelectedItens
            // 
            this.lblSelectedItens.AutoSize = true;
            this.lblSelectedItens.Location = new System.Drawing.Point(285, 34);
            this.lblSelectedItens.Name = "lblSelectedItens";
            this.lblSelectedItens.Size = new System.Drawing.Size(135, 20);
            this.lblSelectedItens.TabIndex = 6;
            this.lblSelectedItens.Text = "Itens do Pedido";
            this.lblSelectedItens.MouseHover += new System.EventHandler(this.lblSelectedItens_MouseHover);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(10, 34);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(53, 20);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            this.lblMenu.MouseHover += new System.EventHandler(this.lblMenu_MouseHover);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirmOrder.Location = new System.Drawing.Point(737, 132);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(126, 44);
            this.btnConfirmOrder.TabIndex = 4;
            this.btnConfirmOrder.Text = "Criar Pedido";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnCleanOrder
            // 
            this.btnCleanOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCleanOrder.Location = new System.Drawing.Point(580, 132);
            this.btnCleanOrder.Name = "btnCleanOrder";
            this.btnCleanOrder.Size = new System.Drawing.Size(126, 44);
            this.btnCleanOrder.TabIndex = 3;
            this.btnCleanOrder.Text = "Limpar Itens";
            this.btnCleanOrder.UseVisualStyleBackColor = false;
            this.btnCleanOrder.Click += new System.EventHandler(this.btnCleanOrder_Click);
            // 
            // lbOrderItens
            // 
            this.lbOrderItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrderItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderItens.FormattingEnabled = true;
            this.lbOrderItens.ItemHeight = 16;
            this.lbOrderItens.Location = new System.Drawing.Point(289, 57);
            this.lbOrderItens.Name = "lbOrderItens";
            this.lbOrderItens.Size = new System.Drawing.Size(242, 130);
            this.lbOrderItens.TabIndex = 2;
            this.lbOrderItens.DoubleClick += new System.EventHandler(this.lbOrderItens_DoubleClick);
            // 
            // lbMenu
            // 
            this.lbMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Location = new System.Drawing.Point(14, 57);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(256, 130);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.DoubleClick += new System.EventHandler(this.lbMenu_DoubleClick);
            // 
            // gbQueue
            // 
            this.gbQueue.Controls.Add(this.lbQueue);
            this.gbQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQueue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbQueue.Location = new System.Drawing.Point(12, 227);
            this.gbQueue.Name = "gbQueue";
            this.gbQueue.Size = new System.Drawing.Size(248, 134);
            this.gbQueue.TabIndex = 2;
            this.gbQueue.TabStop = false;
            this.gbQueue.Text = "Fila";
            this.gbQueue.MouseHover += new System.EventHandler(this.gbQueue_MouseHover);
            // 
            // lbQueue
            // 
            this.lbQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueue.FormattingEnabled = true;
            this.lbQueue.ItemHeight = 16;
            this.lbQueue.Location = new System.Drawing.Point(9, 29);
            this.lbQueue.Name = "lbQueue";
            this.lbQueue.Size = new System.Drawing.Size(233, 96);
            this.lbQueue.TabIndex = 9;
            // 
            // gbStartedOrders
            // 
            this.gbStartedOrders.Controls.Add(this.lbStartedOrders);
            this.gbStartedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStartedOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbStartedOrders.Location = new System.Drawing.Point(266, 227);
            this.gbStartedOrders.Name = "gbStartedOrders";
            this.gbStartedOrders.Size = new System.Drawing.Size(248, 134);
            this.gbStartedOrders.TabIndex = 3;
            this.gbStartedOrders.TabStop = false;
            this.gbStartedOrders.Text = "Iniciado";
            this.gbStartedOrders.MouseHover += new System.EventHandler(this.gbStartedOrders_MouseHover);
            // 
            // lbStartedOrders
            // 
            this.lbStartedOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbStartedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartedOrders.FormattingEnabled = true;
            this.lbStartedOrders.ItemHeight = 16;
            this.lbStartedOrders.Location = new System.Drawing.Point(10, 28);
            this.lbStartedOrders.Name = "lbStartedOrders";
            this.lbStartedOrders.Size = new System.Drawing.Size(232, 96);
            this.lbStartedOrders.TabIndex = 10;
            // 
            // gbFinishedOrders
            // 
            this.gbFinishedOrders.Controls.Add(this.lbFinishedOrders);
            this.gbFinishedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFinishedOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbFinishedOrders.Location = new System.Drawing.Point(520, 227);
            this.gbFinishedOrders.Name = "gbFinishedOrders";
            this.gbFinishedOrders.Size = new System.Drawing.Size(248, 134);
            this.gbFinishedOrders.TabIndex = 4;
            this.gbFinishedOrders.TabStop = false;
            this.gbFinishedOrders.Text = "Finalizados";
            this.gbFinishedOrders.MouseHover += new System.EventHandler(this.gbFinishedOrders_MouseHover);
            // 
            // lbFinishedOrders
            // 
            this.lbFinishedOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFinishedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinishedOrders.FormattingEnabled = true;
            this.lbFinishedOrders.ItemHeight = 16;
            this.lbFinishedOrders.Location = new System.Drawing.Point(9, 25);
            this.lbFinishedOrders.Name = "lbFinishedOrders";
            this.lbFinishedOrders.Size = new System.Drawing.Size(233, 96);
            this.lbFinishedOrders.TabIndex = 11;
            // 
            // gbDeliveredOrders
            // 
            this.gbDeliveredOrders.Controls.Add(this.lbDeliveredOrders);
            this.gbDeliveredOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeliveredOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDeliveredOrders.Location = new System.Drawing.Point(774, 227);
            this.gbDeliveredOrders.Name = "gbDeliveredOrders";
            this.gbDeliveredOrders.Size = new System.Drawing.Size(256, 134);
            this.gbDeliveredOrders.TabIndex = 5;
            this.gbDeliveredOrders.TabStop = false;
            this.gbDeliveredOrders.Text = "Entregues";
            this.gbDeliveredOrders.MouseHover += new System.EventHandler(this.gbDeliveredOrders_MouseHover);
            // 
            // lbDeliveredOrders
            // 
            this.lbDeliveredOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDeliveredOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeliveredOrders.FormattingEnabled = true;
            this.lbDeliveredOrders.ItemHeight = 16;
            this.lbDeliveredOrders.Location = new System.Drawing.Point(9, 25);
            this.lbDeliveredOrders.Name = "lbDeliveredOrders";
            this.lbDeliveredOrders.Size = new System.Drawing.Size(241, 96);
            this.lbDeliveredOrders.TabIndex = 12;
            this.lbDeliveredOrders.DoubleClick += new System.EventHandler(this.lbDeliveredOrders_DoubleClick);
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::FitBank_TestePratico_SilvioRodriguez.Properties.Resources.FitBank_logo;
            this.pbLogo.Location = new System.Drawing.Point(925, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(105, 92);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(940, 137);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(74, 70);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 6;
            this.pbStatus.TabStop = false;
            // 
            // frGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 497);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.gbDeliveredOrders);
            this.Controls.Add(this.gbFinishedOrders);
            this.Controls.Add(this.gbStartedOrders);
            this.Controls.Add(this.gbQueue);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblFooterAuthor);
            this.Controls.Add(this.lblFooterYear);
            this.Controls.Add(this.lbFooterDescription);
            this.Controls.Add(this.gbLog);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitBank - Gerenciador de Pedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLog.ResumeLayout(false);
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.gbQueue.ResumeLayout(false);
            this.gbStartedOrders.ResumeLayout(false);
            this.gbFinishedOrders.ResumeLayout(false);
            this.gbDeliveredOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.Label lbFooterDescription;
        private System.Windows.Forms.Label lblFooterYear;
        private System.Windows.Forms.Label lblFooterAuthor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ListBox lbLogging;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.GroupBox gbQueue;
        private System.Windows.Forms.GroupBox gbStartedOrders;
        private System.Windows.Forms.GroupBox gbFinishedOrders;
        private System.Windows.Forms.GroupBox gbDeliveredOrders;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnCleanOrder;
        private System.Windows.Forms.ListBox lbOrderItens;
        private System.Windows.Forms.Label lblSelectedItens;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ListBox lbQueue;
        private System.Windows.Forms.ListBox lbStartedOrders;
        private System.Windows.Forms.ListBox lbFinishedOrders;
        private System.Windows.Forms.ListBox lbDeliveredOrders;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

