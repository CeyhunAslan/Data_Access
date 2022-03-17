using Dapper_CRUD.Repository.Conrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapRepository kitapRepository = new KitapRepository();
        Kitap kitap = new Kitap();
        int id;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ListGetir();
            }
            catch (Exception ex)
            {

                throw new Exception("Sql bağlantısını kontrol et" +ex.Message.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                kitap = new Kitap()
                {
                    Id = id,
                    Name = txtName.Text,
                    SeriesName = txtSeriesName.Text,
                    Author = txtAuthor.Text,
                };
                if (id == 0)
                {
                    KitapRepository kitapRepository = new KitapRepository();
                    kitapRepository.Save(kitap);

                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                {
                    KitapRepository kitapRepository = new KitapRepository();
                    kitapRepository.Save(kitap);

                    MessageBox.Show("Günceleme Başarılı");
                }
                ListGetir();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
          

        }
        private void ListGetir()
        {
            KitapRepository kitapRepository = new KitapRepository();
             var list = kitapRepository.GettAll();

            dataGridView1.DataSource = list;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                kitap = new Kitap()
                {
                    Id = id, 


                };
                kitapRepository = new KitapRepository();
                kitapRepository.Delete(kitap);

                MessageBox.Show("Silme başarılı");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            ListGetir();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //değer varmı yokmu kontrolu
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtSeriesName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtAuthor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                }
                //seçili değer varsa true olsun
                btnDelete.Enabled = true;
                btnAdd.Text = "Update";
            }
            catch (Exception ex)
            {

                throw new Exception("Seçili ıd değeri yok" + ex.Message.ToString());
            }   
        }
    }
}
