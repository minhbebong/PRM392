using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFirstApp
{
    public partial class frmMain : Form
    {
        //khai bao cac object control
        Label lbTitle; 
        Button btSubmit;
        TextBox tbContent;
        ComboBox cbUnit;

        public frmMain()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            //tao doi tuong control
            lbTitle = new Label();
            btSubmit = new Button();
            tbContent = new TextBox();
            cbUnit = new ComboBox();

            //thay doi thuoc tinh cua control
            lbTitle.Text = "The first desktop app";
            lbTitle.Size = new Size(500, 50);
            lbTitle.ForeColor = Color.BlueViolet;
            lbTitle.BackColor = Color.Aqua;
            lbTitle.Font = new Font("Arial", 20);

            btSubmit.Text = "Submit";
            btSubmit.Size = new Size(100, 30);
            btSubmit.Location = new Point(lbTitle.Location.X + lbTitle.Size.Width - btSubmit.Size.Width, 
                lbTitle.Location.Y + lbTitle.Size.Height + 10);

            cbUnit.Items.Add("Hour");
            cbUnit.Items.Add("Minute");
            cbUnit.Items.Add("Second");
            cbUnit.Location = new Point(0, 300);
            cbUnit.SelectedIndex = 0;

            //add control len form
            this.Controls.Add(lbTitle);
            this.Controls.Add(btSubmit);
            this.Controls.Add(cbUnit);
        }

    }
}
