using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        // MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e) //RESEST button
        {
            txtPepsi.Text = "0";
            txtOrangeJuice.Text = "0";
            txtRedBull.Text = "0";
            txtSparklingWater.Text = "0";
            txtPineappleJuice.Text = "0";
            txtGrapeJuice.Text = "0";
            txtLemonJuice.Text = "0";
            txtShanena.Text = "0";

            txtMansaf.Text = "0";
            txtMandi.Text = "0";
            txtMlokhyeh.Text = "0";
            txtKabseh.Text = "0";
            txtBeryani.Text = "0";
            txtMadbi.Text = "0";
            txtMaqloubeh.Text = "0";
            txtKofta.Text = "0";

            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "0";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkPepsi.Checked = false;
            chkOrangeJuice.Checked = false;
            chkRedbull.Checked = false;
            chkSparklingWater.Checked = false;
            chkPineappleJuice.Checked = false;
            chkGrapeJuice.Checked = false;
            chkLemonJuice.Checked = false;
            chkShanena.Checked = false;

            chkMandi.Checked = false;
            chkMansaf.Checked = false;
            chkMlokhyeh.Checked = false;
            chkKabseh.Checked = false;
            chkBeryani.Checked = false;
            chkMadbi.Checked = false;
            chkMaqloubeh.Checked = false;
            chkKofta.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e) //Receipt Button
        {

            rtfReceipt.Clear();

            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "   DUW Restaurant " + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("ITEM" + "\t  \t \t \t" + "QTY" + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);

            //Drinks:
            if (chkPepsi.Checked == true)
            {
                rtfReceipt.AppendText("Pepsi \t\t\t\t" + txtPepsi.Text + Environment.NewLine);
            }
            else
            { }

            if (chkOrangeJuice.Checked == true)
            {
                rtfReceipt.AppendText("OrangeJuice \t\t\t" + txtOrangeJuice.Text + Environment.NewLine);
            }
            else
            { }

            if (chkRedbull.Checked == true)
            {
                rtfReceipt.AppendText("RedBull \t\t\t\t" + txtRedBull.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkSparklingWater.Checked == true)
            {
                rtfReceipt.AppendText("SparklingWater \t\t" + txtSparklingWater.Text + Environment.NewLine);
            }
            else
            { }

            if (chkPineappleJuice.Checked == true)
            {
                rtfReceipt.AppendText("PinnappleJuice \t\t" + txtPineappleJuice.Text + Environment.NewLine);
            }
            else
            { }

            if (chkGrapeJuice.Checked == true)
            {
                rtfReceipt.AppendText("GrapeJuice \t\t\t" + txtGrapeJuice.Text + Environment.NewLine);
            }
            else
            { }

            if (chkLemonJuice.Checked == true)
            {
                rtfReceipt.AppendText("LemonJuice \t\t\t" + txtLemonJuice.Text + Environment.NewLine);
            }
            else
            { }

            if (chkShanena.Checked == true)
            {
                rtfReceipt.AppendText("Shanena \t\t\t" + txtShanena.Text + Environment.NewLine);
            }
            else
            { }
            //Food:
            if (chkMansaf.Checked == true)
            {
                rtfReceipt.AppendText(" Mansaf \t\t\t\t" + txtMansaf.Text + Environment.NewLine);
            }
            else
            { }

            if (chkMandi.Checked == true)
            {
                rtfReceipt.AppendText("Mandi \t\t\t" + txtMandi.Text + Environment.NewLine);
            }
            else
            { }

            if (chkMlokhyeh.Checked == true)
            {
                rtfReceipt.AppendText("Mlokhyeh \t\t" + txtMlokhyeh.Text + Environment.NewLine);
            }
            else
            { }

            if (chkKabseh.Checked == true)
            {
                rtfReceipt.AppendText("Kabseh \t\t" + txtKabseh.Text + Environment.NewLine);
            }
            else
            { }

            if (chkBeryani.Checked == true)
            {
                rtfReceipt.AppendText("Beryani \t\t" + txtBeryani.Text + Environment.NewLine);
            }
            else
            { }

            if (chkMadbi.Checked == true)
            {
                rtfReceipt.AppendText("Madbi \t\t" + txtMadbi.Text + Environment.NewLine);
            }
            else
            { }

            if (chkMaqloubeh.Checked == true)
            {
                rtfReceipt.AppendText("Maqloubeh \t\t\t" + txtMaqloubeh.Text + Environment.NewLine);
            }
            else
            { }

            if (chkKofta.Checked == true)
            {
                rtfReceipt.AppendText("Kofta \t\t\t" + txtKofta.Text + Environment.NewLine);
            }
            else
            { }


            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("  Service Charge    \t" + lblSvcCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("  Tax \t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("  Sub Total \t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("  Total Cost \t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t\t" + lblDate.Text);

        }

        private void button1_Click(object sender, EventArgs e) //TOTAL button
        {
            double pepsiPRICE, RedBullPRICE, OrangeJuicePRICE, SparklingWaterPRICE, PineappleJuicePRICE, GrapeJuicePRICE, LemonJuicePRICE, ShanenaPRICE;

            double MansafPRICE, MandiPRICE, MlokhyehPRICE, KabsehPRICE, BeryaniPRICE, MadbiPRICE, MaqloubehPRICE, KoftaPRICE;

            double tax = 5;
            double sCh = 3.34;

            pepsiPRICE = 2.50; OrangeJuicePRICE = 2.70; RedBullPRICE = 1.80; SparklingWaterPRICE = 1.50; PineappleJuicePRICE = 3.50; GrapeJuicePRICE = 4.00; LemonJuicePRICE = 3.30; ShanenaPRICE = 1.50; //Drinks pries
            MansafPRICE = 35.00; MandiPRICE = 28.00; MlokhyehPRICE = 30.00; KabsehPRICE = 38.00; BeryaniPRICE = 22.00; MadbiPRICE = 40.00; MaqloubehPRICE = 20.00; KoftaPRICE = 42.00; //food prices
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            //Drinks
            double Pepsi = Convert.ToDouble(txtPepsi.Text);
            double RedBull = Convert.ToDouble(txtRedBull.Text);
            double OrangeJuice = Convert.ToDouble(txtOrangeJuice.Text);
            double SparklingWater = Convert.ToDouble(txtSparklingWater.Text);
            double PineappleJuice = Convert.ToDouble(txtPineappleJuice.Text);
            double GrapeJuice = Convert.ToDouble(txtGrapeJuice.Text);
            double LemonJuice = Convert.ToDouble(txtLemonJuice.Text);
            double Shanena = Convert.ToDouble(txtShanena.Text);
            //Cakes
            double Mansaf = Convert.ToDouble(txtMansaf.Text);
            double Mandi = Convert.ToDouble(txtMandi.Text);
            double Mlokhyeh = Convert.ToDouble(txtMlokhyeh.Text);
            double Kabseh = Convert.ToDouble(txtKabseh.Text);
            double Beryani = Convert.ToDouble(txtBeryani.Text);
            double Madbi = Convert.ToDouble(txtMadbi.Text);
            double Maqloubeh = Convert.ToDouble(txtMaqloubeh.Text);
            double Kofta = Convert.ToDouble(txtKofta.Text);

            Cafe eat_in_cafe = new Cafe(Pepsi, OrangeJuice, RedBull, SparklingWater, PineappleJuice, GrapeJuice, LemonJuice, Shanena,
                Mansaf, Mandi, MlokhyehPRICE, Kabseh, Beryani, Madbi, Maqloubeh, Kofta);

            double drinkCosts = (Pepsi * pepsiPRICE) + (OrangeJuice * OrangeJuicePRICE) + (RedBull * RedBullPRICE) + (SparklingWater * SparklingWaterPRICE)
           + (PineappleJuice * PineappleJuicePRICE) + (GrapeJuice * GrapeJuicePRICE) + (LemonJuice * LemonJuicePRICE) + (Shanena * ShanenaPRICE);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);

            double FoodCosts = (Mansaf * MansafPRICE) + (Mandi * MandiPRICE) + (Mlokhyeh * MlokhyehPRICE) + (Kabseh * KabsehPRICE)
                + (Beryani * BeryaniPRICE) + (Madbi * MadbiPRICE) + (Maqloubeh * MaqloubehPRICE) + (Kofta * KoftaPRICE);
            lblCakeCost.Text = Convert.ToString(FoodCosts);

            double svcCharge = Convert.ToDouble(sCh);
            //Subtotal
            lblSubTotal.Text = Convert.ToString(FoodCosts + drinkCosts + svcCharge);
            //Tax
            lblTax.Text = Convert.ToString(((FoodCosts + drinkCosts + svcCharge) * tax) / 100);
            //Total after tax
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(FoodCosts + drinkCosts + svcCharge + totalAftTax);
            //DrinkCost , FoodCost
            lblDrinkCost.Text = String.Format(culture, "{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format(culture, "{0:C}", FoodCosts);
            //lblSvcCharge.Text = svcCharge.ToString();
            lblSvcCharge.Text = String.Format(culture, "{0:C}", svcCharge);
            lblSubTotal.Text = String.Format(culture, "{0:C}", (FoodCosts + drinkCosts + svcCharge));
            lblTax.Text = String.Format(culture, "{0:C}", totalAftTax);
            lblTotal.Text = String.Format(culture, "{0:C}", (FoodCosts + drinkCosts + svcCharge + totalAftTax));

            
            //put your own DATA inside it 
            /*
             
            connection = new MySqlConnection("Data source = ; Database =  ;" + "UserID = ; " + "Password =  ; SSL Mode = ");

            connection.Open();
            String Query = "INSERT Into Customer(TOTAL) VALUES(" + lblTotal.Text + "','" + "');";
            MySqlCommand mycommand = new MySqlCommand(Query, connection);


            */



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            double latteeCof = Convert.ToDouble(txtPepsi.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();


            txtPepsi.Text = "0";
            txtOrangeJuice.Text = "0";
            txtRedBull.Text = "0";
            txtSparklingWater.Text = "0";
            txtPineappleJuice.Text = "0";
            txtGrapeJuice.Text = "0";
            txtLemonJuice.Text = "0";
            txtShanena.Text = "0";
            txtMansaf.Text = "0";
            txtMandi.Text = "0";
            txtMlokhyeh.Text = "0";
            txtKabseh.Text = "0";
            txtBeryani.Text = "0";
            txtMadbi.Text = "0";
            txtMaqloubeh.Text = "0";
            txtKofta.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "0";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtPepsi.Enabled = false;
            txtOrangeJuice.Enabled = false; ;
            txtRedBull.Enabled = false;
            txtSparklingWater.Enabled = false;
            txtPineappleJuice.Enabled = false;
            txtGrapeJuice.Enabled = false;
            txtLemonJuice.Enabled = false;
            txtShanena.Enabled = false;
            txtMansaf.Enabled = false;
            txtMandi.Enabled = false;
            txtMlokhyeh.Enabled = false;
            txtKabseh.Enabled = false;
            txtBeryani.Enabled = false;
            txtMadbi.Enabled = false;
            txtMaqloubeh.Enabled = false;
            txtKofta.Enabled = false;

            chkPepsi.Checked = false;
            chkOrangeJuice.Checked = false;
            chkRedbull.Checked = false;
            chkSparklingWater.Checked = false;
            chkPineappleJuice.Checked = false;
            chkGrapeJuice.Checked = false;
            chkLemonJuice.Checked = false;
            chkShanena.Checked = false;
            chkMandi.Checked = false;
            chkMansaf.Checked = false;
            chkMlokhyeh.Checked = false;
            chkKabseh.Checked = false;
            chkBeryani.Checked = false;
            chkMadbi.Checked = false;
            chkMaqloubeh.Checked = false;
            chkKofta.Checked = false;

            rtfReceipt.Clear();

        }

        private void Pepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepsi.Checked == true)
            {
                txtPepsi.Enabled = true;
                txtPepsi.Text = "1";
            }
            else
            {
                txtPepsi.Enabled = false;
                txtPepsi.Text = "0";
            }
        }

        private void txtPepsi_Click(object sender, EventArgs e)
        {
            txtPepsi.Text = "";
            txtPepsi.Focus();
        }

        private void chkOrangeJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrangeJuice.Checked == true)
            {
                txtOrangeJuice.Enabled = true;
                txtOrangeJuice.Text = "1";
            }
            else
            {
                txtOrangeJuice.Enabled = false;
                txtOrangeJuice.Text = "0";
            }
        }

        private void txtOrangeJuice_Click(object sender, EventArgs e)
        {
            txtOrangeJuice.Text = "";
            txtOrangeJuice.Focus();
        }

        private void chkRedBull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedbull.Checked == true)
            {
                txtRedBull.Enabled = true;
                txtRedBull.Text = "1";
            }
            else
            {
                txtRedBull.Enabled = false;
                txtRedBull.Text = "0";
            }
        }

        private void txtRedBull_Click(object sender, EventArgs e)
        {
            txtRedBull.Text = "";
            txtRedBull.Focus();
        }

        private void chkSparklingWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSparklingWater.Checked == true)
            {
                txtSparklingWater.Enabled = true;
                txtSparklingWater.Text = "1";
            }
            else
            {
                txtSparklingWater.Enabled = false;
                txtSparklingWater.Text = "0";
            }
        }

        private void txtSparklingWater_Click(object sender, EventArgs e)
        {
            txtSparklingWater.Text = "";
            txtSparklingWater.Focus();
        }

        private void chkPineappleJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPineappleJuice.Checked == true)
            {
                txtPineappleJuice.Enabled = true;
                txtPineappleJuice.Text = "1";
            }
            else
            {
                txtPineappleJuice.Enabled = false;
                txtPineappleJuice.Text = "0";
            }
        }

        private void txtPineappleJuice_Click(object sender, EventArgs e)
        {
            txtPineappleJuice.Text = "";
            txtPineappleJuice.Focus();
        }

        private void chkGrapeJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrapeJuice.Checked == true)
            {
                txtGrapeJuice.Enabled = true;
                txtGrapeJuice.Text = "1";
            }
            else
            {
                txtGrapeJuice.Enabled = false;
                txtGrapeJuice.Text = "0";
            }
        }

        private void txtGrapeJuice_Click(object sender, EventArgs e)
        {
            txtGrapeJuice.Text = "";
            txtGrapeJuice.Focus();
        }

        private void chkLemonJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLemonJuice.Checked == true)
            {
                txtLemonJuice.Enabled = true;
                txtLemonJuice.Text = "1";
            }
            else
            {
                txtLemonJuice.Enabled = false;
                txtLemonJuice.Text = "0";
            }
        }

        private void txtLemonJuice_Click(object sender, EventArgs e)
        {
            txtLemonJuice.Text = "";
            txtLemonJuice.Focus();
        }

        private void chkShanena_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShanena.Checked == true)
            {
                txtShanena.Enabled = true;
                txtShanena.Text = "1";
            }
            else
            {
                txtShanena.Enabled = false;
                txtShanena.Text = "0";
            }
        }

        private void txtShanena_Click(object sender, EventArgs e)
        {
            txtShanena.Text = "";
            txtShanena.Focus();
        }

        private void chkMansaf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMansaf.Checked == true)
            {
                txtMansaf.Enabled = true;
                txtMansaf.Text = "1";
            }
            else
            {
                txtMansaf.Enabled = false;
                txtMansaf.Text = "0";
            }
        }

        private void txtMansaf_Click(object sender, EventArgs e)
        {
            txtMansaf.Text = "";
            txtMansaf.Focus();
        }

        private void chkMandi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMandi.Checked == true)
            {
                txtMandi.Enabled = true;
                txtMandi.Text = "1";
            }
            else
            {
                txtMandi.Enabled = false;
                txtMandi.Text = "0";
            }
        }

        private void txtMandi_Click(object sender, EventArgs e)
        {
            txtMandi.Text = "";
            txtMandi.Focus();
        }


        private void chkMlokhyeh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMlokhyeh.Checked == true)
            {
                txtMlokhyeh.Enabled = true;
                txtMlokhyeh.Text = "1";
            }
            else
            {
                txtMlokhyeh.Enabled = false;
                txtMlokhyeh.Text = "0";
            }
        }

        private void txtMlokhyeh_Click(object sender, EventArgs e)
        {
            txtMlokhyeh.Text = "";
            txtMlokhyeh.Focus();
        }

        private void chkKabseh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKabseh.Checked == true)
            {
                txtKabseh.Enabled = true;
                txtKabseh.Text = "1";
            }
            else
            {
                txtKabseh.Enabled = false;
                txtKabseh.Text = "0";
            }
        }

        private void txtKabseh_Click(object sender, EventArgs e)
        {
            txtKabseh.Text = "";
            txtKabseh.Focus();
        }

        private void txtBeryani_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeryani.Checked == true)
            {
                txtBeryani.Enabled = true;
                txtBeryani.Text = "1";
            }
            else
            {
                txtBeryani.Enabled = false;
                txtBeryani.Text = "0";
            }
        }

        private void txtBeryani_Click(object sender, EventArgs e)
        {
            txtBeryani.Text = "";
            txtBeryani.Focus();
        }

        private void chkMadbi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMadbi.Checked == true)
            {
                txtMadbi.Enabled = true;
                txtMadbi.Text = "1";
            }
            else
            {
                txtMadbi.Enabled = false;
                txtMadbi.Text = "0";
            }
        }


        private void txtMadbi_Click(object sender, EventArgs e)
        {
            txtMadbi.Text = "";
            txtMadbi.Focus();
        }

        private void chkMaqloubeh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaqloubeh.Checked == true)
            {
                txtMaqloubeh.Enabled = true;
                txtMaqloubeh.Text = "1";
            }
            else
            {
                txtMaqloubeh.Enabled = false;
                txtMaqloubeh.Text = "0";
            }
        }


        private void txtMaqloubeh_Click(object sender, EventArgs e)
        {
            txtMaqloubeh.Text = "";
            txtMaqloubeh.Focus();
        }

        private void chkKofta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKofta.Checked == true)
            {
                txtKofta.Enabled = true;
                txtKofta.Text = "1";
            }
            else
            {
                txtKofta.Enabled = false;
                txtKofta.Text = "0";
            }
        }

        private void txtKofta_Click(object sender, EventArgs e)
        {
            txtKofta.Text = "";
            txtKofta.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void openToolStripButton_Click(object sender, EventArgs e) //OPEN
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) //SAVE
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
