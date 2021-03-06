﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Proj
{
    public partial class DadosPessoais : Form
    {
        DataAccess data = new DataAccess();
        decimal cond;
        public DadosPessoais()
        {
            InitializeComponent();
            GetPessoas();
        }

        public DadosPessoais(string morada)
        {
            InitializeComponent();
            GetPessoasByCasa(morada);
        }

        public DadosPessoais(decimal condominio)
        {
            InitializeComponent();
            cond = condominio;
            GetProprietariosByCondominio(cond);
        }

        private void GetInquilinosByCondominio(decimal condominio)
        {
            view_label.Text = "Inquilinos";
            data.connectToDB();

            SqlCommand com = new SqlCommand("select * from getInquilinosByCond(@condominio)", data.connection());
            com.Parameters.AddWithValue("@condominio", condominio);
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(com);
            DataTable objDataTable = new DataTable();
            objSqlDataAdapter.Fill(objDataTable);
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = objDataTable;
            pessoa_dataGrid.DataSource = objBindingSource;
            objSqlDataAdapter.Update(objDataTable);

            data.close();
        }

        private void GetProprietariosByCondominio(decimal condominio)
        {
            view_label.Text = "Proprietários";
            data.connectToDB();

            SqlCommand com = new SqlCommand("select * from getProprietariosByCond(@condominio)", data.connection());
            com.Parameters.AddWithValue("@condominio", condominio);
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(com);
            DataTable objDataTable = new DataTable();
            objSqlDataAdapter.Fill(objDataTable);
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = objDataTable;
            pessoa_dataGrid.DataSource = objBindingSource;
            objSqlDataAdapter.Update(objDataTable);

            data.close();
        }

        private void GetPessoasByCondominio(decimal condominio)
        {
            data.connectToDB();

            SqlCommand com = new SqlCommand("select * from getPessoasByCond(@condominio)", data.connection());
            com.Parameters.AddWithValue("@condominio", condominio);
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(com);
            DataTable objDataTable = new DataTable();
            objSqlDataAdapter.Fill(objDataTable);
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = objDataTable;
            pessoa_dataGrid.DataSource = objBindingSource;
            objSqlDataAdapter.Update(objDataTable);

            data.close();
        }

        private void GetPessoasByCasa(string morada)
        {
            data.connectToDB();

            List<PessoaModel> pessoas = new List<PessoaModel>();

            //String sql = "SELECT * FROM proj_pessoa join proj_casa_inquilino on proj_pessoa.nif=proj_casa_inquilino.nif where morada='"+morada+"'";
            SqlCommand com = new SqlCommand("getPessoasByCasa", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@morada", morada);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PessoaModel tmp = new PessoaModel();

                tmp.fname = reader.GetString(0);
                tmp.lname = reader.GetString(1);
                tmp.telefone = reader.GetDecimal(2);
                tmp.id = reader.GetDecimal(3);
                tmp.nif = reader.GetDecimal(4);

                pessoas.Add(tmp);
            }
            data.close();

            //return pessoas;
            fillDataGrid(pessoas);
        }

        //private void Fill_listbox()
        //{
        //    data.connectToDB();
        //    String sql = "SELECT morada FROM proj_pessoa";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        pessoas_listBox.Items.Add(reader.GetValue(0));
        //    }
        //    data.close();
        //}

        private void GetPessoas()
        {
            data.connectToDB();

            List<PessoaModel> pessoas = new List<PessoaModel>();

            String sql = "SELECT * FROM proj_pessoa";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PessoaModel tmp = new PessoaModel();

                tmp.fname = reader.GetString(0);
                tmp.lname = reader.GetString(1);
                tmp.telefone = reader.GetDecimal(2);
                tmp.id = reader.GetDecimal(3);
                tmp.nif = reader.GetDecimal(4);

                pessoas.Add(tmp);
            }
            data.close();

            //return pessoas;
            fillDataGrid(pessoas);
        }

        private void fillDataGrid<T>(List<T> lista)
        {
            pessoa_dataGrid.DataSource = lista;
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            AddCasa add = new AddCasa();
            add.ShowDialog();
        }

        private void pessoa_bt_Click(object sender, EventArgs e)
        {
            addPessoa add = new addPessoa();
            add.ShowDialog();
        }

        private void inquilinos_Click(object sender, EventArgs e)
        {
            //printInquilinos();
            GetInquilinosByCondominio(cond);
        }

        private void proprietarios_Click(object sender, EventArgs e)
        {
            //printProprietarios();
            GetProprietariosByCondominio(cond);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var nif = Decimal.Parse( pessoa_dataGrid.CurrentRow.Cells[5].Value.ToString());

            data.connectToDB();
            SqlCommand com = new SqlCommand("deletePerson", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nif", nif);
            com.ExecuteNonQuery();
            data.close();

            if (cond >= 1)
                GetPessoasByCondominio(cond);
            else GetPessoas();
        }


        //public void printProprietarios()
        //{
        //    data.connectToDB();

        //    List<ProprietarioModel> props = new List<ProprietarioModel>();

        //    String sql = "SELECT * FROM (proj_pessoa join proj_proprietario on proj_pessoa.nif=proj_proprietario.nif)";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        ProprietarioModel tmp = new ProprietarioModel();

        //        tmp.fname = reader.GetString(0);
        //        tmp.lname = reader.GetString(1);
        //        tmp.telefone = reader.GetDecimal(2);
        //        tmp.id = reader.GetDecimal(3);
        //        tmp.nif = reader.GetDecimal(4);


        //        props.Add(tmp);
        //    }
        //    data.close();

        //    fillDataGrid(props);
        //}

        //public void printInquilinos()
        //{
        //    data.connectToDB();

        //    List<InquilinoModel> inqs = new List<InquilinoModel>();

        //    String sql = "SELECT * FROM (proj_pessoa join proj_inquilino on proj_pessoa.nif=proj_inquilino.nif)";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        InquilinoModel tmp = new InquilinoModel();

        //        tmp.fname = reader.GetString(0);
        //        tmp.lname = reader.GetString(1);
        //        tmp.telefone = reader.GetDecimal(2);
        //        tmp.id = reader.GetDecimal(3);
        //        tmp.nif = reader.GetDecimal(4);
        //        tmp.certificado = reader.GetString(6);
        //        tmp.reg_criminal = reader.GetString(7);


        //        inqs.Add(tmp);
        //    }
        //    data.close();

        //    fillDataGrid(inqs);
        //}
    }
}
