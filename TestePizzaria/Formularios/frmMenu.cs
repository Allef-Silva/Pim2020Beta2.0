﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm
{
    public partial class frmMenu : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public frmMenu()
        {
            InitializeComponent();
            timerTempo.Start();
            PanelWidth = painelEsquerda.Width;
            isCollapsed = false;
        }


      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                painelEsquerda.Width = painelEsquerda.Width + 10;
                if (painelEsquerda.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                painelEsquerda.Width = painelEsquerda.Width - 10;
                if (painelEsquerda.Width <= 70)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

        }


        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
       

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCardapio);
            ControlesDeUsuario.CU_Produto abs = new ControlesDeUsuario.CU_Produto();
            AddControlsToPanel(abs);
        }

   
      

        private void btnVendas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVendas);
            ControlesDeUsuario.CU_RelatoriosVendas ula = new ControlesDeUsuario.CU_RelatoriosVendas();
            AddControlsToPanel(ula);
        }

     

        private void btnClientes_Click(object sender, EventArgs e)
        {

            moveSidePanel(btnClientes);
            ControlesDeUsuario.CU_CadastroClientes ua = new ControlesDeUsuario.CU_CadastroClientes();
            AddControlsToPanel(ua);
        }



        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFornecedores);
            ControlesDeUsuario.CU_CompraFornecedores up = new ControlesDeUsuario.CU_CompraFornecedores();
            AddControlsToPanel(up);
        }

        private void timerTempo_Tick(object sender, EventArgs e)
        {

            {
                labelTime.Text = DateTime.Now.ToString("hh:mm:ss ");
                lblData.Text = DateTime.Now.ToLongDateString();
            }

        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            ControlesDeUsuario.CU_Home usc = new ControlesDeUsuario.CU_Home();
            AddControlsToPanel(usc);
        }

   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(249, 6, 6);
        }

        private void labelTimee_Click(object sender, EventArgs e)
        {

        }

      

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCadastrarFunc);
            ControlesDeUsuario.CU_CadastrosUsuarios usb = new ControlesDeUsuario.CU_CadastrosUsuarios();
            AddControlsToPanel(usb);

        }

        
        private void lblData_Click(object sender, EventArgs e)
        {

        }

      

      

        private void frmMenu_Load(object sender, EventArgs e)
        {

            if (lblCargo.Text == "Recepcionista ")
            {
                btnRelatorio.Enabled = false;
                btnCadastrarFunc.Enabled = false;
            } 
            if (lblCargo.Text == "Garcom")
            {
                btnRelatorio.Enabled = false;
                btnCadastrarFunc.Enabled = false;
            }




        }
        public void RecebendoValorLogin(string nome, string cargo)
        {
            lblCargo.Text = cargo;
            lblNomeUsuario.Text = nome;
        }

      

       

      

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnRelatorio);
            ControlesDeUsuario.CU_Relatorios usb = new ControlesDeUsuario.CU_Relatorios();

            AddControlsToPanel(usb);
        }

        private void btnSair_Click_3(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
