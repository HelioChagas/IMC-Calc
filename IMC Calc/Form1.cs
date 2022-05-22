using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Ação de limpar todos os textos//
        public void Zerar()
        {
            CampNome.Text = "";
            CampAltura.Text = "";
            CampPeso.Text = "";
            ResultIMC.Text = "";
            ResultPideal.Text = "";
            ResultCondicao.Text = "";
            Masculino.Checked = false;
            Feminino.Checked = false;
        }
        
        public void Informacoes()
        {
           
            // Campo destinado a Inicialização de valores//
            double Altura = 0;
            double Peso = 0;
            double IMC = 0;
            double Mediaimc1 = 0; double Mediaimc2 = 0; double Mediaimc3 = 0; double Mediaimc4 = 0; double Mediaimc5 = 0;
            double Pesoideal1 = 0; double Pesoideal2 = 0; double Pesoideal3 = 0; double Pesoideal4 = 0; double Pesoideal5 = 0;
            double Pesofinal1 = 0; double Pesofinal2 = 0; double Pesofinal3 = 0; double Pesofinal4 = 0; double Pesofinal5 = 0;
            
            //Campo destinado a conversão de todas as caixas para conta//  Altura = double.Parse(CampAltura.Text);
            Altura = double.Parse(CampAltura.Text);
            Peso = double.Parse(CampPeso.Text);

            // Formula do IMC //
            // IMC = Peso / Altura² //
            IMC = Peso / Altura *2;

            if (Masculino.Checked == true) 
            {
                if (IMC <20.7)
                {
                    Mediaimc1 = (20.7 + 26.4) / 2;
                    Pesoideal1 = Mediaimc1 * (Altura * 2);
                    Pesofinal1 = Pesoideal1 - Peso;
                    ResultIMC.Text = Pesoideal1.ToString("N2");
                    ResultPideal.Text = "Faltam " + Pesofinal1.ToString("N2") + " Para o paciente chegar ao peso ideal";
                    ResultCondicao.Text = "Abaixo do Peso!";
                    
                }
               
                if (IMC <26.4) 
                {
                    Mediaimc2 = (20.7 + 26.4) / 2;
                    Pesoideal2 = Mediaimc2 * (Altura * 2);
                    Pesofinal2 = Pesoideal2 - Peso;
                    ResultIMC.Text = Pesoideal2.ToString("N2");
                    ResultCondicao.Text = "Paciente no peso ideal!";
                }
               
                if (IMC <27.8)
                {
                    Mediaimc3 = (26.4 + 27.8 ) / 2;
                    Pesoideal3 = Mediaimc3 * (Altura * 2);
                    Pesofinal3 = Pesoideal3 - Peso;
                    ResultIMC.Text = Pesoideal3.ToString("N2");
                    ResultPideal.Text = "Faltam " + Pesofinal3.ToString("N2") + " Para o paciente chegar ao peso ideal";
                    ResultCondicao.Text = "Marginalmente Acima do peso!";
                }
               
                if (IMC <27.8 ) 
                {
                    Mediaimc4 = (27.8 + 31.1) / 2;
                    Pesoideal4 = Mediaimc4 * (Altura * 2);
                    Pesofinal4 = Pesoideal4 - Peso;
                    ResultIMC.Text = Pesoideal4.ToString("N2");
                    ResultPideal.Text = "Faltam " + Pesofinal4.ToString("N2") + " Para o paciente chegar ao peso ideal";
                    ResultCondicao.Text = "Acima do peso ideal";
                }
                
                if (IMC > 31.1) 
                {
                    Mediaimc5 = (27.8 + 31.1) / 2;
                    Pesoideal5 = Mediaimc5 * (Altura * 2);
                    Pesofinal5 = Pesoideal5 - Peso;
                    ResultIMC.Text = Pesoideal5.ToString("N2");
                    ResultPideal.Text = "Faltam " + Pesofinal5.ToString("N2") + " Para o paciente chegar ao peso ideal";
                    ResultCondicao.Text = "Acima do peso ideal";
                }
               
            }
            
        }
                //Botão Reset//
        private void button2_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacoes();
        }
    }
}
