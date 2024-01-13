using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBoxLastName.Click += TextBox_Click;
            txtBoxName.Click += TextBox_Click;
            txtBoxAge.Click += TextBox_Click;
            txtBoxAddress.Click += TextBox_Click;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int errorCount = 0;

            errorCount += CheckAndSetField(txtBoxLastName, lblLastName) ? 1 : 0;
            errorCount += CheckAndSetField(txtBoxName, lblName) ? 1 : 0;
            errorCount += CheckAndSetField(txtBoxAge, lblAge, true) ? 1 : 0;
            errorCount += CheckAndSetField(txtBoxAddress, lblAddress) ? 1 : 0;

            if (errorCount == 0)
            {
                string lastName = txtBoxLastName.Text.ToUpper();
                string name = txtBoxName.Text.ToUpper();
                string age = txtBoxAge.Text;
                string address = txtBoxAddress.Text.ToUpper();

                txtBoxResult.Text = $"Apellido y Nombre: {lastName} {name}\r\nEdad: {age}\r\nDirección: {address}";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form messageForm = new Form
            {
                Text = "Cierre",
                Size = new Size(300, 100),
                StartPosition = FormStartPosition.CenterParent // Asegura que la ventana se abra encima de la ventana actual

            };

            Label messageLabel = new Label
            {
                Text = "Gracias por usar la aplicacion.",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            messageForm.Controls.Add(messageLabel);

            // Crea un Timer que cierre la ventana después de 2 segundos
            Timer timer = new Timer
            {
                Interval = 1500, // 2 segundos
                Enabled = true
            };

            timer.Tick += (s, args) =>
            {
                messageForm.Close();
                timer.Dispose();
            };

            messageForm.ShowDialog();
            Application.Exit();
        }

        private bool CheckAndSetField(TextBox textBox, Label label, bool checkForNumber = false)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)
                && (!label.ForeColor.Name.Equals("Red"))
                || (checkForNumber && !int.TryParse(textBox.Text, out _)))
            {
                label.ForeColor = Color.Red;
                textBox.ForeColor = Color.Red;
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Text = checkForNumber ? "Must Be a Number" : "Must Complete";
                return true;
            }
            return false;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.ForeColor = Color.Black;
            textBox.Text = string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetField(txtBoxLastName, lblLastName);
            ResetField(txtBoxName, lblName);
            ResetField(txtBoxAge, lblAge);
            ResetField(txtBoxAddress, lblAddress);
            txtBoxResult.Text = string.Empty;
        }

        private void ResetField(TextBox textBox, Label label)
        {
            label.ForeColor = Color.Black;
            textBox.ForeColor = Color.Black;
            textBox.Text = string.Empty;
        }
    }
}
