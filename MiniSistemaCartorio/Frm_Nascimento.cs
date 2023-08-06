using MiniSistemaCartorio.Entidades;
using MiniSistemaCartorio.DB;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSistemaCartorio.Model.Dao;
using MiniSistemaCartorio.Model.Dao.Impl;

namespace MiniSistemaCartorio
{
    public partial class Frm_Nascimento : Form
    {
        INascimentoDao nascimentoDao = DaoFactory.CriarINascimentoDao();
        IPaisDao paisDao = DaoFactory.CriarIPaisDao();

        public Frm_Nascimento()
        {
            InitializeComponent();
        }

        private void Btn_Incluir_Click(object sender, EventArgs e)
        {
            Nascimento registro = LerCampos();
            paisDao.Inserir(registro.Pai);
            paisDao.Inserir(registro.Mae);
            nascimentoDao.Inserir(registro);
            
            MessageBox.Show("Incluido com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            Txt_NomeRegistrado.Text = "";
            Txt_DataNascimento.Text = "";
            Txt_NomePai.Text = "";
            Txt_DataNascimentoPai.Text = "";
            Txt_NomeMae.Text = "";
            Txt_DataNascimentoMae.Text = "";
            Txt_CpfPai.Text = "";
            Txt_CpfMae.Text = "";
            Txt_DataRegistro.Text = "";
        }

        private Nascimento LerCampos()
        {
            string nomeRegistrado = Txt_NomeRegistrado.Text;
            string dataNascimento = Txt_DataNascimento.Text;
            string nomePai = Txt_NomePai.Text;
            string dataNascimentoPai = Txt_DataNascimentoPai.Text;
            string nomeMae = Txt_NomeMae.Text;
            string dataNascimentoMae = Txt_DataNascimentoMae.Text;
            string cpfPai = Txt_CpfPai.Text;
            string cpfMae = Txt_CpfMae.Text;
            string dataRegistro = Txt_DataRegistro.Text;
            string teste;

            Pai pai = new Pai(nomePai, ParseDate(dataNascimentoPai), cpfPai);
            Mae mae = new Mae(nomeMae, ParseDate(dataNascimentoMae), cpfMae);

            Nascimento registro = new Nascimento(ParseDate(dataRegistro), ParseDate(dataNascimento), nomeRegistrado, pai, mae);

            return registro;
        }

        private DateTime? ParseDate(string dateStr)
        {
            if (DateTime.TryParse(dateStr, out DateTime date))
            {
                // Se a conversão for bem-sucedida, retorna a data
                return date;
            }

            // Se a conversão falhar (data inválida ou campo vazio), retorna null
            return null;
        }
    }
}
