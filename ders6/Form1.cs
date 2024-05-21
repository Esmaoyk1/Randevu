using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ders6{
    public partial class Form1 : Form{
        const string filePath = "randevular.txt";


        public Form1(){
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            label_re.Text = "";
            label_er.Text = "";
            label_er_r.Text = "";
            dataGridView1.DataSource = ConvertToDataTable(filePath);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){
            TarihDegistirildi();
        }
        private void button_re_Click(object sender, EventArgs e){
            RandevuyuEkle();
        }





        void TarihDegistirildi(){
            label_re.Text = "";
            string tarih = dateTimePicker1.Value.ToShortDateString();
            if (RandevuVarMı(tarih)){
                label_er.Text = "Seçilen tarihte başka bir randevu bulunmaktadır.";
                BulunanRandevuyuGoster(tarih);
                label_er_r.Text = RandevuBul(tarih);
                button_re.Enabled = false;
            }
            else{
                label_er.Text = "";
                label_er_r.Text = "";
                button_re.Enabled = true;
            }
        }

        void RandevuyuEkle(){
            string tarih = dateTimePicker1.Value.ToShortDateString();
            if (!RandevuVarMı(tarih)){
                DosyayaEkle(randevu(tarih, textBox_ri.Text, textBox_rn.Text));
                TarihDegistirildi();
                label_re.Text = "Randevu eklendi";
                dataGridView1.DataSource = ConvertToDataTable(filePath);
            }
        }


        string randevu(string tarih, string ismi, string not) {
            return tarih + "," + ismi + "," + not;
        }



        void DosyayaEkle(string line){
            if (!File.Exists(filePath)){
                using (StreamWriter sw = File.CreateText(filePath)){
                    sw.WriteLine(line);
                }
            }
            else{
                using (StreamWriter sw = new StreamWriter(File.Open(filePath, System.IO.FileMode.Append))){
                    sw.WriteLine(line);
                }
            }
        }
        

        bool RandevuVarMı(string tarih){
            using (StreamReader sr = new StreamReader(filePath)){
                while (sr.Peek() >= 0){
                    string line = sr.ReadLine();
                    string randev = line.Split(',')[0];
                    if (randev == tarih){
                        return true;
                    }
                }
            }
            return false;
        }

        string RandevuBul(string tarih){
            using (StreamReader sr = new StreamReader(filePath)){
                while (sr.Peek() >= 0){
                    string line = sr.ReadLine();
                    if (line.Split(',')[0] == tarih){
                        return line;
                    }
                }
            }
            return "";
        }

        void BulunanRandevuyuGoster(string tarih){
            for (int i = 0; i < dataGridView1.RowCount; i++){
                var val = dataGridView1[0, i].Value;
                
                if (val == null) { 
                    break; 
                }

                if (val.ToString() == tarih){
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                }
            }
        }



        public DataTable ConvertToDataTable(string filePath)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("Tarih"));
            tbl.Columns.Add(new DataColumn("İsim"));
            tbl.Columns.Add(new DataColumn("Not"));

            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines){
                var cols = line.Split(',');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < cols.Length; cIndex++){
                    dr[cIndex] = cols[cIndex];
                }

                tbl.Rows.Add(dr);
            }

            return tbl;
        }
    }
}
