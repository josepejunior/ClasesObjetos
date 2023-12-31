﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPruebaAnotaciones
{
    public partial class frmPrueba : Form
    {
        Employee emp = new Employee();

        public frmPrueba()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                emp.IdNumber = int.Parse(txtNumber.Text);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                emp.FirstName = txtFName.Text;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                emp.LastName = txtLName.Text;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
