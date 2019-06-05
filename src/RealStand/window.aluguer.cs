using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class window
    {
        bool newCarroAluguer = false;

        private void buttonCriarAluguer_Click(object sender, EventArgs e)
        {
            newCarroAluguer = true;
            groupBoxAdicionarCarroAluguer.Enabled = true;
            buttonGuardarCarroAluguer.Visible = true;
        }

        private void buttonGuardarCarroAluguer_Click(object sender, EventArgs e)
        {
            if (newCarroAluguer)
            {
                CarroAluguer carroAluguer = new CarroAluguer(
                    estadoTextBox.Text, 
                    maskedTextBoxMatriculaAluguer.Text,
                    numeroChassisMaskedTextBox.Text,
                    textBoxMarcaAluguer.Text,
                    textBoxModeloAluguer.Text,
                    comboBoxCombustivelAluguer.Text
                    );
                standContainer.Carros.Add(carroAluguer);
            }
            else
            {

            }
            standContainer.SaveChanges();
            listBoxCarrosAluguer.DataSource = standContainer.Carros.OfType<CarroAluguer>().ToList();
            newCarroAluguer = false;
            groupBoxAdicionarCarroAluguer.Enabled = false;
            buttonGuardarCarroAluguer.Visible = false;
        }
    }
}
