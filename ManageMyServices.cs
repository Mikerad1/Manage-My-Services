using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_My_Services_2
{
    public partial class frmManageMyServices : Form
    {
        public frmManageMyServices()
        {
            InitializeComponent();
        }

        ServiceController[] services;
        ServiceController[] dependantServices;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDependantServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void RbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                services = ServiceController.GetServices();
                btnGetServices.Enabled = false;
                lblMachineName.Enabled = false;
                txtMachineName.Enabled = false;
                dgvServices.DataSource = services;
                if (dgvServices.Columns.Contains("CanStop"))
                {
                    dgvServices.Columns.Remove("CanStop");
                }
                if (dgvServices.Columns.Contains("CanPauseandContinue"))
                {
                    dgvServices.Columns.Remove("CanPauseandContinue");
                }
                if (dgvServices.Columns.Contains("CanShutdown"))
                {
                    dgvServices.Columns.Remove("CanShutdown");
                }
                
            }
        }

        private void RbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNo.Checked)
            {
                btnGetServices.Enabled = true;
                lblMachineName.Enabled = true;
                txtMachineName.Enabled = true;
                dgvServices.DataSource = services;
                if (dgvServices.Columns.Contains("CanStop"))
                {
                    dgvServices.Columns.Remove("CanStop");
                }
                if (dgvServices.Columns.Contains("CanPauseandContinue"))
                {
                    dgvServices.Columns.Remove("CanPauseandContinue");
                }
                if (dgvServices.Columns.Contains("CanShutdown"))
                {
                    dgvServices.Columns.Remove("CanShutdown");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMachineName.Text))
            {
                MessageBox.Show("Please enter a machine name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    services = ServiceController.GetServices(txtMachineName.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Machine not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnStartService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select atleast one service");
            }
            else
            {
                foreach (DataGridViewRow row in dgvServices.SelectedRows)
                {
                    ServiceController service = row.DataBoundItem as ServiceController;
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        MessageBox.Show($"{service.DisplayName} is already running.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                        dgvServices.Refresh();
                    }
                }
            }
        }

        private void BtnStopService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select atleast one service");
            }
            else
            {
                foreach (DataGridViewRow row in dgvServices.SelectedRows)
                {
                    ServiceController service = row.DataBoundItem as ServiceController;
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        MessageBox.Show($"{service.DisplayName} is already stopped.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped);
                        dgvServices.Refresh();
                    }
                }
            }
        }

        private void TxtServiceName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServiceName.Text))
            {
                List<ServiceController> filteredServices = new List<ServiceController>();

                foreach (ServiceController service in services)
                {
                    if (service.DisplayName.Contains(txtServiceName.Text))
                    {
                        filteredServices.Add(service);
                    }
                }
                if (filteredServices.Count > 0)
                {
                    dgvServices.DataSource = filteredServices;
                    if (dgvServices.Columns.Contains("CanStop"))
                    {
                        dgvServices.Columns.Remove("CanStop");
                    }
                    if (dgvServices.Columns.Contains("CanPauseandContinue"))
                    {
                        dgvServices.Columns.Remove("CanPauseandContinue");
                    }
                    if (dgvServices.Columns.Contains("CanShutdown"))
                    {
                        dgvServices.Columns.Remove("CanShutdown");
                    }
                }
                else
                {
                    dgvServices.DataSource = services;
                    if (dgvServices.Columns.Contains("CanStop"))
                    {
                        dgvServices.Columns.Remove("CanStop");
                    }
                    if (dgvServices.Columns.Contains("CanPauseandContinue"))
                    {
                        dgvServices.Columns.Remove("CanPauseandContinue");
                    }
                    if (dgvServices.Columns.Contains("CanShutdown"))
                    {
                        dgvServices.Columns.Remove("CanShutdown");
                    }
                }
            }
            else
            {
                dgvServices.DataSource = services;
                if (dgvServices.Columns.Contains("CanStop"))
                {
                    dgvServices.Columns.Remove("CanStop");
                }
                if (dgvServices.Columns.Contains("CanPauseandContinue"))
                {
                    dgvServices.Columns.Remove("CanPauseandContinue");
                }
                if (dgvServices.Columns.Contains("CanShutdown"))
                {
                    dgvServices.Columns.Remove("CanShutdown");
                }
            }
        }

        private void DgvServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                ServiceController service = dgvServices.SelectedRows[0].DataBoundItem as ServiceController;
                dependantServices = service.DependentServices;
                dgvDependantServices.DataSource = dependantServices;
                if (dgvDependantServices.Columns.Contains("CanStop"))
                {
                    dgvDependantServices.Columns.Remove("CanStop");
                }
                if (dgvDependantServices.Columns.Contains("CanPauseandContinue"))
                {
                    dgvDependantServices.Columns.Remove("CanPauseandContinue");
                }
                if (dgvDependantServices.Columns.Contains("CanShutdown"))
                {
                    dgvDependantServices.Columns.Remove("CanShutdown");
                }
                if (dependantServices == null || dependantServices.Length == 0)
                {
                    btnRestartDependantServices.Enabled = false;
                    btnStartDependantServices.Enabled = false;
                    btnStopDependantServices.Enabled = false;
                    txtSearchDependantServices.Enabled = false;
                    lblFindDependantServices.Enabled = false;
                }
                else
                {
                    btnRestartDependantServices.Enabled = true;
                    btnStartDependantServices.Enabled = true;
                    btnStopDependantServices.Enabled = true;
                    txtSearchDependantServices.Enabled = true;
                    lblFindDependantServices.Enabled = true;
                }
            } 
        }

        private void BtnRestartServices_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select atleast one service");
            }
            else
            {
                foreach (DataGridViewRow row in dgvServices.SelectedRows)
                {
                    ServiceController service = row.DataBoundItem as ServiceController;
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                        dgvServices.Refresh();
                    }
                    else
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped);
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                        dgvServices.Refresh();
                    }
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchDependantServices.Text))
            {
                List<ServiceController> filteredServices = new List<ServiceController>();

                foreach (ServiceController service in dependantServices)
                {
                    if (service.DisplayName.Contains(txtSearchDependantServices.Text))
                    {
                        filteredServices.Add(service);
                    }
                }
                if (filteredServices.Count > 0)
                {
                    dgvDependantServices.DataSource = filteredServices;
                    if (dgvDependantServices.Columns.Contains("CanStop"))
                    {
                        dgvDependantServices.Columns.Remove("CanStop");
                    }
                    if (dgvDependantServices.Columns.Contains("CanPauseandContinue"))
                    {
                        dgvDependantServices.Columns.Remove("CanPauseandContinue");
                    }
                    if (dgvDependantServices.Columns.Contains("CanShutdown"))
                    {
                        dgvDependantServices.Columns.Remove("CanShutdown");
                    }
                }
                else
                {
                    dgvDependantServices.DataSource = dependantServices;
                    if (dgvDependantServices.Columns.Contains("CanStop"))
                    {
                        dgvDependantServices.Columns.Remove("CanStop");
                    }
                    if (dgvDependantServices.Columns.Contains("CanPauseandContinue"))
                    {
                        dgvDependantServices.Columns.Remove("CanPauseandContinue");
                    }
                    if (dgvDependantServices.Columns.Contains("CanShutdown"))
                    {
                        dgvDependantServices.Columns.Remove("CanShutdown");
                    }
                }
            }
            else
            {
                dgvDependantServices.DataSource = dependantServices;
                if (dgvDependantServices.Columns.Contains("CanStop"))
                {
                    dgvDependantServices.Columns.Remove("CanStop");
                }
                if (dgvDependantServices.Columns.Contains("CanPauseandContinue"))
                {
                    dgvDependantServices.Columns.Remove("CanPauseandContinue");
                }
                if (dgvDependantServices.Columns.Contains("CanShutdown"))
                {
                    dgvDependantServices.Columns.Remove("CanShutdown");
                }
            }
        }

        private void BtnStartDependantServices_Click(object sender, EventArgs e)
        {
            if (dgvDependantServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select atleast one dependant service");
            }
            else
            {
                foreach (DataGridViewRow row in dgvDependantServices.SelectedRows)
                {
                    ServiceController service = row.DataBoundItem as ServiceController;
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        MessageBox.Show($"{service.DisplayName} is already running.");
                    }
                    else
                    {
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                        dgvDependantServices.Refresh();
                    }
                }
            }
        }

        private void BtnStopDependantServices_Click(object sender, EventArgs e)
        {
            if (dgvDependantServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select atleast one service");
            }
            else
            {
                foreach (DataGridViewRow row in dgvDependantServices.SelectedRows)
                {
                    ServiceController service = row.DataBoundItem as ServiceController;
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        MessageBox.Show($"{service.DisplayName} is already stopped.");
                    }
                    else
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped);
                        dgvDependantServices.Refresh();
                    }
                }
            }
        }

        private void BtnRestartDependantServices_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select atleast one service");
            }
            else
            {
                foreach (DataGridViewRow row in dgvServices.SelectedRows)
                {
                    ServiceController service = row.DataBoundItem as ServiceController;
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                        dgvServices.Refresh();
                    }
                    else
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped);
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                        dgvServices.Refresh();
                    }
                }
            }
        }
    }
}
