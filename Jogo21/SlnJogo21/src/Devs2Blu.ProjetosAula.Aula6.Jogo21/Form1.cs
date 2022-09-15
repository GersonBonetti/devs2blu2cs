using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public partial class Form1 : Form
    {
        public int contador = 0;
        public int somaComputador = 0;
        public int pontosComputador = 0;
        public int somaUsuario = 0;
        public int pontosUsuario = 0;

        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private int ReturnPoints(int soma)
        {
            int pontos = 0;
            switch (soma)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontos += 1;
                    break;
                case 7:
                    pontos += 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontos += 5;
                    break;
                case 14:
                    pontos += 20;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontos += 6;
                    break;
                case 21:
                    pontos += 30;
                    break;
                default:
                    pontos += 0;
                    break;
            }
            return pontos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            if (txtB_usuario.Text != "")
            {
                if (contador <= 3)
                {
                    lbl_Aleatorio.Text = rd.Next(1, 20).ToString();
                    lbl_nRound.Text = contador.ToString();

                    somaUsuario = 0;
                    somaComputador = 0;
                    switch (contador) //atribui o número à etiqueta de round específica do computador
                    {
                        case 1:
                            lbl_User_R1.Text = txtB_usuario.Text;
                            lbl_PC_R1.Text = rd.Next(1, 20).ToString();
                            somaComputador += int.Parse(lbl_PC_R1.Text) + (int.Parse(lbl_Aleatorio.Text));
                            break;
                        case 2:
                            lbl_User_R2.Text = txtB_usuario.Text;
                            lbl_PC_R2.Text = rd.Next(1, 20).ToString();
                            somaComputador += int.Parse(lbl_PC_R2.Text) + (int.Parse(lbl_Aleatorio.Text));
                            break;
                        case 3:
                            lbl_User_R3.Text = txtB_usuario.Text;
                            lbl_PC_R3.Text = rd.Next(1, 20).ToString();
                            somaComputador += int.Parse(lbl_PC_R3.Text) + (int.Parse(lbl_Aleatorio.Text));
                            break;
                        default:
                            break;
                    }
                    somaUsuario = int.Parse(txtB_usuario.Text) + int.Parse(lbl_Aleatorio.Text);

                    pontosComputador += ReturnPoints(somaComputador);
                    pontosUsuario += ReturnPoints(somaUsuario);

                    lbl_totalUser.Text = pontosUsuario.ToString();
                    lbl_totalPC.Text = pontosComputador.ToString();
                    txtB_usuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira algum número no seu campo");
                contador--;          
            }
        }
    }
}