﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseWorkers
{
    public partial class Form1 : Form
    {
        DatabaseWorkersDataContext DatabaseDC = new DatabaseWorkersDataContext();


        public Form1()
        {
            InitializeComponent();
            LoadWorkers();

            //listBoxWorkers.DisplayMember = "FirstName";
        }

        private void LoadWorkers()
        {
            listBoxWorkers.Items.Clear();
            foreach( Worker w in DatabaseDC.Workers)
            {
                listBoxWorkers.Items.Add(w);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {


            if(IsWorkerFormValid())
            { 

                Worker workerToSave = null;
                //edycja
                if (listBoxWorkers.SelectedItems.Count == 1)
                {
                    listBoxWorkers.Enabled = true;
                    buttonDelete.Visible = false;
                    buttonSave.Text = "Dodaj";

                    workerToSave = listBoxWorkers.SelectedItem as Worker;
                }
                //dodawanie
                else
                {
                    workerToSave = new Worker();
                    DatabaseDC.Workers.InsertOnSubmit(workerToSave);
                }
                workerToSave.FirstName = textBoxFirtsName.Text;
                workerToSave.LastName = textBoxLastName.Text;
                workerToSave.DateBegin = dateTimePickerDateBegin.Value;
                workerToSave.Salary = numericUpDownSalary.Value;
                workerToSave.Manager = checkBoxMenager.Checked;


                DatabaseDC.SubmitChanges();
                ClearFormm();

                LoadWorkers();
                }
            else
            {
                MessageBox.Show("Formularz wypełiony nie poprawnie");
            }
        }

        private bool IsWorkerFormValid()
        {
            if(textBoxFirtsName.Text.Length==0)
            {
                return false;
            }
            if (textBoxLastName.Text.Length == 0)
            {
                return false;
            }
            if (dateTimePickerDateBegin.Value >= DateTime.Today )
            {
                return false;
            }
            return true;
        }

        private void ClearFormm()
        {
            textBoxFirtsName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerDateBegin.Value = DateTime.Today;
            numericUpDownSalary.Value = numericUpDownSalary.Minimum;
            checkBoxMenager.Checked = false;
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxWorkers.SelectedItems.Count==1)
            {
                listBoxWorkers.Enabled = false;
                buttonSave.Text = "Zmień";
                buttonDelete.Visible = true;
                


                Worker selectedWorker = listBoxWorkers.SelectedItem as Worker;

                textBoxFirtsName.Text = selectedWorker.FirstName;
                textBoxLastName.Text = selectedWorker.LastName;
                dateTimePickerDateBegin.Value = selectedWorker.DateBegin;
                numericUpDownSalary.Value = selectedWorker.Salary;
                checkBoxMenager.Checked = selectedWorker.Manager;


            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItems.Count == 1)
            {
                Worker selectedWorker = listBoxWorkers.SelectedItem as Worker;

                DatabaseDC.Workers.DeleteOnSubmit(selectedWorker);

                DatabaseDC.SubmitChanges();

                listBoxWorkers.Enabled = true;
                buttonSave.Text = "Dodaj";
                buttonDelete.Visible = false;

                ClearFormm();
                LoadWorkers();
            }
        }
    }
}
