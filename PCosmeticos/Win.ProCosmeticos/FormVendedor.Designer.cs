namespace Win.ProCosmeticos
{
    partial class FormVendedor
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
            this.listaVendedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaVendedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaVendedorBindingNavigator)).BeginInit();
            this.listaVendedorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(58, 178);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(62, 16);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            areaLabel.Location = new System.Drawing.Point(58, 115);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(48, 16);
            areaLabel.TabIndex = 3;
            areaLabel.Text = "Area:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargoLabel.Location = new System.Drawing.Point(58, 141);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(57, 16);
            cargoLabel.TabIndex = 5;
            cargoLabel.Text = "Cargo:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(58, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(28, 16);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(58, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(71, 16);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // listaVendedorBindingNavigator
            // 
            this.listaVendedorBindingNavigator.AddNewItem = null;
            this.listaVendedorBindingNavigator.BindingSource = this.listaVendedorBindingSource;
            this.listaVendedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaVendedorBindingNavigator.DeleteItem = null;
            this.listaVendedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaVendedorBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaVendedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaVendedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaVendedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaVendedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaVendedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaVendedorBindingNavigator.Name = "listaVendedorBindingNavigator";
            this.listaVendedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaVendedorBindingNavigator.Size = new System.Drawing.Size(501, 25);
            this.listaVendedorBindingNavigator.TabIndex = 0;
            this.listaVendedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaVendedorBindingSource
            // 
            this.listaVendedorBindingSource.DataSource = typeof(BL.Cosmeticos.Vendedor);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaVendedorBindingNavigatorSaveItem
            // 
            this.listaVendedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaVendedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaVendedorBindingNavigatorSaveItem.Image")));
            this.listaVendedorBindingNavigatorSaveItem.Name = "listaVendedorBindingNavigatorSaveItem";
            this.listaVendedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaVendedorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaVendedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaVendedorBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaVendedorBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(140, 172);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVendedorBindingSource, "Area", true));
            this.areaTextBox.Location = new System.Drawing.Point(140, 111);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(261, 20);
            this.areaTextBox.TabIndex = 4;
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVendedorBindingSource, "Cargo", true));
            this.cargoTextBox.Location = new System.Drawing.Point(140, 137);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(261, 20);
            this.cargoTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVendedorBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(140, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(261, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVendedorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(140, 85);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(261, 20);
            this.nombreTextBox.TabIndex = 12;
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win.ProCosmeticos.Properties.Resources.fr;
            this.ClientSize = new System.Drawing.Size(501, 299);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaVendedorBindingNavigator);
            this.Name = "FormVendedor";
            this.Text = "Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.listaVendedorBindingNavigator)).EndInit();
            this.listaVendedorBindingNavigator.ResumeLayout(false);
            this.listaVendedorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVendedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaVendedorBindingSource;
        private System.Windows.Forms.BindingNavigator listaVendedorBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton listaVendedorBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}