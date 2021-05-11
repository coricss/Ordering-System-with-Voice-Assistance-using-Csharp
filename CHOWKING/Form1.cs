using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using WMPLib;

namespace CHOWKING
{
    public partial class Form1 : Form
    {
        
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "chowking-chinese-style-fried-chicken-zelda-tvc-2019.mp3";
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timee.Text = DateTime.Now.ToLongTimeString();
            datee.Text = DateTime.Now.ToShortDateString();
            
            
            player.controls.play();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timee.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        public void clr()
        {
            txtPay.Text = "0.00";
            txtQuan.Text = "0";
            txtSubTotal.Text = "0.00";
            txtVat.Text = "0.00";
            txtTotAm.Text = "0.00";
            txtChange.Text = "0.00";
            rdPWD.Checked = false;
            rdSC.Checked = false;
            rdNone.Checked = false;
            if (rdPWD.Enabled == false || rdSC.Enabled == false || rdNone.Enabled == false)
            {
                rdPWD.Enabled = true;
                rdNone.Enabled = true;
                rdSC.Enabled = true;
            }
           
        }
        public void tot()
        {

            dataGridView1.AllowUserToAddRows = false;
            decimal sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }

            txtSubTotal.Text = sum.ToString();

            double vat = Convert.ToDouble(txtVat.Text);
            double sub = Convert.ToDouble(txtSubTotal.Text);
            double twv = sub / 1.12;
            double vatAm = sub - twv;
            
            
            if (rdSC.Checked == true)
            {
              
           
                double dis= (twv * 0.20);
                double d = twv - dis;
                txtTotAm.Text = d.ToString("0.00");

            }
            else if (rdPWD.Checked == true)
            {


                double dis = (twv * 0.20);
                double d = twv - dis;
                txtTotAm.Text =d.ToString("0.00");
            }
            else
            {
                
                txtTotAm.Text = twv.ToString("0.00");
            }
            txtVat.Text = vatAm.ToString("0.00");

        }
   
        private void btnTotal_Click(object sender, EventArgs e)
        {

            double cash = Convert.ToDouble(txtPay.Text);
            double total = Convert.ToDouble(txtTotAm.Text);
            double vat = Convert.ToDouble(txtVat.Text);
            double sub = Convert.ToDouble(txtSubTotal.Text);
            double twv = sub / 1.12;

            if (dataGridView1.Rows.Count == 0)
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please select order");
                MessageBox.Show("Please select order", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cash==0.00)
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please enter cash");
                MessageBox.Show("Please enter cash", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (cash<total)
            {
                double kulang = total - cash;
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please pay ₱" + kulang.ToString(".00"));
                MessageBox.Show("Please pay ₱" + kulang.ToString(".00"), "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double change = cash-total ;
                if (txtSubTotal.Text == "0.00" && txtTotAm.Text == "0.00" && txtVat.Text == "0.00")
                {
                    reader.Dispose();
                    reader = new SpeechSynthesizer();
                    reader.SelectVoiceByHints(VoiceGender.Female);
                    reader.SpeakAsync("Please select order");
                    MessageBox.Show("Please select order", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    txtChange.Text = change.ToString(".00");
                    reader.Dispose();
                    reader = new SpeechSynthesizer();
                    reader.SelectVoiceByHints(VoiceGender.Female);
                    reader.SpeakAsync("Your change is" + txtChange.Text);
                }

            }

        }
        int x=1;
        private void btnShanghai_Click(object sender, EventArgs e)
        {

            if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (txtQuan.Text != "0")
            {
                // double shang = Convert.ToDouble(txtSubTotal.Text);
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(txtQuan.Text + "pieces, of Shanghai Lauriat added");
                double q = Convert.ToInt32(txtQuan.Text);
                int a = dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = "Shanghai Lauriat";
                dataGridView1.Rows[a].Cells[1].Value = txtQuan.Text;
                dataGridView1.Rows[a].Cells[2].Value = q * 165;
            
                listBox1.Items.Add(x++ + "_Shanghai Lauriat_" + txtQuan.Text + "pcs_" + "₱"+(q * 165)+"_"+timee.Text+"_"+datee.Text);
               
                tot();

                btnVoid.Enabled = true;
                btn_Clear.Enabled = true;

            }

            else if (txtQuan.Text == "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Enter quantity");
                MessageBox.Show("Enter quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtQuan.Text != "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(txtQuan.Text + "pieces, of Chinese-Style Pork Chop added");
                double q = Convert.ToDouble(txtQuan.Text);
                int b = dataGridView1.Rows.Add();
                dataGridView1.Rows[b].Cells[0].Value = "Chinese-Style Pork Chop";
                dataGridView1.Rows[b].Cells[1].Value = txtQuan.Text;
                dataGridView1.Rows[b].Cells[2].Value = q * 105;
                listBox1.Items.Add(x++ + "_Chinese-Style Pork Chop_" + txtQuan.Text + "pcs_" + "₱" + (q * 105) + "_" + timee.Text + "_" + datee.Text); tot();
                btnVoid.Enabled = true;
                btn_Clear.Enabled = true;
               
            }
         
            else if (txtQuan.Text == "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Enter quantity");
                MessageBox.Show("Enter quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnPCF_Click(object sender, EventArgs e)
        {
            if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtQuan.Text != "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(txtQuan.Text + "pieces, of Pork Chao Fan added");
                double q = Convert.ToDouble(txtQuan.Text);
                int c = dataGridView1.Rows.Add();
                dataGridView1.Rows[c].Cells[0].Value = "Pork Chao Fan";
                dataGridView1.Rows[c].Cells[1].Value = txtQuan.Text;
                dataGridView1.Rows[c].Cells[2].Value = q * 55;

                listBox1.Items.Add(x++ + "_Pork Chao Fan_" + txtQuan.Text + "pcs_" + "₱" + (q * 55) + "_" + timee.Text + "_" + datee.Text);

                tot();
                btnVoid.Enabled = true;
                btn_Clear.Enabled = true;
               
            }
            else if (txtQuan.Text == "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Enter quantity");
                MessageBox.Show("Enter quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnPCL_Click(object sender, EventArgs e)
        {
            if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtQuan.Text != "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(txtQuan.Text + "pieces, of Pork Chop Lauriat added");
                double q = Convert.ToDouble(txtQuan.Text);
                int d = dataGridView1.Rows.Add();
                dataGridView1.Rows[d].Cells[0].Value = "Pork Chop Lauriat";
                dataGridView1.Rows[d].Cells[1].Value = txtQuan.Text;
                dataGridView1.Rows[d].Cells[2].Value = q * 178;
                listBox1.Items.Add(x++ + "_Pork Chop Lauriat_" + txtQuan.Text + "pcs_" + "₱" + (q * 178) + "_" + timee.Text + "_" + datee.Text);
                tot();
                btnVoid.Enabled = true;
                btn_Clear.Enabled = true;
               
            }
    
            else if (txtQuan.Text == "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Enter quantity");
                MessageBox.Show("Enter quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnYCSC_Click(object sender, EventArgs e)
        {
            if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtQuan.Text != "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(txtQuan.Text + "pieces, of Yang Chow Shomai Chao fan added");
                double q = Convert.ToDouble(txtQuan.Text);
                int E = dataGridView1.Rows.Add();
                dataGridView1.Rows[E].Cells[0].Value = "Yang Chow Siomai Chaofan";
                dataGridView1.Rows[E].Cells[1].Value = txtQuan.Text;
                dataGridView1.Rows[E].Cells[2].Value = q * 110;
                listBox1.Items.Add(x++ + "_Yang Chow Siomai Chaofan_" + txtQuan.Text + "pcs_" + "₱" + (q * 110) + "_" + timee.Text + "_" + datee.Text);
                tot();
                btnVoid.Enabled = true;
                btn_Clear.Enabled = true;
                
            }
       
            else if (txtQuan.Text == "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Enter quantity");
                MessageBox.Show("Enter quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSSPL_Click(object sender, EventArgs e)
        {
            if (rdPWD.Checked.Equals(false) && rdSC.Checked.Equals(false) && rdNone.Checked.Equals(false))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please check if there is any discount");
                MessageBox.Show("Please check if there is any discount", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtQuan.Text != "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(txtQuan.Text + "pieces, of Sweet & Sour Pork Lauriat added");
                double q = Convert.ToDouble(txtQuan.Text);
                int f = dataGridView1.Rows.Add();
                dataGridView1.Rows[f].Cells[0].Value = "Sweet & Sour Pork Lauriat";
                dataGridView1.Rows[f].Cells[1].Value = txtQuan.Text;
                dataGridView1.Rows[f].Cells[2].Value = q * 150;
                listBox1.Items.Add(x++ + "_Sweet & Sour Pork Lauriat_" + txtQuan.Text + "pcs_" + "₱" + (q * 150) + "_" + timee.Text + "_" + datee.Text);
                tot();
                btnVoid.Enabled = true;
                btn_Clear.Enabled = true;

            }
            else if (txtQuan.Text == "0")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Enter quantity");
                MessageBox.Show("Enter quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtPay_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPay.Text == "0.00")
            {
                txtPay.Text = "0";
            }

        }

       
        private void txtPay_MouseEnter(object sender, EventArgs e)
        {
            if (txtPay.Text == "0.00")
            {
                txtPay.Text = "";
            }
        }

        private void txtPay_MouseLeave(object sender, EventArgs e)
        {
            if (txtPay.Text == "")
            {
                txtPay.Text = "0.00";
            }
        }

        
        private void btnVoid_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows.Count;
            int rowCount = dataGridView1.RowCount;
            //dataGridView1.Rows.RemoveAt(rowIndex);
            if (dataGridView1.Rows.Count == 0)
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please select an order");
                MessageBox.Show("Please select an order", "No items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < rowCount; i++)
                {
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
               
            }

            listBox1.Items.Clear();
            clr();
        }

        private void btnShanghai_MouseHover(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Shanghai Lauriat. 165");
        }

        private void btnCS_MouseHover(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Chinese-Style Pork Chop. 105");
        }

        private void btnPCF_MouseHover(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Pork Chao Fan. 55");
        }

        private void btnPCL_MouseHover(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Pork Chop Lauriat. 178");
        }

        private void btnYCSC_MouseHover(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Yang Chow Shomai Chao fan. 110");
        }

        private void btnSSPL_MouseHover(object sender, EventArgs e)
        {
            
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Sweet & Sour Pork Lauriat. 150");
        }

        private void txtQuan_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtQuan.Text == "0")
            {
                txtQuan.Text = "";
            }
        }

       

        private void txtQuan_MouseHover(object sender, EventArgs e)
        {
            if (txtQuan.Text == "0")
            {
                txtQuan.Text = "";
            }
        }

        private void txtQuan_MouseLeave(object sender, EventArgs e)
        {
            if (txtQuan.Text == "")
            {
                txtQuan.Text = "0";
            }
        }

        private void btnShanghai_MouseLeave(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("");
        }

        private void btnCS_MouseLeave(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("");
        }

        private void btnPCF_MouseLeave(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("");
        }

        private void btnPCL_MouseLeave(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("");
        }

        private void btnYCSC_MouseLeave(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("");
        }

        private void btnSSPL_MouseLeave(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync("Do you really want to exit");
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialog == DialogResult.Yes)
            {
                
                Application.ExitThread();
                
            }
            else if (dialog==DialogResult.No)
            {
                e.Cancel = true;
                player.controls.play();

            }
        }

        private void btnVoid_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //int rowCount = dataGridView1.RowCount;
            
            //dataGridView1.Rows.RemoveAt(rowIndex);
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);

            }
            else
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync("Please select an order");
                MessageBox.Show("Please select an order", "No items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                tot();
                txtTotAm.Text = "0.00";

            }
            else
            {
                tot();
                
                txtTotAm.Text = "0.00";
            }
            
        }

        private void txtQuan_MouseEnter(object sender, EventArgs e)
        {
            if (txtQuan.Text == "0")
            {
                txtQuan.Text = "";
            }
        }

        private void rdSC_CheckedChanged(object sender, EventArgs e)
        {
            rdPWD.Enabled = false;
            rdNone.Enabled = false;
        }

        private void rdPWD_CheckedChanged(object sender, EventArgs e)
        {
            rdSC.Enabled = false;
            rdNone.Enabled = false;
        }

        private void rdNone_CheckedChanged(object sender, EventArgs e)
        {
            rdSC.Enabled = false;
            rdPWD.Enabled = false;
        }

        private void toggle_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                listBox1.Visible = true;
                toggle.BackgroundImage = Properties.Resources.toggle2;
            }
            else {
                listBox1.Visible = false;
                toggle.BackgroundImage = Properties.Resources.toggle1;
            }
        }
    }
}
