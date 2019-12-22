using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatGamev0._2
{
    public partial class frmMain : Form
    {

        public int g_AdimSayac;
        public int g_Size;
        public frmMain(int areaSize)
        {
            InitializeComponent();
            g_Size = areaSize;
        }
        String g_ClickedData;
        int fareSayac = 0;
        int peynirSayac = 0;
        int farex;
        int farey;
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            grpMoves.Visible = false;
            grpItems.Visible = false;
            btnStartGame.Visible = false;
            zamanlayici.Interval = 200;

            gridViewTemizleme();
        }

        private void gridViewTemizleme()
        {

            dgvMaze.Columns.Clear();
            dgvMaze.Rows.Clear();



            for (int i = 0; i < g_Size; i++)
            {
                DataGridViewImageColumn resim = new DataGridViewImageColumn();
                resim.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvMaze.Columns.Add(resim);
            }
            dgvMaze.Rows.Add(g_Size);


            dgvMaze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewRow item in dgvMaze.Rows)
            {
                item.Height = dgvMaze.Columns[0].Width;
            }

            if (dgvMaze.Rows.Count > 0)
            {
                foreach (DataGridViewImageCell item in dgvMaze.Rows[0].Cells)
                {
                    item.Value = pbWall.Image;
                    item.Tag = 100;
                }

                foreach (DataGridViewImageCell item in dgvMaze.Rows[dgvMaze.Rows.Count - 1].Cells)
                {
                    item.Value = pbWall.Image;
                    item.Tag = 100;
                }
            }

            for (int i = 0; i < dgvMaze.Rows.Count - 1; i++)
            {
                dgvMaze[0, i].Value = pbWall.Image;
                dgvMaze[0, i].Tag = 100;
                dgvMaze[dgvMaze.Columns.Count - 1, i].Value = pbWall.Image;
                dgvMaze[dgvMaze.Columns.Count - 1, i].Tag = 100;
            }

            for (int i = 1; i < dgvMaze.Columns.Count - 1; i++)
            {
                for (int j = 1; j < dgvMaze.Rows.Count - 1; j++)
                {
                    dgvMaze[i, j].Value = pbRoute.Image;
                    dgvMaze[i, j].Tag = 1;
                }
            }
            fareSayac = 0;
            peynirSayac = 0;
        }

        private void pbRoute_Click(object sender, EventArgs e)
        {
            g_ClickedData = "Yol";
        }

        private void pbWall_Click(object sender, EventArgs e)
        {
            g_ClickedData = "Duvar";
        }

        private void pbCheese_Click(object sender, EventArgs e)
        {
            g_ClickedData = "Peynir";

        }

        private void pbRat_Click(object sender, EventArgs e)
        {
            g_ClickedData = "Fare";

        }

        private void dgvMaze_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


            int x = dgvMaze.CurrentCellAddress.X;

            int y = dgvMaze.CurrentCellAddress.Y;


            int tag = int.Parse((dgvMaze.Rows[y].Cells[x]).Tag.ToString());

            if (tag == 100)
            {
                MessageBox.Show("Burası Doludur!");
                return;
            }
            switch (g_ClickedData)
            {
                case "Duvar":
                    {
                        if (dgvMaze[x, y].Value == pbRat.Image)
                            fareSayac = 0;

                        if (dgvMaze[x, y].Value == pbCheese.Image)
                            peynirSayac = 0;

                        DataGridViewImageCell duvar = new DataGridViewImageCell();

                        duvar.Tag = "111";
                        dgvMaze[x, y].Value = pbWall.Image;
                        dgvMaze[x, y].Tag = duvar.Tag;
                        break;
                    }
                case "Yol":
                    {
                        if (dgvMaze[x, y].Value == pbRat.Image)
                            fareSayac = 0;

                        if (dgvMaze[x, y].Value == pbCheese.Image)
                            peynirSayac = 0;

                        DataGridViewImageCell yol = new DataGridViewImageCell();
                        yol.Tag = "1";
                        dgvMaze[x, y].Value = pbRoute.Image;
                        dgvMaze[x, y].Tag = yol.Tag;
                        break;
                    }
                case "Peynir":
                    {
                        if (peynirSayac == 0)
                        {
                            DataGridViewImageCell peynir = new DataGridViewImageCell();
                            peynir.Tag = "0";
                            dgvMaze[x, y].Value = pbCheese.Image;
                            dgvMaze[x, y].Tag = peynir.Tag;
                            peynirSayac++;
                        }
                        else
                            MessageBox.Show("Sadece bir peynir eklenebilir!");
                        break;
                    }
                case "Fare":
                    {
                        if (fareSayac == 0)
                        {
                            DataGridViewImageCell fare = new DataGridViewImageCell();
                            fare.Tag = "1";
                            dgvMaze[x, y].Value = pbRat.Image;
                            dgvMaze[x, y].Tag = fare.Tag;
                            fareSayac++;
                            farex = e.ColumnIndex;
                            farey = e.RowIndex;
                        }
                        else
                            MessageBox.Show("Sadece bir fare eklenebilir!");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Lütfen önce eklemek istediğiniz fare/peynir/yol/duvar seçiniz!");
                        break;
                    }

                    
            }
            if(fareSayac==1&&peynirSayac==1)
                btnStartGame.Visible = true;



        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            g_AdimSayac = 0;

            //tek oyunculu
            if (btnStartGame.Text=="Oyuna Başla")
            {

                grpItems.Visible = false;
                grpMoves.Visible = true;
                btnStartGame.Visible = false;

            }

            //bilgisayara oynatma oyunculu
            else
            {
                btnStartGame.Visible = false;
                grpItems.Visible = false;

                zamanlayici.Interval = 200;

                g_AdimSayac = 0;

                zamanlayici.Enabled = true;
                zamanlayici.Start();


                if (peynirSayac != 1 || fareSayac != 1)
                {

                    zamanlayici.Stop();
                    MessageBox.Show("Peynir veya fare eklemeden başlayamazsınız.");

                }
                else
                {
                    btnStartGame.Visible = false;

                }



            }
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {

            //True donürürse
            if (RoutePath())
            {
                zamanlayici.Stop();
                zamanlayici.Enabled = false;

                MessageBox.Show("Bilgisayar Peynir'i " + g_AdimSayac + " adımda bulundu..");
            }
        }

        private bool RoutePath()
        {
            g_AdimSayac++;


            int kuzey = 0;
            int guney = 0;
            int bati = 0;
            int dogu = 0;
            int hucredegeri = 0;
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = pbRat.Image;
            kuzey = Convert.ToInt32(dgvMaze.Rows[farey - 1].Cells[farex].Tag);
            guney = Convert.ToInt32(dgvMaze.Rows[farey + 1].Cells[farex].Tag);
            bati = Convert.ToInt32(dgvMaze.Rows[farey].Cells[farex - 1].Tag);
            dogu = Convert.ToInt32(dgvMaze.Rows[farey].Cells[farex + 1].Tag);


            if (kuzey <= bati && kuzey <= dogu && kuzey <= guney)
            {
                if (kuzey != 100 || kuzey != 111)
                {
                    hucredegeri = kuzey;
                    if (kuzey == 0)
                    {
                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return true;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgvMaze.Rows[farey - 1].Cells[farex] = yeniFareKonum;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farey--;

                }
            }
            else if (bati <= kuzey && bati <= dogu & bati <= guney)
            {
                if (bati != 100 || bati != 111)
                {
                    hucredegeri = bati;
                    if (bati == 0)
                    {

                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return true;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgvMaze.Rows[farey].Cells[farex - 1] = yeniFareKonum;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farex--;
                }
            }
            else if (guney <= kuzey && guney <= bati && guney <= dogu)
            {
                if (guney != 100 || guney != 111)
                {
                    hucredegeri = guney;
                    if (guney == 0)
                    {

                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return true;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgvMaze.Rows[farey + 1].Cells[farex] = yeniFareKonum;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farey++;
                }
            }
            else if (dogu <= kuzey && dogu < bati && dogu <= guney)
            {
                if (dogu != 100 || dogu != 111)
                {
                    hucredegeri = dogu;
                    if (dogu == 0)
                    {

                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return true;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgvMaze.Rows[farey].Cells[farex + 1].Value = pbRat.Image;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farex++;
                }
            }

            return false;

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = pbRat.Image;

            if (dgvMaze.Rows[farey - 1].Cells[farex].Value != pbWall.Image)
            {
                g_AdimSayac++;

                if (dgvMaze.Rows[farey - 1].Cells[farex].Value == pbCheese.Image)
                {

                    Win();

                }
                else
                {
                    dgvMaze.Rows[farey - 1].Cells[farex] = yeniFareKonum;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farey--;
                }
                }
        }

        void Win()
        {

            MessageBox.Show("Oyunu " + g_AdimSayac.ToString() + " adımda kazandınız..");
        
            grpMoves.Visible = false;
            grpItems.Visible = false;
            btnStartGame.Visible = false;
            peynirSayac = 0;
            lblKarsilama.Visible = true;
            gridViewTemizleme();
        }

        private void tekOyunculuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewTemizleme();
            btnStartGame.Visible = false;
            lblKarsilama.Visible = false;
            grpItems.Visible = true;
            grpMoves.Visible = false;
            btnStartGame.Text = "Oyuna Başla";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = pbRat.Image;

            if (dgvMaze.Rows[farey].Cells[farex-1].Value != pbWall.Image)
            {
                g_AdimSayac++;

                if (dgvMaze.Rows[farey].Cells[farex-1].Value == pbCheese.Image)
                {

                    Win();

                }
                else
                { 
                dgvMaze.Rows[farey].Cells[farex-1] = yeniFareKonum;
                dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                farex--;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = pbRat.Image;

            if (dgvMaze.Rows[farey + 1].Cells[farex].Value != pbWall.Image)
            {
                g_AdimSayac++;

                if (dgvMaze.Rows[farey + 1].Cells[farex].Value == pbCheese.Image)
                {

                    Win();

                }

                else
                {
                    dgvMaze.Rows[farey + 1].Cells[farex] = yeniFareKonum;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farey++;
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = pbRat.Image;

            if (dgvMaze.Rows[farey].Cells[farex + 1].Value != pbWall.Image)
            {
                g_AdimSayac++;

                if (dgvMaze.Rows[farey].Cells[farex + 1].Value == pbCheese.Image)
                {

                    Win();

                }
                else
                {
                    dgvMaze.Rows[farey].Cells[farex + 1] = yeniFareKonum;
                    dgvMaze.Rows[farey].Cells[farex].Value = pbRoute.Image;
                    farex++;
                }
            }
        }

        private void bilgisayaraOynatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewTemizleme();
            lblKarsilama.Visible = false;
            btnStartGame.Text = "Fareye Peyniri Buldur";
            grpMoves.Visible = false;
            grpItems.Visible = true;
            btnStartGame.Visible = true;
        }
    }
}
