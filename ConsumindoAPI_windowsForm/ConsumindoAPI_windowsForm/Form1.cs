using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Newtonsoft.Json;

namespace ConsumindoAPI_windowsForm
{
    public partial class frmAmigo : Form
    {
        string URI = "";

        public frmAmigo()
        {
            InitializeComponent();
            CarregaComboAmigos();
            SetTimer(true);
            GetNumToken();
        }

        private void CarregaComboAmigos()
        {
            GetAllAmigos();
        }

        private void SetTimer(bool ativo)
        {
            timerToken.Enabled = ativo;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            GetAmigosProximos(cboAmigos, txtToken);
            txtToken.Text = "";
        }

        private async void GetNumToken()
        {
            try
            {
                SetTimer(false);

                URI = "http://localhost:8585/api/token";

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            //clienteUri = response.Headers.Location;
                            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                            Token tkn = new Token();

                            tkn = JsonConvert.DeserializeObject<Token>(ProdutoJsonString);

                            lblNumToken.Text = tkn.NumToken;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                        }
                    }
                }
            }
            finally
            {
                SetTimer(true);
            }
        }

        private async void GetAllAmigos()
        {
            try
            {
                SetTimer(false);

                URI = "http://localhost:8585/api/amigos";

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            //clienteUri = response.Headers.Location;
                            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                            cboAmigos.DataSource = JsonConvert.DeserializeObject<Amigos[]>(ProdutoJsonString).ToList();
                            cboAmigos.DisplayMember = "Nome";
                            cboAmigos.ValueMember = "ID";
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                        }
                    }
                }
            }
            finally
            {
                SetTimer(true);
            }
        }

        private async void GetAmigosProximos(ComboBox cboAmigoId, TextBox TxtNumToken)
        {
            try
            {
                SetTimer(false);
                using (var client = new HttpClient())
                {

                    BindingSource bsDados = new BindingSource();
                    URI = "http://localhost:8585/api/amigos" + "/?Id=" + cboAmigoId.SelectedValue + "&numToken=" + TxtNumToken.Text;

                    HttpResponseMessage response = await client.GetAsync(URI);
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        Amigos amg = new Amigos();

                        amg = JsonConvert.DeserializeObject<Amigos[]>(ProdutoJsonString).FirstOrDefault();
                        if (amg.ID == -1)
                        {
                            MessageBox.Show("401 - " + amg.Nome);
                        }
                        else
                        {
                            dgvDados.DataSource = JsonConvert.DeserializeObject<Amigos[]>(ProdutoJsonString).ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter os amigos proximos : " + response.StatusCode);
                    }
                }
            }
            finally
            {
                SetTimer(true);
            }
        }

        private void timerToken_Tick(object sender, EventArgs e)
        {
            GetNumToken();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtToken.Text = lblNumToken.Text;
        }
    }
}
