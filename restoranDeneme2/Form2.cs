using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace restoranDeneme2
{
    public partial class Form2 : System.Windows.Forms.Form
    {
     
        public Form2()
        {
            InitializeComponent();
 
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //newButton.Text = "Created Button";
            //newButton.Location = new Point(70, 70);
            //newButton.Size = new Size(50, 100);

            for (int i = 1; i <= Form1.Form1Instance.numberOfTables; i++)
            {

                Button newBtn = new Button();

                TableObject.TableID = 1000 + i;
                newBtn.Text = "Table" + " " + i.ToString();
                newBtn.Name = i.ToString();
                newBtn.Size = new Size(100, 50);
                newBtn.Click += new EventHandler(this.table_clicked);
                
                flowLayoutPanel1.Controls.Add(newBtn);
            }
            
        }

        //SELECT KULLANILMASI GEREKLIYMIS CLICK DEGIL SELECTLE ILGILI ARASTIRMA YAPILACAK.

        //create user defined function
        void table_clicked(object sender, EventArgs e)
        {   Masa TableClickedObject = new Masa();
            //Get the button clicked
            Button btn = sender as Button;
            TableClickedObject.TableID = Convert.ToInt32(btn.Name);

            MessageBox.Show("Table" + " " + TableClickedObject.TableID + "Selected");
        }
    }
}
